using EventoPresupuestado.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventoPresupuestado.Componentes
{
    public partial class ServicioItemControl : UserControl
    {
        public ServicioAdicionalDto ServicioData => (ServicioAdicionalDto)Tag;

        private bool _seleccionada;

        public bool Seleccionada
        {
            get => _seleccionada;
            set
            {
                _seleccionada = value;
                AplicarEstiloSeleccion();
            }
        }

        public ServicioItemControl()
        {
            InitializeComponent();

            RedondeoPanelPersonalizados();
            AsignarEventosClick(pnlContainerAll);

        }

        public void CargarDatos(ServicioAdicionalDto servicioDto)
        {
            Tag = servicioDto ?? throw new ArgumentNullException(nameof(servicioDto));

            lblIdServicio.Text = $"#{ServicioData.Id:D2}";
            lblNombreServicio.Text = ServicioData.nombreServicio;
            lblValorServicio.Text = $"$ {ServicioData.valorServicio:N0}";

            AplicarEstiloSeleccion();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            RedondeoPanelPersonalizados();
        }

        private void RedondeoPanelPersonalizados()
        {
            if (this.Width <= 0 || this.Height <= 0) return;

            RedondearControl(this, 10);

            if (pnlBadgeId != null && pnlBadgeId.Width > 0 && pnlBadgeId.Height > 0)
            {
                RedondearControl(pnlBadgeId, 10);
            }
        }

        private void RedondearControl(Control control, int radio)
        {
            if (control.Width <= 0 || control.Height <= 0) return;

            using (GraphicsPath path = new GraphicsPath())
            {
                path.StartFigure();
                path.AddArc(new Rectangle(0, 0, radio, radio), 180, 90);
                path.AddArc(new Rectangle(control.Width - radio, 0, radio, radio), 270, 90);
                path.AddArc(new Rectangle(control.Width - radio, control.Height - radio, radio, radio), 0, 90);
                path.AddArc(new Rectangle(0, control.Height - radio, radio, radio), 90, 90);
                path.CloseFigure();

                control.Region = new Region(path);
            }
        }

        private void AplicarEstiloSeleccion()
        {
            if (_seleccionada)
            {
                Color azulSeleccion = Color.FromArgb(240, 246, 255);
                pnlContainerAll.BackColor = azulSeleccion;
                EstablecerFondoTransparenteLabels(azulSeleccion);

                pnlContainerAll.BorderStyle = BorderStyle.FixedSingle;
                Padding = new Padding(1);
                BackColor = Color.FromArgb(37, 99, 235);
            }
            else
            {
                pnlContainerAll.BorderStyle = BorderStyle.None;
                Padding = new Padding(0);
                BackColor = Color.Transparent;

                if (ServicioData != null && !ServicioData.Activo)
                {
                    Color rojoPastel = Color.FromArgb(253, 237, 237);
                    pnlContainerAll.BackColor = rojoPastel;
                    EstablecerFondoTransparenteLabels(rojoPastel);
                }
                else
                {
                    pnlContainerAll.BackColor = Color.White;
                    EstablecerFondoTransparenteLabels(Color.White);
                }
            }
        }

        private void EstablecerFondoTransparenteLabels(Color colorFondo)
        {
            if (lblNombreServicio != null) lblNombreServicio.BackColor = colorFondo;
            if (lblValorServicio != null) lblValorServicio.BackColor = colorFondo;
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
        }

        private void AsignarEventosClick(Control controlPadre)
        {
            controlPadre.Click += (s, e) => OnClick(e);

            foreach (Control hijo in controlPadre.Controls)
            {
                hijo.Click += (s, e) => OnClick(e);
                if (hijo.HasChildren)
                {
                    AsignarEventosClick(hijo);
                }
            }
        }

    }
}
