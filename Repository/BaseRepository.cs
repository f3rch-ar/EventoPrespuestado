using EventoPresupuestado.Model;
using EventoPresupuestado.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventoPresupuestado.Repository
{
    public abstract class BaseRepository<T> : IRepository<T> where T : ModelBase
    {

        protected readonly List<T> listElementos = new List<T>();


        private int GenerarNextId()
        {
            if (listElementos.Count == 0)
            {
                return 1;
            }
            return listElementos.Max(x => x.Id) + 1;
        }

        public virtual void Create(T entidad)
        {
            
            if (entidad.Id == 0)
            {
                entidad.Id = GenerarNextId();
            }
            listElementos.Add(entidad);
        }

        public virtual List<T> GetAlls()
        {
            return listElementos.Where(x => x.Activo).ToList();
        }

        public virtual List<T> GetAlls_NoActivos()
        {
            return listElementos;
        }


        public virtual T GetID(int id)
        {
            //return listElementos.FirstOrDefault(x => x.Id == id);
            return listElementos.FirstOrDefault(x => x.Id == id && x.Activo);
        }

        public virtual void Delete(int id)
        {
            T elementoExistente = listElementos.FirstOrDefault(x => x.Id == id);

            if (elementoExistente == null)
            {
                throw new KeyNotFoundException($"No se encontró el registro con el ID {id} para dar de baja.");
            }

            elementoExistente.Activo = false;
        }

        public virtual void DeletePermanent(int id)
        {
            T elementoExistente = listElementos.FirstOrDefault(x => x.Id == id);

            if (elementoExistente == null)
            {
                throw new KeyNotFoundException($"No se encontró el registro con el ID {id} para eliminar definitivamente.");
            }

            listElementos.Remove(elementoExistente);
        }

        public virtual void Reactivar(int id)
        {
            T elementoExistente = listElementos.FirstOrDefault(x => x.Id == id);

            if (elementoExistente == null)
            {
                throw new KeyNotFoundException($"No se encontró el registro con el ID {id} para reactivar.");
            }

            elementoExistente.Activo = true;
        }


        public abstract void Update(T entidad);
        
    }
}
