using EventoPresupuestado.Controller;
using EventoPresupuestado.Dto;
using EventoPresupuestado.Model;
using EventoPresupuestado.Model.Enums;
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
    public partial class ViewComida : Form
    {
        private readonly ComidaController _comidaController;
        private int _idSeleccionado = 0;

        public ViewComida()
        {
            InitializeComponent();

            _comidaController = new ComidaController();
            configInitialViewComida();
        }

        private void configInitialViewComida()
        {
            configurarColumnasGrilla();
            rellenarComboBoxComida();
            actualizarGrilla();
            actualizarEstadosBotones(true);
            configurarEventosGrilla();
            limpiarCampos();
        }

        private void configurarColumnasGrilla()
        {
            dgvListComida.AutoGenerateColumns = false;
            dgvListComida.Columns.Clear();

            DataGridViewTextBoxColumn colId = new DataGridViewTextBoxColumn();
            colId.DataPropertyName = "idComida";
            colId.HeaderText = "ID Código";
            colId.FillWeight = 40;
            dgvListComida.Columns.Add(colId);

            DataGridViewTextBoxColumn colDesc = new DataGridViewTextBoxColumn();
            colDesc.DataPropertyName = "descripcionComida";
            colDesc.HeaderText = "Descripción";
            colDesc.FillWeight = 100;
            dgvListComida.Columns.Add(colDesc);

            DataGridViewTextBoxColumn colTipo = new DataGridViewTextBoxColumn();
            colTipo.DataPropertyName = "estadoTipoCom";
            colTipo.HeaderText = "Tipo de Comida";
            colTipo.FillWeight = 90;
            dgvListComida.Columns.Add(colTipo);

            DataGridViewTextBoxColumn colValor = new DataGridViewTextBoxColumn();
            colValor.DataPropertyName = "valorComida";
            colValor.HeaderText = "Precio ($)";
            colValor.FillWeight = 90;
            dgvListComida.Columns.Add(colValor);
        }

        private void rellenarComboBoxComida()
        {
            cbxTipoComida.DataSource = Enum.GetValues(typeof(EnumTipoCom));
            cbxTipoComida.SelectedIndex = 0;
        }

        private void actualizarGrilla()
        {
            dgvListComida.DataSource = null;

            // Consultamos la sesión global para decidir si traemos inactivos o solo activos
            if (SesionActual.ShowInactivos)
            {
                dgvListComida.DataSource = _comidaController.GetComidasNoActivas();
            }
            else
            {
                dgvListComida.DataSource = _comidaController.GetComidas();
            }
        }

        private void actualizarEstadosBotones(bool esActivo)
        {
            if (_idSeleccionado == 0)
            {
                btnCreateComida.Enabled = true;
                btnCreateComida.Text = "Crear";
                btnUpdateComida.Enabled = false;
                btnDeleteComida.Enabled = false;
            }
            else
            {
                if (esActivo)
                {
                    btnCreateComida.Enabled = false;
                    btnCreateComida.Text = "Crear";
                    btnUpdateComida.Enabled = true;
                    btnDeleteComida.Enabled = true;
                }
                else
                {
                    btnCreateComida.Enabled = true;
                    btnCreateComida.Text = "Activar";
                    btnUpdateComida.Enabled = false;
                    btnDeleteComida.Enabled = true;
                }
            }
        }

        private void limpiarCampos()
        {
            txtComidaDescripcion.Clear();
            txtComidaValor.Clear();
            cbxTipoComida.SelectedIndex = 0;
            _idSeleccionado = 0;

            dgvListComida.ClearSelection();
            if (dgvListComida.CurrentCell != null)
            {
                dgvListComida.CurrentCell = null;
            }

            txtComidaDescripcion.Focus();

            actualizarEstadosBotones(true);
        }

        private void btnLimpiarDataGrid_Click(object sender, EventArgs e)
        {
            limpiarCampos();
            dgvListComida.ClearSelection();
        }

        private void btnCreateComida_Click(object sender, EventArgs e)
        {
            if (_idSeleccionado > 0 && btnCreateComida.Text == "Activar")
            {
                if (!ValidationViews.confirmarAccionUI("activar", "comida")) return;

                ResultDto respuestaReactivar = _comidaController.ReactivateComida(_idSeleccionado);
                actualizarYLimpiarGrilla(respuestaReactivar);
                return;
            }

            if (!ValidationViews.validarDescripcionUI(txtComidaDescripcion.Text, "comida")) return;
            if (!ValidationViews.validarPrecioUI(txtComidaValor.Text, "comida")) return;
            if (!ValidationViews.confirmarAccionUI("crear", "comida")) return;

            string descripcionComida = txtComidaDescripcion.Text.Trim();
            EnumTipoCom estadoComida = (EnumTipoCom)cbxTipoComida.SelectedItem;
            decimal valorComida = Convert.ToDecimal(txtComidaValor.Text);

            ComidaDto comidaDto = new ComidaDto(descripcionComida, estadoComida, valorComida);
            ResultDto respuesta = _comidaController.CreateComida(comidaDto);

            actualizarYLimpiarGrilla(respuesta);
        }

        private void btnUpdateComida_Click(object sender, EventArgs e)
        {
            if (!ValidationViews.validarSeleccionUI(_idSeleccionado, "modificarla", "comida")) return;
            if (!ValidationViews.validarDescripcionUI(txtComidaDescripcion.Text, "comida")) return;
            if (!ValidationViews.validarPrecioUI(txtComidaValor.Text, "comida")) return;
            if (!ValidationViews.confirmarAccionUI("modificar", "comida")) return;

            string descripcionComida = txtComidaDescripcion.Text.Trim();
            EnumTipoCom estadoComida = (EnumTipoCom)cbxTipoComida.SelectedItem;
            decimal valorComida = Convert.ToDecimal(txtComidaValor.Text);

            ComidaDto comidaDto = new ComidaDto(_idSeleccionado, descripcionComida, estadoComida, valorComida);
            ResultDto respuesta = _comidaController.UpdateComida(comidaDto);

            actualizarYLimpiarGrilla(respuesta);
        }

        private void btnDeleteComida_Click(object sender, EventArgs e)
        {
            if (!ValidationViews.validarSeleccionUI(_idSeleccionado, "gestionar la baja o eliminación de", "comida")) return;

            ComidaDto comidaActual = dgvListComida.CurrentRow?.DataBoundItem as ComidaDto;

            if (comidaActual != null && !comidaActual.activo)
            {
                if (!ValidationViews.confirmarAccionUI("eliminar definitivamente", "comida")) return;

                ResultDto respuestaPermanente = _comidaController.DeleteComidaPermanente(_idSeleccionado);
                actualizarYLimpiarGrilla(respuestaPermanente);
            }
            else
            {
                if (!ValidationViews.confirmarAccionUI("dar de baja", "comida")) return;

                ResultDto respuestaBaja = _comidaController.DeleteComida(_idSeleccionado);
                actualizarYLimpiarGrilla(respuestaBaja);
            }
        }

        private void actualizarYLimpiarGrilla(ResultDto respuesta)
        {
            MessageUser.mostrarResultado(respuesta);

            if (respuesta.IsSuccess)
            {
                actualizarGrilla();
                limpiarCampos();
            }
        }

        private void configurarEventosGrilla()
        {
            dgvListComida.CellFormatting += (sender, e) =>
            {
                if (e.RowIndex >= 0)
                {
                    ComidaDto comidaFila = dgvListComida.Rows[e.RowIndex].DataBoundItem as ComidaDto;

                    if (comidaFila != null)
                    {
                        if (!comidaFila.activo)
                        {
                            Color rojoPastel = Color.FromArgb(253, 237, 237);
                            dgvListComida.Rows[e.RowIndex].DefaultCellStyle.BackColor = rojoPastel;
                            dgvListComida.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.FromArgb(139, 0, 0);
                        }
                        else
                        {
                            dgvListComida.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                            dgvListComida.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
                        }
                    }
                }
            };

            dgvListComida.CellClick += (sender, e) =>
            {
                if (e.RowIndex >= 0 && dgvListComida.CurrentRow != null)
                {
                    ComidaDto comidaSeleccionada = dgvListComida.CurrentRow.DataBoundItem as ComidaDto;

                    if (comidaSeleccionada != null)
                    {
                        _idSeleccionado = comidaSeleccionada.idComida;
                        txtComidaDescripcion.Text = comidaSeleccionada.descripcionComida;
                        txtComidaValor.Text = comidaSeleccionada.valorComida.ToString();
                        cbxTipoComida.SelectedItem = comidaSeleccionada.estadoTipoCom;

                        actualizarEstadosBotones(comidaSeleccionada.activo);
                    }
                }
            };
        }
    }
}
