using Labo5___Listas.services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Labo5___Listas.entitites;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labo5___Listas
{
    public partial class FormElectrodomestico : Form
    {
        private ElectrodomesticoService electrodomesticoService = new ElectrodomesticoService();
        public FormElectrodomestico()
        {
            InitializeComponent();
        }

        public void MostrarElectrodomestico( List<Electrodomestico> electrodomesticos)
        {
            dgElectrodomesticos.DataSource = null;
            if(electrodomesticos.Count == 0)
            {
                lbTotalRegistros.Text = "0";
                lbTotalStock.Text = "0";
                return;
            }
            else
            {
                dgElectrodomesticos.DataSource = electrodomesticos;
                lbTotalRegistros.Text = electrodomesticos.Count.ToString();

                int Totalstock = 0;
                for (int i=0; i< electrodomesticos.Count; i++)
                {
                    Totalstock += electrodomesticos[i].Stock;
                }
                lbTotalStock.Text = Totalstock.ToString();
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // validación de campos 
            if (tbCodigo.Text == "" || tbNombre.Text == "" || tbPrecio.Text == "" &&
                 tbStock.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            // creamos el objeto 

            Electrodomestico elec = new Electrodomestico()
            {
                Codigo = tbCodigo.Text,
                Nombre = tbNombre.Text,
                Stock = int.Parse(tbStock.Text),
                Precio = double.Parse(tbPrecio.Text)
            };

            // service 


            bool registrado = electrodomesticoService.Registrar(elec);
            if (!registrado)
            {
                MessageBox.Show("El codigo ya existe");
                return;
            }

            // mostrar 

            MostrarElectrodomestico(electrodomesticoService.ListarTodo());

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // validacion de seleccion 

            if(dgElectrodomesticos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciones registro a eliminar");
                return;
            }
            string codigo = dgElectrodomesticos.SelectedRows[0].Cells[0].Value.ToString();

            electrodomesticoService.Eliminar(codigo);
            MostrarElectrodomestico(electrodomesticoService.ListarTodo());
        }

        private void btnEliminarTodo_Click(object sender, EventArgs e)
        {
            electrodomesticoService.EliminarTodo();
            MostrarElectrodomestico(electrodomesticoService.ListarTodo());
        }

        private void btnOrdenarPorPrecio_Click(object sender, EventArgs e)
        {
            MostrarElectrodomestico(electrodomesticoService.OrdenarPorPrecio());
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            MostrarElectrodomestico(electrodomesticoService.ListarTodo());
            tbBuscarPorNombre.Text = "";
            tbNombre.Text = "";
            tbCodigo.Text = "";
            tbPrecio.Text = "";
            tbStock.Text = "";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // validacion de campo 

            if(tbBuscarPorNombre.Text == "")
            {
                MessageBox.Show("Ingrese nombre");
                return;
            }

            string nombre = tbBuscarPorNombre.Text;
            // MOSTRAR
            MostrarElectrodomestico(electrodomesticoService.BuscarPorNombre(nombre));
        }
    }
}
