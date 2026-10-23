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

namespace EventoPresupuestado
{
    public partial class LineShadow : UserControl
    {
        // Enumeración personalizada para las 4 direcciones de la sombra
        public enum DireccionSombra
        {
            Abajo,    // Sombra superior que cae hacia abajo
            Arriba,   // Sombra inferior que sube hacia arriba
            Derecha,  // Sombra lateral izquierda que se proyecta a la derecha
            Izquierda // Sombra lateral derecha que se proyecta a la izquierda
        }

        private Color _colorSombra = Color.FromArgb(40, 0, 0, 0);
        private DireccionSombra _orientacion = DireccionSombra.Abajo;

        [Category("Apariencia Sombra")]
        [Description("Color inicial de la sombra. Usa el canal Alpha para un difuminado realista.")]
        public Color ColorSombra
        {
            get => _colorSombra;
            set { _colorSombra = value; this.Invalidate(); }
        }

        [Category("Apariencia Sombra")]
        [Description("Dirección hacia la que se proyecta y difumina la sombra.")]
        public DireccionSombra Orientacion
        {
            get => _orientacion;
            set
            {
                _orientacion = value;
                AjustarDimensionesPorDefecto();
                this.Invalidate();
            }
        }

        public LineShadow()
        {
            InitializeComponent();

            this.SetStyle(ControlStyles.UserPaint |
                           ControlStyles.AllPaintingInWmPaint |
                           ControlStyles.OptimizedDoubleBuffer |
                           ControlStyles.ResizeRedraw |
                           ControlStyles.SupportsTransparentBackColor, true);

            this.BackColor = Color.Transparent;
            this.Height = 8; // Altura inicial por defecto (Abajo)
        }

        // Automatiza el tamaño inicial estimado según la orientación elegida
        private void AjustarDimensionesPorDefecto()
        {
            // Solo ajusta el tamaño si estás arrastrándolo de cero o cambiándolo en el diseñador
            if (_orientacion == DireccionSombra.Abajo || _orientacion == DireccionSombra.Arriba)
            {
                if (this.Height > this.Width || this.Height == 150) // 150 es el alto por defecto de VS
                    this.Height = 8;
            }
            else // Derecha o Izquierda
            {
                if (this.Width > this.Height || this.Width == 150) // 150 es el ancho por defecto de VS
                    this.Width = 8;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (this.ClientRectangle.Width <= 0 || this.ClientRectangle.Height <= 0)
                return;

            Color colorInicio = _colorSombra;
            Color colorFin = Color.Transparent;
            LinearGradientMode modoGradiente = LinearGradientMode.Vertical;

            // Lógica matemática para invertir los vectores del degradado según la orientación
            switch (_orientacion)
            {
                case DireccionSombra.Abajo:
                    colorInicio = _colorSombra;
                    colorFin = Color.Transparent;
                    modoGradiente = LinearGradientMode.Vertical;
                    break;

                case DireccionSombra.Arriba:
                    colorInicio = Color.Transparent;
                    colorFin = _colorSombra;
                    modoGradiente = LinearGradientMode.Vertical;
                    break;

                case DireccionSombra.Derecha:
                    colorInicio = _colorSombra;
                    colorFin = Color.Transparent;
                    modoGradiente = LinearGradientMode.Horizontal;
                    break;

                case DireccionSombra.Izquierda:
                    colorInicio = Color.Transparent;
                    colorFin = _colorSombra;
                    modoGradiente = LinearGradientMode.Horizontal;
                    break;
            }

            // Renderizado del degradado procesado
            using (LinearGradientBrush brush = new LinearGradientBrush(
                this.ClientRectangle,
                colorInicio,
                colorFin,
                modoGradiente))
            {
                e.Graphics.CompositingQuality = CompositingQuality.HighQuality;
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }
    }
}
