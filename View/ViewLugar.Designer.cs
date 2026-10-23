namespace EventoPresupuestado.View
{
    partial class ViewLugar
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
            flpCardLugares = new FlowLayoutPanel();
            lblTitleGestor = new Label();
            btnLimpiarTexts = new Button();
            panelAsideABM = new Panel();
            groupBoxLugar = new GroupBox();
            btnCargarImagen = new Button();
            lblCargarImagen = new Label();
            txtLugarCantidadMax = new TextBox();
            lblLugarCantidadMax = new Label();
            txtLugarNombre = new TextBox();
            lblLugarNombre = new Label();
            txtLugarDescripcion = new TextBox();
            lblLugarComida = new Label();
            txtLugarPrecio = new TextBox();
            lblLugarPrecio = new Label();
            panelButtonsABM = new Panel();
            btnDeleteLugar = new Button();
            btnUpdateLugar = new Button();
            btnCreateLugar = new Button();
            panelFill.SuspendLayout();
            panelAsideABM.SuspendLayout();
            groupBoxLugar.SuspendLayout();
            panelButtonsABM.SuspendLayout();
            SuspendLayout();
            // 
            // panelFill
            // 
            panelFill.Controls.Add(flpCardLugares);
            panelFill.Controls.Add(lblTitleGestor);
            panelFill.Controls.Add(btnLimpiarTexts);
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(0, 0);
            panelFill.Name = "panelFill";
            panelFill.Size = new Size(602, 501);
            panelFill.TabIndex = 3;
            // 
            // flpCardLugares
            // 
            flpCardLugares.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flpCardLugares.AutoScroll = true;
            flpCardLugares.BackColor = Color.FromArgb(224, 224, 224);
            flpCardLugares.Location = new Point(3, 66);
            flpCardLugares.Name = "flpCardLugares";
            flpCardLugares.Padding = new Padding(3);
            flpCardLugares.Size = new Size(593, 432);
            flpCardLugares.TabIndex = 13;
            // 
            // lblTitleGestor
            // 
            lblTitleGestor.AutoSize = true;
            lblTitleGestor.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitleGestor.Location = new Point(18, 5);
            lblTitleGestor.Name = "lblTitleGestor";
            lblTitleGestor.Size = new Size(368, 37);
            lblTitleGestor.TabIndex = 12;
            lblTitleGestor.Text = "Gestor Lugar y Salones - ABM";
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
            panelAsideABM.Controls.Add(groupBoxLugar);
            panelAsideABM.Controls.Add(panelButtonsABM);
            panelAsideABM.Dock = DockStyle.Right;
            panelAsideABM.Location = new Point(602, 0);
            panelAsideABM.Name = "panelAsideABM";
            panelAsideABM.Size = new Size(198, 501);
            panelAsideABM.TabIndex = 2;
            // 
            // groupBoxLugar
            // 
            groupBoxLugar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            groupBoxLugar.Controls.Add(btnCargarImagen);
            groupBoxLugar.Controls.Add(lblCargarImagen);
            groupBoxLugar.Controls.Add(txtLugarCantidadMax);
            groupBoxLugar.Controls.Add(lblLugarCantidadMax);
            groupBoxLugar.Controls.Add(txtLugarNombre);
            groupBoxLugar.Controls.Add(lblLugarNombre);
            groupBoxLugar.Controls.Add(txtLugarDescripcion);
            groupBoxLugar.Controls.Add(lblLugarComida);
            groupBoxLugar.Controls.Add(txtLugarPrecio);
            groupBoxLugar.Controls.Add(lblLugarPrecio);
            groupBoxLugar.Location = new Point(6, 8);
            groupBoxLugar.Margin = new Padding(3, 2, 3, 2);
            groupBoxLugar.Name = "groupBoxLugar";
            groupBoxLugar.Padding = new Padding(3, 2, 3, 2);
            groupBoxLugar.Size = new Size(186, 435);
            groupBoxLugar.TabIndex = 6;
            groupBoxLugar.TabStop = false;
            groupBoxLugar.Text = "Detalles Salon";
            // 
            // btnCargarImagen
            // 
            btnCargarImagen.Image = Restaurante_Menus.Properties.Resources.subir_imagen_16px;
            btnCargarImagen.ImageAlign = ContentAlignment.BottomCenter;
            btnCargarImagen.Location = new Point(119, 328);
            btnCargarImagen.Margin = new Padding(3, 4, 3, 0);
            btnCargarImagen.Name = "btnCargarImagen";
            btnCargarImagen.Size = new Size(52, 24);
            btnCargarImagen.TabIndex = 5;
            btnCargarImagen.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCargarImagen.UseVisualStyleBackColor = true;
            btnCargarImagen.Click += btnCargarImagen_Click;
            // 
            // lblCargarImagen
            // 
            lblCargarImagen.AutoSize = true;
            lblCargarImagen.Location = new Point(14, 331);
            lblCargarImagen.Name = "lblCargarImagen";
            lblCargarImagen.Size = new Size(88, 15);
            lblCargarImagen.TabIndex = 16;
            lblCargarImagen.Text = "Cargar Imagen:";
            // 
            // txtLugarCantidadMax
            // 
            txtLugarCantidadMax.Location = new Point(14, 248);
            txtLugarCantidadMax.Margin = new Padding(3, 2, 3, 2);
            txtLugarCantidadMax.Name = "txtLugarCantidadMax";
            txtLugarCantidadMax.Size = new Size(157, 23);
            txtLugarCantidadMax.TabIndex = 3;
            // 
            // lblLugarCantidadMax
            // 
            lblLugarCantidadMax.AutoSize = true;
            lblLugarCantidadMax.Location = new Point(14, 231);
            lblLugarCantidadMax.Name = "lblLugarCantidadMax";
            lblLugarCantidadMax.Size = new Size(114, 15);
            lblLugarCantidadMax.TabIndex = 15;
            lblLugarCantidadMax.Text = "Cant. Max Personas:";
            // 
            // txtLugarNombre
            // 
            txtLugarNombre.Location = new Point(14, 36);
            txtLugarNombre.Margin = new Padding(3, 2, 3, 2);
            txtLugarNombre.Name = "txtLugarNombre";
            txtLugarNombre.Size = new Size(157, 23);
            txtLugarNombre.TabIndex = 1;
            // 
            // lblLugarNombre
            // 
            lblLugarNombre.AutoSize = true;
            lblLugarNombre.Location = new Point(14, 19);
            lblLugarNombre.Name = "lblLugarNombre";
            lblLugarNombre.Size = new Size(86, 15);
            lblLugarNombre.TabIndex = 12;
            lblLugarNombre.Text = "Nombre Salon:";
            // 
            // txtLugarDescripcion
            // 
            txtLugarDescripcion.Location = new Point(14, 84);
            txtLugarDescripcion.Margin = new Padding(3, 2, 3, 2);
            txtLugarDescripcion.Multiline = true;
            txtLugarDescripcion.Name = "txtLugarDescripcion";
            txtLugarDescripcion.ScrollBars = ScrollBars.Vertical;
            txtLugarDescripcion.Size = new Size(157, 139);
            txtLugarDescripcion.TabIndex = 2;
            // 
            // lblLugarComida
            // 
            lblLugarComida.AutoSize = true;
            lblLugarComida.Location = new Point(14, 67);
            lblLugarComida.Name = "lblLugarComida";
            lblLugarComida.Size = new Size(123, 15);
            lblLugarComida.TabIndex = 10;
            lblLugarComida.Text = "Descripcion del Salon:";
            // 
            // txtLugarPrecio
            // 
            txtLugarPrecio.Location = new Point(14, 296);
            txtLugarPrecio.Margin = new Padding(3, 2, 3, 2);
            txtLugarPrecio.Name = "txtLugarPrecio";
            txtLugarPrecio.Size = new Size(157, 23);
            txtLugarPrecio.TabIndex = 4;
            // 
            // lblLugarPrecio
            // 
            lblLugarPrecio.AutoSize = true;
            lblLugarPrecio.Location = new Point(14, 279);
            lblLugarPrecio.Name = "lblLugarPrecio";
            lblLugarPrecio.Size = new Size(87, 15);
            lblLugarPrecio.TabIndex = 11;
            lblLugarPrecio.Text = "Precio Base ($):";
            // 
            // panelButtonsABM
            // 
            panelButtonsABM.Controls.Add(btnDeleteLugar);
            panelButtonsABM.Controls.Add(btnUpdateLugar);
            panelButtonsABM.Controls.Add(btnCreateLugar);
            panelButtonsABM.Dock = DockStyle.Bottom;
            panelButtonsABM.Location = new Point(0, 451);
            panelButtonsABM.Name = "panelButtonsABM";
            panelButtonsABM.Size = new Size(198, 50);
            panelButtonsABM.TabIndex = 0;
            // 
            // btnDeleteLugar
            // 
            btnDeleteLugar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDeleteLugar.Image = Restaurante_Menus.Properties.Resources.borrar_16px;
            btnDeleteLugar.Location = new Point(6, 9);
            btnDeleteLugar.Margin = new Padding(3, 2, 3, 2);
            btnDeleteLugar.Name = "btnDeleteLugar";
            btnDeleteLugar.Size = new Size(28, 30);
            btnDeleteLugar.TabIndex = 5;
            btnDeleteLugar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnDeleteLugar.UseVisualStyleBackColor = true;
            btnDeleteLugar.Click += btnDeleteLugar_Click;
            // 
            // btnUpdateLugar
            // 
            btnUpdateLugar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnUpdateLugar.Location = new Point(38, 9);
            btnUpdateLugar.Margin = new Padding(3, 2, 3, 2);
            btnUpdateLugar.Name = "btnUpdateLugar";
            btnUpdateLugar.Size = new Size(82, 30);
            btnUpdateLugar.TabIndex = 4;
            btnUpdateLugar.Text = "Modificar";
            btnUpdateLugar.UseVisualStyleBackColor = true;
            btnUpdateLugar.Click += btnUpdateLugar_Click;
            // 
            // btnCreateLugar
            // 
            btnCreateLugar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCreateLugar.BackColor = Color.FromArgb(59, 130, 238);
            btnCreateLugar.ForeColor = SystemColors.Control;
            btnCreateLugar.Location = new Point(125, 9);
            btnCreateLugar.Margin = new Padding(3, 2, 3, 2);
            btnCreateLugar.Name = "btnCreateLugar";
            btnCreateLugar.Size = new Size(66, 30);
            btnCreateLugar.TabIndex = 3;
            btnCreateLugar.Text = "Crear";
            btnCreateLugar.UseVisualStyleBackColor = false;
            btnCreateLugar.Click += btnCreateLugar_Click;
            // 
            // ViewLugar
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
            Name = "ViewLugar";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "ViewCategoria";
            panelFill.ResumeLayout(false);
            panelFill.PerformLayout();
            panelAsideABM.ResumeLayout(false);
            groupBoxLugar.ResumeLayout(false);
            groupBoxLugar.PerformLayout();
            panelButtonsABM.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelFill;
        private DataGridView dgvListComida;
        private Panel panelAsideABM;
        private GroupBox groupBoxLugar;
        private TextBox txtLugarPrecio;
        private Panel panelButtonsABM;
        private Button btnCreateLugar;
        private Label lblLugarPrecio;
        private TextBox txtLugarDescripcion;
        private Label lblLugarComida;
        private Button btnUpdateLugar;
        private Button btnDeleteLugar;
        private Button btnLimpiarTexts;
        private Label lblTitleGestor;
        private TextBox txtLugarNombre;
        private Label lblLugarNombre;
        private TextBox txtLugarCantidadMax;
        private Label lblLugarCantidadMax;
        private FlowLayoutPanel flpCardLugares;
        private Button btnCargarImagen;
        private Label lblCargarImagen;
    }
}