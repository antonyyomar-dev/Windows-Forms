using System;
using System.Collections.Generic;
using System.Linq;
using MediTrack.Entities;
using MediTrack.Repositories;

namespace MediTrack.Services
{
    public class AsistenciaService
    {
        private PersonalRepository repoPersonal = new PersonalRepository();
        private TurnoRepository repoTurno = new TurnoRepository();

        // ---------- PROGRAMACION DE JORNADAS ----------

        // true si la jornada se cruza con otra del mismo trabajador (RNF09)
        public bool ValidarSuperposicion(int idPersonal, DateTime inicio, DateTime fin)
        {
            Personal p = repoPersonal.Listar().Find(x => x.IdPersonal == idPersonal);
            if (p == null) return false;

            // Formula de cruce de horarios: inicio1 < fin2 y fin1 > inicio2
            return p.ListaAsistencias.Exists(a => inicio < a.FinProgramado && fin > a.InicioProgramado);
        }

        public string ProgramarJornada(RegistroAsistencia nueva)
        {
            Personal p = repoPersonal.Listar().Find(x => x.IdPersonal == nueva.IdPersonal);
            if (p == null) return "Error: El trabajador no existe.";
            if (!p.Activo) return "Error: El trabajador está desactivado.";

            if (nueva.InicioProgramado >= nueva.FinProgramado)
                return "Error: La hora de inicio debe ser menor a la hora de fin.";

            if ((nueva.FinProgramado - nueva.InicioProgramado).TotalHours > 16)
                return "Error: Una jornada no puede superar las 16 horas.";

            if (nueva.InicioProgramado.Date < DateTime.Today)
                return "Error: No se pueden programar jornadas en fechas pasadas.";

            if (nueva.InicioProgramado.Date > DateTime.Today.AddDays(60))
                return "Error: Solo se puede programar hasta 60 días adelante.";

            if (ValidarSuperposicion(nueva.IdPersonal, nueva.InicioProgramado, nueva.FinProgramado))
                return "Error: El trabajador ya tiene una jornada que se cruza con ese horario.";

            nueva.IdAsistencia = repoPersonal.SiguienteIdAsistencia();
            nueva.Estado = "Programada";
            nueva.HoraIngreso = null;
            nueva.HoraSalida = null;
            nueva.AuditarCreacion(Sesion.UsuarioActual);

            p.ListaAsistencias.Add(nueva);   // se agrega a la sublista del trabajador
            return "Jornada programada correctamente.";
        }

        // Crea la jornada de un dia usando el turno asignado al trabajador
        public string ProgramarJornadaDesdeTurno(int idPersonal, DateTime fecha)
        {
            Personal p = repoPersonal.Listar().Find(x => x.IdPersonal == idPersonal);
            if (p == null) return "Error: El trabajador no existe.";

            Turno t = repoTurno.Listar().Find(x => x.IdTurno == p.IdTurno);
            if (t == null || !t.Activo) return "Error: El trabajador no tiene un turno activo asignado.";

            RegistroAsistencia jornada = new RegistroAsistencia();
            jornada.IdPersonal = idPersonal;
            jornada.InicioProgramado = fecha.Date + t.HoraInicio.TimeOfDay;
            jornada.FinProgramado = fecha.Date + t.HoraFin.TimeOfDay;

            // Turno nocturno: termina al dia siguiente
            if (t.CruzaMedianoche) jornada.FinProgramado = jornada.FinProgramado.AddDays(1);

            return ProgramarJornada(jornada);
        }

        // Programa a todo el personal activo (no administradores) en una fecha
        public string ProgramarJornadaMasiva(DateTime fecha)
        {
            int ok = 0, omitidos = 0;
            foreach (Personal p in repoPersonal.Listar().Where(x => x.Activo))
            {
                string r = ProgramarJornadaDesdeTurno(p.IdPersonal, fecha);
                if (Validador.EsError(r)) omitidos++; else ok++;
            }
            return "Jornadas creadas: " + ok + " | Omitidas (ya existían o sin turno): " + omitidos;
        }

        // ---------- MARCACION (RF05) ----------

