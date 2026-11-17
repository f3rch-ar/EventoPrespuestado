using EventoPresupuestado.Model;
using EventoPresupuestado.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventoPresupuestado.Repository
{
    public class LugarRepository : BaseRepository<Lugar>
    {
        private static LugarRepository instance;

        private LugarRepository() { }

        public static LugarRepository getInstance()
        {
            if (instance == null)
            {
                instance = new LugarRepository();
            }
            return instance;
        }


        public override void Update(Lugar lugarModif)
        {
            //Lugar lugarExistente = listElementos.FirstOrDefault(x => x.Id == lugarModificado.Id);

            Lugar lugarExistente = GetID(lugarModif.Id);

            if (lugarExistente == null)
            {
                throw new KeyNotFoundException($"No se encontró ningún lugar/salón con el ID {lugarModif.Id} para actualizar.");
            }

            lugarExistente.NombreLugar = lugarModif.NombreLugar;
            lugarExistente.DescripcionLugar = lugarModif.DescripcionLugar;
            lugarExistente.PrecioBase = lugarModif.PrecioBase;
            lugarExistente.CantMaxPersonas = lugarModif.CantMaxPersonas;
            lugarExistente.Ocupado = lugarModif.Ocupado;

            if (lugarModif.RutaImagen != null)
            {
                lugarExistente.RutaImagen = lugarModif.RutaImagen;
            }
        }
    }
}
