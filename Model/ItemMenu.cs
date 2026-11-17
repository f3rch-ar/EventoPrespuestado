using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventoPresupuestado.Model
{
    public class ItemMenu : ModelBase
    {
        private int cant;
        private decimal precioUnitarioBaseAdulto;
        private TipoMenu menu;
        private bool isAdulto;
        private float descuentoInfantil;

        // CONSTRUCTORES
        public ItemMenu()
        {
            Activo = true;
        }

        public ItemMenu(int cant, TipoMenu menu, bool isAdulto, float descuentoInfantil)
        {
            Cantidad = cant;
            TipoDeMenu = menu;
            PrecioUnitarioBaseAdulto = menu.ValorTipoMenu;
            IsAdulto = isAdulto;
            DescuentoNino = descuentoInfantil;
            Activo = true;
        }

        public ItemMenu(int idItemMenu, int cant, TipoMenu menu, bool isAdulto, float descuentoInfantil)
        {
            Id = idItemMenu;
            Cantidad = cant;
            TipoDeMenu = menu;
            PrecioUnitarioBaseAdulto = menu.ValorTipoMenu;
            IsAdulto = isAdulto;
            DescuentoNino = descuentoInfantil;
            Activo = true;
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
        public int Cantidad
        {
            get { return cant; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "La cantidad no puede ser menor o igual a cero.");
                }
                cant = value;
            }
        }

        public TipoMenu TipoDeMenu
        {
            get { return menu; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(nameof(value), "El tipo de menú no puede ser nulo.");
                }
                menu = value;
                precioUnitarioBaseAdulto = value.ValorTipoMenu;
            }
        }

        public bool IsAdulto
        {
            get { return isAdulto; }
            set { isAdulto = value; }
        }

        public decimal PrecioUnitarioBaseAdulto
        {
            get { return precioUnitarioBaseAdulto; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "El precio unitario base no puede ser menor a cero.");
                }
                precioUnitarioBaseAdulto = value;
            }
        }

        public float DescuentoNino
        {
            get { return descuentoInfantil; }
            set
            {
                if (value < 0 || value > 1)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "El descuento infantil debe ser un valor entre 0 y 1 (ej: 0.15 para 15%).");
                }
                descuentoInfantil = value;
            }
        }
    }
}
