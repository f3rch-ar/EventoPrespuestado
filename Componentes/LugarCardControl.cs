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
    public partial class LugarCardControl : UserControl
    {
        public LugarDto LugarData => (LugarDto)Tag;

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

        public LugarCardControl()
        {
            InitializeComponent();
            AsignarEventosClick(pnlContainerAll);
        }

        public void CargarDatos(LugarDto lugarDto)
        {
            Tag = lugarDto ?? throw new ArgumentNullException(nameof(lugarDto));

            lblId.Text = $"ID: #{LugarData.idLugar}";
            lblNombre.Text = LugarData.nombreLugar;
            lblDescription.Text = LugarData.descripcionLugar;

            // OPCIÓN A: Con Emojis Unicode directamente en el texto
            lblCapacidadMax.Text = $"👥 Max. {LugarData.cantMaxPersonas} personas";
            lblPrecioBase.Text = $"💵 $ {LugarData.precioBase:N0} / evento";

            // OPCIÓN B: Con Iconos PNG desde Resources
            /*
            lblCapacidadMax.Image = Properties.Resources.icon_people;
            lblCapacidadMax.ImageAlign = ContentAlignment.MiddleLeft;
            lblCapacidadMax.Text = $"    Max. {LugarData.cantMaxPersonas} personas";

            lblPrecioBase.Image = Properties.Resources.icon_money;
            lblPrecioBase.ImageAlign = ContentAlignment.MiddleLeft;
            lblPrecioBase.Text = $"    $ {LugarData.precioBase:N0} / evento";
            */

            CargarImagen(LugarData.rutaImagen);
            ConfigurarBadgeEstado();
            AplicarEstiloSeleccion();
        }

        private void CargarImagen(string? ruta)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(ruta) && File.Exists(ruta))
                {
                    using (var stream = new FileStream(ruta, FileMode.Open, FileAccess.Read))
                    {
                        picImageLugar.Image = Image.FromStream(stream);
                    }
                }
                else
                {
                    picImageLugar.Image = Restaurante_Menus.Properties.Resources.default_salon;
                }
            }
            catch
            {
                picImageLugar.Image = Restaurante_Menus.Properties.Resources.default_salon;
            }
        }

        private void ConfigurarBadgeEstado()
        {
            if (!LugarData.activo)
            {
                lblBadgeState.Text = "INACTIVO";
                lblBadgeState.BackColor = Color.FromArgb(241, 245, 249);
                lblBadgeState.ForeColor = Color.FromArgb(100, 116, 139);
            }
            else if (LugarData.ocupado)
            {
                lblBadgeState.Text = "NO DISPONIBLE";
                lblBadgeState.BackColor = Color.FromArgb(254, 226, 226);
                lblBadgeState.ForeColor = Color.FromArgb(185, 28, 28);
            }
            else
            {
                lblBadgeState.Text = "DISPONIBLE";
                lblBadgeState.BackColor = Color.FromArgb(220, 252, 231);
                lblBadgeState.ForeColor = Color.FromArgb(21, 128, 61);
            }
        }

        private void AplicarEstiloSeleccion()
        {
            if (_seleccionada)
            {
                pnlContainerAll.BackColor = Color.FromArgb(240, 246, 255);
                pnlContainerAll.BorderStyle = BorderStyle.FixedSingle;
                Padding = new Padding(1);
                BackColor = Color.FromArgb(37, 99, 235); // Borde azul activo
            }
            else
            {
                pnlContainerAll.BackColor = LugarData != null && !LugarData.activo
                    ? Color.FromArgb(248, 250, 252) // 253, 237, 237
                    : Color.White;

                pnlContainerAll.BorderStyle = BorderStyle.None;
                Padding = new Padding(0);
                BackColor = Color.Transparent;
            }
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

