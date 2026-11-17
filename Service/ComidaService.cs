using EventoPresupuestado.Dto;
using EventoPresupuestado.Model;
using EventoPresupuestado.Model.Enums;
using EventoPresupuestado.Repository;
using EventoPresupuestado.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventoPresupuestado.Service
{
    public class ComidaService : BaseService
    {
        private readonly IRepository<Comida> _comidaRepository;

        public ComidaService()
        {
            _comidaRepository = ComidaRepository.getInstance();
        }

        public void CreateComida(ComidaDto comidaDto)
        {
            compareComida(comidaDto);

            Comida comidaModel = new Comida(
                comidaDto.descripcionComida,
                comidaDto.estadoTipoCom,
                comidaDto.valorComida
            );

            _comidaRepository.Create(comidaModel);
        }

        private void compareComida(ComidaDto comida)
        {
            List<ComidaDto> comidasExistentes = GetComidas();

            string descripcionNuevaNormalizada = NormalizarTexto(comida.descripcionComida);

            foreach (ComidaDto existente in comidasExistentes)
            {
                string descripcionExistenteNormalizada = NormalizarTexto(existente.descripcionComida);

                if (descripcionExistenteNormalizada.Equals(descripcionNuevaNormalizada) && existente.Id != comida.Id)
                {
                    throw new ArgumentException("Ya existe una comida con esa descripción registrada en el sistema.");
                }
            }
        }

        public List<ComidaDto> GetComidas()
        {
            return _comidaRepository.GetAlls()
                .Select(getComida => new ComidaDto(
                    getComida.Id,
                    getComida.DescripcionComida,
                    getComida.TipoDeComida,
                    getComida.ValorComida,
                    getComida.Activo
                )).ToList();
        }

        public List<ComidaDto> GetComidasNoActivas()
        {
            return _comidaRepository.GetAlls_NoActivos()
                .Select(getComida => new ComidaDto(
                    getComida.Id,
                    getComida.DescripcionComida,
                    getComida.TipoDeComida,
                    getComida.ValorComida,
                    getComida.Activo
                )).ToList();
        }

        public void UpdateComida(ComidaDto comidaDto)
        {
            compareComida(comidaDto);

            Comida comidaModel = new Comida(
                comidaDto.Id,
                comidaDto.descripcionComida,
                comidaDto.estadoTipoCom,
                comidaDto.valorComida
            );

            comidaModel.Activo = comidaDto.Activo;

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

        public List<ComidaDto> GetComidasPorCategoria(EnumTipoCom tipoComida)
        {
            return GetComidas()
                .Where(com => com.estadoTipoCom == tipoComida)
                .ToList();
        }
    }
}
