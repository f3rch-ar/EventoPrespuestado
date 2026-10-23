using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventoPresupuestado.RolControl
{
    public class AdminMood
    {
        private string passwordHash;
        private string email;

        // CONSTRUCTORES
        public AdminMood() { }

        public AdminMood(string passwordHash, string email)
        {
            PasswordHash = passwordHash;
            Email = email;
        }

        // GETTERS && SETTERS
        public string PasswordHash
        {
            get { return passwordHash; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("El hash de la contraseña no puede estar vacío.");
                }
                passwordHash = value.Trim();
            }
        }

        public string Email
        {
            get { return email; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("El correo electrónico no puede estar vacío.");
                }

                string emailClean = value.Trim();

                if (!emailClean.Contains("@") || emailClean.Length < 5 || emailClean.EndsWith("@") || emailClean.StartsWith("@"))
                {
                    throw new ArgumentException("El formato del correo electrónico no es válido.");
                }

                email = emailClean;
            }
        }
    }
}
