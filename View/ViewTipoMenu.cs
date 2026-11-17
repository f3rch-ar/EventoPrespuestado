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
    public partial class ViewTipoMenu : Form
    {
        private readonly TipoMenuController _menuController;
        private int _idSeleccionado = 0;
        private TipoMenuCardControl? _cardSeleccionada = null;

        public ViewTipoMenu()
        {
            InitializeComponent();

            _menuController = new TipoMenuController();
            ConfigInitialView();
        }

        private void ConfigInitialView()
        {
            CargarCombosComidas();
            ActualizarTarjetas();
            ActualizarEstadosBotones(true);
            LimpiarCampos();
        }

        private void CargarCombosComidas()
        {
            cbxEntradaMenu.DataSource = _menuController.GetComidasPorCategoria(EnumTipoCom.ENTRADA);
            cbxEntradaMenu.DisplayMember = "descripcionComida";
            cbxEntradaMenu.ValueMember = "Id";
            cbxEntradaMenu.SelectedIndex = -1;

            cbxPlatoMainMenu.DataSource = _menuController.GetComidasPorCategoria(EnumTipoCom.PLATO_PRINCIAPAL);
            cbxPlatoMainMenu.DisplayMember = "descripcionComida";
            cbxPlatoMainMenu.ValueMember = "Id";
            cbxPlatoMainMenu.SelectedIndex = -1;

            cbxPostreMenu.DataSource = _menuController.GetComidasPorCategoria(EnumTipoCom.POSTRE);
            cbxPostreMenu.DisplayMember = "descripcionComida";
            cbxPostreMenu.ValueMember = "Id";
            cbxPostreMenu.SelectedIndex = -1;

            cbxBebidaMenu.DataSource = _menuController.GetComidasPorCategoria(EnumTipoCom.BEBIDA);
            cbxBebidaMenu.DisplayMember = "descripcionComida";
            cbxBebidaMenu.ValueMember = "Id";
            cbxBebidaMenu.SelectedIndex = -1;

            // Eventos para actualizar precios individuales y recalcular el total general
            cbxEntradaMenu.SelectedIndexChanged += (s, e) => { ActualizarPrecioItem(cbxEntradaMenu, lblPrecioEntrada); RecalcularTotalMenu(s, e); };
            cbxPlatoMainMenu.SelectedIndexChanged += (s, e) => { ActualizarPrecioItem(cbxPlatoMainMenu, lblPrecioPlatoMain); RecalcularTotalMenu(s, e); };
            cbxPostreMenu.SelectedIndexChanged += (s, e) => { ActualizarPrecioItem(cbxPostreMenu, lblPrecioPostre); RecalcularTotalMenu(s, e); };
            cbxBebidaMenu.SelectedIndexChanged += (s, e) => { ActualizarPrecioItem(cbxBebidaMenu, lblPrecioBebida); RecalcularTotalMenu(s, e); };
        }

        private void ActualizarPrecioItem(ComboBox cbx, Label lblPrecio)
        {
            if (cbx.SelectedItem is ComidaDto comida)
            {
                lblPrecio.Text = $"$ {comida.valorComida:N0}";
            }
            else
            {
                lblPrecio.Text = "$ 0";
            }
        }

        private List<ComidaDto> ObtenerComidasSeleccionadas()
        {
            List<ComidaDto> comidasSeleccionadas = new List<ComidaDto>();

            if (cbxEntradaMenu.SelectedItem is ComidaDto en) comidasSeleccionadas.Add(en);
            if (cbxPlatoMainMenu.SelectedItem is ComidaDto pr) comidasSeleccionadas.Add(pr);
            if (cbxPostreMenu.SelectedItem is ComidaDto po) comidasSeleccionadas.Add(po);
            if (cbxBebidaMenu.SelectedItem is ComidaDto be) comidasSeleccionadas.Add(be);

            return comidasSeleccionadas;
        }

        private void RecalcularTotalMenu(object? sender, EventArgs e)
        {
            List<ComidaDto> comidas = ObtenerComidasSeleccionadas();
            decimal total = comidas.Sum(c => c.valorComida);

            ptrPrecioTotal.Titulo = "VALOR TOTAL DEL MENÚ";
            ptrPrecioTotal.ActualizarTotal(total);
        }

        private TipoMenuDto ObtenerDtoDesdePantalla(int id)
        {
            string nombreMenu = txtMenuNombre.Text.Trim();
            List<ComidaDto> comidasSeleccionadas = ObtenerComidasSeleccionadas();

            decimal precioTotalMenu = comidasSeleccionadas.Sum(c => c.valorComida);
            bool estadoActivo = _cardSeleccionada?.MenuData.Activo ?? true;

            TipoMenuDto dto = new TipoMenuDto
            {
                Id = id,
                NombreMenu = nombreMenu,
                ListaComidas = comidasSeleccionadas,
                ValorTipoMenu = precioTotalMenu,
                Activo = estadoActivo
            };

            return dto;
        }

        private void ActualizarTarjetas()
        {
            flpCardMenus.SuspendLayout();
            flpCardMenus.Controls.Clear();
            _cardSeleccionada = null;

            List<TipoMenuDto> listaMenus = SesionActual.ShowInactivos
                ? _menuController.GetTipoMenusNoActivos()
                : _menuController.GetTipoMenus();

            foreach (var menuDto in listaMenus)
            {
                var card = new TipoMenuCardControl
                {
                    Margin = new Padding(8)
                };
                card.CargarDatos(menuDto);
                AsignarEventoSeleccionRecursivo(card, card);
                flpCardMenus.Controls.Add(card);
            }
            flpCardMenus.ResumeLayout();
        }

        private void AsignarEventoSeleccionRecursivo(Control controlPadre, TipoMenuCardControl card)
        {
            controlPadre.Click += (s, e) => SeleccionarTarjeta(card);
            foreach (Control hijo in controlPadre.Controls)
            {
                AsignarEventoSeleccionRecursivo(hijo, card);
            }
        }

        private void SeleccionarTarjeta(TipoMenuCardControl card)
        {
            if (card == null || card.MenuData == null) return;
            LimpiarSeleccionVisualCards();

            _cardSeleccionada = card;
            _cardSeleccionada.Seleccionada = true;

            TipoMenuDto menuSeleccionado = _cardSeleccionada.MenuData;
            _idSeleccionado = menuSeleccionado.Id;

            txtMenuNombre.Text = menuSeleccionado.NombreMenu;

            if (menuSeleccionado.ListaComidas.Count > 0) cbxEntradaMenu.SelectedValue = menuSeleccionado.ListaComidas[0].Id;
            if (menuSeleccionado.ListaComidas.Count > 1) cbxPlatoMainMenu.SelectedValue = menuSeleccionado.ListaComidas[1].Id;
            if (menuSeleccionado.ListaComidas.Count > 2) cbxPostreMenu.SelectedValue = menuSeleccionado.ListaComidas[2].Id;
            if (menuSeleccionado.ListaComidas.Count > 3) cbxBebidaMenu.SelectedValue = menuSeleccionado.ListaComidas[3].Id;

            RecalcularTotalMenu(null, EventArgs.Empty);
            ActualizarEstadosBotones(menuSeleccionado.Activo);
        }

        private void LimpiarSeleccionVisualCards()
        {
            foreach (Control ctrl in flpCardMenus.Controls)
            {
                if (ctrl is TipoMenuCardControl card)
                {
                    card.Seleccionada = false;
                }
            }
        }

        private void ActualizarEstadosBotones(bool esActivo)
        {
            if (_idSeleccionado == 0)
            {
                btnCreateMenu.Enabled = true;
                btnCreateMenu.Text = "Crear";
                btnUpdateMenu.Enabled = false;
                btnDeleteMenu.Enabled = false;
            }
            else
            {
                if (esActivo)
                {
                    btnCreateMenu.Enabled = false;
                    btnCreateMenu.Text = "Crear";
                    btnUpdateMenu.Enabled = true;
                    btnDeleteMenu.Enabled = true;
                }
                else
                {
                    btnCreateMenu.Enabled = true;
                    btnCreateMenu.Text = "Activar";
                    btnUpdateMenu.Enabled = false;
                    btnDeleteMenu.Enabled = false;
                }
            }
        }

        private void LimpiarCampos()
        {
            txtMenuNombre.Clear();
            cbxEntradaMenu.SelectedIndex = -1;
            cbxPlatoMainMenu.SelectedIndex = -1;
            cbxPostreMenu.SelectedIndex = -1;
            cbxBebidaMenu.SelectedIndex = -1;

            // Limpiar etiquetas de precio individuales
            lblPrecioEntrada.Text = "$ 0";
            lblPrecioPlatoMain.Text = "$ 0";
            lblPrecioPostre.Text = "$ 0";
            lblPrecioBebida.Text = "$ 0";

            _idSeleccionado = 0;
            LimpiarSeleccionVisualCards();
            txtMenuNombre.Focus();

            ptrPrecioTotal.ActualizarTotal(0);
            ActualizarEstadosBotones(true);
        }

        private void btnLimpiarTexts_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnCreateMenu_Click(object sender, EventArgs e)
        {
            if (_idSeleccionado > 0 && btnCreateMenu.Text == "Activar")
            {
                if (!ValidationViews.confirmarAccionUI("activar", "tipo de menú")) return;

                ResultDto respuestaReactivar = _menuController.ReactivateTipoMenu(_idSeleccionado);
                ActualizarYLimpiarVista(respuestaReactivar);
                return;
            }
            if (!ValidationViews.validarDescripcionUI(txtMenuNombre.Text, "nombre del menú")) return;
            if (!ValidationViews.validarSeleccionComponentesMenuUI(
                cbxEntradaMenu.SelectedItem,
                cbxPlatoMainMenu.SelectedItem,
                cbxPostreMenu.SelectedItem,
                cbxBebidaMenu.SelectedItem)) return;

            if (!ValidationViews.confirmarAccionUI("crear", "tipo de menú")) return;

            TipoMenuDto nuevoDto = ObtenerDtoDesdePantalla(0);

            ResultDto respuesta = _menuController.CreateTipoMenu(nuevoDto);
            ActualizarYLimpiarVista(respuesta);
        }

        private void btnUpdateMenu_Click(object sender, EventArgs e)
        {
            if (!ValidationViews.validarSeleccionUI(_idSeleccionado, "modificarlo", "tipo de menú")) return;
            if (!ValidationViews.validarDescripcionUI(txtMenuNombre.Text, "nombre del menú")) return;
            if (!ValidationViews.validarSeleccionComponentesMenuUI(
                cbxEntradaMenu.SelectedItem,
                cbxPlatoMainMenu.SelectedItem,
                cbxPostreMenu.SelectedItem,
                cbxBebidaMenu.SelectedItem)) return;

            if (!ValidationViews.confirmarAccionUI("modificar", "tipo de menú")) return;

            TipoMenuDto menuDto = ObtenerDtoDesdePantalla(_idSeleccionado);

            ResultDto respuesta = _menuController.UpdateTipoMenu(menuDto);
            ActualizarYLimpiarVista(respuesta);
        }

        private void btnDeleteMenu_Click(object sender, EventArgs e)
        {
            if (!ValidationViews.validarSeleccionUI(_idSeleccionado, "dar de baja", "tipo de menú")) return;

            if (!ValidationViews.confirmarAccionUI("dar de baja", "tipo de menú")) return;

            ResultDto respuestaBaja = _menuController.DeleteTipoMenu(_idSeleccionado);
            ActualizarYLimpiarVista(respuestaBaja);
        }

        private void ActualizarYLimpiarVista(ResultDto respuesta)
        {
            //MessageUser.mostrarResultado(respuesta);
            ValidationViews.mostrarResultadoUI(respuesta);
            if (respuesta != null && respuesta.IsSuccess)
            {
                ActualizarTarjetas();
                LimpiarCampos();
            }
        }
    }
}