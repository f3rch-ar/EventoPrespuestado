using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventoPresupuestado.Model;
using EventoPresupuestado.Model.Enums;

namespace EventoPresupuestado.Dto
{
    public class ComidaDto : ModelBase
    {
        public string descripcionComida { get; set; }
        public EnumTipoCom estadoTipoCom { get; set; }
        public decimal valorComida { get; set; }


        public ComidaDto(int idCom, string descComida, EnumTipoCom estado, decimal valorCom, bool activoParm = true)
        {
            Id = idCom;
            descripcionComida = descComida;
            estadoTipoCom = estado;
            valorComida = valorCom;
            Activo = activoParm;
        }

        public ComidaDto(string descComida, EnumTipoCom estado, decimal valorCom)
        {
            descripcionComida = descComida;
            estadoTipoCom = estado;
            valorComida = valorCom;
            Activo = true;
        }

        public ComidaDto() { }
    }
}
