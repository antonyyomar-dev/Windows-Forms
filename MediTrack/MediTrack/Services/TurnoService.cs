using System;
using System.Collections.Generic;
using System.Linq;
using MediTrack.Entities;
using MediTrack.Repositories;

namespace MediTrack.Services
{
    public class TurnoService
    {
        private TurnoRepository repoTurno = new TurnoRepository();
        private PersonalRepository repoPersonal = new PersonalRepository();

        // Validaciones comunes de un turno (fechas y horas, RNF09)
        private string ValidarTurno(Turno t)
        {
            if (!Validador.LargoValido(t.Nombre, 3, 30))
                return "Error: El nombre del turno debe tener entre 3 y 30 caracteres.";

            TimeSpan inicio = t.HoraInicio.TimeOfDay;
            TimeSpan fin = t.HoraFin.TimeOfDay;

            if (inicio == fin)
                return "Error: La hora de inicio y fin no pueden ser iguales.";

            // Duracion (si cruza medianoche se suman 24 horas)
            double horas = (fin - inicio).TotalHours;
            if (horas <= 0) horas += 24;
            if (horas > 12)
                return "Error: Un turno no puede durar más de 12 horas.";

            if (t.ToleranciaMin < 0 || t.ToleranciaMin > 60)
                return "Error: La tolerancia debe estar entre 0 y 60 minutos.";

            return "";
        }

        public string RegistrarTurno(Turno nuevo)
        {
            string error = ValidarTurno(nuevo);
            if (error != "") return error;

            if (repoTurno.Listar().Exists(t => t.Nombre.ToUpper() == nuevo.Nombre.Trim().ToUpper()))
                return "Error: Ya existe un turno con ese nombre.";

            nuevo.IdTurno = repoTurno.SiguienteId();
            nuevo.Nombre = nuevo.Nombre.Trim();
            nuevo.Activo = true;
            nuevo.AuditarCreacion(Sesion.UsuarioActual);

            repoTurno.Listar().Add(nuevo);
            return "Turno registrado correctamente.";
        }

        public string ActualizarTurno(Turno editado)
        {
            Turno original = repoTurno.Listar().Find(t => t.IdTurno == editado.IdTurno);
            if (original == null) return "Error: No se encontró el turno.";

            string error = ValidarTurno(editado);
            if (error != "") return error;

            if (repoTurno.Listar().Exists(t => t.IdTurno != editado.IdTurno
                && t.Nombre.ToUpper() == editado.Nombre.Trim().ToUpper()))
                return "Error: Ya existe otro turno con ese nombre.";

            original.Nombre = editado.Nombre.Trim();
            original.HoraInicio = editado.HoraInicio;
            original.HoraFin = editado.HoraFin;
            original.ToleranciaMin = editado.ToleranciaMin;
            original.Descripcion = editado.Descripcion;
            original.AuditarModificacion(Sesion.UsuarioActual);
            return "Turno actualizado correctamente.";
        }

        public string DesactivarTurno(int id)
        {
            Turno turno = repoTurno.Listar().Find(t => t.IdTurno == id);
            if (turno == null) return "Error: No se encontró el turno.";
            if (!turno.Activo) return "Error: El turno ya está desactivado.";

            if (repoPersonal.Listar().Exists(p => p.IdTurno == id && p.Activo))
                return "Error: No se puede desactivar, hay personal activo con este turno.";

            turno.Activo = false;
            turno.AuditarModificacion(Sesion.UsuarioActual);
            return "Turno desactivado correctamente.";
        }

        public List<Turno> ListarTurnos()
        {
            return repoTurno.Listar();
        }

        public List<Turno> ListarActivos()
        {
            return repoTurno.Listar().Where(t => t.Activo).ToList();
        }
    }
}
