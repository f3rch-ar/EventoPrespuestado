namespace EventoPresupuestado.Componentes
{
    partial class TipoMenuCardControl
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
            tlpContainer = new TableLayoutPanel();
            lblPrecioMenu = new Label();
            lblBebida = new Label();
            lblIconBebida = new Label();
            lblPostre = new Label();
            lblIconPostre = new Label();
            lblPlatoPrincipal = new Label();
            lblIconPlatoMain = new Label();
            lblEntrada = new Label();
            lblIconEntrada = new Label();
            lblMenuNombre = new Label();
            lblId = new Label();
            separator = new Panel();
            pnlContainerAll.SuspendLayout();
            tlpContainer.SuspendLayout();
            SuspendLayout();
            // 
            // pnlContainerAll
            // 
            pnlContainerAll.Controls.Add(tlpContainer);
            pnlContainerAll.Dock = DockStyle.Fill;
            pnlContainerAll.Location = new Point(0, 0);
            pnlContainerAll.Name = "pnlContainerAll";
            pnlContainerAll.Size = new Size(190, 114);
            pnlContainerAll.TabIndex = 0;
            // 
            // tlpContainer
            // 
            tlpContainer.ColumnCount = 2;
            tlpContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tlpContainer.Controls.Add(lblPrecioMenu, 0, 6);
            tlpContainer.Controls.Add(lblBebida, 1, 4);
            tlpContainer.Controls.Add(lblIconBebida, 0, 4);
            tlpContainer.Controls.Add(lblPostre, 1, 3);
            tlpContainer.Controls.Add(lblIconPostre, 0, 3);
            tlpContainer.Controls.Add(lblPlatoPrincipal, 1, 2);
            tlpContainer.Controls.Add(lblIconPlatoMain, 0, 2);
            tlpContainer.Controls.Add(lblEntrada, 1, 1);
            tlpContainer.Controls.Add(lblIconEntrada, 0, 1);
            tlpContainer.Controls.Add(lblMenuNombre, 1, 0);
            tlpContainer.Controls.Add(lblId, 0, 0);
            tlpContainer.Controls.Add(separator, 0, 5);
            tlpContainer.Dock = DockStyle.Fill;
            tlpContainer.Location = new Point(0, 0);
            tlpContainer.Name = "tlpContainer";
            tlpContainer.RowCount = 7;
            tlpContainer.RowStyles.Add(new RowStyle());
            tlpContainer.RowStyles.Add(new RowStyle());
            tlpContainer.RowStyles.Add(new RowStyle());
            tlpContainer.RowStyles.Add(new RowStyle());
            tlpContainer.RowStyles.Add(new RowStyle());
            tlpContainer.RowStyles.Add(new RowStyle());
            tlpContainer.RowStyles.Add(new RowStyle());
            tlpContainer.Size = new Size(190, 114);
            tlpContainer.TabIndex = 0;
            // 
            // lblPrecioMenu
            // 
            lblPrecioMenu.AutoSize = true;
            tlpContainer.SetColumnSpan(lblPrecioMenu, 2);
            lblPrecioMenu.Dock = DockStyle.Fill;
            lblPrecioMenu.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrecioMenu.Location = new Point(0, 85);
            lblPrecioMenu.Margin = new Padding(0);
            lblPrecioMenu.Name = "lblPrecioMenu";
            lblPrecioMenu.Size = new Size(190, 29);
            lblPrecioMenu.TabIndex = 15;
            lblPrecioMenu.Text = "$18.500";
            lblPrecioMenu.TextAlign = ContentAlignment.TopRight;
            // 
            // lblBebida
            // 
            lblBebida.Dock = DockStyle.Bottom;
            lblBebida.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBebida.ForeColor = Color.FromArgb(51, 65, 85);
            lblBebida.Location = new Point(38, 64);
            lblBebida.Margin = new Padding(0);
            lblBebida.Name = "lblBebida";
            lblBebida.Size = new Size(152, 12);
            lblBebida.TabIndex = 11;
            lblBebida.Text = "Vino Tinto";
            lblBebida.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblIconBebida
            // 
            lblIconBebida.Dock = DockStyle.Bottom;
            lblIconBebida.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIconBebida.ForeColor = Color.FromArgb(51, 65, 85);
            lblIconBebida.Location = new Point(0, 64);
            lblIconBebida.Margin = new Padding(0);
            lblIconBebida.Name = "lblIconBebida";
            lblIconBebida.Size = new Size(38, 12);
            lblIconBebida.TabIndex = 10;
            lblIconBebida.Text = "\U0001f964";
            lblIconBebida.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblPostre
            // 
            lblPostre.Dock = DockStyle.Bottom;
            lblPostre.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPostre.ForeColor = Color.FromArgb(51, 65, 85);
            lblPostre.Location = new Point(38, 52);
            lblPostre.Margin = new Padding(0);
            lblPostre.Name = "lblPostre";
            lblPostre.Size = new Size(152, 12);
            lblPostre.TabIndex = 9;
            lblPostre.Text = "Budin de Pan";
            lblPostre.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblIconPostre
            // 
            lblIconPostre.Dock = DockStyle.Bottom;
            lblIconPostre.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIconPostre.ForeColor = Color.FromArgb(51, 65, 85);
            lblIconPostre.Location = new Point(0, 52);
            lblIconPostre.Margin = new Padding(0);
            lblIconPostre.Name = "lblIconPostre";
            lblIconPostre.Size = new Size(38, 12);
            lblIconPostre.TabIndex = 8;
            lblIconPostre.Text = "🍰";
            lblIconPostre.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblPlatoPrincipal
            // 
            lblPlatoPrincipal.Dock = DockStyle.Bottom;
            lblPlatoPrincipal.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPlatoPrincipal.ForeColor = Color.FromArgb(51, 65, 85);
            lblPlatoPrincipal.Location = new Point(38, 40);
            lblPlatoPrincipal.Margin = new Padding(0);
            lblPlatoPrincipal.Name = "lblPlatoPrincipal";
            lblPlatoPrincipal.Size = new Size(152, 12);
            lblPlatoPrincipal.TabIndex = 7;
            lblPlatoPrincipal.Text = "Asado Completo";
            lblPlatoPrincipal.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblIconPlatoMain
            // 
            lblIconPlatoMain.Dock = DockStyle.Bottom;
            lblIconPlatoMain.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIconPlatoMain.ForeColor = Color.FromArgb(51, 65, 85);
            lblIconPlatoMain.Location = new Point(0, 40);
            lblIconPlatoMain.Margin = new Padding(0);
            lblIconPlatoMain.Name = "lblIconPlatoMain";
            lblIconPlatoMain.Size = new Size(38, 12);
            lblIconPlatoMain.TabIndex = 6;
            lblIconPlatoMain.Text = "🍝";
            lblIconPlatoMain.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblEntrada
            // 
            lblEntrada.Dock = DockStyle.Bottom;
            lblEntrada.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEntrada.ForeColor = Color.FromArgb(51, 65, 85);
            lblEntrada.Location = new Point(38, 28);
            lblEntrada.Margin = new Padding(0);
            lblEntrada.Name = "lblEntrada";
            lblEntrada.Size = new Size(152, 12);
            lblEntrada.TabIndex = 5;
            lblEntrada.Text = "Ensalda Cessar";
            lblEntrada.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblIconEntrada
            // 
            lblIconEntrada.Dock = DockStyle.Bottom;
            lblIconEntrada.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIconEntrada.ForeColor = Color.FromArgb(51, 65, 85);
            lblIconEntrada.Location = new Point(0, 28);
            lblIconEntrada.Margin = new Padding(0);
            lblIconEntrada.Name = "lblIconEntrada";
            lblIconEntrada.Size = new Size(38, 12);
            lblIconEntrada.TabIndex = 4;
            lblIconEntrada.Text = "🍢";
            lblIconEntrada.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblMenuNombre
            // 
            lblMenuNombre.Dock = DockStyle.Fill;
            lblMenuNombre.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMenuNombre.Location = new Point(38, 0);
            lblMenuNombre.Margin = new Padding(0, 0, 0, 3);
            lblMenuNombre.Name = "lblMenuNombre";
            lblMenuNombre.Size = new Size(152, 25);
            lblMenuNombre.TabIndex = 3;
            lblMenuNombre.Text = "Menú Vegetariano";
            lblMenuNombre.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblId
            // 
            lblId.Dock = DockStyle.Left;
            lblId.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblId.ForeColor = Color.FromArgb(148, 163, 184);
            lblId.Location = new Point(0, 0);
            lblId.Margin = new Padding(0, 0, 0, 3);
            lblId.Name = "lblId";
            lblId.Size = new Size(38, 25);
            lblId.TabIndex = 1;
            lblId.Text = "#01";
            lblId.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // separator
            // 
            separator.BackColor = Color.Gainsboro;
            tlpContainer.SetColumnSpan(separator, 2);
            separator.Dock = DockStyle.Top;
            separator.Location = new Point(5, 81);
            separator.Margin = new Padding(5, 5, 5, 2);
            separator.Name = "separator";
            separator.Size = new Size(180, 2);
            separator.TabIndex = 16;
            // 
            // TipoMenuCardControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(pnlContainerAll);
            Name = "TipoMenuCardControl";
            Size = new Size(190, 114);
            pnlContainerAll.ResumeLayout(false);
            tlpContainer.ResumeLayout(false);
            tlpContainer.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlContainerAll;
        private TableLayoutPanel tlpContainer;
        private Label lblId;
        private Label lblMenuNombre;
        private Label lblIconEntrada;
        private Label lblBebida;
        private Label lblIconBebida;
        private Label lblPostre;
        private Label lblIconPostre;
        private Label lblPlatoPrincipal;
        private Label lblIconPlatoMain;
        private Label lblEntrada;
        private Label lblPrecioMenu;
        private Panel separator;
    }
}
