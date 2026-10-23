namespace EventoPresupuestado.View
{
    partial class ViewConfig
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
            pnlContainerAll = new Panel();
            tlpMain = new TableLayoutPanel();
            gbSeguridadAdmin = new GroupBox();
            tlpSeguridad = new TableLayoutPanel();
            txtEmailRecup = new TextBox();
            lineSeparator = new LineShadow();
            btnGuardarNewPass = new Button();
            txtConfirmPass = new TextBox();
            lblConfirmPass = new Label();
            lblNewPass = new Label();
            txtNewPass = new TextBox();
            lblPassActual = new Label();
            txtPassActual = new TextBox();
            lblEmailRecup = new Label();
            btnGuardarEmail = new Button();
            gbMoodAdmin = new GroupBox();
            tlpMoodAdmin = new TableLayoutPanel();
            btnActivateAdmin = new Button();
            lblIngresePass = new Label();
            txtIngresePassAdmin = new TextBox();
            lblTypeUser = new Label();
            lblEstadoSistema = new Label();
            gbPreferincias = new GroupBox();
            tlpPreferencias = new TableLayoutPanel();
            chbSound = new CheckBox();
            chbMoodNocturne = new CheckBox();
            chbShowInactivos = new CheckBox();
            pnlContainerAll.SuspendLayout();
            tlpMain.SuspendLayout();
            gbSeguridadAdmin.SuspendLayout();
            tlpSeguridad.SuspendLayout();
            gbMoodAdmin.SuspendLayout();
            tlpMoodAdmin.SuspendLayout();
            gbPreferincias.SuspendLayout();
            tlpPreferencias.SuspendLayout();
            SuspendLayout();
            // 
            // pnlContainerAll
            // 
            pnlContainerAll.AutoScroll = true;
            pnlContainerAll.Controls.Add(tlpMain);
            pnlContainerAll.Dock = DockStyle.Fill;
            pnlContainerAll.Location = new Point(0, 0);
            pnlContainerAll.Name = "pnlContainerAll";
            pnlContainerAll.Size = new Size(800, 622);
            pnlContainerAll.TabIndex = 0;
            // 
            // tlpMain
            // 
            tlpMain.AutoScroll = true;
            tlpMain.ColumnCount = 1;
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpMain.Controls.Add(gbSeguridadAdmin, 0, 2);
            tlpMain.Controls.Add(gbMoodAdmin, 0, 1);
            tlpMain.Controls.Add(gbPreferincias, 0, 0);
            tlpMain.Dock = DockStyle.Fill;
            tlpMain.Location = new Point(0, 0);
            tlpMain.Margin = new Padding(10);
            tlpMain.Name = "tlpMain";
            tlpMain.Padding = new Padding(10);
            tlpMain.RowCount = 3;
            tlpMain.RowStyles.Add(new RowStyle());
            tlpMain.RowStyles.Add(new RowStyle());
            tlpMain.RowStyles.Add(new RowStyle());
            tlpMain.Size = new Size(800, 622);
            tlpMain.TabIndex = 0;
            // 
            // gbSeguridadAdmin
            // 
            gbSeguridadAdmin.Controls.Add(tlpSeguridad);
            gbSeguridadAdmin.Dock = DockStyle.Top;
            gbSeguridadAdmin.Font = new Font("Segoe UI", 15F);
            gbSeguridadAdmin.Location = new Point(13, 276);
            gbSeguridadAdmin.Name = "gbSeguridadAdmin";
            gbSeguridadAdmin.Padding = new Padding(10);
            gbSeguridadAdmin.Size = new Size(774, 291);
            gbSeguridadAdmin.TabIndex = 2;
            gbSeguridadAdmin.TabStop = false;
            gbSeguridadAdmin.Text = "Seguridad del Administrador";
            // 
            // tlpSeguridad
            // 
            tlpSeguridad.ColumnCount = 2;
            tlpSeguridad.ColumnStyles.Add(new ColumnStyle());
            tlpSeguridad.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpSeguridad.Controls.Add(txtEmailRecup, 1, 5);
            tlpSeguridad.Controls.Add(lineSeparator, 0, 4);
            tlpSeguridad.Controls.Add(btnGuardarNewPass, 1, 3);
            tlpSeguridad.Controls.Add(txtConfirmPass, 1, 2);
            tlpSeguridad.Controls.Add(lblConfirmPass, 0, 2);
            tlpSeguridad.Controls.Add(lblNewPass, 0, 1);
            tlpSeguridad.Controls.Add(txtNewPass, 1, 1);
            tlpSeguridad.Controls.Add(lblPassActual, 0, 0);
            tlpSeguridad.Controls.Add(txtPassActual, 1, 0);
            tlpSeguridad.Controls.Add(lblEmailRecup, 0, 5);
            tlpSeguridad.Controls.Add(btnGuardarEmail, 1, 6);
            tlpSeguridad.Dock = DockStyle.Fill;
            tlpSeguridad.Location = new Point(10, 37);
            tlpSeguridad.Name = "tlpSeguridad";
            tlpSeguridad.RowCount = 7;
            tlpSeguridad.RowStyles.Add(new RowStyle());
            tlpSeguridad.RowStyles.Add(new RowStyle());
            tlpSeguridad.RowStyles.Add(new RowStyle());
            tlpSeguridad.RowStyles.Add(new RowStyle());
            tlpSeguridad.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpSeguridad.RowStyles.Add(new RowStyle());
            tlpSeguridad.RowStyles.Add(new RowStyle());
            tlpSeguridad.Size = new Size(754, 244);
            tlpSeguridad.TabIndex = 0;
            // 
            // txtEmailRecup
            // 
            txtEmailRecup.BorderStyle = BorderStyle.None;
            txtEmailRecup.Dock = DockStyle.Fill;
            txtEmailRecup.Font = new Font("Segoe UI", 12F);
            txtEmailRecup.Location = new Point(136, 154);
            txtEmailRecup.MaximumSize = new Size(0, 24);
            txtEmailRecup.Name = "txtEmailRecup";
            txtEmailRecup.Size = new Size(615, 22);
            txtEmailRecup.TabIndex = 16;
            // 
            // lineSeparator
            // 
            lineSeparator.BackColor = Color.Transparent;
            lineSeparator.ColorSombra = Color.FromArgb(20, 0, 0, 0);
            tlpSeguridad.SetColumnSpan(lineSeparator, 2);
            lineSeparator.Dock = DockStyle.Top;
            lineSeparator.Location = new Point(5, 137);
            lineSeparator.Margin = new Padding(5, 6, 5, 6);
            lineSeparator.Name = "lineSeparator";
            lineSeparator.Orientacion = LineShadow.DireccionSombra.Abajo;
            lineSeparator.Size = new Size(744, 7);
            lineSeparator.TabIndex = 14;
            // 
            // btnGuardarNewPass
            // 
            btnGuardarNewPass.Anchor = AnchorStyles.Right;
            btnGuardarNewPass.Font = new Font("Segoe UI", 9F);
            btnGuardarNewPass.Location = new Point(531, 89);
            btnGuardarNewPass.Margin = new Padding(3, 5, 3, 10);
            btnGuardarNewPass.Name = "btnGuardarNewPass";
            btnGuardarNewPass.Size = new Size(220, 32);
            btnGuardarNewPass.TabIndex = 12;
            btnGuardarNewPass.Text = "Actualizar Contraseña Nueva";
            btnGuardarNewPass.UseVisualStyleBackColor = true;
            btnGuardarNewPass.Click += btnGuardarNewPass_Click;
            // 
            // txtConfirmPass
            // 
            txtConfirmPass.BorderStyle = BorderStyle.None;
            txtConfirmPass.Dock = DockStyle.Fill;
            txtConfirmPass.Font = new Font("Segoe UI", 12F);
            txtConfirmPass.Location = new Point(136, 59);
            txtConfirmPass.MaximumSize = new Size(0, 24);
            txtConfirmPass.Name = "txtConfirmPass";
            txtConfirmPass.Size = new Size(615, 22);
            txtConfirmPass.TabIndex = 11;
            txtConfirmPass.UseSystemPasswordChar = true;
            // 
            // lblConfirmPass
            // 
            lblConfirmPass.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblConfirmPass.AutoSize = true;
            lblConfirmPass.Font = new Font("Segoe UI", 9F);
            lblConfirmPass.Location = new Point(3, 62);
            lblConfirmPass.Name = "lblConfirmPass";
            lblConfirmPass.Size = new Size(127, 15);
            lblConfirmPass.TabIndex = 10;
            lblConfirmPass.Text = "Confirmar Contraseña:";
            lblConfirmPass.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNewPass
            // 
            lblNewPass.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblNewPass.AutoSize = true;
            lblNewPass.Font = new Font("Segoe UI", 9F);
            lblNewPass.Location = new Point(3, 34);
            lblNewPass.Name = "lblNewPass";
            lblNewPass.Size = new Size(127, 15);
            lblNewPass.TabIndex = 9;
            lblNewPass.Text = "Nueva Contraseña:";
            lblNewPass.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtNewPass
            // 
            txtNewPass.BorderStyle = BorderStyle.None;
            txtNewPass.Dock = DockStyle.Fill;
            txtNewPass.Font = new Font("Segoe UI", 12F);
            txtNewPass.Location = new Point(136, 31);
            txtNewPass.MaximumSize = new Size(0, 24);
            txtNewPass.Name = "txtNewPass";
            txtNewPass.Size = new Size(615, 22);
            txtNewPass.TabIndex = 8;
            txtNewPass.UseSystemPasswordChar = true;
            // 
            // lblPassActual
            // 
            lblPassActual.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblPassActual.AutoSize = true;
            lblPassActual.Font = new Font("Segoe UI", 9F);
            lblPassActual.Location = new Point(3, 6);
            lblPassActual.Name = "lblPassActual";
            lblPassActual.Size = new Size(127, 15);
            lblPassActual.TabIndex = 6;
            lblPassActual.Text = "Contraseña Actual:";
            lblPassActual.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtPassActual
            // 
            txtPassActual.BorderStyle = BorderStyle.None;
            txtPassActual.Dock = DockStyle.Fill;
            txtPassActual.Font = new Font("Segoe UI", 12F);
            txtPassActual.Location = new Point(136, 3);
            txtPassActual.MaximumSize = new Size(0, 24);
            txtPassActual.Name = "txtPassActual";
            txtPassActual.Size = new Size(615, 22);
            txtPassActual.TabIndex = 7;
            txtPassActual.UseSystemPasswordChar = true;
            // 
            // lblEmailRecup
            // 
            lblEmailRecup.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblEmailRecup.AutoSize = true;
            lblEmailRecup.Font = new Font("Segoe UI", 9F);
            lblEmailRecup.Location = new Point(3, 157);
            lblEmailRecup.Name = "lblEmailRecup";
            lblEmailRecup.Size = new Size(127, 15);
            lblEmailRecup.TabIndex = 15;
            lblEmailRecup.Text = "Correo Electronico:";
            lblEmailRecup.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnGuardarEmail
            // 
            btnGuardarEmail.Anchor = AnchorStyles.Right;
            btnGuardarEmail.Font = new Font("Segoe UI", 9F);
            btnGuardarEmail.Location = new Point(531, 193);
            btnGuardarEmail.Margin = new Padding(3, 5, 3, 10);
            btnGuardarEmail.Name = "btnGuardarEmail";
            btnGuardarEmail.Size = new Size(220, 32);
            btnGuardarEmail.TabIndex = 17;
            btnGuardarEmail.Text = "Actualizar Correo Electronico";
            btnGuardarEmail.UseVisualStyleBackColor = true;
            btnGuardarEmail.Click += btnGuardarEmail_Click;
            // 
            // gbMoodAdmin
            // 
            gbMoodAdmin.Controls.Add(tlpMoodAdmin);
            gbMoodAdmin.Dock = DockStyle.Top;
            gbMoodAdmin.Font = new Font("Segoe UI", 15F);
            gbMoodAdmin.Location = new Point(13, 119);
            gbMoodAdmin.Name = "gbMoodAdmin";
            gbMoodAdmin.Padding = new Padding(10);
            gbMoodAdmin.RightToLeft = RightToLeft.Yes;
            gbMoodAdmin.Size = new Size(774, 151);
            gbMoodAdmin.TabIndex = 1;
            gbMoodAdmin.TabStop = false;
            gbMoodAdmin.Text = "Control de Acceso y Privilegios";
            // 
            // tlpMoodAdmin
            // 
            tlpMoodAdmin.ColumnCount = 2;
            tlpMoodAdmin.ColumnStyles.Add(new ColumnStyle());
            tlpMoodAdmin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpMoodAdmin.Controls.Add(btnActivateAdmin, 1, 2);
            tlpMoodAdmin.Controls.Add(lblIngresePass, 0, 1);
            tlpMoodAdmin.Controls.Add(txtIngresePassAdmin, 1, 1);
            tlpMoodAdmin.Controls.Add(lblTypeUser, 1, 0);
            tlpMoodAdmin.Controls.Add(lblEstadoSistema, 0, 0);
            tlpMoodAdmin.Dock = DockStyle.Fill;
            tlpMoodAdmin.Location = new Point(10, 37);
            tlpMoodAdmin.Name = "tlpMoodAdmin";
            tlpMoodAdmin.RightToLeft = RightToLeft.No;
            tlpMoodAdmin.RowCount = 1;
            tlpMoodAdmin.RowStyles.Add(new RowStyle());
            tlpMoodAdmin.RowStyles.Add(new RowStyle());
            tlpMoodAdmin.RowStyles.Add(new RowStyle());
            tlpMoodAdmin.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpMoodAdmin.Size = new Size(754, 104);
            tlpMoodAdmin.TabIndex = 0;
            // 
            // btnActivateAdmin
            // 
            btnActivateAdmin.Anchor = AnchorStyles.Right;
            btnActivateAdmin.Enabled = false;
            btnActivateAdmin.Font = new Font("Segoe UI", 9F);
            btnActivateAdmin.Location = new Point(531, 55);
            btnActivateAdmin.Margin = new Padding(3, 5, 3, 10);
            btnActivateAdmin.Name = "btnActivateAdmin";
            btnActivateAdmin.Size = new Size(220, 32);
            btnActivateAdmin.TabIndex = 13;
            btnActivateAdmin.Text = "Activar Modo Administrador";
            btnActivateAdmin.UseVisualStyleBackColor = true;
            btnActivateAdmin.Click += btnActivateAdmin_Click;
            // 
            // lblIngresePass
            // 
            lblIngresePass.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblIngresePass.AutoSize = true;
            lblIngresePass.Font = new Font("Segoe UI", 9F);
            lblIngresePass.Location = new Point(3, 21);
            lblIngresePass.Name = "lblIngresePass";
            lblIngresePass.Size = new Size(125, 15);
            lblIngresePass.TabIndex = 10;
            lblIngresePass.Text = "Contraseña de Admin:";
            lblIngresePass.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtIngresePassAdmin
            // 
            txtIngresePassAdmin.BorderStyle = BorderStyle.None;
            txtIngresePassAdmin.Dock = DockStyle.Fill;
            txtIngresePassAdmin.Font = new Font("Segoe UI", 12F);
            txtIngresePassAdmin.Location = new Point(134, 18);
            txtIngresePassAdmin.MaximumSize = new Size(0, 24);
            txtIngresePassAdmin.Name = "txtIngresePassAdmin";
            txtIngresePassAdmin.Size = new Size(617, 22);
            txtIngresePassAdmin.TabIndex = 9;
            txtIngresePassAdmin.UseSystemPasswordChar = true;
            txtIngresePassAdmin.TextChanged += txtIngresePassAdmin_TextChanged;
            // 
            // lblTypeUser
            // 
            lblTypeUser.AutoSize = true;
            lblTypeUser.Dock = DockStyle.Fill;
            lblTypeUser.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTypeUser.Location = new Point(134, 0);
            lblTypeUser.Name = "lblTypeUser";
            lblTypeUser.Size = new Size(617, 15);
            lblTypeUser.TabIndex = 6;
            lblTypeUser.Text = "Usuario Común";
            lblTypeUser.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblEstadoSistema
            // 
            lblEstadoSistema.AutoSize = true;
            lblEstadoSistema.Dock = DockStyle.Fill;
            lblEstadoSistema.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEstadoSistema.Location = new Point(3, 0);
            lblEstadoSistema.Name = "lblEstadoSistema";
            lblEstadoSistema.Size = new Size(125, 15);
            lblEstadoSistema.TabIndex = 5;
            lblEstadoSistema.Text = "Estado del Sistema:";
            lblEstadoSistema.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gbPreferincias
            // 
            gbPreferincias.Controls.Add(tlpPreferencias);
            gbPreferincias.Dock = DockStyle.Top;
            gbPreferincias.Font = new Font("Segoe UI", 15F);
            gbPreferincias.Location = new Point(13, 13);
            gbPreferincias.Name = "gbPreferincias";
            gbPreferincias.Padding = new Padding(10);
            gbPreferincias.Size = new Size(774, 100);
            gbPreferincias.TabIndex = 0;
            gbPreferincias.TabStop = false;
            gbPreferincias.Text = "Preferencias de Usuario";
            // 
            // tlpPreferencias
            // 
            tlpPreferencias.ColumnCount = 2;
            tlpPreferencias.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpPreferencias.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpPreferencias.Controls.Add(chbSound, 0, 0);
            tlpPreferencias.Controls.Add(chbMoodNocturne, 0, 1);
            tlpPreferencias.Controls.Add(chbShowInactivos, 1, 0);
            tlpPreferencias.Dock = DockStyle.Fill;
            tlpPreferencias.Location = new Point(10, 37);
            tlpPreferencias.Name = "tlpPreferencias";
            tlpPreferencias.RowCount = 2;
            tlpPreferencias.RowStyles.Add(new RowStyle());
            tlpPreferencias.RowStyles.Add(new RowStyle());
            tlpPreferencias.Size = new Size(754, 53);
            tlpPreferencias.TabIndex = 0;
            // 
            // chbSound
            // 
            chbSound.AutoSize = true;
            chbSound.Font = new Font("Segoe UI", 9F);
            chbSound.Location = new Point(5, 4);
            chbSound.Margin = new Padding(5, 4, 5, 4);
            chbSound.Name = "chbSound";
            chbSound.Size = new Size(167, 19);
            chbSound.TabIndex = 4;
            chbSound.Text = "Habilitar efectos de sonido";
            chbSound.UseVisualStyleBackColor = true;
            // 
            // chbMoodNocturne
            // 
            chbMoodNocturne.AutoSize = true;
            chbMoodNocturne.Font = new Font("Segoe UI", 9F);
            chbMoodNocturne.Location = new Point(5, 31);
            chbMoodNocturne.Margin = new Padding(5, 4, 5, 4);
            chbMoodNocturne.Name = "chbMoodNocturne";
            chbMoodNocturne.Size = new Size(232, 19);
            chbMoodNocturne.TabIndex = 1;
            chbMoodNocturne.Text = "Activar Modo Nocturno (Tema Oscuro)";
            chbMoodNocturne.UseVisualStyleBackColor = true;
            // 
            // chbShowInactivos
            // 
            chbShowInactivos.AutoSize = true;
            chbShowInactivos.Enabled = false;
            chbShowInactivos.Font = new Font("Segoe UI", 9F);
            chbShowInactivos.Location = new Point(382, 4);
            chbShowInactivos.Margin = new Padding(5, 4, 5, 4);
            chbShowInactivos.Name = "chbShowInactivos";
            chbShowInactivos.Size = new Size(250, 19);
            chbShowInactivos.TabIndex = 2;
            chbShowInactivos.Text = "Mostrar registros inactivos (Dados de baja)";
            chbShowInactivos.UseVisualStyleBackColor = true;
            chbShowInactivos.CheckedChanged += chbShowInactivos_CheckedChanged;
            // 
            // ViewConfig
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(800, 622);
            ControlBox = false;
            Controls.Add(pnlContainerAll);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "ViewConfig";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "ViewHome";
            pnlContainerAll.ResumeLayout(false);
            tlpMain.ResumeLayout(false);
            gbSeguridadAdmin.ResumeLayout(false);
            tlpSeguridad.ResumeLayout(false);
            tlpSeguridad.PerformLayout();
            gbMoodAdmin.ResumeLayout(false);
            tlpMoodAdmin.ResumeLayout(false);
            tlpMoodAdmin.PerformLayout();
            gbPreferincias.ResumeLayout(false);
            tlpPreferencias.ResumeLayout(false);
            tlpPreferencias.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlContainerAll;
        private TableLayoutPanel tlpMain;
        private GroupBox gbPreferincias;
        private CheckBox chbMoodNocturne;
        private CheckBox chbShowInactivos;
        private TableLayoutPanel tlpPreferencias;
        private CheckBox chbSound;
        private GroupBox gbMoodAdmin;
        private TableLayoutPanel tlpMoodAdmin;
        private Label lblEstadoSistema;
        private Label lblTypeUser;
        private GroupBox gbSeguridadAdmin;
        private TableLayoutPanel tlpSeguridad;
        private Label lblPassActual;
        private TextBox txtPassActual;
        private TextBox txtConfirmPass;
        private Label lblConfirmPass;
        private Label lblNewPass;
        private TextBox txtNewPass;
        private Button btnGuardarNewPass;
        private LineShadow lineSeparator;
        private Label lblEmailRecup;
        private TextBox txtEmailRecup;
        private Button btnGuardarEmail;
        private Label lblIngresePass;
        private TextBox txtIngresePassAdmin;
        private Button btnActivateAdmin;
    }
}