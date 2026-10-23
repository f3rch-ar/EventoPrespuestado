using EventoPresupuestado.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventoPresupuestado.Repository
{
    public class ComidaRepository : BaseRepository<Comida>
    {
        private static ComidaRepository instance;

        private ComidaRepository() { }

        public static ComidaRepository getInstance()
        {
            if (instance == null)
            {
                instance = new ComidaRepository();
            }
            return instance;
        }

        public override void Update(Comida comidaModificada)
        {
            Comida comidaExistente = listElementos.FirstOrDefault(x => x.Id == comidaModificada.Id);

            if (comidaExistente == null)
            {
                throw new KeyNotFoundException($"No se encontró ninguna comida con el ID {comidaModificada.Id} para actualizar.");
            }

            comidaExistente.DescripcionComida = comidaModificada.DescripcionComida;
            comidaExistente.TipoDeComida = comidaModificada.TipoDeComida;
            comidaExistente.ValorComida = comidaModificada.ValorComida;
        }
    }
}
