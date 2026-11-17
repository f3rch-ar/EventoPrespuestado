using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventoPresupuestado.Model
{
    public class TipoMenu : ModelBase
    {
        private string nombreMenu;
        private decimal valorTipoMenu;
        private List<Comida> listComidas;

        // CONSTRUCTORES
        public TipoMenu()
        {
            listComidas = new List<Comida>();
            valorTipoMenu = 0;
        }

        public TipoMenu(string nombreMenu, List<Comida> listComidas)
        {
            NombreMenu = nombreMenu;
            ValorTipoMenu = 0;
            ListComidas = listComidas ?? new List<Comida>();
        }

        public TipoMenu(int idMenu, string nombreMenu, List<Comida> listComidas, bool active)
        {
            Id = idMenu;
            NombreMenu = nombreMenu;
            ValorTipoMenu = 0;
            ListComidas = listComidas ?? new List<Comida>();
            Activo = active;
        }

        public TipoMenu(string nombreMenu, decimal valorTipoMenu, List<Comida> listComidas)
        {
            NombreMenu = nombreMenu;
            ValorTipoMenu = valorTipoMenu;
            ListComidas = listComidas ?? new List<Comida>();
        }

        public TipoMenu(int idTipoMenu, string nombreMenu, decimal valorTipoMenu, List<Comida> listComidas)
        {
            Id = idTipoMenu;
            NombreMenu = nombreMenu;
            ValorTipoMenu = valorTipoMenu;
            ListComidas = listComidas ?? new List<Comida>();
        }

        //METODOS

        public void CalcularTotalComidas()
        {
            decimal accum = 0;
            foreach (Comida comida in ListComidas)
            {
                accum += comida.ValorComida;
            }
            ValorTipoMenu = accum;
        }


        // PROPIEDADES
        public string NombreMenu
        {
            get { return nombreMenu; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("El nombre del menú no puede estar vacío.", nameof(value));
                }

                foreach (char caracter in value)
                {
                    if (!char.IsLetterOrDigit(caracter) && !char.IsWhiteSpace(caracter) && caracter != '-')
                    {
                        throw new ArgumentException("El nombre solo puede contener letras, números, espacios y guiones.", nameof(value));
                    }
                }
                nombreMenu = value.Trim();
            }
        }

        public decimal ValorTipoMenu
        {
            get { return valorTipoMenu; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "El valor no puede ser menor a cero");
                }

                valorTipoMenu = value;
            }
        }

        public List<Comida> ListComidas
        {
            get { return listComidas; }
            set { listComidas = value ?? new List<Comida>(); }
        }
    }
}

