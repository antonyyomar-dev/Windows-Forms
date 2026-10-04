using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MediTrack.Entities;
using MediTrack.Services;

namespace MediTrack.Forms
{
    // RF08 y RF09: tablas de resumen e incidencias (con filtros)
    public partial class FormReportes : Form
    {
        private ReporteService reporteService = new ReporteService();
        private AreaService areaService = new AreaService();
        private PersonalService personalService = new PersonalService();

        public FormReportes()
        {
            InitializeComponent();

            dtpDesde.Value = DateTime.Today.AddDays(-30);
            CargarFiltros();
        }

        private void CargarFiltros()
        {
            // La opcion con Id 0 significa "todos"
            List<Opcion> areas = new List<Opcion> { new Opcion { Id = 0, Texto = "(Todas)" } };
            areas.AddRange(areaService.ListarArea().Select(a => new Opcion { Id = a.IdArea, Texto = a.Nombre }));
            UI.CargarCombo(cmbArea, areas);

            List<Opcion> personal = new List<Opcion> { new Opcion { Id = 0, Texto = "(Todos)" } };
            personal.AddRange(personalService.ListarTodo().Select(p => new Opcion { Id = p.IdPersonal, Texto = p.Codigo + " - " + p.NombreCompleto }));
            UI.CargarCombo(cmbPersonal, personal);
        }

        // Arma el filtro desde la pantalla
        private Reportes LeerFiltro()
        {
            Reportes f = new Reportes();
            f.PeriodoInicio = dtpDesde.Value.Date;
            f.PeriodoFin = dtpHasta.Value.Date;
            f.IdArea = UI.IdElegido(cmbArea);
            f.IdPersonal = UI.IdElegido(cmbPersonal);
            return f;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            Reportes f = LeerFiltro();
            string error = reporteService.ValidarFiltro(f);
            if (error != "") { UI.Mostrar(error); return; }

            gridResumen.DataSource = reporteService.GenerarResumenAsistencia(f);
            gridIncidencias.DataSource = reporteService.GenerarIncidenciaDiarias(f);

            if (gridResumen.Rows.Count == 0)
                MessageBox.Show("No hay jornadas registradas en el periodo seleccionado.");
        }

        private void btnGraficos_Click(object sender, EventArgs e)
        {
            Reportes f = LeerFiltro();
            string error = reporteService.ValidarFiltro(f);
            if (error != "") { UI.Mostrar(error); return; }

            new FormGraficos(f).ShowDialog();
        }
    }
}
