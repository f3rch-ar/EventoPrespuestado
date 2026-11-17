using EventoPresupuestado.Dto;
using EventoPresupuestado.Model;
using EventoPresupuestado.Repository;
using EventoPresupuestado.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventoPresupuestado.Service
{
    public class ServicioAdicionalService : BaseService
    {
        private readonly IRepository<ServicioAdicional> _servicioRepository;

        public ServicioAdicionalService()
        {
            _servicioRepository = ServicioAdicionalRepository.getInstance();
        }

        public void CreateServicio(ServicioAdicionalDto servicioDto)
        {

            compareServicio(servicioDto);

            ServicioAdicional servicioModel = new ServicioAdicional(
                servicioDto.nombreServicio,
                servicioDto.descripcion,
                servicioDto.valorServicio
            );

            _servicioRepository.Create(servicioModel);
        }

        private void compareServicio(ServicioAdicionalDto servicio)
        {
            List<ServicioAdicionalDto> serviciosExistentes = GetServicios();

            string nombreNuevoNormalizado = NormalizarTexto(servicio.nombreServicio);
            string descripcionNuevaNormalizada = NormalizarTexto(servicio.descripcion);

            foreach (ServicioAdicionalDto existente in serviciosExistentes)
            {
                string nombreExistenteNormalizado = NormalizarTexto(existente.nombreServicio);
                string descripcionExistenteNormalizada = NormalizarTexto(existente.descripcion);

                bool mismoNombre = nombreExistenteNormalizado.Equals(nombreNuevoNormalizado) && existente.Id != servicio.Id;
                bool mismaDescripcion = descripcionExistenteNormalizada.Equals(descripcionNuevaNormalizada) && existente.Id != servicio.Id;

                if (mismoNombre || mismaDescripcion)
                {
                    throw new ArgumentException("Ya existe un servicio adicional igual registrado en el sistema.");
                }
            }
        }

        public List<ServicioAdicionalDto> GetServicios()
        {
            return _servicioRepository.GetAlls()
                .Select(serv => new ServicioAdicionalDto(
                    serv.Id,
                    serv.NombreServicio,
                    serv.Descripcion,
                    serv.ValorServicio,
                    serv.Activo
                )).ToList();
        }

        public List<ServicioAdicionalDto> GetServiciosNoActivos()
        {
            return _servicioRepository.GetAlls_NoActivos()
                .Select(serv => new ServicioAdicionalDto(
                    serv.Id,
                    serv.NombreServicio,
                    serv.Descripcion,
                    serv.ValorServicio,
                    serv.Activo
                )).ToList();
        }

        public void UpdateServicio(ServicioAdicionalDto servicioDto)
        {
            compareServicio(servicioDto);

            ServicioAdicional servicioModel = new ServicioAdicional(
                servicioDto.Id,
                servicioDto.nombreServicio,
                servicioDto.descripcion,
                servicioDto.valorServicio
            );

            servicioModel.Activo = servicioDto.Activo;

            _servicioRepository.Update(servicioModel);
        }

        public void DeleteServicio(int id)
        {
            _servicioRepository.Delete(id);
        }

        public void ReactivateServicio(int id)
        {
            _servicioRepository.Reactivar(id);
        }

        public void DeleteServicioPermanente(int id)
        {
            _servicioRepository.DeletePermanent(id);
        }
    }
}
