namespace EventoPresupuestado.View
{
    partial class ViewServicio
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
            flpCardServicio = new FlowLayoutPanel();
            lblTitleGestor = new Label();
            btnLimpiarTexts = new Button();
            panelAsideABM = new Panel();
            groupBoxServicio = new GroupBox();
            btnCargarImagen = new Button();
            lblCargarImagen = new Label();
            txtServicioNombre = new TextBox();
            lblServicioNombre = new Label();
            txtLServicioDescripcion = new TextBox();
            lblServicioDescripcion = new Label();
            txtServicioPrecio = new TextBox();
            lblServicioPrecio = new Label();
            panelButtonsABM = new Panel();
            btnDeleteServicio = new Button();
            btnUpdateServicio = new Button();
            btnCreateServicio = new Button();
            panelFill.SuspendLayout();
            panelAsideABM.SuspendLayout();
            groupBoxServicio.SuspendLayout();
            panelButtonsABM.SuspendLayout();
            SuspendLayout();
            // 
            // panelFill
            // 
            panelFill.Controls.Add(flpCardServicio);
            panelFill.Controls.Add(lblTitleGestor);
            panelFill.Controls.Add(btnLimpiarTexts);
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(0, 0);
            panelFill.Name = "panelFill";
            panelFill.Size = new Size(602, 501);
            panelFill.TabIndex = 3;
            // 
            // flpCardServicio
            // 
            flpCardServicio.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flpCardServicio.AutoScroll = true;
            flpCardServicio.BackColor = Color.FromArgb(224, 224, 224);
            flpCardServicio.FlowDirection = FlowDirection.TopDown;
            flpCardServicio.Location = new Point(3, 66);
            flpCardServicio.Name = "flpCardServicio";
            flpCardServicio.Padding = new Padding(10, 10, 3, 3);
            flpCardServicio.Size = new Size(593, 432);
            flpCardServicio.TabIndex = 13;
            flpCardServicio.WrapContents = false;
            flpCardServicio.Resize += flpCardServicio_Resize;
            // 
            // lblTitleGestor
            // 
            lblTitleGestor.AutoSize = true;
            lblTitleGestor.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitleGestor.Location = new Point(18, 5);
            lblTitleGestor.Name = "lblTitleGestor";
            lblTitleGestor.Size = new Size(404, 37);
            lblTitleGestor.TabIndex = 12;
            lblTitleGestor.Text = "Gestor Servicios Adicional - ABM";
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
            panelAsideABM.Controls.Add(groupBoxServicio);
            panelAsideABM.Controls.Add(panelButtonsABM);
            panelAsideABM.Dock = DockStyle.Right;
            panelAsideABM.Location = new Point(602, 0);
            panelAsideABM.Name = "panelAsideABM";
            panelAsideABM.Size = new Size(198, 501);
            panelAsideABM.TabIndex = 2;
            // 
            // groupBoxServicio
            // 
            groupBoxServicio.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            groupBoxServicio.Controls.Add(btnCargarImagen);
            groupBoxServicio.Controls.Add(lblCargarImagen);
            groupBoxServicio.Controls.Add(txtServicioNombre);
            groupBoxServicio.Controls.Add(lblServicioNombre);
            groupBoxServicio.Controls.Add(txtLServicioDescripcion);
            groupBoxServicio.Controls.Add(lblServicioDescripcion);
            groupBoxServicio.Controls.Add(txtServicioPrecio);
            groupBoxServicio.Controls.Add(lblServicioPrecio);
            groupBoxServicio.Location = new Point(6, 8);
            groupBoxServicio.Margin = new Padding(3, 2, 3, 2);
            groupBoxServicio.Name = "groupBoxServicio";
            groupBoxServicio.Padding = new Padding(3, 2, 3, 2);
            groupBoxServicio.Size = new Size(186, 435);
            groupBoxServicio.TabIndex = 6;
            groupBoxServicio.TabStop = false;
            groupBoxServicio.Text = "Detalles Servicio Adicional";
            // 
            // btnCargarImagen
            // 
            btnCargarImagen.Image = Restaurante_Menus.Properties.Resources.subir_imagen_16px;
            btnCargarImagen.ImageAlign = ContentAlignment.BottomCenter;
            btnCargarImagen.Location = new Point(119, 280);
            btnCargarImagen.Margin = new Padding(3, 4, 3, 0);
            btnCargarImagen.Name = "btnCargarImagen";
            btnCargarImagen.Size = new Size(52, 24);
            btnCargarImagen.TabIndex = 5;
            btnCargarImagen.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCargarImagen.UseVisualStyleBackColor = true;
            btnCargarImagen.Visible = false;
            btnCargarImagen.Click += btnCargarImagen_Click;
            // 
            // lblCargarImagen
            // 
            lblCargarImagen.AutoSize = true;
            lblCargarImagen.Location = new Point(14, 283);
            lblCargarImagen.Name = "lblCargarImagen";
            lblCargarImagen.Size = new Size(88, 15);
            lblCargarImagen.TabIndex = 16;
            lblCargarImagen.Text = "Cargar Imagen:";
            lblCargarImagen.Visible = false;
            // 
            // txtServicioNombre
            // 
            txtServicioNombre.Location = new Point(14, 36);
            txtServicioNombre.Margin = new Padding(3, 2, 3, 2);
            txtServicioNombre.Name = "txtServicioNombre";
            txtServicioNombre.Size = new Size(157, 23);
            txtServicioNombre.TabIndex = 1;
            // 
            // lblServicioNombre
            // 
            lblServicioNombre.AutoSize = true;
            lblServicioNombre.Location = new Point(14, 19);
            lblServicioNombre.Name = "lblServicioNombre";
            lblServicioNombre.Size = new Size(98, 15);
            lblServicioNombre.TabIndex = 12;
            lblServicioNombre.Text = "Nombre Servicio:";
            // 
            // txtLServicioDescripcion
            // 
            txtLServicioDescripcion.Location = new Point(14, 84);
            txtLServicioDescripcion.Margin = new Padding(3, 2, 3, 2);
            txtLServicioDescripcion.Multiline = true;
            txtLServicioDescripcion.Name = "txtLServicioDescripcion";
            txtLServicioDescripcion.ScrollBars = ScrollBars.Vertical;
            txtLServicioDescripcion.Size = new Size(157, 139);
            txtLServicioDescripcion.TabIndex = 2;
            // 
            // lblServicioDescripcion
            // 
            lblServicioDescripcion.AutoSize = true;
            lblServicioDescripcion.Location = new Point(14, 67);
            lblServicioDescripcion.Name = "lblServicioDescripcion";
            lblServicioDescripcion.Size = new Size(132, 15);
            lblServicioDescripcion.TabIndex = 10;
            lblServicioDescripcion.Text = "Descripcion del Servicio";
            // 
            // txtServicioPrecio
            // 
            txtServicioPrecio.Location = new Point(14, 248);
            txtServicioPrecio.Margin = new Padding(3, 2, 3, 2);
            txtServicioPrecio.Name = "txtServicioPrecio";
            txtServicioPrecio.Size = new Size(157, 23);
            txtServicioPrecio.TabIndex = 4;
            // 
            // lblServicioPrecio
            // 
            lblServicioPrecio.AutoSize = true;
            lblServicioPrecio.Location = new Point(14, 231);
            lblServicioPrecio.Name = "lblServicioPrecio";
            lblServicioPrecio.Size = new Size(60, 15);
            lblServicioPrecio.TabIndex = 11;
            lblServicioPrecio.Text = "Precio ($):";
            // 
            // panelButtonsABM
            // 
            panelButtonsABM.Controls.Add(btnDeleteServicio);
            panelButtonsABM.Controls.Add(btnUpdateServicio);
            panelButtonsABM.Controls.Add(btnCreateServicio);
            panelButtonsABM.Dock = DockStyle.Bottom;
            panelButtonsABM.Location = new Point(0, 451);
            panelButtonsABM.Name = "panelButtonsABM";
            panelButtonsABM.Size = new Size(198, 50);
            panelButtonsABM.TabIndex = 0;
            // 
            // btnDeleteServicio
            // 
            btnDeleteServicio.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDeleteServicio.Image = Restaurante_Menus.Properties.Resources.borrar_16px;
            btnDeleteServicio.Location = new Point(6, 9);
            btnDeleteServicio.Margin = new Padding(3, 2, 3, 2);
            btnDeleteServicio.Name = "btnDeleteServicio";
            btnDeleteServicio.Size = new Size(28, 30);
            btnDeleteServicio.TabIndex = 5;
            btnDeleteServicio.TextImageRelation = TextImageRelation.ImageAboveText;
            btnDeleteServicio.UseVisualStyleBackColor = true;
            btnDeleteServicio.Click += btnDeleteServicio_Click;
            // 
            // btnUpdateServicio
            // 
            btnUpdateServicio.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnUpdateServicio.Location = new Point(38, 9);
            btnUpdateServicio.Margin = new Padding(3, 2, 3, 2);
            btnUpdateServicio.Name = "btnUpdateServicio";
            btnUpdateServicio.Size = new Size(82, 30);
            btnUpdateServicio.TabIndex = 4;
            btnUpdateServicio.Text = "Modificar";
            btnUpdateServicio.UseVisualStyleBackColor = true;
            btnUpdateServicio.Click += btnUpdateServicio_Click;
            // 
            // btnCreateServicio
            // 
            btnCreateServicio.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCreateServicio.BackColor = Color.FromArgb(59, 130, 238);
            btnCreateServicio.ForeColor = SystemColors.Control;
            btnCreateServicio.Location = new Point(125, 9);
            btnCreateServicio.Margin = new Padding(3, 2, 3, 2);
            btnCreateServicio.Name = "btnCreateServicio";
            btnCreateServicio.Size = new Size(66, 30);
            btnCreateServicio.TabIndex = 3;
            btnCreateServicio.Text = "Crear";
            btnCreateServicio.UseVisualStyleBackColor = false;
            btnCreateServicio.Click += btnCreateServicio_Click;
            // 
            // ViewServicio
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
            Name = "ViewServicio";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "ViewCategoria";
            panelFill.ResumeLayout(false);
            panelFill.PerformLayout();
            panelAsideABM.ResumeLayout(false);
            groupBoxServicio.ResumeLayout(false);
            groupBoxServicio.PerformLayout();
            panelButtonsABM.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelFill;
        private Panel panelAsideABM;
        private GroupBox groupBoxServicio;
        private TextBox txtServicioPrecio;
        private Panel panelButtonsABM;
        private Button btnCreateServicio;
        private Label lblServicioPrecio;
        private TextBox txtLServicioDescripcion;
        private Label lblServicioDescripcion;
        private Button btnUpdateServicio;
        private Button btnDeleteServicio;
        private Button btnLimpiarTexts;
        private Label lblTitleGestor;
        private TextBox txtServicioNombre;
        private Label lblServicioNombre;
        private FlowLayoutPanel flpCardServicio;
        private Button btnCargarImagen;
        private Label lblCargarImagen;
    }
}