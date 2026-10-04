using System.Collections.Generic;
using System.Linq;
using MediTrack.Entities;
using MediTrack.Repositories;

namespace MediTrack.Services
{
    public class AreaService
    {
        private AreaRepository repoArea = new AreaRepository();
        private PersonalRepository repoPersonal = new PersonalRepository();

        public string RegistrarArea(Area nueva)
        {
            if (!Validador.LargoValido(nueva.Nombre, 3, 40))
                return "Error: El nombre del área debe tener entre 3 y 40 caracteres.";

            if (repoArea.Listar().Exists(a => a.Nombre.ToUpper() == nueva.Nombre.Trim().ToUpper()))
                return "Error: Ya existe un área con ese nombre.";

            nueva.IdArea = repoArea.SiguienteId();
            nueva.Nombre = nueva.Nombre.Trim();
            nueva.Activo = true;
            nueva.AuditarCreacion(Sesion.UsuarioActual);

            repoArea.Listar().Add(nueva);
            return "Área registrada correctamente.";
        }

        public string ActualizarArea(Area editada)
        {
            Area original = repoArea.Listar().Find(a => a.IdArea == editada.IdArea);
            if (original == null) return "Error: No se encontró el área.";

            if (!Validador.LargoValido(editada.Nombre, 3, 40))
                return "Error: El nombre del área debe tener entre 3 y 40 caracteres.";

            // El nombre no debe chocar con OTRA área
            if (repoArea.Listar().Exists(a => a.IdArea != editada.IdArea
                && a.Nombre.ToUpper() == editada.Nombre.Trim().ToUpper()))
                return "Error: Ya existe otra área con ese nombre.";

            original.Nombre = editada.Nombre.Trim();
            original.Descripcion = editada.Descripcion;
            original.AuditarModificacion(Sesion.UsuarioActual);
            return "Área actualizada correctamente.";
        }

        // No se elimina fisicamente (RNF04): solo se desactiva
        public string DesactivarArea(int id)
        {
            Area area = repoArea.Listar().Find(a => a.IdArea == id);
            if (area == null) return "Error: No se encontró el área.";
            if (!area.Activo) return "Error: El área ya está desactivada.";

            if (repoPersonal.Listar().Exists(p => p.IdArea == id && p.Activo))
                return "Error: No se puede desactivar, tiene personal activo asignado.";

            area.Activo = false;
            area.AuditarModificacion(Sesion.UsuarioActual);
            return "Área desactivada correctamente.";
        }

        public List<Area> ListarArea()
        {
            return repoArea.Listar();
        }

        public List<Area> ListarActivas()
        {
            return repoArea.Listar().Where(a => a.Activo).ToList();
        }
    }
}
