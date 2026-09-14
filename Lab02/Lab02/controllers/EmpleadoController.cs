using Lab02.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02.controllers
{
    internal class EmpleadoController
    {

        public Empleado ProcesarEmpleado(Empleado empleado)
        {
            switch (empleado.Categoria)
            {
                case "A":
                    empleado.Pago = 1000; break;
                case "B":
                    empleado.Pago = 900; break;
                case "C":
                    empleado.Pago = 600; break;
                default:
                   
                    empleado.Pago = 0; break;
                    
                            
            }

            if (empleado.MinutosTardanza == 0)
            {
                empleado.Pago *= 1.10;
                // Otras formas:
                // empleado.Pago = empleado.Pago * 1.10
            }
            else
            {
                empleado.Pago = empleado.Pago - (empleado.MinutosTardanza * 5);
            }
            return empleado;
        }
    }
}
