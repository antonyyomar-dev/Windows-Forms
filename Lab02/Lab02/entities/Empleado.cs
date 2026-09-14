using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02.entities
{
    public class Empleado
    {
        public String Nombre { get; set; }
        public String Categoria { get; set; }
        public int MinutosTardanza { get; set; }
        public double Pago { get; set; }
    }
}
