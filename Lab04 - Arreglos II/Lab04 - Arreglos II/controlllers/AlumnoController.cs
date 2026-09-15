using System;
using Lab04___Arreglos_II.entities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Lab04___Arreglos_II.controlllers
{
    public class AlumnoController
    {
        private Alumno[ ] alumnos = new Alumno[100];
        private int cont = 0;

        public Alumno[] ListarTodo()
        {
            return alumnos;
        }

        public void Registrar(Alumno alumno)
        {
            alumnos[cont] = alumno;
            cont++;
        }

        public void Eliminar(string Codigo)
        {
            int posicion = Array.FindIndex(alumnos, alumno => alumno.Codigo.Equals(Codigo));

            // logica de eliminacion 

            for( int i= 0; i < cont; i++)
            {
                if (i >= posicion)
                {
                    alumnos[i] = alumnos[i + 1];

                }
                cont--;
            }
        }


        // StarWith es para devolver todo lo que se iguala a lo que se esta buscando
        // containg devuelve los elemento igual sin importar el orden
        public Alumno[] BuscarPorCodigo(string codigo)
        {
            return Array.FindAll(alumnos, alumno => alumno != null && alumno.Codigo.Contains(codigo));
        }

        private class MetodoComparacion : IComparer
        {
            int IComparer.Compare(object x, object y)
            {
                // Validar nulos

                if( x == null || y == null)
                {
                    return 1;
                }

                double promedio1 = ((Alumno)x).Promedio;
                double promedio2 = ((Alumno)y).Promedio;

                if (promedio1 < promedio2) return 1;
                else return -1;
            }
        }
        public Alumno[] Ordenar()
        {
            Array.Sort(alumnos,0,cont, new MetodoComparacion());
            return alumnos;
        }
    }
}
