using System;

namespace MediTrack.Entities
{
    public class Justificacion : EntidadBase
    {
        public int IdJustificacion { get; set; }
        public int IdPersonal { get; set; }          // trabajador (relacion con Personal)
        public string Tipo { get; set; }
        public DateTime FechaSolicitud { get; set; }
        public DateTime FechaAusencia { get; set; }  // dia que se justifica
        public string Motivo { get; set; }
        public string Estado { get; set; }           // Pendiente, Aprobada, Rechazada

        public Justificacion() { }
    }
}
