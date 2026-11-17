using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventoPresupuestado.Model;

namespace EventoPresupuestado.Model
{
    public class Presupuesto : ModelBase
    {
        private List<ServicioAdicional> listAdicional;
        private List<ItemMenu> listMenu;
        private DateTime fechaEvento;
        private Lugar lugarEvento;
        private int duracionEvento;

        // CONSTRUCTORES
        public Presupuesto()
        {
            listAdicional = new List<ServicioAdicional>();
            listMenu = new List<ItemMenu>();
            fechaEvento = DateTime.Now;
            duracionEvento = 1;
            Activo = true;
        }

        public Presupuesto(DateTime fechaEvento, int duracionEvento, Lugar lugarEvento, List<ServicioAdicional> listAdicional, List<ItemMenu> listMenu)
        {
            FechaEvento = fechaEvento;
            DuracionEvento = duracionEvento;
            LugarEvento = lugarEvento;
            ListAdicional = listAdicional;
            ListMenu = listMenu;
            Activo = true;
        }

        public Presupuesto(int idPresupuesto, DateTime fechaEvento, int duracionEvento, Lugar lugarEvento, List<ServicioAdicional> listAdicional, List<ItemMenu> listMenu)
        {
            Id = idPresupuesto;
            FechaEvento = fechaEvento;
            DuracionEvento = duracionEvento;
            LugarEvento = lugarEvento;
            ListAdicional = listAdicional;
            ListMenu = listMenu;
            Activo = true;
        }

        // METODOS
        public void AgregarServicioAdicional(ServicioAdicional servicio)
        {
            if (servicio == null)
            {
                throw new ArgumentNullException(nameof(servicio), "El servicio adicional no puede ser nulo.");
            }
            ListAdicional.Add(servicio);
        }

        public void QuitarServicioAdicional(ServicioAdicional servicio)
        {
            if (servicio != null)
            {
                ListAdicional.Remove(servicio);
            }
        }

        public void AgregarItemMenu(ItemMenu item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item), "El ítem de menú no puede ser nulo.");
            }
            ListMenu.Add(item);
        }

        public int CalcularCantidadAdultos()
        {
            int totalAdultos = 0;

            foreach (ItemMenu item in ListMenu)
            {
                if (item.IsAdulto)
                {
                    totalAdultos += item.Cantidad;
                }
            }

            return totalAdultos;
        }

        public int CalcularCantidadNinios()
        {
            int totalNinios = 0;

            foreach (ItemMenu item in ListMenu)
            {
                if (!item.IsAdulto)
                {
                    totalNinios += item.Cantidad;
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
            decimal totalMenus = 0;
            foreach (ItemMenu item in ListMenu)
            {
                totalMenus += item.CalcularSubtotal();
            }

            decimal totalServicios = 0;
            foreach (ServicioAdicional servicio in ListAdicional)
            {
                totalServicios += servicio.ValorServicio;
            }

            decimal totalLugar = 0;
            if (LugarEvento != null)
            {
                totalLugar = LugarEvento.PrecioBase;
            }

            return totalMenus + totalServicios + totalLugar;
        }

        // PROPIEDADES
        public DateTime FechaEvento
        {
            get { return fechaEvento; }
            set
            {
                if (value < DateTime.Now.Date)
                {
                    throw new ArgumentException("La fecha del evento no puede ser anterior a la fecha actual.", nameof(value));
                }
                fechaEvento = value;
            }
        }

        public int DuracionEvento
        {
            get { return duracionEvento; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "La duración del evento debe ser mayor a cero horas.");
                }
                duracionEvento = value;
            }
        }

        public Lugar LugarEvento
        {
            get { return lugarEvento; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(nameof(value), "El lugar asignado no puede estar vacio.");
                }

                int cantidadInvitadosActuales = CalcularInvitados();
                if (cantidadInvitadosActuales > value.CantMaxPersonas)
                {
                    throw new InvalidOperationException($"El lugar '{value.DescripcionLugar}' solo permite hasta {value.CantMaxPersonas} personas, pero el presupuesto actual cuenta con {cantidadInvitadosActuales} invitados.");
                }

                lugarEvento = value;
            }
        }

        public List<ServicioAdicional> ListAdicional
        {
            get { return listAdicional; }
            set
            {
                if (value == null)
                {
                    listAdicional = new List<ServicioAdicional>();
                }
                else
                {
                    listAdicional = value;
                }
            }
        }

        public List<ItemMenu> ListMenu
        {
            get { return listMenu; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(nameof(value), "La lista de ítems de menú no puede estar vacia.");
                }
                listMenu = value;
            }
        }
    }
}
