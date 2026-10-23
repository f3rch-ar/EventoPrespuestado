/*using EventoPresupuestado.Dto;
using EventoPresupuestado.Controller;*/
using EventoPresupuestado.Model;
using EventoPresupuestado.View;
//using System.Windows.Forms;

namespace EventoPresupuestado
{
    public partial class AppMain : Form
    {


        // menu side Colapsado estilo Burger
        private bool menuColapsado = false;
        private System.Windows.Forms.Timer timerMenuLateral;
        private int anchoDestinoMenu = 0;

        private const int ANCHO_MAX_MENU = 200;
        private const int ANCHO_MIN_MENU = 36;
        private const int VELOCIDAD_MENU = 25;

        //Boton border menu
        private Button btnActive = null;
        private Panel bordeLeftBlue;
        private System.Windows.Forms.Timer timerTransitionBorder;
        private int posicionDestinoY = 0;
        private const int VELOCIDAD_PASOS = 8;


        public AppMain()
        {
            InitializeComponent();
            configVisualPersonalizado();

        }

        //Cofig Visual Personalizado
        private void configVisualPersonalizado()
        {
            configVisualComponents();

            configBorderLeft();
            configTimerBordeTansition();

            configTimerMenuColapsado();
            panelSideMenu.Width = ANCHO_MAX_MENU;

            configBotonesMenu(btnInicio, btnPresupuesto, btnTipoMenu, btnComida, btnLugar, btnServAdicional, btnConfig);
            btnActive = btnInicio;
            openViewHijo(new ViewHome());
            bordeLeftBlue.Top = btnInicio.Top;
        }

        //Config Timer Menu burger Colapsado
        private void configTimerMenuColapsado()
        {
            timerMenuLateral = new System.Windows.Forms.Timer();
            timerMenuLateral.Interval = 10;
            timerMenuLateral.Tick += timerMenuLateral_Tick;
        }

        private void timerMenuLateral_Tick(object sender, EventArgs e)
        {
            if (menuColapsado)
            {
                if (panelSideMenu.Width > anchoDestinoMenu)
                {
                    panelSideMenu.Width -= VELOCIDAD_MENU;
                }
                else
                {
                    panelSideMenu.Width = anchoDestinoMenu;
                    timerMenuLateral.Stop();
                }
            }
            else
            {
                if (panelSideMenu.Width < anchoDestinoMenu)
                {
                    panelSideMenu.Width += VELOCIDAD_MENU;
                }
                else
                {
                    panelSideMenu.Width = anchoDestinoMenu;
                    timerMenuLateral.Stop();

                    btnInicio.Text = "Inicio";
                    btnPresupuesto.Text = "Presupuesto";
                    btnTipoMenu.Text = "TipoMenu";
                    btnComida.Text = "Comida";
                    btnLugar.Text = "Lugar";
                    btnServAdicional.Text = "Otro Servicio";
                    btnConfig.Text = "Configuracion";
                }
            }
        }

        //Config Border and Timer

        private void configBorderLeft()
        {
            bordeLeftBlue = new Panel();
            bordeLeftBlue.BackColor = Color.FromArgb(59, 130, 238); // Tu color azul
            bordeLeftBlue.Width = 5; // Ancho de la línea izquierda
            bordeLeftBlue.Height = btnInicio.Height;
            bordeLeftBlue.Left = 0;
            panelSideMenu.Controls.Add(bordeLeftBlue);
            bordeLeftBlue.BringToFront();
        }

        private void configTimerBordeTansition()
        {
            timerTransitionBorder = new System.Windows.Forms.Timer();
            timerTransitionBorder.Interval = 15; // Frecuencia de actualización (60 FPS aprox)
            timerTransitionBorder.Tick += timerTransitionBorder_Tick;
        }

        private void timerTransitionBorder_Tick(object sender, EventArgs e)
        {
            int distancia = posicionDestinoY - bordeLeftBlue.Top;

            if (Math.Abs(distancia) <= VELOCIDAD_PASOS)
            {
                bordeLeftBlue.Top = posicionDestinoY;
                timerTransitionBorder.Stop();
            }
            else
            {
                int avance = distancia / 4;
                if (avance == 0) avance = (distancia > 0) ? 1 : -1;
                bordeLeftBlue.Top += avance;
            }
        }

        //Config botones
        private void configBotonesMenu(params Button[] botones)
        {
            foreach (var btn in botones)
            {
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;

                btn.ImageAlign = ContentAlignment.MiddleLeft;
                btn.TextAlign = ContentAlignment.MiddleCenter;
                btn.TextImageRelation = TextImageRelation.ImageBeforeText;

                btn.Click += BotonMenu_Click;
            }
        }


        private void BotonMenu_Click(object sender, EventArgs e)
        {
            btnActive = (Button)sender;
            posicionDestinoY = btnActive.Top;
            timerTransitionBorder.Start();
        }

        //Line Separator menu - fill
        private void configVisualComponents()
        {
            panelLineSeparator.BackColor = Color.FromArgb(153, 220, 220, 220);
            panelLineSeparator.BringToFront();
        }


        private void btnMenuBurger_Click(object sender, EventArgs e)
        {
            menuColapsado = !menuColapsado;
            anchoDestinoMenu = menuColapsado ? ANCHO_MIN_MENU : ANCHO_MAX_MENU;

            if (menuColapsado)
            {
                btnInicio.Text = "";
                btnPresupuesto.Text = "";
                btnTipoMenu.Text = "";
                btnComida.Text = "";
                btnLugar.Text = "";
                btnServAdicional.Text = "";
                btnConfig.Text = "";
            }
            timerMenuLateral.Start();
        }


        //Formularios y Botones para abrir ellos
        private void openViewHijo(Form formHijo)
        {
            if (panelMainView.Controls.Count > 0)
            {
                Form formAnterior = (Form)panelMainView.Controls[0];
                if (formAnterior != null)
                {
                    formAnterior.Close();
                    formAnterior.Dispose();
                }
                panelMainView.Controls.Clear();
            }

            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            formHijo.Size = panelMainView.ClientSize;
            formHijo.Dock = DockStyle.Fill;

            panelMainView.Controls.Add(formHijo);
            panelMainView.Tag = formHijo;

            formHijo.Show();
        }


        private void btnPresupuesto_Click(object sender, EventArgs e)
        {
            
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            openViewHijo(new ViewHome());
        }

        private void btnTipoMenu_Click(object sender, EventArgs e)
        {
            //openViewHijo(new ViewTipoMenu());
        }

        private void btnComida_Click(object sender, EventArgs e)
        {
            openViewHijo(new ViewComida());
        }

        private void btnLugar_Click(object sender, EventArgs e)
        {
            openViewHijo(new ViewLugar());
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            openViewHijo(new ViewConfig());
        }
    }
}
