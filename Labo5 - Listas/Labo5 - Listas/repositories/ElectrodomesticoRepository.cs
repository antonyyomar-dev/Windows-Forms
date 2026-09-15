using System;
using Labo5___Listas.entitites;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo5___Listas.repositories
{
    class ElectrodomesticoRepository
    {
        private static List<Electrodomestico> electrodomesticos = new List<Electrodomestico>();

        public bool Existe(string codigo)
        {
            return electrodomesticos.Exists(elec => elec.Codigo.Equals(codigo));
        }

        public void Registrar(Electrodomestico elec)
        {
            electrodomesticos.Add(elec);
        }

        public static List<Electrodomestico> ListarTodo()
        {
            return electrodomesticos;
        }

        public void Eliminar(string codigo)
        {
            electrodomesticos.FindAll(elec => elec.Codigo.Equals(codigo));
        }

        public void EliminarTood()
        {
            electrodomesticos.Clear();
        }


        public List<Electrodomestico> BuscarPorNombre (string Nombre)
        {
            return electrodomesticos.Where(elec => elec.Nombre.Contains(Nombre)).ToList();
        }

        public List<Electrodomestico> OrdenarPorPrecio()
        {
            return electrodomesticos.OrderBy(elec => elec.Precio).ToList();
        }
    }
}
