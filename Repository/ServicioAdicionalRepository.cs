using EventoPresupuestado.Model;
using EventoPresupuestado.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventoPresupuestado.Repository
{
    public class ServicioAdicionalRepository : BaseRepository<ServicioAdicional>
    {
        private static ServicioAdicionalRepository instance;

        private ServicioAdicionalRepository() { }

        public static ServicioAdicionalRepository getInstance()
        {
            if (instance == null)
            {
                instance = new ServicioAdicionalRepository();
            }
            return instance;
        }

        public override void Update(ServicioAdicional servicioModif)
        {
            //ServicioAdicional servicioExistente = listElementos.FirstOrDefault(x => x.Id == servicioModif.Id);
            ServicioAdicional servicioExistente = GetID(servicioModif.Id);

            if (servicioExistente == null)
            {
                throw new KeyNotFoundException($"No se encontró ningún servicio adicional con el ID {servicioModif.Id} para actualizar.");
            }

            servicioExistente.NombreServicio = servicioModif.NombreServicio;
            servicioExistente.Descripcion = servicioModif.Descripcion;
            servicioExistente.ValorServicio =   servicioModif.ValorServicio;
        }
    }
}
