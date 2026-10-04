using System;
using System.Collections.Generic;
using System.Linq;
using MediTrack.Entities;
using MediTrack.Services;

namespace MediTrack.Repositories
{
    public class PersonalRepository
    {
        public static List<Personal> listaPersonal = new List<Personal>();

        public PersonalRepository()
        {
            // Usuarios iniciales de prueba
            if (listaPersonal.Count == 0)
            {
                listaPersonal.Add(CrearPersonal(1, "ADM001", "Admin", "Sistema", "admin", "admin123", Roles.Administrador, 1, 1));
                listaPersonal.Add(CrearPersonal(2, "RRH001", "Rosa", "Salazar", "rrhh", "rrhh123", Roles.RRHH, 1, 1));
                listaPersonal.Add(CrearPersonal(3, "ENF001", "Luis", "Vega", "lvega", "enf123", Roles.Personal, 1, 1));
                listaPersonal.Add(CrearPersonal(4, "EME001", "Carla", "Rojas", "crojas", "eme123", Roles.Personal, 2, 3));
            }
        }

        private Personal CrearPersonal(int id, string cod, string nom, string ape, string user, string clave, string rol, int idArea, int idTurno)
        {
            return new Personal
            {
                IdPersonal = id,
                Codigo = cod,
                Nombres = nom,
                Apellidos = ape,
                Usuario = user,
                Password = Seguridad.Hash(clave),
                Rol = rol,
                IdArea = idArea,
                IdTurno = idTurno,
                Activo = true,
                CreadoPor = "Sistema",
                FechaCreacion = DateTime.Now
            };
        }

        public List<Personal> Listar()
        {
            return listaPersonal;
        }

        public int SiguienteId()
        {
            return listaPersonal.Count == 0 ? 1 : listaPersonal.Max(p => p.IdPersonal) + 1;
        }

        // Recorre la multilista: todas las jornadas de todo el personal
        public List<RegistroAsistencia> ListarAsistencias()
        {
            return listaPersonal.SelectMany(p => p.ListaAsistencias).ToList();
        }

        // Recorre la multilista: todas las justificaciones
        public List<Justificacion> ListarJustificaciones()
        {
            return listaPersonal.SelectMany(p => p.ListaJustificaciones).ToList();
        }

        public int SiguienteIdAsistencia()
        {
            List<RegistroAsistencia> todas = ListarAsistencias();
            return todas.Count == 0 ? 1 : todas.Max(a => a.IdAsistencia) + 1;
        }

        public int SiguienteIdJustificacion()
        {
            List<Justificacion> todas = ListarJustificaciones();
            return todas.Count == 0 ? 1 : todas.Max(j => j.IdJustificacion) + 1;
        }
    }
}
