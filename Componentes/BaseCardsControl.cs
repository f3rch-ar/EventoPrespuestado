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
    public partial class BaseCardsControl : UserControl
    {
        protected int RadioRedondeo { get; set; } = 12;

        private bool _seleccionada;
        public bool Seleccionada
        {
            get => _seleccionada;
            set
            {
                _seleccionada = value;
                AplicarEstiloGlobal();
            }
        }

        public BaseCardsControl()
        {
            // Activar doble búfer nativo para evitar parpadeos
            BufferFPSMax();

            this.Resize += (s, e) => RedondearControl(this, RadioRedondeo);
        }

        private void BufferFPSMax()
        {
            this.SetStyle(ControlStyles.UserPaint |
                           ControlStyles.AllPaintingInWmPaint |
                           ControlStyles.OptimizedDoubleBuffer |
                           ControlStyles.ResizeRedraw, true);
        }

        protected void RedondearControl(Control control, int radio)
        {
            if (control == null || control.Width <= 0 || control.Height <= 0) return;

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

        /// <summary>
        /// Método global unificado: Lee automáticamente el 'Tag' como BaseDto para saber si está activo,
        /// y gestiona de forma centralizada los colores de selección, inactividad (rojo pastel) y blanco.
        /// Busca un panel contenedor estándar llamado "pnlContainerAll" o "pnlContainerItem".
        /// </summary>
        public void AplicarEstiloGlobal()
        {
            Control contenedor = this.Controls["pnlContainerAll"];// ?? this.Controls["pnlContainerItem"];

            // Extraemos el estado 'Activo' directamente desde el BaseDto asignado en el Tag
            bool esActivo = true;
            if (this.Tag is BaseDto dto)
            {
                esActivo = dto.Activo;
            }

            if (_seleccionada)
            {
                // Estilo cuando está seleccionada (Borde azul claro y fondo interior azul tenue)
                this.BackColor = Color.FromArgb(37, 99, 235); // O tu azul de selección
                this.Padding = new Padding(1);

                if (contenedor != null)
                {
                    Color azulTenue = Color.FromArgb(240, 246, 255);
                    contenedor.BackColor = azulTenue;
                    if (contenedor is Panel p) p.BorderStyle = BorderStyle.FixedSingle;
                    EstablecerFondoLabels(contenedor, azulTenue);
                }
            }
            else
            {
                this.Padding = new Padding(0);
                this.BackColor = Color.Transparent;

                if (contenedor != null)
                {
                    if (contenedor is Panel p) p.BorderStyle = BorderStyle.None;

                    // Validación global de inactividad usando el BaseDto
                    if (!esActivo)
                    {
                        Color rojoPastel = Color.FromArgb(253, 237, 237);
                        contenedor.BackColor = rojoPastel;
                        EstablecerFondoLabels(contenedor, rojoPastel);
                    }
                    else
                    {
                        Color blanco = Color.White;
                        contenedor.BackColor = blanco;
                        EstablecerFondoLabels(contenedor, blanco);
                    }
                }
            }

            this.Invalidate();
        }

        private void EstablecerFondoLabels(Control parent, Color colorFondo)
        {
            foreach (Control hijo in parent.Controls)
            {
                if (hijo is Label lbl)
                {
                    lbl.BackColor = colorFondo;
                }
                if (hijo.HasChildren)
                {
                    EstablecerFondoLabels(hijo, colorFondo);
                }
            }
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
        }

        protected void AsignarEventosClick(Control controlPadre)
        {
            if (controlPadre == null) return;
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
