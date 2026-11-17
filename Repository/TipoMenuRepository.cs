using EventoPresupuestado.Model;
using EventoPresupuestado.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventoPresupuestado.Repository
{
    public class TipoMenuRepository : BaseRepository<TipoMenu>
    {
        private static TipoMenuRepository instance;

        private TipoMenuRepository() { }

        public static TipoMenuRepository getInstance()
        {
            if (instance == null)
            {
                instance = new TipoMenuRepository();
            }
            return instance;
        }

        public override void Update(TipoMenu tipoMenuModif)
        {
            TipoMenu tipoMenuExistente = GetID(tipoMenuModif.Id);

            if (tipoMenuExistente == null)
            {
                throw new KeyNotFoundException($"No se encontró ningún tipo de menú con el ID {tipoMenuModif.Id} para actualizar.");
            }

            tipoMenuExistente.NombreMenu = tipoMenuModif.NombreMenu;
        }
    }
}
