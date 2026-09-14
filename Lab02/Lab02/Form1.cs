using Lab02.controllers;
using Lab02.entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Lab02
{
    public partial class Form1 : Form
    {
        private EmpleadoController empleadoController = new EmpleadoController();
        public Form1()
        {
            InitializeComponent();
        }

        private void MostrarNuevoEmpleado(Empleado empleado)
        {
            dgvEmpleados.Rows.Add(empleado.Nombre, empleado.Categoria, empleado.MinutosTardanza, empleado.Pago);
        }



        private void btnProcesarEmpleado_Click(object sender, EventArgs e)
        {
            // validar campos 

            if (tbNombre.Text == "" || cbCategoria.Text == "")
            {
                MessageBox.Show("Complete los datos en todos los campos");
                return;
            }

            if (cbCategoria.Text != "A" && cbCategoria.Text != "B" && cbCategoria.Text != "C")
            {
                MessageBox.Show("La categoría no está registrada");
                return;
            }
            // crear empleado

            Empleado empleado = new Empleado()
            {
                Nombre = tbNombre.Text,
                Categoria = cbCategoria.Text,
                MinutosTardanza = Convert.ToInt32(nuMinutosTardanza.Value)
            };

            // Procesar empleado 

            Empleado empleadoProcesado = empleadoController.ProcesarEmpleado(empleado);

            // Agregr al DataGridView

            MostrarNuevoEmpleado(empleadoProcesado);

            tbNombre.Clear();
            cbCategoria.SelectedIndex = -1;
            cbCategoria.Text = "";
            nuMinutosTardanza.Value = 0;
            tbNombre.Focus();
        }
    }
}
