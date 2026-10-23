using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventoPresupuestado.Model
{
    public class TipoMenu
    {
        private int idTipoMenu;
        private string nombreMenu;
        private decimal valorTipoMenu;
        private List<Comida> listComidas;

// CONSTRUCTORES

        public TipoMenu() { }

        public TipoMenu(string nombreMenu)
        {
            NombreMenu = nombreMenu;
        }

// METODOS

        public void AgregarComidas(Comida comida)
        {
            ListComidas.Add(comida);
            CalcularValorTotalMenu();
        }

        public void DeleteComidas(Comida comida)
        {
            ListComidas.Remove(comida);
            CalcularValorTotalMenu();
        }

        public decimal CalcularValorTotalMenu()
        {
            ValorTipoMenu = 0;

            foreach (Comida comida in ListComidas)
            {
                ValorTipoMenu = ValorTipoMenu + comida.ValorComida;
            }

            return valorTipoMenu;
        }


// PROPIEDADES
        public string NombreMenu
        {
            get { return nombreMenu; }
            set
            {
                //Verifica que no este vacio y que solo sea numero y letras
                if(string.IsNullOrEmpty(value) && !value.All(char.IsLetterOrDigit))
                {
                    throw new ArgumentException(nameof(value), "El nombre no debe estar vacio o contener un caracter especial");
                }

                nombreMenu = value;
            }
        }

        public decimal ValorTipoMenu
        {
            get { return valorTipoMenu; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "El valor no puede ser menor a cero");
                }

                valorTipoMenu = value;
            }
        }

        public List<Comida> ListComidas
        {
            get { return listComidas; }
            
        }
    }
}
