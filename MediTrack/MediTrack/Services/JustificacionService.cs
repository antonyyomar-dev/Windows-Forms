using System;
using System.Collections.Generic;
using System.Linq;
using MediTrack.Entities;
using MediTrack.Repositories;

namespace MediTrack.Services
{
    public class JustificacionService
    {
        public static readonly string[] Tipos = { "Enfermedad", "Licencia", "Permiso personal", "Otro" };

        private PersonalRepository repoPersonal = new PersonalRepository();
        private AsistenciaService asistenciaService = new AsistenciaService();

        // RF07: registrar (queda "Pendiente")
        public string RegistrarJustificacion(Justificacion nueva)
        {
            Personal p = repoPersonal.Listar().Find(x => x.IdPersonal == nueva.IdPersonal);
            if (p == null || !p.Activo) return "Error: El trabajador no existe o está desactivado.";

            if (!Tipos.Contains(nueva.Tipo)) return "Error: Seleccione un tipo de justificación válido.";

            if (!Validador.LargoValido(nueva.Motivo, 10, 200))
                return "Error: El motivo debe tener entre 10 y 200 caracteres.";

            if (nueva.FechaAusencia.Date > DateTime.Today)
                return "Error: No se puede justificar una fecha futura.";

            if (nueva.FechaAusencia.Date < DateTime.Today.AddDays(-30))
                return "Error: Solo se pueden justificar ausencias de los últimos 30 días.";

            // No duplicar una justificacion vigente para el mismo dia
            if (p.ListaJustificaciones.Exists(j => j.FechaAusencia.Date == nueva.FechaAusencia.Date
                                                   && j.Estado != "Rechazada"))
                return "Error: Ya existe una justificación para ese día.";

            nueva.IdJustificacion = repoPersonal.SiguienteIdJustificacion();
            nueva.FechaSolicitud = DateTime.Now;
            nueva.Estado = "Pendiente";
            nueva.AuditarCreacion(Sesion.UsuarioActual);

            p.ListaJustificaciones.Add(nueva);
            return "Justificación registrada (pendiente de aprobación).";
        }

        public string Aprobar(int idJustificacion)
        {
            Justificacion j = repoPersonal.ListarJustificaciones().Find(x => x.IdJustificacion == idJustificacion);
            if (j == null) return "Error: No se encontró la justificación.";
            if (j.Estado != "Pendiente") return "Error: Solo se pueden aprobar justificaciones pendientes.";

            // Debe corresponder al trabajador y a una jornada del periodo (RNF09)
            Personal p = repoPersonal.Listar().Find(x => x.IdPersonal == j.IdPersonal);
            if (p == null) return "Error: El trabajador de la justificación no existe.";

            if (!p.ListaAsistencias.Exists(a => a.InicioProgramado.Date == j.FechaAusencia.Date))
                return "Error: El trabajador no tenía jornada programada en esa fecha.";

            j.Estado = "Aprobada";
            j.AuditarModificacion(Sesion.UsuarioActual);
            asistenciaService.ActualizarFaltas();   // las faltas de ese dia pasan a "Justificada"
            return "Justificación aprobada.";
        }

        public string Rechazar(int idJustificacion)
        {
            Justificacion j = repoPersonal.ListarJustificaciones().Find(x => x.IdJustificacion == idJustificacion);
            if (j == null) return "Error: No se encontró la justificación.";
            if (j.Estado != "Pendiente") return "Error: Solo se pueden rechazar justificaciones pendientes.";

            j.Estado = "Rechazada";
            j.AuditarModificacion(Sesion.UsuarioActual);
            return "Justificación rechazada.";
        }

        // Filtra por estado ("Todos" o vacio = todas)
        public List<Justificacion> Consultar(string estado)
        {
            List<Justificacion> todas = repoPersonal.ListarJustificaciones();
            if (!Validador.TieneTexto(estado) || estado == "Todos") return todas;
            return todas.FindAll(j => j.Estado == estado);
        }
    }
}
