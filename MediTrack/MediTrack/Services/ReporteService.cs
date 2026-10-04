using System;
using System.Collections.Generic;
using System.Linq;
using MediTrack.Entities;
using MediTrack.Repositories;

namespace MediTrack.Services
{
    // Reportes de RRHH (RF08 a RF12). Todos reciben los filtros en un objeto Reportes.
    public class ReporteService
    {
        private PersonalRepository repoPersonal = new PersonalRepository();
        private AreaRepository repoArea = new AreaRepository();
        private AsistenciaService asistenciaService = new AsistenciaService();

        // Valida el rango de fechas del filtro
        public string ValidarFiltro(Reportes f)
        {
            if (f.PeriodoInicio.Date > f.PeriodoFin.Date)
                return "Error: La fecha inicial no puede ser mayor a la final.";
            return "";
        }

        // Personal que cumple los filtros de area y trabajador
        private List<Personal> PersonalFiltrado(Reportes f)
        {
            return repoPersonal.Listar().Where(p => (f.IdArea == 0 || p.IdArea == f.IdArea)
                                                    && (f.IdPersonal == 0 || p.IdPersonal == f.IdPersonal)).ToList();
        }

        // Jornadas del trabajador dentro del periodo que ya se cumplieron o ya tienen ingreso
        private List<RegistroAsistencia> JornadasFiltradas(Personal p, Reportes f)
        {
            DateTime ahora = DateTime.Now;
            return p.ListaAsistencias.Where(a => a.InicioProgramado.Date >= f.PeriodoInicio.Date
                                                 && a.InicioProgramado.Date <= f.PeriodoFin.Date
                                                 && (a.FinProgramado <= ahora || a.HoraIngreso != null)).ToList();
        }

        private string NombreArea(int idArea)
        {
            Area a = repoArea.Listar().Find(x => x.IdArea == idArea);
            return a == null ? "-" : a.Nombre;
        }

        // RF08: tabla resumen (tambien total de tardanzas y horas por trabajador)
        public List<ResumenAsistenciaItem> GenerarResumenAsistencia(Reportes f)
        {
            asistenciaService.ActualizarFaltas();
            List<ResumenAsistenciaItem> lista = new List<ResumenAsistenciaItem>();

            foreach (Personal p in PersonalFiltrado(f))
            {
                List<RegistroAsistencia> jornadas = JornadasFiltradas(p, f);
                if (jornadas.Count == 0) continue;   // sin jornadas en el periodo, no se muestra

                ResumenAsistenciaItem item = new ResumenAsistenciaItem();
                item.Id = p.IdPersonal;
                item.Nombre = p.NombreCompleto;
                item.Area = NombreArea(p.IdArea);
                item.DiasLaborables = jornadas.Count;
                item.Asistencias = jornadas.Count(a => a.HoraIngreso != null);
                item.Faltas = jornadas.Count(a => a.Estado == "Falta");
                item.FaltasJustificadas = jornadas.Count(a => a.Estado == "Justificada");
                item.Tardanzas = jornadas.Count(a => a.MinutosTardanza > 0);
                item.MinutosTardanza = jornadas.Sum(a => a.MinutosTardanza);
                item.HorasTrabajadas = jornadas.Sum(a => a.HorasTrabajadas);
                lista.Add(item);
            }
            return lista;
        }

        // RF09: solo jornadas con tardanza, falta o justificacion
        public List<IncidenciaItem> GenerarIncidenciaDiarias(Reportes f)
        {
            asistenciaService.ActualizarFaltas();
            List<IncidenciaItem> lista = new List<IncidenciaItem>();

            foreach (Personal p in PersonalFiltrado(f))
            {
                foreach (RegistroAsistencia a in JornadasFiltradas(p, f))
                {
                    if (a.Estado != "Tardanza" && a.Estado != "Falta" && a.Estado != "Justificada") continue;

                    // Busca la justificacion aprobada de ese dia (si existe)
                    Justificacion j = p.ListaJustificaciones.Find(x => x.Estado == "Aprobada"
                                      && x.FechaAusencia.Date == a.InicioProgramado.Date);

                    IncidenciaItem item = new IncidenciaItem();
                    item.Fecha = a.InicioProgramado.ToString("dd/MM/yyyy");
                    item.Id = p.IdPersonal;
                    item.Nombre = p.NombreCompleto;
                    item.HoraEntrada = a.HoraIngreso == null ? "--:--" : a.HoraIngreso.Value.ToString("HH:mm");
                    item.Estado = a.Estado;
                    item.Justificacion = j == null ? "-" : j.Tipo + ": " + j.Motivo;
                    lista.Add(item);
                }
            }
            return lista.OrderBy(i => DateTime.ParseExact(i.Fecha, "dd/MM/yyyy", null)).ToList();
        }

        // RF10: grafico circular (% asistencias, faltas, justificadas)
        public List<ItemGrafico> ObtenerDistribucionAsistencia(Reportes f)
        {
            List<ResumenAsistenciaItem> resumen = GenerarResumenAsistencia(f);
            double asis = resumen.Sum(r => r.Asistencias);
            double faltas = resumen.Sum(r => r.Faltas);
            double just = resumen.Sum(r => r.FaltasJustificadas);
            double total = asis + faltas + just;

            List<ItemGrafico> lista = new List<ItemGrafico>();
            if (total == 0) return lista;   // evita dividir entre cero

            lista.Add(new ItemGrafico { Etiqueta = "Asistencias", Valor = Math.Round(asis * 100 / total, 1) });
            lista.Add(new ItemGrafico { Etiqueta = "Faltas", Valor = Math.Round(faltas * 100 / total, 1) });
            lista.Add(new ItemGrafico { Etiqueta = "Justificadas", Valor = Math.Round(just * 100 / total, 1) });
            return lista;
        }

        // RF11: grafico de lineas (% de ausentismo NO justificado por mes)
        public List<ItemGrafico> ObtenerEvolucionAusentismo(Reportes f)
        {
            asistenciaService.ActualizarFaltas();
            List<RegistroAsistencia> todas = new List<RegistroAsistencia>();
            foreach (Personal p in PersonalFiltrado(f)) todas.AddRange(JornadasFiltradas(p, f));

            var porMes = todas.GroupBy(a => new DateTime(a.InicioProgramado.Year, a.InicioProgramado.Month, 1))
                              .OrderBy(g => g.Key);

            List<ItemGrafico> lista = new List<ItemGrafico>();
            foreach (var mes in porMes)
            {
                double faltas = mes.Count(a => a.Estado == "Falta");
                lista.Add(new ItemGrafico { Etiqueta = mes.Key.ToString("MM/yyyy"), Valor = Math.Round(faltas * 100 / mes.Count(), 1) });
            }
            return lista;
        }

        // RF12: grafico de barras (cantidad de tardanzas por area)
        public List<ItemGrafico> ObtenerTardanzaPorArea(Reportes f)
        {
            asistenciaService.ActualizarFaltas();
            List<ItemGrafico> lista = new List<ItemGrafico>();

            foreach (Area area in repoArea.Listar())
            {
                if (f.IdArea != 0 && area.IdArea != f.IdArea) continue;

                double cantidad = 0;
                foreach (Personal p in PersonalFiltrado(f).Where(x => x.IdArea == area.IdArea))
                    cantidad += JornadasFiltradas(p, f).Count(a => a.MinutosTardanza > 0);

                lista.Add(new ItemGrafico { Etiqueta = area.Nombre, Valor = cantidad });
            }
            return lista;
        }
    }
}
