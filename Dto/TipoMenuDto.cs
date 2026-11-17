using EventoPresupuestado.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventoPresupuestado.Dto
{
    public class TipoMenuDto : BaseDto
    {
        public string NombreMenu { get; set; }
        public decimal ValorTipoMenu { get; set; }
        public List<ComidaDto> ListaComidas { get; set; }

        public TipoMenuDto()
        {
            ListaComidas = new List<ComidaDto>();
            Activo = true;
        }

        public TipoMenuDto(string nombreMenu, decimal valorTipoMenu, List<ComidaDto> listaComidas)
        {
            NombreMenu = nombreMenu;
            ValorTipoMenu = valorTipoMenu;
            ListaComidas = listaComidas ?? new List<ComidaDto>();
            Activo = true;
        }

        public TipoMenuDto(int id, string nombreMenu, bool activo, List<ComidaDto> listaComidas)
        {
            Id = id;
            NombreMenu = nombreMenu;
            Activo = activo;
            ListaComidas = listaComidas ?? new List<ComidaDto>();
        }
    }
}
