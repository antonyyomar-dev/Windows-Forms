using System;

namespace MediTrack.Entities
{
    // Campos de auditoria que heredan todas las entidades (RNF05)
    public class EntidadBase
    {
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
        public string CreadoPor { get; set; }
        public string ModificadoPor { get; set; }

        // Marca la auditoria al crear
        public void AuditarCreacion(string usuario)
        {
            CreadoPor = usuario;
            FechaCreacion = DateTime.Now;
        }

        // Marca la auditoria al modificar
        public void AuditarModificacion(string usuario)
        {
            ModificadoPor = usuario;
            FechaModificacion = DateTime.Now;
        }
    }
}
