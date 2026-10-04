using System;
using System.Drawing;
using System.Windows.Forms;
using MediTrack.Services;

namespace MediTrack.Forms
{
    // RF05: marcacion de ingreso y salida con el codigo del trabajador
    public partial class FormMarcacion : Form
    {
        private AsistenciaService asistenciaService = new AsistenciaService();

        public FormMarcacion()
        {
            InitializeComponent();

            // Reloj en vivo (el Timer "reloj" se configura en el Disenador)
            ActualizarReloj();
            reloj.Start();
        }

        private void ActualizarReloj()
        {
            DateTime ahora = DateTime.Now;
            lblReloj.Text = ahora.ToString("HH:mm:ss");
            lblFecha.Text = ahora.ToString("dddd, dd 'de' MMMM 'de' yyyy");
        }

        private void reloj_Tick(object sender, EventArgs e)
        {
            ActualizarReloj();
        }

        private void FormMarcacion_FormClosed(object sender, FormClosedEventArgs e)
        {
            reloj.Stop();
        }

        // Valida el codigo antes de llamar al servicio
        private bool CodigoOk()
        {
            if (!Validador.CodigoValido(txtCodigo.Text))
            {
                lblMensaje.ForeColor = Color.Firebrick;
                lblMensaje.Text = "Ingrese un código válido (4 a 10 letras o números).";
                return false;
            }
            return true;
        }

        private void MostrarResultado(string msg)
        {
            lblMensaje.ForeColor = Validador.EsError(msg) ? Color.Firebrick : Color.SeaGreen;
            lblMensaje.Text = msg;
            if (!Validador.EsError(msg)) txtCodigo.Clear();
        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {
            if (CodigoOk()) MostrarResultado(asistenciaService.RegistrarIngreso(txtCodigo.Text));
        }

        private void btnSalida_Click(object sender, EventArgs e)
        {
            if (CodigoOk()) MostrarResultado(asistenciaService.RegistrarSalida(txtCodigo.Text));
        }
    }
}
