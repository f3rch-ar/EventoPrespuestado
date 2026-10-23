namespace EventoPresupuestado.View
{
    partial class ViewComida
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
            lblTitleGestor = new Label();
            btnLimpiarDataGrid = new Button();
            dgvListComida = new DataGridView();
            panelAsideABM = new Panel();
            groupBoxComida = new GroupBox();
            lblTipoComida = new Label();
            cbxTipoComida = new ComboBox();
            txtComidaDescripcion = new TextBox();
            lblDescripcionComida = new Label();
            txtComidaValor = new TextBox();
            lblComidaValor = new Label();
            panelButtonsABM = new Panel();
            btnDeleteComida = new Button();
            btnUpdateComida = new Button();
            btnCreateComida = new Button();
            panelFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListComida).BeginInit();
            panelAsideABM.SuspendLayout();
            groupBoxComida.SuspendLayout();
            panelButtonsABM.SuspendLayout();
            SuspendLayout();
            // 
            // panelFill
            // 
            panelFill.Controls.Add(lblTitleGestor);
            panelFill.Controls.Add(btnLimpiarDataGrid);
            panelFill.Controls.Add(dgvListComida);
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(0, 0);
            panelFill.Name = "panelFill";
            panelFill.Size = new Size(602, 400);
            panelFill.TabIndex = 3;
            // 
            // lblTitleGestor
            // 
            lblTitleGestor.AutoSize = true;
            lblTitleGestor.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitleGestor.Location = new Point(18, 5);
            lblTitleGestor.Name = "lblTitleGestor";
            lblTitleGestor.Size = new Size(287, 37);
            lblTitleGestor.TabIndex = 12;
            lblTitleGestor.Text = "Gestor Comidas - ABM";
            // 
            // btnLimpiarDataGrid
            // 
            btnLimpiarDataGrid.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLimpiarDataGrid.Image = Restaurante_Menus.Properties.Resources.clean_24px;
            btnLimpiarDataGrid.Location = new Point(552, 12);
            btnLimpiarDataGrid.Margin = new Padding(3, 2, 3, 2);
            btnLimpiarDataGrid.Name = "btnLimpiarDataGrid";
            btnLimpiarDataGrid.Size = new Size(28, 30);
            btnLimpiarDataGrid.TabIndex = 9;
            btnLimpiarDataGrid.TextImageRelation = TextImageRelation.ImageAboveText;
            btnLimpiarDataGrid.UseVisualStyleBackColor = true;
            btnLimpiarDataGrid.Click += btnLimpiarDataGrid_Click;
            // 
            // dgvListComida
            // 
            dgvListComida.AllowUserToAddRows = false;
            dgvListComida.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvListComida.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListComida.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListComida.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvListComida.Location = new Point(18, 52);
            dgvListComida.Margin = new Padding(3, 2, 3, 2);
            dgvListComida.MultiSelect = false;
            dgvListComida.Name = "dgvListComida";
            dgvListComida.RowHeadersWidth = 51;
            dgvListComida.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListComida.Size = new Size(562, 337);
            dgvListComida.TabIndex = 12;
            // 
            // panelAsideABM
            // 
            panelAsideABM.BackColor = Color.FromArgb(245, 246, 248);
            panelAsideABM.Controls.Add(groupBoxComida);
            panelAsideABM.Controls.Add(panelButtonsABM);
            panelAsideABM.Dock = DockStyle.Right;
            panelAsideABM.Location = new Point(602, 0);
            panelAsideABM.Name = "panelAsideABM";
            panelAsideABM.Size = new Size(198, 400);
            panelAsideABM.TabIndex = 2;
            // 
            // groupBoxComida
            // 
            groupBoxComida.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            groupBoxComida.Controls.Add(lblTipoComida);
            groupBoxComida.Controls.Add(cbxTipoComida);
            groupBoxComida.Controls.Add(txtComidaDescripcion);
            groupBoxComida.Controls.Add(lblDescripcionComida);
            groupBoxComida.Controls.Add(txtComidaValor);
            groupBoxComida.Controls.Add(lblComidaValor);
            groupBoxComida.Location = new Point(6, 8);
            groupBoxComida.Margin = new Padding(3, 2, 3, 2);
            groupBoxComida.Name = "groupBoxComida";
            groupBoxComida.Padding = new Padding(3, 2, 3, 2);
            groupBoxComida.Size = new Size(186, 334);
            groupBoxComida.TabIndex = 6;
            groupBoxComida.TabStop = false;
            groupBoxComida.Text = "Detalles Comida";
            // 
            // lblTipoComida
            // 
            lblTipoComida.AutoSize = true;
            lblTipoComida.Location = new Point(14, 24);
            lblTipoComida.Name = "lblTipoComida";
            lblTipoComida.Size = new Size(95, 15);
            lblTipoComida.TabIndex = 9;
            lblTipoComida.Text = "Tipo de Comida:";
            // 
            // cbxTipoComida
            // 
            cbxTipoComida.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxTipoComida.FormattingEnabled = true;
            cbxTipoComida.Location = new Point(14, 41);
            cbxTipoComida.Name = "cbxTipoComida";
            cbxTipoComida.Size = new Size(157, 23);
            cbxTipoComida.TabIndex = 0;
            // 
            // txtComidaDescripcion
            // 
            txtComidaDescripcion.Location = new Point(14, 112);
            txtComidaDescripcion.Margin = new Padding(3, 2, 3, 2);
            txtComidaDescripcion.Multiline = true;
            txtComidaDescripcion.Name = "txtComidaDescripcion";
            txtComidaDescripcion.ScrollBars = ScrollBars.Vertical;
            txtComidaDescripcion.Size = new Size(157, 139);
            txtComidaDescripcion.TabIndex = 1;
            // 
            // lblDescripcionComida
            // 
            lblDescripcionComida.AutoSize = true;
            lblDescripcionComida.Location = new Point(14, 95);
            lblDescripcionComida.Name = "lblDescripcionComida";
            lblDescripcionComida.Size = new Size(117, 15);
            lblDescripcionComida.TabIndex = 10;
            lblDescripcionComida.Text = "Descripcion Comida:";
            // 
            // txtComidaValor
            // 
            txtComidaValor.Location = new Point(14, 295);
            txtComidaValor.Margin = new Padding(3, 2, 3, 2);
            txtComidaValor.Name = "txtComidaValor";
            txtComidaValor.Size = new Size(157, 23);
            txtComidaValor.TabIndex = 2;
            // 
            // lblComidaValor
            // 
            lblComidaValor.AutoSize = true;
            lblComidaValor.Location = new Point(14, 278);
            lblComidaValor.Name = "lblComidaValor";
            lblComidaValor.Size = new Size(81, 15);
            lblComidaValor.TabIndex = 11;
            lblComidaValor.Text = "Valor Comida:";
            // 
            // panelButtonsABM
            // 
            panelButtonsABM.Controls.Add(btnDeleteComida);
            panelButtonsABM.Controls.Add(btnUpdateComida);
            panelButtonsABM.Controls.Add(btnCreateComida);
            panelButtonsABM.Dock = DockStyle.Bottom;
            panelButtonsABM.Location = new Point(0, 350);
            panelButtonsABM.Name = "panelButtonsABM";
            panelButtonsABM.Size = new Size(198, 50);
            panelButtonsABM.TabIndex = 0;
            // 
            // btnDeleteComida
            // 
            btnDeleteComida.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDeleteComida.Image = Restaurante_Menus.Properties.Resources.borrar_16px;
            btnDeleteComida.Location = new Point(6, 9);
            btnDeleteComida.Margin = new Padding(3, 2, 3, 2);
            btnDeleteComida.Name = "btnDeleteComida";
            btnDeleteComida.Size = new Size(28, 30);
            btnDeleteComida.TabIndex = 5;
            btnDeleteComida.TextImageRelation = TextImageRelation.ImageAboveText;
            btnDeleteComida.UseVisualStyleBackColor = true;
            btnDeleteComida.Click += btnDeleteComida_Click;
            // 
            // btnUpdateComida
            // 
            btnUpdateComida.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnUpdateComida.Location = new Point(38, 9);
            btnUpdateComida.Margin = new Padding(3, 2, 3, 2);
            btnUpdateComida.Name = "btnUpdateComida";
            btnUpdateComida.Size = new Size(82, 30);
            btnUpdateComida.TabIndex = 4;
            btnUpdateComida.Text = "Modificar";
            btnUpdateComida.UseVisualStyleBackColor = true;
            btnUpdateComida.Click += btnUpdateComida_Click;
            // 
            // btnCreateComida
            // 
            btnCreateComida.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCreateComida.BackColor = Color.FromArgb(59, 130, 238);
            btnCreateComida.ForeColor = SystemColors.Control;
            btnCreateComida.Location = new Point(125, 9);
            btnCreateComida.Margin = new Padding(3, 2, 3, 2);
            btnCreateComida.Name = "btnCreateComida";
            btnCreateComida.Size = new Size(66, 30);
            btnCreateComida.TabIndex = 3;
            btnCreateComida.Text = "Crear";
            btnCreateComida.UseVisualStyleBackColor = false;
            btnCreateComida.Click += btnCreateComida_Click;
            // 
            // ViewComida
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 400);
            ControlBox = false;
            Controls.Add(panelFill);
            Controls.Add(panelAsideABM);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "ViewComida";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "ViewCategoria";
            panelFill.ResumeLayout(false);
            panelFill.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListComida).EndInit();
            panelAsideABM.ResumeLayout(false);
            groupBoxComida.ResumeLayout(false);
            groupBoxComida.PerformLayout();
            panelButtonsABM.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelFill;
        private DataGridView dgvListComida;
        private Panel panelAsideABM;
        private GroupBox groupBoxComida;
        private TextBox txtComidaValor;
        private Panel panelButtonsABM;
        private Button btnCreateComida;
        private Label lblComidaValor;
        private TextBox txtComidaDescripcion;
        private Label lblDescripcionComida;
        private Label lblTipoComida;
        private ComboBox cbxTipoComida;
        private Button btnUpdateComida;
        private Button btnDeleteComida;
        private Button btnLimpiarDataGrid;
        private Label lblTitleGestor;
    }
}