using System;
using System.Linq;
using System.Windows.Forms;
using MediTrack.Entities;
using MediTrack.Services;

namespace MediTrack.Forms
{
    // Gestion de areas (solo Administrador)
    public partial class FormAreas : Form
    {
        private AreaService areaService = new AreaService();

        public FormAreas()
        {
            InitializeComponent();
            CargarGrid();
        }

        private void CargarGrid()
        {
            grid.DataSource = areaService.ListarArea().Select(a => new
            {
                Id = a.IdArea, Nombre = a.Nombre, Descripcion = a.Descripcion,
                Estado = a.Activo ? "Activa" : "Inactiva"
            }).ToList();
        }

        private void grid_SelectionChanged(object sender, EventArgs e)
        {
            Area a = areaService.ListarArea().Find(x => x.IdArea == UI.IdFilaSeleccionada(grid));
            if (a == null) return;
            txtNombre.Text = a.Nombre;
            txtDescripcion.Text = a.Descripcion;
        }

        private bool NombreOk()
        {
            if (!Validador.TieneTexto(txtNombre.Text)) { errores.SetError(txtNombre, "Campo obligatorio"); return false; }
            errores.SetError(txtNombre, "");
            return true;
        }

        private void Resultado(string msg)
        {
            UI.Mostrar(msg);
            if (!Validador.EsError(msg)) CargarGrid();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (!NombreOk()) return;
            Resultado(areaService.RegistrarArea(new Area { Nombre = txtNombre.Text, Descripcion = txtDescripcion.Text }));
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            int id = UI.IdFilaSeleccionada(grid);
            if (id == 0 || !NombreOk()) return;
            Resultado(areaService.ActualizarArea(new Area { IdArea = id, Nombre = txtNombre.Text, Descripcion = txtDescripcion.Text }));
        }

        private void btnDesactivar_Click(object sender, EventArgs e)
        {
            int id = UI.IdFilaSeleccionada(grid);
            if (id == 0) { UI.Mostrar("Error: Seleccione un área de la tabla."); return; }
            Resultado(areaService.DesactivarArea(id));
        }
    }
}
