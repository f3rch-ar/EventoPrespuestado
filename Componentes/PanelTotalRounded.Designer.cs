namespace EventoPresupuestado.Componentes
{
    partial class PanelTotalRounded
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
            pnlContainer = new Panel();
            tlpMain = new TableLayoutPanel();
            lblTitulo = new Label();
            lblMonto = new Label();
            pnlContainer.SuspendLayout();
            tlpMain.SuspendLayout();
            SuspendLayout();
            // 
            // pnlContainer
            // 
            pnlContainer.BackColor = Color.White;
            pnlContainer.Controls.Add(tlpMain);
            pnlContainer.Dock = DockStyle.Fill;
            pnlContainer.Location = new Point(0, 0);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Padding = new Padding(8);
            pnlContainer.Size = new Size(207, 73);
            pnlContainer.TabIndex = 0;
            // 
            // tlpMain
            // 
            tlpMain.BackColor = Color.Transparent;
            tlpMain.ColumnCount = 1;
            tlpMain.ColumnStyles.Add(new ColumnStyle());
            tlpMain.Controls.Add(lblTitulo, 0, 0);
            tlpMain.Controls.Add(lblMonto, 0, 1);
            tlpMain.Dock = DockStyle.Fill;
            tlpMain.Location = new Point(8, 8);
            tlpMain.Name = "tlpMain";
            tlpMain.RowCount = 2;
            tlpMain.RowStyles.Add(new RowStyle());
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMain.Size = new Size(191, 57);
            tlpMain.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.None;
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.FromArgb(71, 85, 105);
            lblTitulo.Location = new Point(8, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(175, 17);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "VALOR TOTAL CALCULADO";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMonto
            // 
            lblMonto.Anchor = AnchorStyles.None;
            lblMonto.AutoSize = true;
            lblMonto.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblMonto.ForeColor = Color.FromArgb(30, 41, 59);
            lblMonto.Location = new Point(31, 17);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(128, 40);
            lblMonto.TabIndex = 1;
            lblMonto.Text = "$18.500";
            lblMonto.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PanelTotalRounded
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlContainer);
            Name = "PanelTotalRounded";
            Size = new Size(207, 73);
            pnlContainer.ResumeLayout(false);
            tlpMain.ResumeLayout(false);
            tlpMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlContainer;
        private TableLayoutPanel tlpMain;
        private Label lblTitulo;
        private Label lblMonto;
    }
}
