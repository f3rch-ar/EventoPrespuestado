using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventoPresupuestado.Model;

namespace EventoPresupuestado.Model
{
    public class Presupuesto
    {
        private int idPresupuesto;
        private List<ServicioAdicional> listAdicional;
        private List<ItemMenu> listMenu;
        private DateTime fechaEvento;
        private Lugar lugarEvento;
        private int duracionEvento;

// CONSTRUCTORES

        public Presupuesto() { }

// METODOS

        public void AgregarServicioAdicional(ServicioAdicional servicio)
        {
            ListAdicional.Add(servicio);
        }

        public void QuitarServicioAdicional(ServicioAdicional servicio)
        {
            ListAdicional.Remove(servicio);
        }

        public int CalcularCantidadAdultos()
        {
            int totalAdultos = 0;

            foreach (ItemMenu item in ListMenu)
            {
                if (item.IsAdulto == true)
                {
                    totalAdultos = totalAdultos + item.Cantidad;
                }
            }

            return totalAdultos;
        }

        public int CalcularCantidadNinios()
        {
            int totalNinios = 0;

            foreach (ItemMenu item in ListMenu)
            {
                if (item.IsAdulto == false)
                {
                    totalNinios = totalNinios + item.Cantidad;
                }
            }

            return totalNinios;
        }

        public int CalcularInvitados()
        {
            return CalcularCantidadAdultos() + CalcularCantidadNinios();
        }

        public decimal CalcularTotal()
        {
            // Calcula el total de los menus
            decimal totalMenus = 0;
            foreach (ItemMenu item in ListMenu)
            {
                totalMenus = totalMenus + item.CalcularSubtotal();
            }

            // Calcula el total de los servicios adicionales
            decimal totalServicios = 0;
            foreach (ServicioAdicional servicio in ListAdicional)
            {
                totalServicios = totalServicios + servicio.ValorServicio;
            }

            // Calcula el costo del lugar verificando si existe
            decimal totalLugar = 0;
            if (LugarEvento != null)
            {
                totalLugar = LugarEvento.PrecioBase;
            }
            else
            {
                totalLugar = 0;
            }

            return totalMenus + totalServicios + totalLugar;
        }


// PROPIEDADES

        public List<ServicioAdicional> ListAdicional
        {
            get
            {
                return listAdicional;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(nameof(value), "La lista de servicios adicionales no puede ser nula.");
                }

                listAdicional = value;
            }
        }

        public List<ItemMenu> ListMenu
        {
            get
            {
                return listMenu;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(nameof(value), "La lista de ítems de menú no puede ser nula.");
                }
                listMenu = value;
            }
        }

        public Lugar LugarEvento
        {
            get
            {
                return lugarEvento;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("El lugar asignado no puede ser nulo.");
                }

                // Valida la capacidad maxima si ya hay invitados cargados en el presupuesto
                int cantidadInvitadosActuales = CalcularInvitados();
                if (cantidadInvitadosActuales > value.CantMaxPersonas)
                {
                    throw new InvalidOperationException($"El lugar '{value.DescripcionLugar}' solo permite hasta {value.CantMaxPersonas} personas, pero el presupuesto actual tiene {cantidadInvitadosActuales} invitados.");
                }

                lugarEvento = value;
            }
        }
    }
}
