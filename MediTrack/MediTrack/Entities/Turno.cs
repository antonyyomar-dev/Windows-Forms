using System;

namespace MediTrack.Entities
{
    public class Turno : EntidadBase
    {
        public int IdTurno { get; set; }
        public string Nombre { get; set; }
        public DateTime HoraInicio { get; set; }   // solo se usa la hora (TimeOfDay)
        public DateTime HoraFin { get; set; }      // solo se usa la hora (TimeOfDay)
        public int ToleranciaMin { get; set; }
        public string Descripcion { get; set; }
        public bool Activo { get; set; }

        // Un turno nocturno termina "al dia siguiente" (ej. 23:00 a 07:00)
        public bool CruzaMedianoche
        {
            get { return HoraFin.TimeOfDay <= HoraInicio.TimeOfDay; }
        }

        // Texto para mostrar en tablas
        public string Horario
        {
            get { return HoraInicio.ToString("HH:mm") + " - " + HoraFin.ToString("HH:mm"); }
        }

        public Turno() { }
    }
}
