using EventoPresupuestado.Dto;
using EventoPresupuestado.RolControl;
using EventoPresupuestado.RolControl.helpers;
using EventoPresupuestado.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventoPresupuestado.View
{
    public partial class ViewConfig : Form
    {
        private readonly AdminMoodController _adminController;

        public ViewConfig()
        {
            InitializeComponent();

            _adminController = new AdminMoodController();

            ConfigurarEstadoInicialVista();
        }

        private void ConfigurarEstadoInicialVista()
        {
            bool primerUso = _adminController.isPrimerUso();

            if (primerUso)
            {
                // ESTADO PRIMER USO
                txtIngresePassAdmin.Enabled = false;
                btnActivateAdmin.Enabled = false;

                txtPassActual.Enabled = false;
                txtNewPass.Enabled = true;
                txtConfirmPass.Enabled = true;
                txtEmailRecup.Enabled = true;

                btnGuardarNewPass.Enabled = false;
                btnGuardarNewPass.Text = "Actualizar Contraseña";

                btnGuardarEmail.Enabled = true;
                btnGuardarEmail.Text = "Registrar Usuario Administrador";

                lblTypeUser.Text = "Usuario Común";
                lblTypeUser.ForeColor = Color.Black;
                chbShowInactivos.Enabled = false;
                chbShowInactivos.Checked = false;
                SesionActual.ShowInactivos = false;
            }
            else
            {
                // ESTADO USO NORMAL
                txtIngresePassAdmin.Enabled = true;
                btnActivateAdmin.Enabled = false;

                txtPassActual.Enabled = true;
                txtNewPass.Enabled = true;
                txtConfirmPass.Enabled = true;
                txtEmailRecup.Enabled = true;

                btnGuardarNewPass.Enabled = true;
                btnGuardarNewPass.Text = "Actualizar Contraseña";

                btnGuardarEmail.Enabled = true;
                btnGuardarEmail.Text = "Actualizar Correo";

                if (_adminController.IsAdminActivo())
                {
                    lblTypeUser.Text = "Modo Administrador";
                    lblTypeUser.ForeColor = Color.FromArgb(46, 125, 50);
                    chbShowInactivos.Enabled = true;
                    chbShowInactivos.Checked = SesionActual.ShowInactivos;
                }
                else
                {
                    lblTypeUser.Text = "Usuario Común";
                    lblTypeUser.ForeColor = Color.Black;
                    chbShowInactivos.Enabled = false;
                    chbShowInactivos.Checked = false;
                    SesionActual.ShowInactivos = false;
                }
            }

            txtIngresePassAdmin.Clear();
            txtPassActual.Clear();
            txtNewPass.Clear();
            txtConfirmPass.Clear();
            txtEmailRecup.Clear();
        }

        private void txtIngresePassAdmin_TextChanged(object sender, EventArgs e)
        {
            btnActivateAdmin.Enabled = !string.IsNullOrWhiteSpace(txtIngresePassAdmin.Text);
        }

        private void btnActivateAdmin_Click(object sender, EventArgs e)
        {
            string passwordIngresada = txtIngresePassAdmin.Text;

            ResultDto respuesta = _adminController.ValidarLoginAdmin(passwordIngresada);

            MessageUser.mostrarResultado(respuesta);

            if (respuesta.IsSuccess)
            {
                txtIngresePassAdmin.Clear();

                lblTypeUser.Text = "Modo Administrador";
                lblTypeUser.ForeColor = Color.FromArgb(46, 125, 50);
                lblTypeUser.Refresh();
                chbShowInactivos.Enabled = true;
                chbShowInactivos.Checked = SesionActual.ShowInactivos;
            }
        }

        private void chbShowInactivos_CheckedChanged(object sender, EventArgs e)
        {
            SesionActual.ShowInactivos = chbShowInactivos.Checked;
        }

        private void btnGuardarEmail_Click(object sender, EventArgs e)
        {
            bool primerUso = _adminController.isPrimerUso();

            if (primerUso)
            {
                if (string.IsNullOrWhiteSpace(txtEmailRecup.Text))
                {
                    MessageUser.mostrarAdvertencia("Por favor, ingrese un correo electrónico de recuperación.");
                    txtEmailRecup.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtNewPass.Text) || string.IsNullOrWhiteSpace(txtConfirmPass.Text))
                {
                    MessageUser.mostrarAdvertencia("Por favor, complete la nueva contraseña y su confirmación.");
                    txtNewPass.Focus();
                    return;
                }

                if (!MessageUser.confirmarAccion("¿Desea registrar las credenciales del usuario Administrador?", "Confirmar Registro"))
                {
                    return;
                }

                AdminDto dto = new AdminDto
                {
                    passwordNew = txtNewPass.Text,
                    passwordNewConfirm = txtConfirmPass.Text,
                    Email = txtEmailRecup.Text.Trim()
                };

                ResultDto respuesta = _adminController.RegistrarAdminInicial(dto);

                MessageUser.mostrarResultado(respuesta);

                if (respuesta.IsSuccess)
                {
                    ConfigurarEstadoInicialVista();
                }
            }
            else
            {
                if (string.IsNullOrWhiteSpace(txtEmailRecup.Text))
                {
                    MessageUser.mostrarAdvertencia("Por favor, ingrese un correo electrónico válido.");
                    txtEmailRecup.Focus();
                    return;
                }

                if (!MessageUser.confirmarAccion("¿Desea actualizar el correo electrónico de recuperación?", "Confirmar Modificación"))
                {
                    return;
                }

                string nuevoEmail = txtEmailRecup.Text.Trim();
                ResultDto respuesta = _adminController.UpdateEmail(nuevoEmail);

                MessageUser.mostrarResultado(respuesta);

                if (respuesta.IsSuccess)
                {
                    ConfigurarEstadoInicialVista();
                }
            }
        }

        private void btnGuardarNewPass_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassActual.Text))
            {
                MessageUser.mostrarAdvertencia("Por favor, ingrese la contraseña actual.");
                txtPassActual.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNewPass.Text) || string.IsNullOrWhiteSpace(txtConfirmPass.Text))
            {
                MessageUser.mostrarAdvertencia("Por favor, ingrese la nueva contraseña y su confirmación.");
                txtNewPass.Focus();
                return;
            }

            if (!MessageUser.confirmarAccion("¿Desea actualizar la contraseña de Administrador?", "Confirmar Cambio de Clave"))
            {
                return;
            }

            AdminDto dto = new AdminDto
            {
                passwordActual = txtPassActual.Text,
                passwordNew = txtNewPass.Text,
                passwordNewConfirm = txtConfirmPass.Text
            };

            ResultDto respuesta = _adminController.ChangePassword(dto);

            MessageUser.mostrarResultado(respuesta);

            if (respuesta.IsSuccess)
            {
                ConfigurarEstadoInicialVista();
            }
        }
    }
}
