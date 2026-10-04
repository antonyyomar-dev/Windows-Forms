using System;

namespace MediTrack.Entities
{
    // Filtros de los reportes (segun el diagrama de clases)
    public class Reportes
    {
        public DateTime PeriodoInicio { get; set; }
        public DateTime PeriodoFin { get; set; }
        public int IdArea { get; set; }       // 0 = todas las areas
        public int IdPersonal { get; set; }   // 0 = todo el personal

        public Reportes()
        {
            PeriodoInicio = DateTime.Today.AddDays(-30);
            PeriodoFin = DateTime.Today;
        }
    }
}
