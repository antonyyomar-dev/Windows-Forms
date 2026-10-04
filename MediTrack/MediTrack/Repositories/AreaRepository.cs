using System;
using System.Collections.Generic;
using System.Linq;
using MediTrack.Entities;

namespace MediTrack.Repositories
{
    public class AreaRepository
    {
        // Lista estatica = "base de datos" en memoria
        public static List<Area> listaAreas = new List<Area>();

        public AreaRepository()
        {
            // Datos iniciales de prueba
            if (listaAreas.Count == 0)
            {
                string[] nombres = { "Enfermería", "Emergencia", "Laboratorio" };
                for (int i = 0; i < nombres.Length; i++)
                {
                    listaAreas.Add(new Area
                    {
                        IdArea = i + 1,
                        Nombre = nombres[i],
                        Descripcion = "Área de " + nombres[i],
                        Activo = true,
                        CreadoPor = "Sistema",
                        FechaCreacion = DateTime.Now
                    });
                }
            }
        }

        public List<Area> Listar()
        {
            return listaAreas;
        }

        public int SiguienteId()
        {
            return listaAreas.Count == 0 ? 1 : listaAreas.Max(a => a.IdArea) + 1;
        }
    }
}
