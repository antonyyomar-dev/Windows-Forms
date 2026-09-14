using Lab03.controllers;
using Lab03.entites;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03
{
    public partial class Form1 : Form
    {

        private AtencionController atencionController = new AtencionController();
        public Form1()
        {
            InitializeComponent();
        }

        private void MostrarEnDataGrid(Atencion[] atenciones)
        {
            dgAtenciones.DataSource = null;
            dgAtenciones.DataSource = atenciones;
            lbTotalServicio1.Text = atencionController.ObtenerTotalServicio1().ToString();
            lbTotalServicio2.Text = atencionController.ObtenerTotalServicio2().ToString();
            lbTotalServicio3.Text = atencionController.ObtenerTotalServicio3().ToString();
            lbPromedioServicio1.Text = atencionController.ObtenerPromedioLavado().ToString();
            lbServicioMenorD.Text = atencionController.ObtnerServicioMenorDemanda().ToString();


        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
     
            // Validar campos
            if(cbTipoVehiculo.Text == "" || cbTipoServicio.Text == "")
            {
                MessageBox.Show("Ingrese los datos en todos los campos");
                return;
            }

            Atencion atencion = new Atencion()
            {
                TipoServicio = cbTipoServicio.Text,
                TipoVehiculo = cbTipoVehiculo.Text,
            };

            atencionController.Registrar(atencion);

            MostrarEnDataGrid(atencionController.ListarTodo());
        }
    }
}
