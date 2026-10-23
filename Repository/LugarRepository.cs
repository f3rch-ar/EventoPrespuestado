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


        public override void Update(Lugar lugarModificado)
        {
            Lugar lugarExistente = listElementos.FirstOrDefault(x => x.Id == lugarModificado.Id);

            if (lugarExistente == null)
            {
                throw new KeyNotFoundException($"No se encontró ningún lugar/salón con el ID {lugarModificado.Id} para actualizar.");
            }

            lugarExistente.NombreLugar = lugarModificado.NombreLugar;
            lugarExistente.DescripcionLugar = lugarModificado.DescripcionLugar;
            lugarExistente.PrecioBase = lugarModificado.PrecioBase;
            lugarExistente.CantMaxPersonas = lugarModificado.CantMaxPersonas;
            lugarExistente.Ocupado = lugarModificado.Ocupado;

            if (lugarModificado.RutaImagen != null)
            {
                lugarExistente.RutaImagen = lugarModificado.RutaImagen;
            }
        }
    }
}
