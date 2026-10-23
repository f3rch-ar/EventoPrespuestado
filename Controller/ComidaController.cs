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
            catch (Exception ex)
            {
                return ResultDto.Fatal("No se pudo agregar la comida debido a un error del sistema: " + ex.Message);
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
            catch (KeyNotFoundException ex)
            {
                return ResultDto.Warning(ex.Message);
            }
            catch (Exception ex)
            {
                return ResultDto.Fatal("No se pudo modificar la comida debido a un error del sistema: " + ex.Message);
            }
        }

        public ResultDto DeleteComida(int id)
        {
            try
            {
                _comidaService.DeleteComida(id);
                return ResultDto.Success("La comida fue dada de baja correctamente.");
            }
            catch (KeyNotFoundException ex)
            {
                return ResultDto.Warning(ex.Message);
            }
            catch (Exception ex)
            {
                return ResultDto.Fatal("No se pudo eliminar la comida debido a un error del sistema: " + ex.Message);
            }
        }

        public ResultDto ReactivateComida(int id)
        {
            try
            {
                _comidaService.ReactivateComida(id);
                return ResultDto.Success("La comida ha sido reactivada con éxito.");
            }
            catch (KeyNotFoundException ex)
            {
                return ResultDto.Warning(ex.Message);
            }
            catch (Exception ex)
            {
                return ResultDto.Fatal("No se pudo reactivar la comida debido a un error del sistema: " + ex.Message);
            }
        }

        public ResultDto DeleteComidaPermanente(int id)
        {
            try
            {
                _comidaService.DeleteComidaPermanente(id);
                return ResultDto.Success("La comida fue eliminada definitivamente del sistema.");
            }
            catch (KeyNotFoundException ex)
            {
                return ResultDto.Warning(ex.Message);
            }
            catch (Exception ex)
            {
                return ResultDto.Fatal("No se pudo eliminar definitivamente la comida debido a un error del sistema: " + ex.Message);
            }
        }
    }
}
