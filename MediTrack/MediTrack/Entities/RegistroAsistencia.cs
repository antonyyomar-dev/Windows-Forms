using System;

namespace MediTrack.Entities
{
    // Una jornada programada y su marcacion real
    public class RegistroAsistencia : EntidadBase
    {
        public int IdAsistencia { get; set; }
        public int IdPersonal { get; set; }
        public DateTime InicioProgramado { get; set; }
        public DateTime FinProgramado { get; set; }
        public DateTime? HoraIngreso { get; set; }   // null = aun no marca
        public DateTime? HoraSalida { get; set; }    // null = aun no sale
        public int MinutosTardanza { get; set; }
        public decimal HorasTrabajadas { get; set; }
        public string Estado { get; set; }           // Programada, Puntual, Tardanza, Falta, Justificada

        public RegistroAsistencia() { }
    }
}
