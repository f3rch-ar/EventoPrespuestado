using EventoPresupuestado.Dto;
using EventoPresupuestado.Model.Enums;
using EventoPresupuestado.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventoPresupuestado.Controller
{
    public class TipoMenuController
    {
        private readonly TipoMenuService _tipoMenuService;
        private readonly ComidaService _comidaService;

        public TipoMenuController()
        {
            _tipoMenuService = new TipoMenuService();
            _comidaService = new ComidaService();
        }

        public List<ComidaDto> GetComidasPorCategoria(EnumTipoCom tipoComida)
        {
            return _comidaService.GetComidasPorCategoria(tipoComida);
        }


        public List<TipoMenuDto> GetTipoMenus()
        {
            return _tipoMenuService.GetTipoMenus();
        }

        public List<TipoMenuDto> GetTipoMenusNoActivos()
        {
            return _tipoMenuService.GetTipoMenusNoActivos();
        }

        public ResultDto CreateTipoMenu(TipoMenuDto tipoMenuDto)
        {
            try
            {
                _tipoMenuService.CreateTipoMenu(tipoMenuDto);
                return ResultDto.Success("El tipo de menú se registró correctamente en el sistema.");
            }
            catch (ArgumentException ex)
            {
                return ResultDto.Warning(ex.Message);
            }
            catch (Exception)
            {
                return ResultDto.Fatal("Ocurrió un error inesperado al intentar registrar el tipo de menú. Intente nuevamente.");
            }
        }

        public ResultDto UpdateTipoMenu(TipoMenuDto tipoMenuDto)
        {
            try
            {
                _tipoMenuService.UpdateTipoMenu(tipoMenuDto);
                return ResultDto.Success("El tipo de menú fue modificado con éxito.");
            }
            catch (ArgumentException ex)
            {
                return ResultDto.Warning(ex.Message);
            }
            catch (KeyNotFoundException)
            {
                return ResultDto.Warning("No se encontró el registro del tipo de menú que intenta modificar.");
            }
            catch (Exception)
            {
                return ResultDto.Fatal("Ocurrió un error inesperado al intentar actualizar el tipo de menú.");
            }
        }

        public ResultDto DeleteTipoMenu(int id)
        {
            try
            {
                _tipoMenuService.DeleteTipoMenu(id);
                return ResultDto.Success("El tipo de menú fue dado de baja correctamente.");
            }
            catch (KeyNotFoundException)
            {
                return ResultDto.Warning("No se encontró el registro del tipo de menú que desea dar de baja.");
            }
            catch (Exception)
            {
                return ResultDto.Fatal("Ocurrió un error inesperado al intentar dar de baja el tipo de menú.");
            }
        }

        public ResultDto ReactivateTipoMenu(int id)
        {
            try
            {
                _tipoMenuService.ReactivateTipoMenu(id);
                return ResultDto.Success("El tipo de menú ha sido reactivado con éxito.");
            }
            catch (KeyNotFoundException)
            {
                return ResultDto.Warning("No se encontró el registro del tipo de menú que desea reactivar.");
            }
            catch (Exception)
            {
                return ResultDto.Fatal("Ocurrió un error inesperado al intentar reactivar el tipo de menú.");
            }
        }
    }
}
