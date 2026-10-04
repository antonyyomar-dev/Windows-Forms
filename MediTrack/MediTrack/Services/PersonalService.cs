using System.Collections.Generic;
using System.Linq;
using MediTrack.Entities;
using MediTrack.Repositories;

namespace MediTrack.Services
{
    public class PersonalService
    {
        private PersonalRepository repoPersonal = new PersonalRepository();
        private AreaRepository repoArea = new AreaRepository();     // se crean para tener los datos iniciales
        private TurnoRepository repoTurno = new TurnoRepository();

        // RF01: devuelve el personal si usuario y clave son correctos y esta activo
        public Personal IniciarSesion(string usuario, string clave)
        {
            if (!Validador.TieneTexto(usuario) || !Validador.TieneTexto(clave)) return null;

            string hash = Seguridad.Hash(clave);
            return repoPersonal.Listar().Find(p => p.Usuario.ToLower() == usuario.Trim().ToLower()
                                                   && p.Password == hash && p.Activo);
        }

        // Valida los datos comunes de registrar y modificar
        private string ValidarDatos(Personal p)
        {
            if (!Validador.NombreValido(p.Nombres)) return "Error: Nombres inválidos (solo letras, mínimo 2).";
            if (!Validador.NombreValido(p.Apellidos)) return "Error: Apellidos inválidos (solo letras, mínimo 2).";
            if (!Validador.RolValido(p.Rol)) return "Error: Seleccione un rol válido.";

            if (!repoArea.Listar().Exists(a => a.IdArea == p.IdArea && a.Activo))
                return "Error: El área seleccionada no existe o está desactivada.";

            if (!repoTurno.Listar().Exists(t => t.IdTurno == p.IdTurno && t.Activo))
                return "Error: El turno seleccionado no existe o está desactivado.";

            return "";
        }

        // RF02: registrar (la clave llega en texto y aqui se convierte en hash)
        public string RegistrarPersonal(Personal nuevo, string clavePlana)
        {
            if (!Validador.CodigoValido(nuevo.Codigo))
                return "Error: El código debe tener entre 4 y 10 letras o números.";

            // No se permiten codigos duplicados (RNF09)
            if (repoPersonal.Listar().Exists(p => p.Codigo.ToUpper() == nuevo.Codigo.Trim().ToUpper()))
                return "Error: Ya existe un trabajador con ese código.";

            string error = ValidarDatos(nuevo);
            if (error != "") return error;

            if (!Validador.UsuarioValido(nuevo.Usuario))
                return "Error: El usuario debe tener entre 4 y 20 caracteres (letras, números, . o _).";

            if (repoPersonal.Listar().Exists(p => p.Usuario.ToLower() == nuevo.Usuario.Trim().ToLower()))
                return "Error: Ese nombre de usuario ya está en uso.";

            if (!Validador.ClaveValida(clavePlana))
                return "Error: La contraseña debe tener mínimo 6 caracteres, con letras y números.";

            nuevo.IdPersonal = repoPersonal.SiguienteId();
            nuevo.Codigo = nuevo.Codigo.Trim().ToUpper();
            nuevo.Nombres = nuevo.Nombres.Trim();
            nuevo.Apellidos = nuevo.Apellidos.Trim();
            nuevo.Usuario = nuevo.Usuario.Trim();
            nuevo.Password = Seguridad.Hash(clavePlana);
            nuevo.Activo = true;
            nuevo.AuditarCreacion(Sesion.UsuarioActual);

            repoPersonal.Listar().Add(nuevo);
            return "Personal registrado correctamente.";
        }

        // RF02: modificar (el codigo y el usuario no cambian)
        public string ModificarPersonal(Personal editado)
        {
            Personal original = repoPersonal.Listar().Find(p => p.IdPersonal == editado.IdPersonal);
            if (original == null) return "Error: No se encontró al trabajador.";
            if (!original.Activo) return "Error: No se puede modificar a un trabajador desactivado.";

            string error = ValidarDatos(editado);
            if (error != "") return error;

            original.Nombres = editado.Nombres.Trim();
            original.Apellidos = editado.Apellidos.Trim();
            original.Rol = editado.Rol;
            original.IdArea = editado.IdArea;
            original.IdTurno = editado.IdTurno;
            original.AuditarModificacion(Sesion.UsuarioActual);
            return "Personal modificado correctamente.";
        }

        // RNF04: no se borra, se desactiva
        public string DesactivarPersonal(int id)
        {
            Personal p = repoPersonal.Listar().Find(x => x.IdPersonal == id);
            if (p == null) return "Error: No se encontró al trabajador.";
            if (!p.Activo) return "Error: El trabajador ya está desactivado.";
            if (p.IdPersonal == Sesion.IdPersonalActual) return "Error: No puedes desactivar tu propia cuenta.";

            // No dejar ingresos abiertos sin cerrar
            if (p.ListaAsistencias.Exists(a => a.HoraIngreso != null && a.HoraSalida == null))
                return "Error: El trabajador tiene un ingreso abierto sin salida.";

            p.Activo = false;
            p.AuditarModificacion(Sesion.UsuarioActual);
            return "Personal desactivado correctamente.";
        }

        // RF03: buscar por codigo o nombre
        public List<Personal> BuscarPersonal(string texto)
        {
            if (!Validador.TieneTexto(texto)) return repoPersonal.Listar();

            string t = texto.Trim().ToLower();
            return repoPersonal.Listar().FindAll(p => p.Codigo.ToLower().Contains(t)
                                                      || p.NombreCompleto.ToLower().Contains(t));
        }

        // RF04: asignar turno
        public string AsignarTurno(int idPersonal, int idTurno)
        {
            Personal p = repoPersonal.Listar().Find(x => x.IdPersonal == idPersonal);
            if (p == null || !p.Activo) return "Error: El trabajador no existe o está desactivado.";

            if (!repoTurno.Listar().Exists(t => t.IdTurno == idTurno && t.Activo))
                return "Error: El turno no existe o está desactivado.";

            p.IdTurno = idTurno;
            p.AuditarModificacion(Sesion.UsuarioActual);
            return "Turno asignado correctamente.";
        }

        public string CambiarPassword(string usuario, string nuevoPassword)
        {
            Personal p = repoPersonal.Listar().Find(x => x.Usuario == usuario);
            if (p == null || !p.Activo) return "Error: El usuario no existe o está desactivado.";

            if (!Validador.ClaveValida(nuevoPassword))
                return "Error: La contraseña debe tener mínimo 6 caracteres, con letras y números.";

            p.Password = Seguridad.Hash(nuevoPassword);
            p.AuditarModificacion(Sesion.UsuarioActual);
            return "Contraseña actualizada correctamente.";
        }

        public List<Personal> ListarTodo()
        {
            return repoPersonal.Listar();
        }

        public List<Personal> ListarActivos()
        {
            return repoPersonal.Listar().Where(p => p.Activo).ToList();
        }

        public Personal BuscarPorId(int id)
        {
            return repoPersonal.Listar().Find(p => p.IdPersonal == id);
        }
    }
}
