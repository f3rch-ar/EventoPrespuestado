using EventoPresupuestado.Dto;
using EventoPresupuestado.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventoPresupuestado.Controller
{
    public class LugarController
    {
        private readonly LugarService _lugarService;

        public LugarController()
        {
            _lugarService = new LugarService();
        }

        public ResultDto CreateLugar(LugarDto lugar)
        {
            try
            {
                _lugarService.CreateLugar(lugar);
                return ResultDto.Success("El salón/lugar se registró correctamente en el sistema.");
            }
            catch (ArgumentException ex)
            {
                return ResultDto.Warning(ex.Message);
            }
            catch (Exception)
            {
                return ResultDto.Fatal("Ocurrió un error inesperado al intentar registrar el salón. Intente nuevamente.");
            }
        }

        public List<LugarDto> GetLugares()
        {
            return _lugarService.GetLugares();
        }

        public List<LugarDto> GetLugaresNoActivos()
        {
            return _lugarService.GetLugaresNoActivos();
        }

        public ResultDto UpdateLugar(LugarDto lugar)
        {
            try
            {
                _lugarService.UpdateLugar(lugar);
                return ResultDto.Success("El salón/lugar fue modificado con éxito.");
            }
            catch (ArgumentException ex)
            {
                return ResultDto.Warning(ex.Message);
            }
            catch (KeyNotFoundException)
            {
                return ResultDto.Warning("No se encontró el registro del salón que intenta modificar.");
            }
            catch (Exception)
            {
                return ResultDto.Fatal("Ocurrió un error inesperado al intentar actualizar el salón.");
            }
        }

        public ResultDto DeleteLugar(int id)
        {
            try
            {
                _lugarService.DeleteLugar(id);
                return ResultDto.Success("El salón/lugar fue dado de baja correctamente.");
            }
            catch (KeyNotFoundException)
            {
                return ResultDto.Warning("No se encontró el registro del salón que desea dar de baja.");
            }
            catch (Exception)
            {
                return ResultDto.Fatal("Ocurrió un error inesperado al intentar dar de baja el salón.");
            }
        }

        public ResultDto ReactivateLugar(int id)
        {
            try
            {
                _lugarService.ReactivateLugar(id);
                return ResultDto.Success("El salón/lugar ha sido reactivado con éxito.");
            }
            catch (KeyNotFoundException)
            {
                return ResultDto.Warning("No se encontró el registro del salón que desea reactivar.");
            }
            catch (Exception)
            {
                return ResultDto.Fatal("Ocurrió un error inesperado al intentar reactivar el salón.");
            }
        }

        public ResultDto DeleteLugarPermanente(int id)
        {
            try
            {
                _lugarService.DeleteLugarPermanente(id);
                return ResultDto.Success("El salón/lugar fue eliminado definitivamente del sistema.");
            }
            catch (KeyNotFoundException)
            {
                return ResultDto.Warning("No se encontró el registro del salón que intenta eliminar de forma definitiva.");
            }
            catch (Exception)
            {
                return ResultDto.Fatal("Ocurrió un error inesperado al intentar realizar la eliminación permanente del salón.");
            }
        }
    }
}
