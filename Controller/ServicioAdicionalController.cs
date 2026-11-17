using EventoPresupuestado.Dto;
using EventoPresupuestado.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventoPresupuestado.Controller
{
    public class ServicioAdicionalController
    {
        private readonly ServicioAdicionalService _servicioService;

        public ServicioAdicionalController()
        {
            _servicioService = new ServicioAdicionalService();
        }

        public ResultDto CreateServicioAdicional(ServicioAdicionalDto servicioDto)
        {
            try
            {
                _servicioService.CreateServicio(servicioDto);
                return ResultDto.Success("El servicio adicional se registró correctamente en el sistema.");
            }
            catch (ArgumentException ex)
            {
                return ResultDto.Warning(ex.Message);
            }
            catch (Exception)
            {
                return ResultDto.Fatal("Ocurrió un error inesperado al intentar registrar el servicio adicional. Intente nuevamente.");
            }
        }

        public List<ServicioAdicionalDto> GetServiciosAdicionales()
        {
            return _servicioService.GetServicios();
        }

        public List<ServicioAdicionalDto> GetServiciosAdicionalesNoActivos()
        {
            return _servicioService.GetServiciosNoActivos();
        }

        public ResultDto UpdateServicioAdicional(ServicioAdicionalDto servicioDto)
        {
            try
            {
                _servicioService.UpdateServicio(servicioDto);
                return ResultDto.Success("El servicio adicional fue modificado con éxito.");
            }
            catch (ArgumentException ex)
            {
                return ResultDto.Warning(ex.Message);
            }
            catch (KeyNotFoundException)
            {
                return ResultDto.Warning("No se encontró el registro del servicio adicional que intenta modificar.");
            }
            catch (Exception)
            {
                return ResultDto.Fatal("Ocurrió un error inesperado al intentar actualizar el servicio adicional.");
            }
        }

        public ResultDto DeleteServicioAdicional(int id)
        {
            try
            {
                _servicioService.DeleteServicio(id);
                return ResultDto.Success("El servicio adicional fue dado de baja correctamente.");
            }
            catch (KeyNotFoundException)
            {
                return ResultDto.Warning("No se encontró el registro del servicio adicional que desea dar de baja.");
            }
            catch (Exception)
            {
                return ResultDto.Fatal("Ocurrió un error inesperado al intentar dar de baja el servicio adicional.");
            }
        }

        public ResultDto ReactivateServicioAdicional(int id)
        {
            try
            {
                _servicioService.ReactivateServicio(id);
                return ResultDto.Success("El servicio adicional ha sido reactivado con éxito.");
            }
            catch (KeyNotFoundException)
            {
                return ResultDto.Warning("No se encontró el registro del servicio adicional que desea reactivar.");
            }
            catch (Exception)
            {
                return ResultDto.Fatal("Ocurrió un error inesperado al intentar reactivar el servicio adicional.");
            }
        }

        public ResultDto DeleteServicioAdicionalPermanente(int id)
        {
            try
            {
                _servicioService.DeleteServicioPermanente(id);
                return ResultDto.Success("El servicio adicional fue eliminado definitivamente del sistema.");
            }
            catch (KeyNotFoundException)
            {
                return ResultDto.Warning("No se encontró el registro del servicio adicional que intenta eliminar de forma definitiva.");
            }
            catch (Exception)
            {
                return ResultDto.Fatal("Ocurrió un error inesperado al intentar realizar la eliminación permanente del servicio adicional.");
            }
        }
    }
}
