namespace MediTrack.Entities
{
    public class Area : EntidadBase
    {
        public int IdArea { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public bool Activo { get; set; }

        public Area() { }
    }
}
