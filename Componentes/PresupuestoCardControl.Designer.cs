namespace EventoPresupuestado.Componentes
{
    partial class PresupuestoCardControl
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
            tlpContainerCard = new TableLayoutPanel();
            pnlBadgeId = new Panel();
            lblIDPresupuesto = new Label();
            pnlBadgeEstado = new Panel();
            lblPointEstado = new Label();
            lblStatePresupuesto = new Label();
            lblNombrePresupuesto = new Label();
            pnlContainerAll.SuspendLayout();
            tlpContainerCard.SuspendLayout();
            pnlBadgeId.SuspendLayout();
            pnlBadgeEstado.SuspendLayout();
            SuspendLayout();
            // 
            // pnlContainerAll
            // 
            pnlContainerAll.Controls.Add(tlpContainerCard);
            pnlContainerAll.Dock = DockStyle.Fill;
            pnlContainerAll.Location = new Point(0, 0);
            pnlContainerAll.Name = "pnlContainerAll";
            pnlContainerAll.Padding = new Padding(12, 10, 12, 10);
            pnlContainerAll.Size = new Size(300, 125);
            pnlContainerAll.TabIndex = 0;
            // 
            // tlpContainerCard
            // 
            tlpContainerCard.ColumnCount = 3;
            tlpContainerCard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tlpContainerCard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tlpContainerCard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tlpContainerCard.Controls.Add(pnlBadgeId, 0, 0);
            tlpContainerCard.Controls.Add(lblNombrePresupuesto, 0, 1);
            tlpContainerCard.Controls.Add(pnlBadgeEstado, 2, 0);
            tlpContainerCard.Dock = DockStyle.Fill;
            tlpContainerCard.Location = new Point(12, 10);
            tlpContainerCard.Name = "tlpContainerCard";
            tlpContainerCard.RowCount = 5;
            tlpContainerCard.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tlpContainerCard.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpContainerCard.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpContainerCard.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpContainerCard.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpContainerCard.Size = new Size(276, 105);
            tlpContainerCard.TabIndex = 0;
            // 
            // pnlBadgeId
            // 
            pnlBadgeId.Anchor = AnchorStyles.Left;
            pnlBadgeId.BackColor = Color.FromArgb(238, 242, 255);
            pnlBadgeId.Controls.Add(lblIDPresupuesto);
            pnlBadgeId.Location = new Point(3, 3);
            pnlBadgeId.Name = "pnlBadgeId";
            pnlBadgeId.Size = new Size(42, 20);
            pnlBadgeId.TabIndex = 2;
            // 
            // lblIDPresupuesto
            // 
            lblIDPresupuesto.Dock = DockStyle.Fill;
            lblIDPresupuesto.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblIDPresupuesto.ForeColor = Color.FromArgb(37, 99, 235);
            lblIDPresupuesto.Location = new Point(0, 0);
            lblIDPresupuesto.Name = "lblIDPresupuesto";
            lblIDPresupuesto.Size = new Size(42, 20);
            lblIDPresupuesto.TabIndex = 2;
            lblIDPresupuesto.Text = "#01";
            lblIDPresupuesto.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlBadgeEstado
            // 
            pnlBadgeEstado.Anchor = AnchorStyles.Right;
            pnlBadgeEstado.BackColor = Color.FromArgb(248, 250, 252);
            pnlBadgeEstado.Controls.Add(lblStatePresupuesto);
            pnlBadgeEstado.Controls.Add(lblPointEstado);
            pnlBadgeEstado.ForeColor = SystemColors.ControlText;
            pnlBadgeEstado.Location = new Point(181, 3);
            pnlBadgeEstado.Name = "pnlBadgeEstado";
            pnlBadgeEstado.Size = new Size(92, 20);
            pnlBadgeEstado.TabIndex = 3;
            // 
            // lblPointEstado
            // 
            lblPointEstado.Dock = DockStyle.Left;
            lblPointEstado.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPointEstado.ForeColor = Color.FromArgb(37, 99, 235);
            lblPointEstado.Location = new Point(0, 0);
            lblPointEstado.MinimumSize = new Size(20, 0);
            lblPointEstado.Name = "lblPointEstado";
            lblPointEstado.Size = new Size(20, 20);
            lblPointEstado.TabIndex = 0;
            lblPointEstado.Text = "●";
            lblPointEstado.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblStatePresupuesto
            // 
            lblStatePresupuesto.Dock = DockStyle.Fill;
            lblStatePresupuesto.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblStatePresupuesto.ForeColor = Color.FromArgb(51, 65, 85);
            lblStatePresupuesto.Location = new Point(20, 0);
            lblStatePresupuesto.Name = "lblStatePresupuesto";
            lblStatePresupuesto.Padding = new Padding(2, 0, 0, 0);
            lblStatePresupuesto.Size = new Size(72, 20);
            lblStatePresupuesto.TabIndex = 3;
            lblStatePresupuesto.Text = "En Proceso";
            lblStatePresupuesto.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblNombrePresupuesto
            // 
            lblNombrePresupuesto.AutoEllipsis = true;
            lblNombrePresupuesto.AutoSize = true;
            tlpContainerCard.SetColumnSpan(lblNombrePresupuesto, 3);
            lblNombrePresupuesto.Dock = DockStyle.Fill;
            lblNombrePresupuesto.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNombrePresupuesto.ForeColor = Color.FromArgb(15, 23, 42);
            lblNombrePresupuesto.Location = new Point(3, 26);
            lblNombrePresupuesto.Name = "lblNombrePresupuesto";
            lblNombrePresupuesto.Size = new Size(270, 19);
            lblNombrePresupuesto.TabIndex = 4;
            lblNombrePresupuesto.Text = "Cumpleaños López";
            lblNombrePresupuesto.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // PresupuestoCardControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlContainerAll);
            Name = "PresupuestoCardControl";
            Size = new Size(300, 125);
            pnlContainerAll.ResumeLayout(false);
            tlpContainerCard.ResumeLayout(false);
            tlpContainerCard.PerformLayout();
            pnlBadgeId.ResumeLayout(false);
            pnlBadgeEstado.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlContainerAll;
        private TableLayoutPanel tlpContainerCard;
        private Panel pnlBadgeId;
        private Label lblIDPresupuesto;
        private Panel pnlBadgeEstado;
        private Label lblPointEstado;
        private Label lblStatePresupuesto;
        private Label lblNombrePresupuesto;
    }
}
