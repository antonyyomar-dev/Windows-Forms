using Lab04___Arreglos_II.controlllers;
using Lab04___Arreglos_II.entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04___Arreglos_II
{
    public partial class Form1 : Form
    {
        private AlumnoController alumnoController = new AlumnoController();

        private void MostrarAlumnosEnDataGrid(Alumno[] alumnos)
        {
            dgAlumnos.DataSource = null;
            dgAlumnos.DataSource = alumnos;
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void tbnRegistrar_Click(object sender, EventArgs e)
        {
            if (tbCodigo.Text == "" || tbNombre.Text == "" || tbPromedio.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            // crear objeto 

            Alumno alumno = new Alumno()
            {
                Codigo = tbCodigo.Text,
                Nombre = tbNombre.Text,
                Promedio = double.Parse(tbPromedio.Text)
            };

            // Registrar
            alumnoController.Registrar(alumno);

            // mostrar
            MostrarAlumnosEnDataGrid(alumnoController.ListarTodo());
        }
        
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(dgAlumnos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione registro a eliminar");
            }

            string codigo = dgAlumnos.SelectedRows[0].Cells[0].Value.ToString();

            // Eliminamos 

            alumnoController.Eliminar(tbCodigo.Text);

            // Mostrar
            MostrarAlumnosEnDataGrid(alumnoController.ListarTodo());
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            // validacion

            if (tbBuscarPorCodigo.Text == "")
            {
                MessageBox.Show("Ingrese un codigo a buscar");
                return;
            }

            string codigo = tbBuscarPorCodigo.Text;
            MostrarAlumnosEnDataGrid(alumnoController.BuscarPorCodigo(codigo));
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            // Mostrar
            MostrarAlumnosEnDataGrid(alumnoController.Ordenar());
        }
    }
}
