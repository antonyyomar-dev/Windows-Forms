using System.Security.Cryptography;
using System.Text;

namespace MediTrack.Services
{
    // Hash de contraseñas con SHA256 (RNF03)
    public static class Seguridad
    {
        private const string Sal = "MediTrack2026";

        public static string Hash(string clave)
        {
            using (SHA256 sha = SHA256.Create())
            {
                byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(Sal + clave));
                StringBuilder sb = new StringBuilder();
                foreach (byte b in bytes)
                {
                    sb.Append(b.ToString("x2"));
                }
                return sb.ToString();
            }
        }
    }
}
