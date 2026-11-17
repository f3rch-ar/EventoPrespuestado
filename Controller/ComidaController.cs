using EventoPresupuestado.Dto;
using EventoPresupuestado.Model;
using EventoPresupuestado.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventoPresupuestado.Controller
{
    public class ComidaController
    {
        private readonly ComidaService _comidaService;

        public ComidaController()
        {
            _comidaService = new ComidaService();
        }

        public ResultDto CreateComida(ComidaDto comida)
        {
            try
            {
                _comidaService.CreateComida(comida);
                return ResultDto.Success("La comida se registró correctamente en el sistema.");
            }
            catch (ArgumentException ex)
            {
                return ResultDto.Warning(ex.Message);
            }
            catch (Exception)
            {
                return ResultDto.Fatal("Ocurrió un error inesperado al intentar registrar la comida. Intente nuevamente.");
            }
        }

        public List<ComidaDto> GetComidas()
        {
            return _comidaService.GetComidas();
        }

        public List<ComidaDto> GetComidasNoActivas()
        {
            return _comidaService.GetComidasNoActivas();
        }

        public ResultDto UpdateComida(ComidaDto comida)
        {
            try
            {
                _comidaService.UpdateComida(comida);
                return ResultDto.Success("La comida fue modificada con éxito.");
            }
            catch (ArgumentException ex)
            {
                return ResultDto.Warning(ex.Message);
            }
            catch (KeyNotFoundException)
            {
                return ResultDto.Warning("No se encontró el registro de la comida que intenta modificar.");
            }
            catch (Exception)
            {
                return ResultDto.Fatal("Ocurrió un error inesperado al intentar actualizar la comida.");
            }
        }

        public ResultDto DeleteComida(int id)
        {
            try
            {
                _comidaService.DeleteComida(id);
                return ResultDto.Success("La comida fue dada de baja correctamente.");
            }
            catch (KeyNotFoundException)
            {
                return ResultDto.Warning("No se encontró el registro de la comida que desea dar de baja.");
            }
            catch (Exception)
            {
                return ResultDto.Fatal("Ocurrió un error inesperado al intentar dar de baja la comida.");
            }
        }

        public ResultDto ReactivateComida(int id)
        {
            try
            {
                _comidaService.ReactivateComida(id);
                return ResultDto.Success("La comida ha sido reactivada con éxito.");
            }
            catch (KeyNotFoundException)
            {
                return ResultDto.Warning("No se encontró el registro de la comida que desea reactivar.");
            }
            catch (Exception)
            {
                return ResultDto.Fatal("Ocurrió un error inesperado al intentar reactivar la comida.");
            }
        }

        public ResultDto DeleteComidaPermanente(int id)
        {
            try
            {
                _comidaService.DeleteComidaPermanente(id);
                return ResultDto.Success("La comida fue eliminada definitivamente del sistema.");
            }
            catch (KeyNotFoundException)
            {
                return ResultDto.Warning("No se encontró el registro de la comida que intenta eliminar de forma definitiva.");
            }
            catch (Exception)
            {
                return ResultDto.Fatal("Ocurrió un error inesperado al intentar realizar la eliminación permanente.");
            }
        }
    }
}
