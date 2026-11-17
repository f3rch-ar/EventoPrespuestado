using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventoPresupuestado.Dto
{
    public class ServicioAdicionalDto : BaseDto
    {
        public string nombreServicio { get; set; }
        public string descripcion { get; set; }
        public decimal valorServicio { get; set; }

        public ServicioAdicionalDto()
        {
            Activo = true;
        }

        public ServicioAdicionalDto(string nombreServ, string descp, decimal valorServ)
        {
            nombreServicio = nombreServ;
            descripcion = descp;
            valorServicio = valorServ;
            Activo = true;
        }

        public ServicioAdicionalDto(int idServ, string nombreServ, string descp, decimal valorServ, bool estaActivo)
        {
            Id = idServ;
            nombreServicio = nombreServ;
            descripcion = descp;
            valorServicio = valorServ;
            Activo = estaActivo;
        }
    }
}
