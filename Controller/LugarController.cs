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
            catch (Exception ex)
            {
                return ResultDto.Fatal("No se pudo agregar el salón debido a un error del sistema: " + ex.Message);
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
            catch (KeyNotFoundException ex)
            {
                return ResultDto.Warning(ex.Message);
            }
            catch (Exception ex)
            {
                return ResultDto.Fatal("No se pudo modificar el salón debido a un error del sistema: " + ex.Message);
            }
        }

        public ResultDto DeleteLugar(int id)
        {
            try
            {
                _lugarService.DeleteLugar(id);
                return ResultDto.Success("El salón/lugar fue dado de baja correctamente.");
            }
            catch (KeyNotFoundException ex)
            {
                return ResultDto.Warning(ex.Message);
            }
            catch (Exception ex)
            {
                return ResultDto.Fatal("No se pudo eliminar el salón debido a un error del sistema: " + ex.Message);
            }
        }

        public ResultDto ReactivateLugar(int id)
        {
            try
            {
                _lugarService.ReactivateLugar(id);
                return ResultDto.Success("El salón/lugar ha sido reactivado con éxito.");
            }
            catch (KeyNotFoundException ex)
            {
                return ResultDto.Warning(ex.Message);
            }
            catch (Exception ex)
            {
                return ResultDto.Fatal("No se pudo reactivar el salón debido a un error del sistema: " + ex.Message);
            }
        }

        public ResultDto DeleteLugarPermanente(int id)
        {
            try
            {
                _lugarService.DeleteLugarPermanente(id);
                return ResultDto.Success("El salón/lugar fue eliminado definitivamente del sistema.");
            }
            catch (KeyNotFoundException ex)
            {
                return ResultDto.Warning(ex.Message);
            }
            catch (Exception ex)
            {
                return ResultDto.Fatal("No se pudo eliminar definitivamente el salón debido a un error del sistema: " + ex.Message);
            }
        }
    }
}
