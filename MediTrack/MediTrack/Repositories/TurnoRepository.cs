using System;
using System.Collections.Generic;
using System.Linq;
using MediTrack.Entities;

namespace MediTrack.Repositories
{
    public class TurnoRepository
    {
        public static List<Turno> listaTurnos = new List<Turno>();

        public TurnoRepository()
        {
            // Turnos iniciales: mañana, tarde y noche (cruza medianoche)
            if (listaTurnos.Count == 0)
            {
                listaTurnos.Add(CrearTurno(1, "Mañana", 7, 15));
                listaTurnos.Add(CrearTurno(2, "Tarde", 15, 23));
                listaTurnos.Add(CrearTurno(3, "Noche", 23, 7));
            }
        }

        private Turno CrearTurno(int id, string nombre, int horaIni, int horaFin)
        {
            return new Turno
            {
                IdTurno = id,
                Nombre = nombre,
                HoraInicio = DateTime.Today.AddHours(horaIni),
                HoraFin = DateTime.Today.AddHours(horaFin),
                ToleranciaMin = 10,
                Descripcion = "Turno " + nombre,
                Activo = true,
                CreadoPor = "Sistema",
                FechaCreacion = DateTime.Now
            };
        }

        public List<Turno> Listar()
        {
            return listaTurnos;
        }

        public int SiguienteId()
        {
            return listaTurnos.Count == 0 ? 1 : listaTurnos.Max(t => t.IdTurno) + 1;
        }
    }
}
