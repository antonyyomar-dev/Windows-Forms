namespace MediTrack.Services
{
    // Roles del sistema (RF01)
    public static class Roles
    {
        public const string Administrador = "Administrador";
        public const string RRHH = "Recursos Humanos";
        public const string Personal = "Personal";

        public static readonly string[] Todos = { Administrador, RRHH, Personal };
    }
}
