namespace EventoPresupuestado.View
{
    partial class ViewTipoMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelFill = new Panel();
            flpCardMenus = new FlowLayoutPanel();
            lblTitleGestor = new Label();
            btnLimpiarTexts = new Button();
            panelAsideABM = new Panel();
            groupBoxMenu = new GroupBox();
            pnlAsideInferiorTotal = new Panel();
            ptrPrecioTotal = new EventoPresupuestado.Componentes.PanelTotalRounded();
            lblPrecioBebida = new Label();
            cbxBebidaMenu = new ComboBox();
            lblBebidaMenu = new Label();
            lblPrecioPostre = new Label();
            lblPrecioPlatoMain = new Label();
            lblPrecioEntrada = new Label();
            cbxPostreMenu = new ComboBox();
            cbxPlatoMainMenu = new ComboBox();
            cbxEntradaMenu = new ComboBox();
            lblPlatoMainMenu = new Label();
            txtMenuNombre = new TextBox();
            lblMenuNombre = new Label();
            lblEntradaMenu = new Label();
            lblPostreMenu = new Label();
            panelButtonsABM = new Panel();
            btnDeleteMenu = new Button();
            btnUpdateMenu = new Button();
            btnCreateMenu = new Button();
            panelFill.SuspendLayout();
            panelAsideABM.SuspendLayout();
            groupBoxMenu.SuspendLayout();
            pnlAsideInferiorTotal.SuspendLayout();
            panelButtonsABM.SuspendLayout();
            SuspendLayout();
            // 
            // panelFill
            // 
            panelFill.Controls.Add(flpCardMenus);
            panelFill.Controls.Add(lblTitleGestor);
            panelFill.Controls.Add(btnLimpiarTexts);
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(0, 0);
            panelFill.Name = "panelFill";
            panelFill.Size = new Size(602, 501);
            panelFill.TabIndex = 3;
            // 
            // flpCardMenus
            // 
            flpCardMenus.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flpCardMenus.AutoScroll = true;
            flpCardMenus.BackColor = Color.FromArgb(224, 224, 224);
            flpCardMenus.Location = new Point(3, 66);
            flpCardMenus.Name = "flpCardMenus";
            flpCardMenus.Padding = new Padding(3);
            flpCardMenus.Size = new Size(593, 432);
            flpCardMenus.TabIndex = 13;
            // 
            // lblTitleGestor
            // 
            lblTitleGestor.AutoSize = true;
            lblTitleGestor.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitleGestor.Location = new Point(18, 5);
            lblTitleGestor.Name = "lblTitleGestor";
            lblTitleGestor.Size = new Size(353, 37);
            lblTitleGestor.TabIndex = 12;
            lblTitleGestor.Text = "Gestor Menús y Tipos - ABM";
            // 
            // btnLimpiarTexts
            // 
            btnLimpiarTexts.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLimpiarTexts.Image = Restaurante_Menus.Properties.Resources.clean_24px;
            btnLimpiarTexts.Location = new Point(552, 12);
            btnLimpiarTexts.Margin = new Padding(3, 2, 3, 2);
            btnLimpiarTexts.Name = "btnLimpiarTexts";
            btnLimpiarTexts.Size = new Size(28, 30);
            btnLimpiarTexts.TabIndex = 9;
            btnLimpiarTexts.TextImageRelation = TextImageRelation.ImageAboveText;
            btnLimpiarTexts.UseVisualStyleBackColor = true;
            btnLimpiarTexts.Click += btnLimpiarTexts_Click;
            // 
            // panelAsideABM
            // 
            panelAsideABM.AutoScroll = true;
            panelAsideABM.BackColor = Color.FromArgb(245, 246, 248);
            panelAsideABM.Controls.Add(groupBoxMenu);
            panelAsideABM.Controls.Add(panelButtonsABM);
            panelAsideABM.Dock = DockStyle.Right;
            panelAsideABM.Location = new Point(602, 0);
            panelAsideABM.Name = "panelAsideABM";
            panelAsideABM.Size = new Size(198, 501);
            panelAsideABM.TabIndex = 2;
            // 
            // groupBoxMenu
            // 
            groupBoxMenu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            groupBoxMenu.AutoSize = true;
            groupBoxMenu.Controls.Add(pnlAsideInferiorTotal);
            groupBoxMenu.Controls.Add(lblPrecioBebida);
            groupBoxMenu.Controls.Add(cbxBebidaMenu);
            groupBoxMenu.Controls.Add(lblBebidaMenu);
            groupBoxMenu.Controls.Add(lblPrecioPostre);
            groupBoxMenu.Controls.Add(lblPrecioPlatoMain);
            groupBoxMenu.Controls.Add(lblPrecioEntrada);
            groupBoxMenu.Controls.Add(cbxPostreMenu);
            groupBoxMenu.Controls.Add(cbxPlatoMainMenu);
            groupBoxMenu.Controls.Add(cbxEntradaMenu);
            groupBoxMenu.Controls.Add(lblPlatoMainMenu);
            groupBoxMenu.Controls.Add(txtMenuNombre);
            groupBoxMenu.Controls.Add(lblMenuNombre);
            groupBoxMenu.Controls.Add(lblEntradaMenu);
            groupBoxMenu.Controls.Add(lblPostreMenu);
            groupBoxMenu.Location = new Point(6, 8);
            groupBoxMenu.Margin = new Padding(3, 2, 3, 2);
            groupBoxMenu.Name = "groupBoxMenu";
            groupBoxMenu.Padding = new Padding(3, 2, 3, 2);
            groupBoxMenu.Size = new Size(186, 435);
            groupBoxMenu.TabIndex = 6;
            groupBoxMenu.TabStop = false;
            groupBoxMenu.Text = "Detalles de Menú";
            // 
            // pnlAsideInferiorTotal
            // 
            pnlAsideInferiorTotal.Controls.Add(ptrPrecioTotal);
            pnlAsideInferiorTotal.Dock = DockStyle.Bottom;
            pnlAsideInferiorTotal.Location = new Point(3, 359);
            pnlAsideInferiorTotal.Name = "pnlAsideInferiorTotal";
            pnlAsideInferiorTotal.Size = new Size(180, 74);
            pnlAsideInferiorTotal.TabIndex = 27;
            // 
            // ptrPrecioTotal
            // 
            ptrPrecioTotal.Location = new Point(5, 9);
            ptrPrecioTotal.Margin = new Padding(3, 2, 3, 2);
            ptrPrecioTotal.Name = "ptrPrecioTotal";
            ptrPrecioTotal.RadioRedondeo = 12;
            ptrPrecioTotal.Size = new Size(171, 55);
            ptrPrecioTotal.TabIndex = 26;
            ptrPrecioTotal.Titulo = "VALOR TOTAL CALCULADO";
            // 
            // lblPrecioBebida
            // 
            lblPrecioBebida.ForeColor = Color.DimGray;
            lblPrecioBebida.Location = new Point(96, 228);
            lblPrecioBebida.Name = "lblPrecioBebida";
            lblPrecioBebida.Size = new Size(75, 15);
            lblPrecioBebida.TabIndex = 25;
            lblPrecioBebida.Text = "$4500";
            lblPrecioBebida.TextAlign = ContentAlignment.TopRight;
            // 
            // cbxBebidaMenu
            // 
            cbxBebidaMenu.FormattingEnabled = true;
            cbxBebidaMenu.Location = new Point(15, 246);
            cbxBebidaMenu.Name = "cbxBebidaMenu";
            cbxBebidaMenu.Size = new Size(157, 23);
            cbxBebidaMenu.TabIndex = 24;
            // 
            // lblBebidaMenu
            // 
            lblBebidaMenu.AutoSize = true;
            lblBebidaMenu.Location = new Point(14, 227);
            lblBebidaMenu.Name = "lblBebidaMenu";
            lblBebidaMenu.Size = new Size(46, 15);
            lblBebidaMenu.TabIndex = 23;
            lblBebidaMenu.Text = "Bebida:";
            // 
            // lblPrecioPostre
            // 
            lblPrecioPostre.ForeColor = Color.DimGray;
            lblPrecioPostre.Location = new Point(96, 178);
            lblPrecioPostre.Name = "lblPrecioPostre";
            lblPrecioPostre.Size = new Size(75, 15);
            lblPrecioPostre.TabIndex = 22;
            lblPrecioPostre.Text = "$4500";
            lblPrecioPostre.TextAlign = ContentAlignment.TopRight;
            // 
            // lblPrecioPlatoMain
            // 
            lblPrecioPlatoMain.ForeColor = Color.DimGray;
            lblPrecioPlatoMain.Location = new Point(96, 128);
            lblPrecioPlatoMain.Name = "lblPrecioPlatoMain";
            lblPrecioPlatoMain.Size = new Size(75, 15);
            lblPrecioPlatoMain.TabIndex = 21;
            lblPrecioPlatoMain.Text = "$4500";
            lblPrecioPlatoMain.TextAlign = ContentAlignment.TopRight;
            // 
            // lblPrecioEntrada
            // 
            lblPrecioEntrada.ForeColor = Color.DimGray;
            lblPrecioEntrada.Location = new Point(96, 78);
            lblPrecioEntrada.Name = "lblPrecioEntrada";
            lblPrecioEntrada.Size = new Size(75, 15);
            lblPrecioEntrada.TabIndex = 20;
            lblPrecioEntrada.Text = "$4500";
            lblPrecioEntrada.TextAlign = ContentAlignment.TopRight;
            // 
            // cbxPostreMenu
            // 
            cbxPostreMenu.FormattingEnabled = true;
            cbxPostreMenu.Location = new Point(15, 196);
            cbxPostreMenu.Name = "cbxPostreMenu";
            cbxPostreMenu.Size = new Size(157, 23);
            cbxPostreMenu.TabIndex = 19;
            // 
            // cbxPlatoMainMenu
            // 
            cbxPlatoMainMenu.FormattingEnabled = true;
            cbxPlatoMainMenu.Location = new Point(14, 146);
            cbxPlatoMainMenu.Name = "cbxPlatoMainMenu";
            cbxPlatoMainMenu.Size = new Size(157, 23);
            cbxPlatoMainMenu.TabIndex = 18;
            // 
            // cbxEntradaMenu
            // 
            cbxEntradaMenu.FormattingEnabled = true;
            cbxEntradaMenu.Location = new Point(14, 96);
            cbxEntradaMenu.Name = "cbxEntradaMenu";
            cbxEntradaMenu.Size = new Size(157, 23);
            cbxEntradaMenu.TabIndex = 17;
            // 
            // lblPlatoMainMenu
            // 
            lblPlatoMainMenu.AutoSize = true;
            lblPlatoMainMenu.Location = new Point(14, 127);
            lblPlatoMainMenu.Name = "lblPlatoMainMenu";
            lblPlatoMainMenu.Size = new Size(86, 15);
            lblPlatoMainMenu.TabIndex = 15;
            lblPlatoMainMenu.Text = "Plato Principal:";
            // 
            // txtMenuNombre
            // 
            txtMenuNombre.Location = new Point(14, 36);
            txtMenuNombre.Margin = new Padding(3, 2, 3, 2);
            txtMenuNombre.Name = "txtMenuNombre";
            txtMenuNombre.Size = new Size(157, 23);
            txtMenuNombre.TabIndex = 1;
            // 
            // lblMenuNombre
            // 
            lblMenuNombre.AutoSize = true;
            lblMenuNombre.Location = new Point(14, 19);
            lblMenuNombre.Name = "lblMenuNombre";
            lblMenuNombre.Size = new Size(104, 15);
            lblMenuNombre.TabIndex = 12;
            lblMenuNombre.Text = "Nombre de Menú:";
            // 
            // lblEntradaMenu
            // 
            lblEntradaMenu.AutoSize = true;
            lblEntradaMenu.Location = new Point(14, 77);
            lblEntradaMenu.Name = "lblEntradaMenu";
            lblEntradaMenu.Size = new Size(50, 15);
            lblEntradaMenu.TabIndex = 10;
            lblEntradaMenu.Text = "Entrada:";
            // 
            // lblPostreMenu
            // 
            lblPostreMenu.AutoSize = true;
            lblPostreMenu.Location = new Point(14, 177);
            lblPostreMenu.Name = "lblPostreMenu";
            lblPostreMenu.Size = new Size(43, 15);
            lblPostreMenu.TabIndex = 11;
            lblPostreMenu.Text = "Postre:";
            // 
            // panelButtonsABM
            // 
            panelButtonsABM.Controls.Add(btnDeleteMenu);
            panelButtonsABM.Controls.Add(btnUpdateMenu);
            panelButtonsABM.Controls.Add(btnCreateMenu);
            panelButtonsABM.Dock = DockStyle.Bottom;
            panelButtonsABM.Location = new Point(0, 451);
            panelButtonsABM.Name = "panelButtonsABM";
            panelButtonsABM.Size = new Size(198, 50);
            panelButtonsABM.TabIndex = 0;
            // 
            // btnDeleteMenu
            // 
            btnDeleteMenu.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDeleteMenu.Image = Restaurante_Menus.Properties.Resources.borrar_16px;
            btnDeleteMenu.Location = new Point(6, 9);
            btnDeleteMenu.Margin = new Padding(3, 2, 3, 2);
            btnDeleteMenu.Name = "btnDeleteMenu";
            btnDeleteMenu.Size = new Size(28, 30);
            btnDeleteMenu.TabIndex = 5;
            btnDeleteMenu.TextImageRelation = TextImageRelation.ImageAboveText;
            btnDeleteMenu.UseVisualStyleBackColor = true;
            btnDeleteMenu.Click += btnDeleteMenu_Click;
            // 
            // btnUpdateMenu
            // 
            btnUpdateMenu.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnUpdateMenu.Location = new Point(38, 9);
            btnUpdateMenu.Margin = new Padding(3, 2, 3, 2);
            btnUpdateMenu.Name = "btnUpdateMenu";
            btnUpdateMenu.Size = new Size(82, 30);
            btnUpdateMenu.TabIndex = 4;
            btnUpdateMenu.Text = "Modificar";
            btnUpdateMenu.UseVisualStyleBackColor = true;
            btnUpdateMenu.Click += btnUpdateMenu_Click;
            // 
            // btnCreateMenu
            // 
            btnCreateMenu.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCreateMenu.BackColor = Color.FromArgb(59, 130, 238);
            btnCreateMenu.ForeColor = SystemColors.Control;
            btnCreateMenu.Location = new Point(125, 9);
            btnCreateMenu.Margin = new Padding(3, 2, 3, 2);
            btnCreateMenu.Name = "btnCreateMenu";
            btnCreateMenu.Size = new Size(66, 30);
            btnCreateMenu.TabIndex = 3;
            btnCreateMenu.Text = "Crear";
            btnCreateMenu.UseVisualStyleBackColor = false;
            btnCreateMenu.Click += btnCreateMenu_Click;
            // 
            // ViewTipoMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 501);
            ControlBox = false;
            Controls.Add(panelFill);
            Controls.Add(panelAsideABM);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "ViewTipoMenu";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "ViewCategoria";
            panelFill.ResumeLayout(false);
            panelFill.PerformLayout();
            panelAsideABM.ResumeLayout(false);
            panelAsideABM.PerformLayout();
            groupBoxMenu.ResumeLayout(false);
            groupBoxMenu.PerformLayout();
            pnlAsideInferiorTotal.ResumeLayout(false);
            panelButtonsABM.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelFill;
        private Panel panelAsideABM;
        private GroupBox groupBoxMenu;
        private TextBox txtLugarPrecio;
        private Panel panelButtonsABM;
        private Button btnCreateMenu;
        private Label lblPostreMenu;
        private TextBox txtLugarDescripcion;
        private Label lblEntradaMenu;
        private Button btnUpdateMenu;
        private Button btnDeleteMenu;
        private Button btnLimpiarTexts;
        private Label lblTitleGestor;
        private TextBox txtMenuNombre;
        private Label lblMenuNombre;
        private TextBox txtLugarCantidadMax;
        private Label lblPlatoMainMenu;
        private FlowLayoutPanel flpCardMenus;
        private Button btnCargarImagen;
        private ComboBox cbxEntradaMenu;
        private ComboBox cbxPlatoMainMenu;
        private ComboBox cbxPostreMenu;
        private Label lblPrecioPostre;
        private Label lblPrecioPlatoMain;
        private Label lblPrecioEntrada;
        private Label lblPrecioBebida;
        private ComboBox cbxBebidaMenu;
        private Label lblBebidaMenu;
        private Componentes.PanelTotalRounded ptrPrecioTotal;
        private Panel pnlAsideInferiorTotal;
    }
}