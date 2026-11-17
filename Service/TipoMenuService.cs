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
    public class TipoMenuService : BaseService
    {
        private readonly IRepository<TipoMenu> _tipoMenuRepository;

        public TipoMenuService()
        {
            _tipoMenuRepository = TipoMenuRepository.getInstance();
        }

        public void CreateTipoMenu(TipoMenuDto tipoMenuDto)
        {
            compareTipoMenu(tipoMenuDto);

            List<Comida> comidasModel = GetMapListComidas(tipoMenuDto.ListaComidas);

            TipoMenu tipoMenuModel = new TipoMenu(
                tipoMenuDto.NombreMenu,
                //valorTotalMenu,
                comidasModel
            );

            tipoMenuModel.CalcularTotalComidas();

            _tipoMenuRepository.Create(tipoMenuModel);
        }

        private void compareTipoMenu(TipoMenuDto tipoMenu)
        {
            List<TipoMenuDto> tiposMenuExistentes = GetTipoMenus();

            string nombreNuevoNormalizado = NormalizarTexto(tipoMenu.NombreMenu);

            List<int> idsComidasNuevas = new List<int>();
            if (tipoMenu.ListaComidas != null)
            {
                idsComidasNuevas = tipoMenu.ListaComidas
                    .Select(com => com.Id)
                    .OrderBy(id => id)
                    .ToList();
            }

            foreach (TipoMenuDto existente in tiposMenuExistentes)
            {
                string nombreExistenteNormalizado = NormalizarTexto(existente.NombreMenu);

                if (nombreExistenteNormalizado.Equals(nombreNuevoNormalizado) && existente.Id != tipoMenu.Id)
                {
                    throw new ArgumentException("Ya existe un tipo de menú con ese nombre registrado en el sistema.");
                }

                if (existente.ListaComidas != null && existente.ListaComidas.Count > 0)
                {
                    List<int> idsComidasExistentes = existente.ListaComidas
                        .Select(com => com.Id)
                        .OrderBy(id => id)
                        .ToList();

                    if (idsComidasExistentes.SequenceEqual(idsComidasNuevas) && existente.Id != tipoMenu.Id)
                    {
                        throw new ArgumentException("Ya existe un tipo de menú registrado con exactamente esta misma combinación de comidas.");
                    }
                }
            }
        }

        private List<Comida> GetMapListComidas(List<ComidaDto> listaComidasDto)
        {
            List<Comida> listComidasModelR = new List<Comida>();

            foreach (ComidaDto comidaDto in listaComidasDto)
            {
                Comida comidaModel = new Comida(
                    comidaDto.Id,
                    comidaDto.descripcionComida,
                    comidaDto.estadoTipoCom,
                    comidaDto.valorComida
                );
                listComidasModelR.Add(comidaModel);
            }

            return listComidasModelR;
        }


        public List<TipoMenuDto> GetTipoMenus()
        {
            return _tipoMenuRepository.GetAlls()
                .Select(menu => new TipoMenuDto(
                    menu.Id,
                    menu.NombreMenu,
                    menu.Activo,
                    menu.ListComidas.Select(com => new ComidaDto(
                        com.Id,
                        com.DescripcionComida,
                        com.TipoDeComida,
                        com.ValorComida,
                        com.Activo
                    )).ToList()
                )).ToList();
        }

        public List<TipoMenuDto> GetTipoMenusNoActivos()
        {
            return _tipoMenuRepository.GetAlls_NoActivos()
                .Select(menu => new TipoMenuDto(
                    menu.Id,
                    menu.NombreMenu,
                    menu.Activo,
                    menu.ListComidas.Select(com => new ComidaDto(
                        com.Id,
                        com.DescripcionComida,
                        com.TipoDeComida,
                        com.ValorComida,
                        com.Activo
                    )).ToList()
                )).ToList();
        }

        public void UpdateTipoMenu(TipoMenuDto tipoMenuDto)
        {
            compareTipoMenu(tipoMenuDto);

            List<Comida> comidasModel = GetMapListComidas(tipoMenuDto.ListaComidas);

            TipoMenu tipoMenuModel = new TipoMenu(
                tipoMenuDto.Id,
                tipoMenuDto.NombreMenu,
                comidasModel,
                tipoMenuDto.Activo
            );

            tipoMenuModel.CalcularTotalComidas();

            _tipoMenuRepository.Update(tipoMenuModel);
        }

        public void DeleteTipoMenu(int id)
        {
            _tipoMenuRepository.Delete(id);
        }

        public void ReactivateTipoMenu(int id)
        {
            _tipoMenuRepository.Reactivar(id);
        }
    }
}
