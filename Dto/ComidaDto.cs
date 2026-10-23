using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EventoPresupuestado.Model.Enums;

namespace EventoPresupuestado.Dto
{
    public class ComidaDto
    {
        public int idComida { get; set; }
        public string descripcionComida { get; set; }
        public EnumTipoCom estadoTipoCom { get; set; }
        public decimal valorComida { get; set; }
        public bool activo { get; set; } = true;


        public ComidaDto(int idCom, string descComida, EnumTipoCom estado, decimal valorCom, bool activoParm = true)
        {
            idComida = idCom;
            descripcionComida = descComida;
            estadoTipoCom = estado;
            valorComida = valorCom;
            activo = activoParm;
        }

        public ComidaDto(string descComida, EnumTipoCom estado, decimal valorCom)
        {
            descripcionComida = descComida;
            estadoTipoCom = estado;
            valorComida = valorCom;
            activo = true;
        }

        public ComidaDto() { }
    }
}
