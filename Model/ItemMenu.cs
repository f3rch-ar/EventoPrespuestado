using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventoPresupuestado.Model
{
    public class ItemMenu
    {
        private int idItemMenu;
        private int cant;
        private decimal precioUnitarioBaseAdulto;
        private TipoMenu menu;
        private bool isAdulto;
        private float descuentoInfantil;

// CONSTRUCTORES

        public ItemMenu() { }

        public ItemMenu(int cant, TipoMenu menu)
        {
            Cantidad = cant;
            TipoDeMenu = menu;
            PrecioUnitarioBaseAdulto = menu.ValorTipoMenu;
            IsAdulto = true;
        }

        public ItemMenu(int cant, TipoMenu menu, bool isAdulto) : this(cant, menu) // <- sobrecarga que ejecuta el constructor anterior
        {
            IsAdulto = isAdulto;
        }

// METODOS

        public decimal CalcularSubtotal()
        {
            decimal precioUnitario;

            if (IsAdulto)
            {
                precioUnitario = PrecioUnitarioBaseAdulto;
            }

            else
            {
                precioUnitario = PrecioUnitarioBaseAdulto * (decimal)(1 - DescuentoNino);
            }

            return precioUnitario * Cantidad;
        }

// PROPIEDADES

        public TipoMenu TipoDeMenu
        {
            get { return menu; }
            set
            {
                menu = value;
            }
        }

        public int Cantidad
        {
            get { return cant; }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("La cantidad no puede ser menor a 0");
                }

                cant = value;
            }
        }

        public bool IsAdulto
        {
            get { return isAdulto; }

            set
            {
                isAdulto = value;
            }
        }

        public decimal PrecioUnitarioBaseAdulto
        {
            get { return precioUnitarioBaseAdulto; }
            set
            {
                precioUnitarioBaseAdulto = value;
            }
        }

        public float DescuentoNino
        {
            get { return descuentoInfantil; }
            set
            {
                if(value >= 0 && value <= 100)
                {
                    descuentoInfantil = value;
                }
                else
                {
                    //throw Exception();
                }
                
            }
        }
    }
}
