using MediTrack.Entities;

namespace MediTrack.Services
{
    // Guarda quien inicio sesion (se usa para auditoria y permisos)
    public static class Sesion
    {
        public static string UsuarioActual { get; set; } = "Sistema";
        public static string RolActual { get; set; } = "";
        public static int IdPersonalActual { get; set; } = 0;

        public static void Iniciar(Personal p)
        {
            UsuarioActual = p.Usuario;
            RolActual = p.Rol;
            IdPersonalActual = p.IdPersonal;
        }

        public static void Cerrar()
        {
            UsuarioActual = "Sistema";
            RolActual = "";
            IdPersonalActual = 0;
        }

        // Atajo: ¿puede gestionar (Admin o RRHH)?
        public static bool EsGestor()
        {
            return RolActual == Roles.Administrador || RolActual == Roles.RRHH;
        }
    }
}
