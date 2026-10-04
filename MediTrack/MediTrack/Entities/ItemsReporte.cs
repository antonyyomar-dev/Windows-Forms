using System;

namespace MediTrack.Entities
{
    // RF08: fila de la tabla resumen
    public class ResumenAsistenciaItem
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Area { get; set; }
        public int DiasLaborables { get; set; }
        public int Asistencias { get; set; }
        public int Faltas { get; set; }
        public int Tardanzas { get; set; }
        public int FaltasJustificadas { get; set; }
        public int MinutosTardanza { get; set; }
        public decimal HorasTrabajadas { get; set; }
    }

    // RF09: fila de la tabla de incidencias
    public class IncidenciaItem
    {
        public string Fecha { get; set; }
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string HoraEntrada { get; set; }
        public string Estado { get; set; }
        public string Justificacion { get; set; }
    }

    // RF10-RF12: punto de un grafico
    public class ItemGrafico
    {
        public string Etiqueta { get; set; }
        public double Valor { get; set; }
    }

    // Item simple para llenar ComboBox
    public class Opcion
    {
        public int Id { get; set; }
        public string Texto { get; set; }
    }
}
