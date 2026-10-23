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
    public partial class ViewLugar : Form
    {
        private readonly LugarController _lugarController;
        private int _idSeleccionado = 0;
        private string? _rutaImagenTemp = null;
        private LugarCardControl? _cardSeleccionada = null;

        public ViewLugar()
        {
            InitializeComponent();

            _lugarController = new LugarController();
            ConfigInitialViewLugar();
        }

        private void ConfigInitialViewLugar()
        {
            ActualizarTarjetas();
            ActualizarEstadosBotones(true);
            LimpiarCampos();
        }

        private void ActualizarTarjetas()
        {
            flpCardLugares.SuspendLayout();
            flpCardLugares.Controls.Clear();
            _cardSeleccionada = null;

            List<LugarDto> listaLugares = SesionActual.ShowInactivos
                ? _lugarController.GetLugaresNoActivos()
                : _lugarController.GetLugares();

            foreach (var lugarDto in listaLugares)
            {
                var card = new LugarCardControl
                {
                    Margin = new Padding(8)
                };

                card.CargarDatos(lugarDto);
                AsignarEventoSeleccionRecursivo(card, card);

                flpCardLugares.Controls.Add(card);
            }

            flpCardLugares.ResumeLayout();
        }

        private void AsignarEventoSeleccionRecursivo(Control controlPadre, LugarCardControl card)
        {
            controlPadre.Click += (s, e) => SeleccionarTarjeta(card);

            foreach (Control hijo in controlPadre.Controls)
            {
                AsignarEventoSeleccionRecursivo(hijo, card);
            }
        }


        private void SeleccionarTarjeta(LugarCardControl card)
        {
            if (card == null || card.LugarData == null) return;

            LimpiarSeleccionVisualCards();

            _cardSeleccionada = card;
            _cardSeleccionada.Seleccionada = true;

            LugarDto lugarSeleccionado = _cardSeleccionada.LugarData;

            _idSeleccionado = lugarSeleccionado.idLugar;
            txtLugarNombre.Text = lugarSeleccionado.nombreLugar;
            txtLugarDescripcion.Text = lugarSeleccionado.descripcionLugar;
            txtLugarCantidadMax.Text = lugarSeleccionado.cantMaxPersonas.ToString();
            txtLugarPrecio.Text = lugarSeleccionado.precioBase.ToString();
            _rutaImagenTemp = lugarSeleccionado.rutaImagen;

            ActualizarEstadosBotones(lugarSeleccionado.activo);
        }

        private void LimpiarSeleccionVisualCards()
        {
            foreach (Control ctrl in flpCardLugares.Controls)
            {
                if (ctrl is LugarCardControl card)
                {
                    card.Seleccionada = false;
                }
            }
            _cardSeleccionada = null;
        }

        private void ActualizarEstadosBotones(bool esActivo)
        {
            if (_idSeleccionado == 0)
            {
                btnCreateLugar.Enabled = true;
                btnCreateLugar.Text = "Crear";
                btnUpdateLugar.Enabled = false;
                btnDeleteLugar.Enabled = false;
            }
            else
            {
                if (esActivo)
                {
                    btnCreateLugar.Enabled = false;
                    btnCreateLugar.Text = "Crear";
                    btnUpdateLugar.Enabled = true;
                    btnDeleteLugar.Enabled = true;
                }
                else
                {
                    btnCreateLugar.Enabled = true;
                    btnCreateLugar.Text = "Activar";
                    btnUpdateLugar.Enabled = false;
                    btnDeleteLugar.Enabled = true;
                }
            }
        }

        private void LimpiarCampos()
        {
            txtLugarNombre.Clear();
            txtLugarDescripcion.Clear();
            txtLugarCantidadMax.Clear();
            txtLugarPrecio.Clear();
            _rutaImagenTemp = null;
            _idSeleccionado = 0;

            LimpiarSeleccionVisualCards();
            txtLugarNombre.Focus();

            ActualizarEstadosBotones(true);
        }

        private void btnLimpiarTexts_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnCargarImagen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Seleccionar Imagen del Salón";
                ofd.Filter = "Archivos de Imagen (*.jpg;*.jpeg;*.png;*.webp)|*.jpg;*.jpeg;*.png;*.webp";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    _rutaImagenTemp = ofd.FileName;
                    MessageUser.mostrarExito("Imagen seleccionada correctamente.");
                }
            }
        }

        private void btnCreateLugar_Click(object sender, EventArgs e)
        {
            if (_idSeleccionado > 0 && btnCreateLugar.Text == "Activar")
            {
                if (!ValidationViews.confirmarAccionUI("activar", "lugar/salón")) return;

                ResultDto respuestaReactivar = _lugarController.ReactivateLugar(_idSeleccionado);
                ActualizarYLimpiarVista(respuestaReactivar);
                return;
            }

            if (!ValidationViews.validarDescripcionUI(txtLugarNombre.Text, "nombre del lugar")) return;
            if (!ValidationViews.validarDescripcionUI(txtLugarDescripcion.Text, "lugar/salón")) return;
            if (!ValidationViews.validarPrecioUI(txtLugarPrecio.Text, "lugar/salón")) return;

            if (!int.TryParse(txtLugarCantidadMax.Text.Trim(), out int cantMax) || cantMax <= 0)
            {
                MessageUser.mostrarAdvertencia("Por favor, ingrese un número entero válido mayor a 0 para la cantidad máxima de personas.");
                return;
            }

            if (!ValidationViews.confirmarAccionUI("crear", "lugar/salón")) return;

            string nombreLugar = txtLugarNombre.Text.Trim();
            string descripcionLugar = txtLugarDescripcion.Text.Trim();
            decimal precioBase = Convert.ToDecimal(txtLugarPrecio.Text.Trim());

            LugarDto lugarDto = new LugarDto(nombreLugar, descripcionLugar, precioBase, cantMax, _rutaImagenTemp);
            ResultDto respuesta = _lugarController.CreateLugar(lugarDto);

            ActualizarYLimpiarVista(respuesta);
        }

        private void btnUpdateLugar_Click(object sender, EventArgs e)
        {
            if (!ValidationViews.validarSeleccionUI(_idSeleccionado, "modificarlo", "lugar/salón")) return;
            if (!ValidationViews.validarDescripcionUI(txtLugarNombre.Text, "nombre del lugar")) return;
            if (!ValidationViews.validarDescripcionUI(txtLugarDescripcion.Text, "lugar/salón")) return;
            if (!ValidationViews.validarPrecioUI(txtLugarPrecio.Text, "lugar/salón")) return;

            if (!int.TryParse(txtLugarCantidadMax.Text.Trim(), out int cantMax) || cantMax <= 0)
            {
                MessageUser.mostrarAdvertencia("Por favor, ingrese una cantidad de personas válida.");
                return;
            }

            if (!ValidationViews.confirmarAccionUI("modificar", "lugar/salón")) return;

            string nombreLugar = txtLugarNombre.Text.Trim();
            string descripcionLugar = txtLugarDescripcion.Text.Trim();
            decimal precioBase = Convert.ToDecimal(txtLugarPrecio.Text.Trim());

            bool estaOcupado = _cardSeleccionada?.LugarData.ocupado ?? false;
            bool estaActivo = _cardSeleccionada?.LugarData.activo ?? true;

            LugarDto lugarDto = new LugarDto(_idSeleccionado, nombreLugar, descripcionLugar, precioBase, cantMax, estaOcupado, _rutaImagenTemp, estaActivo);
            ResultDto respuesta = _lugarController.UpdateLugar(lugarDto);

            ActualizarYLimpiarVista(respuesta);
        }

        private void btnDeleteLugar_Click(object sender, EventArgs e)
        {
            if (!ValidationViews.validarSeleccionUI(_idSeleccionado, "gestionar la baja o eliminación de", "lugar/salón")) return;

            LugarDto? lugarActual = _cardSeleccionada?.LugarData;

            if (lugarActual != null && !lugarActual.activo)
            {
                if (!ValidationViews.confirmarAccionUI("eliminar definitivamente", "lugar/salón")) return;

                ResultDto respuestaPermanente = _lugarController.DeleteLugarPermanente(_idSeleccionado);
                ActualizarYLimpiarVista(respuestaPermanente);
            }
            else
            {
                if (!ValidationViews.confirmarAccionUI("dar de baja", "lugar/salón")) return;

                ResultDto respuestaBaja = _lugarController.DeleteLugar(_idSeleccionado);
                ActualizarYLimpiarVista(respuestaBaja);
            }
        }

        private void ActualizarYLimpiarVista(ResultDto respuesta)
        {
            MessageUser.mostrarResultado(respuesta);

            if (respuesta != null && respuesta.IsSuccess)
            {
                ActualizarTarjetas();
                LimpiarCampos();
            }
        }
    }
}