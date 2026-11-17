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
    public partial class PanelTotalRounded : UserControl
    {
        private int _radioRedondeo = 12;
        

        private string _titulo = "VALOR TOTAL CALCULADO";
        

        private decimal _montoTotal = 0;

        public PanelTotalRounded()
        {
            InitializeComponent();

            this.SetStyle(ControlStyles.UserPaint |
                           ControlStyles.AllPaintingInWmPaint |
                           ControlStyles.OptimizedDoubleBuffer |
                           ControlStyles.ResizeRedraw, true);

            this.Resize += (s, e) => RedondearControl(this, _radioRedondeo);
        }

        public void ActualizarTotal(decimal nuevoMonto)
        {
            _montoTotal = nuevoMonto;

            if (lblMonto != null)
            {
                lblMonto.Text = $"$ {_montoTotal:N0}";
            }
        }

        private void RedondearControl(Control control, int radio)
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

        public int RadioRedondeo
        {
            get => _radioRedondeo;
            set
            {
                _radioRedondeo = value;
                RedondearControl(this, _radioRedondeo);
                Invalidate();
            }
        }

        public string Titulo
        {
            get => _titulo;
            set
            {
                _titulo = value;
                if (lblTitulo != null) lblTitulo.Text = _titulo;
            }
        }
    }
}
