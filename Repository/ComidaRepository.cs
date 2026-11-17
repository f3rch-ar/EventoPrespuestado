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

        public override void Update(Comida comidaModif)
        {
            //Comida comidaExistente = listElementos.FirstOrDefault(comida => comida.Id == comidaModificada.Id);

            Comida comidaExistente = GetID(comidaModif.Id);

            if (comidaExistente == null)
            {
                throw new KeyNotFoundException($"No se encontró ninguna comida con el ID {comidaModif.Id} para actualizar.");
            }

            comidaExistente.DescripcionComida = comidaModif.DescripcionComida;
            comidaExistente.TipoDeComida = comidaModif.TipoDeComida;
            comidaExistente.ValorComida = comidaModif.ValorComida;
        }
    }
}
