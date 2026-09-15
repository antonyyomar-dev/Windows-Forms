using Labo5___Listas.repositories;
using Labo5___Listas.entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo5___Listas.services
{
    class ElectrodomesticoService
    {
        private ElectrodomesticoRepository electrodomesticoRepository = new ElectrodomesticoRepository();

        public bool  Registrar(Electrodomestico elec)
        {
            if (electrodomesticoRepository.Existe(elec.Codigo))
            {
                return false;
            }
            else
            {
                electrodomesticoRepository.Registrar(elec);
                return true;
            }
        }

        public List<Electrodomestico> ListarTodo()
        {
            return ElectrodomesticoRepository.ListarTodo();
        }

        public void Eliminar(string codigo)
        {
            electrodomesticoRepository.Eliminar(codigo);
        }

        public void EliminarTodo()
        {

            electrodomesticoRepository.EliminarTood();
        }

        public List<Electrodomestico> BuscarPorNombre (string nombre)
        {
            return electrodomesticoRepository.BuscarPorNombre(nombre);
        }

        public List<Electrodomestico> OrdenarPorPrecio()
        {
            return electrodomesticoRepository.OrdenarPorPrecio();
        }
        
    }
}
