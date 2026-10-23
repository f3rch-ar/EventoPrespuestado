namespace EventoPresupuestado
{
    partial class AppMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelSuperior = new Panel();
            panelSuperiorSideRight = new Panel();
            panelSuperiorFillMidSearch = new Panel();
            txtBoxSearch = new TextBox();
            panelSuperiorSideMenuBurger = new Panel();
            lblWelcome = new Label();
            btnMenuBurger = new Button();
            panelMain = new Panel();
            panelMainView = new Panel();
            panelLineSeparator = new Panel();
            panelSideMenu = new Panel();
            btnServAdicional = new Button();
            btnLugar = new Button();
            btnComida = new Button();
            btnTipoMenu = new Button();
            btnPresupuesto = new Button();
            btnInicio = new Button();
            lineShadowSup = new LineShadow();
            btnConfig = new Button();
            panelSuperior.SuspendLayout();
            panelSuperiorFillMidSearch.SuspendLayout();
            panelSuperiorSideMenuBurger.SuspendLayout();
            panelMain.SuspendLayout();
            panelSideMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panelSuperior
            // 
            panelSuperior.BackColor = Color.White;
            panelSuperior.Controls.Add(panelSuperiorSideRight);
            panelSuperior.Controls.Add(panelSuperiorFillMidSearch);
            panelSuperior.Controls.Add(panelSuperiorSideMenuBurger);
            panelSuperior.Dock = DockStyle.Top;
            panelSuperior.Location = new Point(0, 0);
            panelSuperior.Name = "panelSuperior";
            panelSuperior.Size = new Size(1209, 35);
            panelSuperior.TabIndex = 7;
            // 
            // panelSuperiorSideRight
            // 
            panelSuperiorSideRight.Dock = DockStyle.Right;
            panelSuperiorSideRight.Location = new Point(1009, 0);
            panelSuperiorSideRight.Name = "panelSuperiorSideRight";
            panelSuperiorSideRight.Size = new Size(200, 35);
            panelSuperiorSideRight.TabIndex = 2;
            // 
            // panelSuperiorFillMidSearch
            // 
            panelSuperiorFillMidSearch.Controls.Add(txtBoxSearch);
            panelSuperiorFillMidSearch.Dock = DockStyle.Fill;
            panelSuperiorFillMidSearch.Location = new Point(175, 0);
            panelSuperiorFillMidSearch.Name = "panelSuperiorFillMidSearch";
            panelSuperiorFillMidSearch.Size = new Size(1034, 35);
            panelSuperiorFillMidSearch.TabIndex = 1;
            // 
            // txtBoxSearch
            // 
            txtBoxSearch.Anchor = AnchorStyles.None;
            txtBoxSearch.BackColor = Color.WhiteSmoke;
            txtBoxSearch.BorderStyle = BorderStyle.None;
            txtBoxSearch.Font = new Font("Segoe UI", 10F);
            txtBoxSearch.Location = new Point(186, 8);
            txtBoxSearch.Name = "txtBoxSearch";
            txtBoxSearch.Size = new Size(434, 18);
            txtBoxSearch.TabIndex = 0;
            txtBoxSearch.Text = "Buscar";
            // 
            // panelSuperiorSideMenuBurger
            // 
            panelSuperiorSideMenuBurger.Controls.Add(lblWelcome);
            panelSuperiorSideMenuBurger.Controls.Add(btnMenuBurger);
            panelSuperiorSideMenuBurger.Dock = DockStyle.Left;
            panelSuperiorSideMenuBurger.Location = new Point(0, 0);
            panelSuperiorSideMenuBurger.Name = "panelSuperiorSideMenuBurger";
            panelSuperiorSideMenuBurger.Size = new Size(175, 35);
            panelSuperiorSideMenuBurger.TabIndex = 0;
            // 
            // lblWelcome
            // 
            lblWelcome.Dock = DockStyle.Fill;
            lblWelcome.Font = new Font("Cooper Black", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblWelcome.Location = new Point(36, 0);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.RightToLeft = RightToLeft.No;
            lblWelcome.Size = new Size(139, 35);
            lblWelcome.TabIndex = 10;
            lblWelcome.Text = "AppEvents";
            lblWelcome.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnMenuBurger
            // 
            btnMenuBurger.BackgroundImageLayout = ImageLayout.Center;
            btnMenuBurger.Dock = DockStyle.Left;
            btnMenuBurger.FlatAppearance.BorderSize = 0;
            btnMenuBurger.FlatAppearance.MouseDownBackColor = Color.FromArgb(59, 131, 241);
            btnMenuBurger.FlatStyle = FlatStyle.Flat;
            btnMenuBurger.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnMenuBurger.Image = Restaurante_Menus.Properties.Resources.burger_menu_24px;
            btnMenuBurger.Location = new Point(0, 0);
            btnMenuBurger.Name = "btnMenuBurger";
            btnMenuBurger.Padding = new Padding(3, 0, 0, 3);
            btnMenuBurger.Size = new Size(36, 35);
            btnMenuBurger.TabIndex = 9;
            btnMenuBurger.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMenuBurger.UseVisualStyleBackColor = true;
            btnMenuBurger.Click += btnMenuBurger_Click;
            // 
            // panelMain
            // 
            panelMain.Controls.Add(panelMainView);
            panelMain.Controls.Add(panelLineSeparator);
            panelMain.Controls.Add(panelSideMenu);
            panelMain.Controls.Add(lineShadowSup);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 35);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1209, 455);
            panelMain.TabIndex = 8;
            // 
            // panelMainView
            // 
            panelMainView.Dock = DockStyle.Fill;
            panelMainView.Location = new Point(180, 5);
            panelMainView.Name = "panelMainView";
            panelMainView.Size = new Size(1029, 450);
            panelMainView.TabIndex = 10;
            // 
            // panelLineSeparator
            // 
            panelLineSeparator.BackColor = Color.Gainsboro;
            panelLineSeparator.Dock = DockStyle.Left;
            panelLineSeparator.Location = new Point(175, 5);
            panelLineSeparator.Name = "panelLineSeparator";
            panelLineSeparator.Size = new Size(5, 450);
            panelLineSeparator.TabIndex = 9;
            // 
            // panelSideMenu
            // 
            panelSideMenu.Controls.Add(btnConfig);
            panelSideMenu.Controls.Add(btnServAdicional);
            panelSideMenu.Controls.Add(btnLugar);
            panelSideMenu.Controls.Add(btnComida);
            panelSideMenu.Controls.Add(btnTipoMenu);
            panelSideMenu.Controls.Add(btnPresupuesto);
            panelSideMenu.Controls.Add(btnInicio);
            panelSideMenu.Dock = DockStyle.Left;
            panelSideMenu.Location = new Point(0, 5);
            panelSideMenu.Name = "panelSideMenu";
            panelSideMenu.RightToLeft = RightToLeft.Yes;
            panelSideMenu.Size = new Size(175, 450);
            panelSideMenu.TabIndex = 8;
            // 
            // btnServAdicional
            // 
            btnServAdicional.BackgroundImageLayout = ImageLayout.None;
            btnServAdicional.Dock = DockStyle.Top;
            btnServAdicional.FlatAppearance.BorderSize = 0;
            btnServAdicional.FlatAppearance.MouseDownBackColor = Color.FromArgb(59, 131, 241);
            btnServAdicional.FlatStyle = FlatStyle.Flat;
            btnServAdicional.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnServAdicional.ForeColor = SystemColors.ControlText;
            btnServAdicional.Image = Restaurante_Menus.Properties.Resources.servicio_adicional_24px;
            btnServAdicional.Location = new Point(0, 150);
            btnServAdicional.Name = "btnServAdicional";
            btnServAdicional.Padding = new Padding(5, 0, 0, 0);
            btnServAdicional.Size = new Size(175, 30);
            btnServAdicional.TabIndex = 12;
            btnServAdicional.Text = "Otro Servicio";
            btnServAdicional.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnServAdicional.UseVisualStyleBackColor = true;
            // 
            // btnLugar
            // 
            btnLugar.BackgroundImageLayout = ImageLayout.None;
            btnLugar.Dock = DockStyle.Top;
            btnLugar.FlatAppearance.BorderSize = 0;
            btnLugar.FlatAppearance.MouseDownBackColor = Color.FromArgb(59, 131, 241);
            btnLugar.FlatStyle = FlatStyle.Flat;
            btnLugar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnLugar.ForeColor = SystemColors.ControlText;
            btnLugar.Image = Restaurante_Menus.Properties.Resources.lugar_alfiler_24px;
            btnLugar.Location = new Point(0, 120);
            btnLugar.Name = "btnLugar";
            btnLugar.Padding = new Padding(5, 0, 0, 0);
            btnLugar.Size = new Size(175, 30);
            btnLugar.TabIndex = 11;
            btnLugar.Text = "Lugar";
            btnLugar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLugar.UseVisualStyleBackColor = true;
            btnLugar.Click += btnLugar_Click;
            // 
            // btnComida
            // 
            btnComida.BackgroundImageLayout = ImageLayout.None;
            btnComida.Dock = DockStyle.Top;
            btnComida.FlatAppearance.BorderSize = 0;
            btnComida.FlatAppearance.MouseDownBackColor = Color.FromArgb(59, 131, 241);
            btnComida.FlatStyle = FlatStyle.Flat;
            btnComida.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnComida.ForeColor = SystemColors.ControlText;
            btnComida.Image = Restaurante_Menus.Properties.Resources.comida_almuerzo__24pxpng;
            btnComida.Location = new Point(0, 90);
            btnComida.Name = "btnComida";
            btnComida.Padding = new Padding(5, 0, 0, 0);
            btnComida.Size = new Size(175, 30);
            btnComida.TabIndex = 10;
            btnComida.Text = "Comida";
            btnComida.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnComida.UseVisualStyleBackColor = true;
            btnComida.Click += btnComida_Click;
            // 
            // btnTipoMenu
            // 
            btnTipoMenu.BackgroundImageLayout = ImageLayout.None;
            btnTipoMenu.Dock = DockStyle.Top;
            btnTipoMenu.FlatAppearance.BorderSize = 0;
            btnTipoMenu.FlatAppearance.MouseDownBackColor = Color.FromArgb(59, 131, 241);
            btnTipoMenu.FlatStyle = FlatStyle.Flat;
            btnTipoMenu.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnTipoMenu.ForeColor = SystemColors.ControlText;
            btnTipoMenu.Image = Restaurante_Menus.Properties.Resources.tipo_menu_24px;
            btnTipoMenu.Location = new Point(0, 60);
            btnTipoMenu.Name = "btnTipoMenu";
            btnTipoMenu.Padding = new Padding(5, 0, 0, 0);
            btnTipoMenu.Size = new Size(175, 30);
            btnTipoMenu.TabIndex = 9;
            btnTipoMenu.Text = "TipoMenu";
            btnTipoMenu.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTipoMenu.UseVisualStyleBackColor = true;
            btnTipoMenu.Click += btnTipoMenu_Click;
            // 
            // btnPresupuesto
            // 
            btnPresupuesto.Dock = DockStyle.Top;
            btnPresupuesto.FlatAppearance.BorderSize = 0;
            btnPresupuesto.FlatAppearance.MouseDownBackColor = Color.FromArgb(59, 131, 241);
            btnPresupuesto.FlatStyle = FlatStyle.Flat;
            btnPresupuesto.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnPresupuesto.ForeColor = SystemColors.ControlText;
            btnPresupuesto.Image = Restaurante_Menus.Properties.Resources.presupuesto_24px;
            btnPresupuesto.Location = new Point(0, 30);
            btnPresupuesto.Name = "btnPresupuesto";
            btnPresupuesto.Padding = new Padding(5, 0, 0, 0);
            btnPresupuesto.Size = new Size(175, 30);
            btnPresupuesto.TabIndex = 8;
            btnPresupuesto.Text = "Presupuesto";
            btnPresupuesto.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPresupuesto.UseVisualStyleBackColor = true;
            btnPresupuesto.Click += btnPresupuesto_Click;
            // 
            // btnInicio
            // 
            btnInicio.BackgroundImageLayout = ImageLayout.None;
            btnInicio.Dock = DockStyle.Top;
            btnInicio.FlatAppearance.BorderSize = 0;
            btnInicio.FlatAppearance.MouseDownBackColor = Color.FromArgb(59, 131, 241);
            btnInicio.FlatStyle = FlatStyle.Flat;
            btnInicio.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnInicio.Image = Restaurante_Menus.Properties.Resources.casa_home_24px;
            btnInicio.Location = new Point(0, 0);
            btnInicio.Name = "btnInicio";
            btnInicio.Padding = new Padding(5, 0, 0, 0);
            btnInicio.RightToLeft = RightToLeft.Yes;
            btnInicio.Size = new Size(175, 30);
            btnInicio.TabIndex = 7;
            btnInicio.Text = "Inicio";
            btnInicio.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnInicio.UseVisualStyleBackColor = true;
            btnInicio.Click += btnInicio_Click;
            // 
            // lineShadowSup
            // 
            lineShadowSup.BackColor = Color.Transparent;
            lineShadowSup.ColorSombra = Color.FromArgb(40, 0, 0, 0);
            lineShadowSup.Dock = DockStyle.Top;
            lineShadowSup.Location = new Point(0, 0);
            lineShadowSup.Margin = new Padding(3, 4, 3, 4);
            lineShadowSup.Name = "lineShadowSup";
            lineShadowSup.Orientacion = LineShadow.DireccionSombra.Abajo;
            lineShadowSup.Size = new Size(1209, 5);
            lineShadowSup.TabIndex = 7;
            // 
            // btnConfig
            // 
            btnConfig.BackgroundImageLayout = ImageLayout.None;
            btnConfig.Dock = DockStyle.Bottom;
            btnConfig.FlatAppearance.BorderSize = 0;
            btnConfig.FlatAppearance.MouseDownBackColor = Color.FromArgb(59, 131, 241);
            btnConfig.FlatStyle = FlatStyle.Flat;
            btnConfig.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnConfig.ForeColor = SystemColors.ControlText;
            btnConfig.Image = Restaurante_Menus.Properties.Resources.config_24px;
            btnConfig.Location = new Point(0, 420);
            btnConfig.Name = "btnConfig";
            btnConfig.Padding = new Padding(5, 0, 0, 0);
            btnConfig.Size = new Size(175, 30);
            btnConfig.TabIndex = 13;
            btnConfig.Text = "Configuracion";
            btnConfig.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnConfig.UseVisualStyleBackColor = true;
            btnConfig.Click += btnConfig_Click;
            // 
            // AppMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 242, 242);
            ClientSize = new Size(1209, 490);
            Controls.Add(panelMain);
            Controls.Add(panelSuperior);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AppMain";
            Text = "PresupuestadoEventos";
            panelSuperior.ResumeLayout(false);
            panelSuperiorFillMidSearch.ResumeLayout(false);
            panelSuperiorFillMidSearch.PerformLayout();
            panelSuperiorSideMenuBurger.ResumeLayout(false);
            panelMain.ResumeLayout(false);
            panelSideMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panelSuperior;
        private Panel panelMain;
        private LineShadow lineShadowSup;
        private Panel panelSideMenu;
        private Panel panelLineSeparator;
        private Panel panelMainView;
        private Button btnInicio;
        private Button btnPresupuesto;
        private Panel panelSuperiorSideRight;
        private Panel panelSuperiorFillMidSearch;
        private Panel panelSuperiorSideMenuBurger;
        private TextBox txtBoxSearch;
        private Label lblWelcome;
        private Button btnMenuBurger;
        private Button btnTipoMenu;
        private Button btnServAdicional;
        private Button btnLugar;
        private Button btnComida;
        private Button btnConfig;
    }
}
