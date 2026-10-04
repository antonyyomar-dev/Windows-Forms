using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using MediTrack.Entities;
using MediTrack.Services;

namespace MediTrack.Forms
{
    // RF10, RF11 y RF12: graficos estadisticos
    public partial class FormGraficos : Form
    {
        private ReporteService reporteService = new ReporteService();
        private Reportes filtro;

        public FormGraficos(Reportes filtro)
        {
            InitializeComponent();
            this.filtro = filtro;

            UI.CargarCombo(cmbTipo, new List<Opcion>
            {
                new Opcion { Id = 1, Texto = "Distribución de asistencia (circular)" },
                new Opcion { Id = 2, Texto = "Evolución del ausentismo (líneas)" },
                new Opcion { Id = 3, Texto = "Tardanzas por área (barras)" }
            });

            Mostrar();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            Mostrar();
        }

        private void Mostrar()
        {
            int tipo = UI.IdElegido(cmbTipo);
            chart.Series.Clear();
            chart.Titles.Clear();

            Series serie = new Series("Datos");
            List<ItemGrafico> datos;

            if (tipo == 1)          // RF10
            {
                datos = reporteService.ObtenerDistribucionAsistencia(filtro);
                serie.ChartType = SeriesChartType.Pie;
                serie.Label = "#VALX: #VAL{0.0}%";
                serie.LegendText = "#VALX";
                chart.Titles.Add(new Title("Distribución de asistencia (%)"));
            }
            else if (tipo == 2)     // RF11
            {
                datos = reporteService.ObtenerEvolucionAusentismo(filtro);
                serie.ChartType = SeriesChartType.Line;
                serie.MarkerStyle = MarkerStyle.Circle;
                serie.Label = "#VAL{0.0}%";
                chart.Titles.Add(new Title("Ausentismo no justificado por mes (%)"));
            }
            else                    // RF12
            {
                datos = reporteService.ObtenerTardanzaPorArea(filtro);
                serie.ChartType = SeriesChartType.Column;
                serie.Label = "#VAL";
                chart.Titles.Add(new Title("Tardanzas acumuladas por área"));
            }

            chart.Legends["leyenda"].Enabled = (tipo == 1);

            foreach (ItemGrafico item in datos)
                serie.Points.AddXY(item.Etiqueta, item.Valor);

            chart.Series.Add(serie);

            if (datos.Count == 0)
                MessageBox.Show("No hay datos para el periodo y filtros seleccionados.");
        }
    }
}
