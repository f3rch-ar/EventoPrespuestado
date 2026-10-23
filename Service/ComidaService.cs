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
    public class ComidaService
    {

        private readonly IRepository<Comida> _comidaRepository;

        public ComidaService()
        {
            _comidaRepository = ComidaRepository.getInstance();
        }

        public void CreateComida(ComidaDto comida)
        {
            Comida comidaModel = new Comida(comida.idComida, comida.descripcionComida, comida.estadoTipoCom, comida.valorComida);
            _comidaRepository.Create(comidaModel);
        }

        public List<ComidaDto> GetComidas()
        {
            //return _comidaRepository.GetAlls();

            return _comidaRepository.GetAlls()
                .Select(getComida => new ComidaDto(getComida.Id, getComida.DescripcionComida, getComida.TipoDeComida, getComida.ValorComida, getComida.Activo)).ToList();
        }

        public List<ComidaDto> GetComidasNoActivas()
        {
            //return _comidaRepository.GetAlls_NoActivos();
            return _comidaRepository.GetAlls_NoActivos()
                .Select(getComida => new ComidaDto(getComida.Id, getComida.DescripcionComida, getComida.TipoDeComida, getComida.ValorComida, getComida.Activo)).ToList();
        }

        public void UpdateComida(ComidaDto comidaDto)
        {
            Comida comidaModel = new Comida(comidaDto.idComida, comidaDto.descripcionComida, comidaDto.estadoTipoCom, comidaDto.valorComida);
            _comidaRepository.Update(comidaModel);
        }

        public void DeleteComida(int id)
        {
            _comidaRepository.Delete(id);
        }

        public void ReactivateComida(int id)
        {
            _comidaRepository.Reactivar(id);
        }

        public void DeleteComidaPermanente(int id)
        {
            _comidaRepository.DeletePermanent(id);
        }

    }
}
