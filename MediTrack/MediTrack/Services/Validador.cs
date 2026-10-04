using System.Linq;
using System.Text.RegularExpressions;

namespace MediTrack.Services
{
    // Validaciones reutilizables (RNF09). Todas devuelven true si el dato es VALIDO.
    public static class Validador
    {
        // Los servicios devuelven mensajes; si empiezan con "Error" es un fallo
        public static bool EsError(string mensaje)
        {
            return mensaje != null && mensaje.StartsWith("Error");
        }

        public static bool TieneTexto(string texto)
        {
            return !string.IsNullOrWhiteSpace(texto);
        }

        // Codigo: 4 a 10 letras o numeros
        public static bool CodigoValido(string codigo)
        {
            return TieneTexto(codigo) && Regex.IsMatch(codigo.Trim(), @"^[A-Za-z0-9]{4,10}$");
        }

        // Nombres/apellidos: solo letras y espacios
        public static bool NombreValido(string texto)
        {
            return TieneTexto(texto) && Regex.IsMatch(texto.Trim(), @"^[A-Za-zÁÉÍÓÚáéíóúÑñ ]{2,50}$");
        }

        // Usuario: 4 a 20 caracteres (letras, numeros, punto o guion bajo)
        public static bool UsuarioValido(string usuario)
        {
            return TieneTexto(usuario) && Regex.IsMatch(usuario.Trim(), @"^[A-Za-z0-9_.]{4,20}$");
        }

        // Clave: minimo 6, con al menos una letra y un numero
        public static bool ClaveValida(string clave)
        {
            return TieneTexto(clave) && clave.Length >= 6
                   && clave.Any(char.IsLetter) && clave.Any(char.IsDigit);
        }

        public static bool RolValido(string rol)
        {
            return Roles.Todos.Contains(rol);
        }

        // Texto con largo minimo (nombres de area, motivos, etc.)
        public static bool LargoValido(string texto, int min, int max)
        {
            return TieneTexto(texto) && texto.Trim().Length >= min && texto.Trim().Length <= max;
        }
    }
}