        public string RegistrarIngreso(string codigo)
        {
            Personal p = BuscarPorCodigo(codigo);
            if (p == null) return "Error: Código no encontrado o trabajador desactivado.";

            DateTime ahora = DateTime.Now;

            // Jornada vigente: desde 60 min antes del inicio hasta el fin
            RegistroAsistencia jornada = p.ListaAsistencias
                .Where(a => ahora >= a.InicioProgramado.AddMinutes(-60) && ahora <= a.FinProgramado)
                .OrderByDescending(a => a.InicioProgramado)
                .FirstOrDefault();

            if (jornada == null)
                return "Error: No tiene una jornada programada para este momento.";

            // No se permite ingreso duplicado (RNF09)
            if (jornada.HoraIngreso != null)
                return "Error: Ya registró su ingreso en esta jornada.";

            jornada.HoraIngreso = ahora;
            jornada.MinutosTardanza = CalcularTardanza(jornada);
            jornada.Estado = jornada.MinutosTardanza > 0 ? "Tardanza" : "Puntual";
            jornada.AuditarModificacion(Sesion.UsuarioActual);

            if (jornada.MinutosTardanza > 0)
                return "Ingreso registrado con TARDANZA de " + jornada.MinutosTardanza + " min. Hora: " + ahora.ToString("HH:mm:ss");
            return "Ingreso registrado a tiempo. Hora: " + ahora.ToString("HH:mm:ss");
        }

        public string RegistrarSalida(string codigo)
        {
            Personal p = BuscarPorCodigo(codigo);
            if (p == null) return "Error: Código no encontrado o trabajador desactivado.";

            // Debe existir un ingreso abierto antes de la salida (RNF09)
            RegistroAsistencia jornada = p.ListaAsistencias
                .Where(a => a.HoraIngreso != null && a.HoraSalida == null)
                .OrderByDescending(a => a.InicioProgramado)
                .FirstOrDefault();

            if (jornada == null)
                return "Error: No existe un ingreso abierto para registrar la salida.";

            jornada.HoraSalida = DateTime.Now;
            jornada.HorasTrabajadas = CalcularHorasTrabajadas(jornada);
            jornada.AuditarModificacion(Sesion.UsuarioActual);

            return "Salida registrada. Horas trabajadas: " + jornada.HorasTrabajadas.ToString("0.00");
        }

        // ---------- CALCULOS (regla de negocio, RNF06) ----------

        // Minutos de tardanza: si pasa la tolerancia se cuenta desde la hora de inicio
        public int CalcularTardanza(RegistroAsistencia a)
        {
            if (a.HoraIngreso == null) return 0;

            Personal p = repoPersonal.Listar().Find(x => x.IdPersonal == a.IdPersonal);
            Turno t = p == null ? null : repoTurno.Listar().Find(x => x.IdTurno == p.IdTurno);
            int tolerancia = t == null ? 0 : t.ToleranciaMin;

            int minutos = (int)Math.Floor((a.HoraIngreso.Value - a.InicioProgramado).TotalMinutes);
            if (minutos <= tolerancia) return 0;
            return minutos;
        }

        public decimal CalcularHorasTrabajadas(RegistroAsistencia a)
        {
            if (a.HoraIngreso == null || a.HoraSalida == null) return 0;
            double horas = (a.HoraSalida.Value - a.HoraIngreso.Value).TotalHours;
            return Math.Round((decimal)horas, 2);
        }

        // ---------- CONSULTAS ----------

        public List<RegistroAsistencia> ListarPorPersonal(int idPersonal)
        {
            Personal p = repoPersonal.Listar().Find(x => x.IdPersonal == idPersonal);
            if (p == null) return new List<RegistroAsistencia>();
            return p.ListaAsistencias.OrderByDescending(a => a.InicioProgramado).ToList();
        }

        // Jornadas vencidas sin ingreso pasan a "Falta" (o "Justificada" si hay justificacion aprobada)
        public void ActualizarFaltas()
        {
            DateTime ahora = DateTime.Now;
            foreach (Personal p in repoPersonal.Listar())
            {
                foreach (RegistroAsistencia a in p.ListaAsistencias)
                {
                    bool sinIngreso = a.HoraIngreso == null && a.FinProgramado < ahora;
                    if (sinIngreso && (a.Estado == "Programada" || a.Estado == "Falta"))
                    {
                        bool justificada = p.ListaJustificaciones.Exists(j => j.Estado == "Aprobada"
                            && j.FechaAusencia.Date == a.InicioProgramado.Date);
                        a.Estado = justificada ? "Justificada" : "Falta";
                    }
                }
            }
        }

        // Busca un trabajador ACTIVO por codigo
        private Personal BuscarPorCodigo(string codigo)
        {
            if (!Validador.TieneTexto(codigo)) return null;
            return repoPersonal.Listar().Find(p => p.Codigo.ToUpper() == codigo.Trim().ToUpper() && p.Activo);
        }
    }
}
