using EventoPresupuestado.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventoPresupuestado.Componentes
{
    public partial class TipoMenuCardControl : BaseCardsControl
    {
        public TipoMenuDto MenuData => (TipoMenuDto)Tag;

        public TipoMenuCardControl()
        {
            InitializeComponent();

            RadioRedondeo = 12;

            AsignarEventosClick(pnlContainerAll);
        }

        public void CargarDatos(TipoMenuDto menuDto)
        {
            Tag = menuDto ?? throw new ArgumentNullException(nameof(menuDto));

            if (lblId != null)
            {
                lblId.Text = $"#{MenuData.Id:D2}";
            }

            if (lblMenuNombre != null)
            {
                lblMenuNombre.Text = MenuData.NombreMenu;
            }

            //if (lblIconEntrada != null) lblIconEntrada.Text = "🥗";
            if (lblEntrada != null)
                lblEntrada.Text = MenuData.ListaComidas.Count > 0 ? MenuData.ListaComidas[0].descripcionComida : "—";

            //if (lblIconPlatoMain != null) lblIconPlatoMain.Text = "🍝";
            if (lblPlatoPrincipal != null)
                lblPlatoPrincipal.Text = MenuData.ListaComidas.Count > 1 ? MenuData.ListaComidas[1].descripcionComida : "—";

            //if (lblIconPostre != null) lblIconPostre.Text = "🍰";
            if (lblPostre != null)
                lblPostre.Text = MenuData.ListaComidas.Count > 2 ? MenuData.ListaComidas[2].descripcionComida : "—";

            //if (lblIconBebida != null) lblIconBebida.Text = "🥤";
            if (lblBebida != null)
                lblBebida.Text = MenuData.ListaComidas.Count > 3 ? MenuData.ListaComidas[3].descripcionComida : "—";

            if (lblPrecioMenu != null)
            {
                decimal totalCard = MenuData.ValorTipoMenu > 0
                    ? MenuData.ValorTipoMenu
                    : MenuData.ListaComidas.Sum(c => c.valorComida);

                lblPrecioMenu.Text = $"$ {totalCard:N0}";
            }

            AplicarEstiloGlobal();
        }
    }
}
