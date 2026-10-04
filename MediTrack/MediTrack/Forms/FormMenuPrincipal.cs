using System;
using System.Drawing;
using System.Windows.Forms;
using MediTrack.Services;

namespace MediTrack.Forms
{
    // Menu principal: muestra opciones segun el rol (RF01)
    public partial class FormMenuPrincipal : Form
    {
        public FormMenuPrincipal()
        {
            InitializeComponent();

            lblUsuario.Text = "Usuario: " + Sesion.UsuarioActual + "  (" + Sesion.RolActual + ")";

            // Todos los roles ven "Marcar asistencia" y "Justificaciones".
            // Las demas opciones se ocultan segun el rol.
            bool gestor = Sesion.EsGestor();
            btnPersonal.Visible = gestor;
            btnTurnos.Visible = gestor;
            btnJornadas.Visible = gestor;
            btnReportes.Visible = gestor;
            btnAreas.Visible = (Sesion.RolActual == Roles.Administrador);

            // Ajusta el alto de la ventana a los botones visibles
            flpOpciones.PerformLayout();
            this.ClientSize = new Size(this.ClientSize.Width, flpOpciones.Bottom + 25);
        }


        private void btnMarcar_Click(object sender, EventArgs e) 
        { 
            FormMarcacion frm = new FormMarcacion();
            frm.ShowDialog(); 
        }
        private void btnJustificaciones_Click(object sender, EventArgs e) 
        {
            FormJustificaciones frm = new FormJustificaciones();
            frm.ShowDialog();
        }
        private void btnPersonal_Click(object sender, EventArgs e) 
        {
            FormPersonal frm = new FormPersonal();
            frm.ShowDialog(); 
        }
        private void btnTurnos_Click(object sender, EventArgs e)
        {
            FormTurnos frm = new FormTurnos(); 
            frm.ShowDialog(); 
        }
        private void btnJornadas_Click(object sender, EventArgs e) 
        {
            FormJornadas frm = new FormJornadas(); 
            frm.ShowDialog(); 
        }
        private void btnReportes_Click(object sender, EventArgs e) 
        {
            FormReportes frm = new FormReportes();
            frm.ShowDialog(); 
        }
        private void btnAreas_Click(object sender, EventArgs e) 
        {
            FormAreas frm = new FormAreas();
            frm.ShowDialog(); 
        }
        private void btnCerrarSesion_Click(object sender, EventArgs e) 
        {
            Close(); 
        }
    }
}
