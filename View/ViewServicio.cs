using EventoPresupuestado.Componentes;
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
    public partial class ViewServicio : Form
    {
        private readonly ServicioAdicionalController _servicioController;
        private int _idSeleccionado = 0;
        private ServicioItemControl? _itemSeleccionado = null;

        public ViewServicio()
        {
            InitializeComponent();

            _servicioController = new ServicioAdicionalController();
            ConfigInitialViewServicio();
        }

        private void ConfigInitialViewServicio()
        {
            ActualizarTarjetas();
            ActualizarEstadosBotones(true);
            LimpiarCampos();
        }

        private void ActualizarTarjetas()
        {
            flpCardServicio.SuspendLayout();
            flpCardServicio.Controls.Clear();
            _itemSeleccionado = null;

            List<ServicioAdicionalDto> listaServicios = SesionActual.ShowInactivos
                ? _servicioController.GetServiciosAdicionalesNoActivos()
                : _servicioController.GetServiciosAdicionales();

            int anchoDisponible = flpCardServicio.ClientSize.Width - 25;
            if (anchoDisponible <= 0) anchoDisponible = 480;

            foreach (var servicioDto in listaServicios)
            {
                var card = new ServicioItemControl
                {
                    Width = anchoDisponible,
                    Margin = new Padding(0, 0, 0, 8)
                };

                card.CargarDatos(servicioDto);
                AsignarEventoSeleccionRecursivo(card, card);
                flpCardServicio.Controls.Add(card);
            }

            flpCardServicio.ResumeLayout();
        }

        private void AsignarEventoSeleccionRecursivo(Control controlPadre, ServicioItemControl card)
        {
            controlPadre.Click += (s, e) => SeleccionarTarjeta(card);

            foreach (Control hijo in controlPadre.Controls)
            {
                AsignarEventoSeleccionRecursivo(hijo, card);
            }
        }

        private void SeleccionarTarjeta(ServicioItemControl card)
        {
            if (card == null || card.ServicioData == null) return;

            LimpiarSeleccionVisualCards();

            _itemSeleccionado = card;
            _itemSeleccionado.Seleccionada = true;

            ServicioAdicionalDto servicioSeleccionado = _itemSeleccionado.ServicioData;

            _idSeleccionado = servicioSeleccionado.Id;
            txtServicioNombre.Text = servicioSeleccionado.nombreServicio;
            txtLServicioDescripcion.Text = servicioSeleccionado.descripcion;
            txtServicioPrecio.Text = servicioSeleccionado.valorServicio.ToString();

            ActualizarEstadosBotones(servicioSeleccionado.Activo);
        }

        private void LimpiarSeleccionVisualCards()
        {
            foreach (Control ctrl in flpCardServicio.Controls)
            {
                if (ctrl is ServicioItemControl card)
                {
                    card.Seleccionada = false;
                }
            }
            _itemSeleccionado = null;
        }

        private void ActualizarEstadosBotones(bool esActivo)
        {
            if (_idSeleccionado == 0)
            {
                btnCreateServicio.Enabled = true;
                btnCreateServicio.Text = "Crear";
                btnUpdateServicio.Enabled = false;
                btnDeleteServicio.Enabled = false;
            }
            else
            {
                if (esActivo)
                {
                    btnCreateServicio.Enabled = false;
                    btnCreateServicio.Text = "Crear";
                    btnUpdateServicio.Enabled = true;
                    btnDeleteServicio.Enabled = true;
                }
                else
                {
                    btnCreateServicio.Enabled = true;
                    btnCreateServicio.Text = "Activar";
                    btnUpdateServicio.Enabled = false;
                    btnDeleteServicio.Enabled = false;
                }
            }
        }

        private void LimpiarCampos()
        {
            txtServicioNombre.Clear();
            txtLServicioDescripcion.Clear();
            txtServicioPrecio.Clear();
            _idSeleccionado = 0;

            LimpiarSeleccionVisualCards();
            txtServicioNombre.Focus();

            ActualizarEstadosBotones(true);
        }

        private ServicioAdicionalDto ObtenerDtoDesdePantalla(int id)
        {
            string nombreServicio = txtServicioNombre.Text.Trim();
            string descripcion = txtLServicioDescripcion.Text.Trim();
            decimal valorServicio = Convert.ToDecimal(txtServicioPrecio.Text.Trim());
            bool estaActivo = _itemSeleccionado?.ServicioData.Activo ?? true;

            if (id == 0)
            {
                return new ServicioAdicionalDto(nombreServicio, descripcion, valorServicio);
            }
            else
            {
                return new ServicioAdicionalDto(id, nombreServicio, descripcion, valorServicio, estaActivo);
            }
        }

        private void btnLimpiarTexts_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnCargarImagen_Click(object sender, EventArgs e)
        {
            // Espacio reservado para manejo de imágenes futuras
        }

        private void btnCreateServicio_Click(object sender, EventArgs e)
        {
            if (_idSeleccionado > 0 && btnCreateServicio.Text == "Activar")
            {
                if (!ValidationViews.confirmarAccionUI("activar", "servicio adicional")) return;

                ResultDto respuestaReactivar = _servicioController.ReactivateServicioAdicional(_idSeleccionado);
                ActualizarYLimpiarVista(respuestaReactivar);
                return;
            }

            if (!ValidationViews.validarDescripcionUI(txtServicioNombre.Text, "nombre del servicio")) return;
            if (!ValidationViews.validarDescripcionUI(txtLServicioDescripcion.Text, "servicio adicional")) return;
            if (!ValidationViews.validarPrecioUI(txtServicioPrecio.Text, "servicio adicional")) return;

            if (!ValidationViews.confirmarAccionUI("crear", "servicio adicional")) return;

            ServicioAdicionalDto servicioDto = ObtenerDtoDesdePantalla(0);
            ResultDto respuesta = _servicioController.CreateServicioAdicional(servicioDto);

            ActualizarYLimpiarVista(respuesta);
        }

        private void btnUpdateServicio_Click(object sender, EventArgs e)
        {
            if (!ValidationViews.validarSeleccionUI(_idSeleccionado, "modificarlo", "servicio adicional")) return;
            if (!ValidationViews.validarDescripcionUI(txtServicioNombre.Text, "nombre del servicio")) return;
            if (!ValidationViews.validarDescripcionUI(txtLServicioDescripcion.Text, "servicio adicional")) return;
            if (!ValidationViews.validarPrecioUI(txtServicioPrecio.Text, "servicio adicional")) return;

            if (!ValidationViews.confirmarAccionUI("modificar", "servicio adicional")) return;

            ServicioAdicionalDto servicioDto = ObtenerDtoDesdePantalla(_idSeleccionado);
            ResultDto respuesta = _servicioController.UpdateServicioAdicional(servicioDto);

            ActualizarYLimpiarVista(respuesta);
        }

        private void btnDeleteServicio_Click(object sender, EventArgs e)
        {
            if (!ValidationViews.validarSeleccionUI(_idSeleccionado, "gestionar la baja o eliminación de", "servicio adicional")) return;

            if (!ValidationViews.confirmarAccionUI("dar de baja", "servicio adicional")) return;

            ResultDto respuestaBaja = _servicioController.DeleteServicioAdicional(_idSeleccionado);
            ActualizarYLimpiarVista(respuestaBaja);
        }

        private void ActualizarYLimpiarVista(ResultDto respuesta)
        {
            ValidationViews.mostrarResultadoUI(respuesta);

            if (respuesta != null && respuesta.IsSuccess)
            {
                ActualizarTarjetas();
                LimpiarCampos();
            }
        }

        private void flpCardServicio_Resize(object sender, EventArgs e)
        {
            int nuevoAncho = flpCardServicio.ClientSize.Width - 25;
            if (nuevoAncho <= 0) return;

            foreach (Control ctrl in flpCardServicio.Controls)
            {
                if (ctrl is ServicioItemControl card)
                {
                    card.Width = nuevoAncho;
                }
            }
        }
    }
}