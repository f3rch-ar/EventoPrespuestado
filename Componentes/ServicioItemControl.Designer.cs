namespace EventoPresupuestado.Componentes
{
    partial class ServicioItemControl
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
            lblValorServicio = new Label();
            lblNombreServicio = new Label();
            pnlBadgeId = new Panel();
            lblIdServicio = new Label();
            pnlContainerAll.SuspendLayout();
            pnlBadgeId.SuspendLayout();
            SuspendLayout();
            // 
            // pnlContainerAll
            // 
            pnlContainerAll.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlContainerAll.BackColor = Color.White;
            pnlContainerAll.BorderStyle = BorderStyle.FixedSingle;
            pnlContainerAll.Controls.Add(lblValorServicio);
            pnlContainerAll.Controls.Add(lblNombreServicio);
            pnlContainerAll.Controls.Add(pnlBadgeId);
            pnlContainerAll.Location = new Point(0, 0);
            pnlContainerAll.Name = "pnlContainerAll";
            pnlContainerAll.Size = new Size(800, 48);
            pnlContainerAll.TabIndex = 0;
            // 
            // lblValorServicio
            // 
            lblValorServicio.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblValorServicio.BackColor = Color.Transparent;
            lblValorServicio.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblValorServicio.ForeColor = Color.FromArgb(15, 23, 42);
            lblValorServicio.Location = new Point(685, 11);
            lblValorServicio.Name = "lblValorServicio";
            lblValorServicio.Size = new Size(100, 22);
            lblValorServicio.TabIndex = 2;
            lblValorServicio.Text = "$45.000";
            lblValorServicio.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblNombreServicio
            // 
            lblNombreServicio.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblNombreServicio.AutoSize = true;
            lblNombreServicio.BackColor = Color.Transparent;
            lblNombreServicio.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombreServicio.ForeColor = Color.FromArgb(15, 23, 42);
            lblNombreServicio.Location = new Point(75, 15);
            lblNombreServicio.Name = "lblNombreServicio";
            lblNombreServicio.Size = new Size(153, 17);
            lblNombreServicio.TabIndex = 1;
            lblNombreServicio.Text = "DJ y Control de Consola";
            // 
            // pnlBadgeId
            // 
            pnlBadgeId.BackColor = Color.FromArgb(224, 231, 255);
            pnlBadgeId.Controls.Add(lblIdServicio);
            pnlBadgeId.Location = new Point(12, 11);
            pnlBadgeId.Name = "pnlBadgeId";
            pnlBadgeId.Size = new Size(52, 26);
            pnlBadgeId.TabIndex = 0;
            // 
            // lblIdServicio
            // 
            lblIdServicio.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblIdServicio.BackColor = Color.Transparent;
            lblIdServicio.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblIdServicio.ForeColor = Color.FromArgb(30, 41, 59);
            lblIdServicio.Location = new Point(0, 0);
            lblIdServicio.Name = "lblIdServicio";
            lblIdServicio.Size = new Size(52, 26);
            lblIdServicio.TabIndex = 0;
            lblIdServicio.Text = "#01";
            lblIdServicio.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ServicioItemControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(pnlContainerAll);
            Name = "ServicioItemControl";
            Size = new Size(800, 48);
            pnlContainerAll.ResumeLayout(false);
            pnlContainerAll.PerformLayout();
            pnlBadgeId.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlContainerAll;
        private Panel pnlBadgeId;
        private Label lblIdServicio;
        private Label lblNombreServicio;
        private Label lblValorServicio;
    }
}
