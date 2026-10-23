namespace EventoPresupuestado.Componentes
{
    partial class LugarCardControl
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            pnlContainerAll = new Panel();
            tlpLayout = new TableLayoutPanel();
            pnlHeader = new Panel();
            lblBadgeState = new Label();
            lblId = new Label();
            picImageLugar = new PictureBox();
            lblNombre = new Label();
            lblDescription = new Label();
            pnlInfo = new Panel();
            lblPrecioBase = new Label();
            lblCapacidadMax = new Label();
            pnlContainerAll.SuspendLayout();
            tlpLayout.SuspendLayout();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picImageLugar).BeginInit();
            pnlInfo.SuspendLayout();
            SuspendLayout();
            // 
            // pnlContainerAll
            // 
            pnlContainerAll.BackColor = Color.White;
            pnlContainerAll.Controls.Add(tlpLayout);
            pnlContainerAll.Dock = DockStyle.Fill;
            pnlContainerAll.Location = new Point(0, 0);
            pnlContainerAll.Margin = new Padding(1);
            pnlContainerAll.Name = "pnlContainerAll";
            pnlContainerAll.Padding = new Padding(5);
            pnlContainerAll.Size = new Size(170, 170);
            pnlContainerAll.TabIndex = 0;
            // 
            // tlpLayout
            // 
            tlpLayout.ColumnCount = 1;
            tlpLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpLayout.Controls.Add(pnlHeader, 0, 0);
            tlpLayout.Controls.Add(picImageLugar, 0, 1);
            tlpLayout.Controls.Add(lblNombre, 0, 2);
            tlpLayout.Controls.Add(lblDescription, 0, 3);
            tlpLayout.Controls.Add(pnlInfo, 0, 4);
            tlpLayout.Dock = DockStyle.Fill;
            tlpLayout.Location = new Point(5, 5);
            tlpLayout.Name = "tlpLayout";
            tlpLayout.RowCount = 5;
            tlpLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tlpLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tlpLayout.RowStyles.Add(new RowStyle());
            tlpLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tlpLayout.Size = new Size(160, 160);
            tlpLayout.TabIndex = 0;
            // 
            // pnlHeader
            // 
            pnlHeader.Controls.Add(lblBadgeState);
            pnlHeader.Controls.Add(lblId);
            pnlHeader.Dock = DockStyle.Fill;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(0, 0, 0, 2);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(160, 13);
            pnlHeader.TabIndex = 0;
            // 
            // lblBadgeState
            // 
            lblBadgeState.Dock = DockStyle.Right;
            lblBadgeState.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblBadgeState.ForeColor = Color.Gray;
            lblBadgeState.Location = new Point(85, 0);
            lblBadgeState.Margin = new Padding(0, 2, 0, 2);
            lblBadgeState.MaximumSize = new Size(75, 24);
            lblBadgeState.Name = "lblBadgeState";
            lblBadgeState.Padding = new Padding(2, 0, 2, 0);
            lblBadgeState.Size = new Size(75, 13);
            lblBadgeState.TabIndex = 1;
            lblBadgeState.Text = "DISPONIBLE";
            lblBadgeState.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblId
            // 
            lblId.Dock = DockStyle.Left;
            lblId.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblId.ForeColor = Color.FromArgb(148, 163, 184);
            lblId.Location = new Point(0, 0);
            lblId.Margin = new Padding(0);
            lblId.Name = "lblId";
            lblId.Size = new Size(80, 13);
            lblId.TabIndex = 0;
            lblId.Text = "ID: #1";
            lblId.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // picImageLugar
            // 
            picImageLugar.BackColor = Color.FromArgb(248, 250, 252);
            picImageLugar.Dock = DockStyle.Fill;
            picImageLugar.Image = Restaurante_Menus.Properties.Resources.default_salon;
            picImageLugar.Location = new Point(0, 17);
            picImageLugar.Margin = new Padding(0, 2, 0, 4);
            picImageLugar.Name = "picImageLugar";
            picImageLugar.Size = new Size(160, 54);
            picImageLugar.SizeMode = PictureBoxSizeMode.StretchImage;
            picImageLugar.TabIndex = 1;
            picImageLugar.TabStop = false;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Dock = DockStyle.Fill;
            lblNombre.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblNombre.Location = new Point(0, 77);
            lblNombre.Margin = new Padding(0, 2, 0, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(160, 17);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "El Ismael Eventos";
            // 
            // lblDescription
            // 
            lblDescription.AutoEllipsis = true;
            lblDescription.AutoSize = true;
            lblDescription.Dock = DockStyle.Fill;
            lblDescription.Font = new Font("Segoe UI", 8F);
            lblDescription.ForeColor = Color.FromArgb(100, 116, 139);
            lblDescription.Location = new Point(0, 96);
            lblDescription.Margin = new Padding(0, 2, 0, 2);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(160, 34);
            lblDescription.TabIndex = 3;
            lblDescription.Text = "Amplio salón con vista al mar y pista de baile principal.";
            // 
            // pnlInfo
            // 
            pnlInfo.Controls.Add(lblPrecioBase);
            pnlInfo.Controls.Add(lblCapacidadMax);
            pnlInfo.Dock = DockStyle.Fill;
            pnlInfo.Location = new Point(0, 134);
            pnlInfo.Margin = new Padding(0, 2, 0, 2);
            pnlInfo.Name = "pnlInfo";
            pnlInfo.Size = new Size(160, 24);
            pnlInfo.TabIndex = 4;
            // 
            // lblPrecioBase
            // 
            lblPrecioBase.Dock = DockStyle.Top;
            lblPrecioBase.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblPrecioBase.ForeColor = Color.FromArgb(51, 65, 85);
            lblPrecioBase.Location = new Point(0, 12);
            lblPrecioBase.Margin = new Padding(0);
            lblPrecioBase.Name = "lblPrecioBase";
            lblPrecioBase.Size = new Size(160, 12);
            lblPrecioBase.TabIndex = 1;
            lblPrecioBase.Text = "💵 $ 150.000 / evento";
            // 
            // lblCapacidadMax
            // 
            lblCapacidadMax.Dock = DockStyle.Top;
            lblCapacidadMax.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblCapacidadMax.ForeColor = Color.FromArgb(51, 65, 85);
            lblCapacidadMax.Location = new Point(0, 0);
            lblCapacidadMax.Margin = new Padding(0);
            lblCapacidadMax.Name = "lblCapacidadMax";
            lblCapacidadMax.Size = new Size(160, 12);
            lblCapacidadMax.TabIndex = 0;
            lblCapacidadMax.Text = "👥 Max. 250 personas";
            // 
            // LugarCardControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(pnlContainerAll);
            Name = "LugarCardControl";
            Size = new Size(170, 170);
            pnlContainerAll.ResumeLayout(false);
            tlpLayout.ResumeLayout(false);
            tlpLayout.PerformLayout();
            pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picImageLugar).EndInit();
            pnlInfo.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlContainerAll;
        private TableLayoutPanel tlpLayout;
        private Panel pnlHeader;
        private Label lblBadgeState;
        private Label lblId;
        private PictureBox picImageLugar;
        private Label lblNombre;
        private Label lblDescription;
        private Panel pnlInfo;
        private Label lblPrecioBase;
        private Label lblCapacidadMax;
    }
}
