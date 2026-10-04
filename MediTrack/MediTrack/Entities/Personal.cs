using System;
using System.Collections.Generic;

namespace MediTrack.Entities
{
    public class Personal : EntidadBase
    {
        public int IdPersonal { get; set; }
        public int IdArea { get; set; }
        public int IdTurno { get; set; }
        public string Codigo { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Usuario { get; set; }
        public string Password { get; set; }   // se guarda el HASH, nunca el texto plano (RNF03)
        public string Rol { get; set; }
        public bool Activo { get; set; }

        // MULTILISTAS: cada personal tiene sus propias listas (1 a 0..*)
        public List<RegistroAsistencia> ListaAsistencias { get; set; }
        public List<Justificacion> ListaJustificaciones { get; set; }

        public string NombreCompleto
        {
            get { return Nombres + " " + Apellidos; }
        }

        public Personal()
        {
            ListaAsistencias = new List<RegistroAsistencia>();
            ListaJustificaciones = new List<Justificacion>();
        }
    }
}
