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
            return listElementos.Max(element => element.Id) + 1;
        }

        public virtual void Create(T element)
        {
            
            if (element.Id == 0)
            {
                element.Id = GenerarNextId();
            }
            listElementos.Add(element);
        }

        public virtual List<T> GetAlls()
        {
            return listElementos.Where(element => element.Activo).ToList();
        }

        public virtual List<T> GetAlls_NoActivos()
        {
            return listElementos;
        }


        public virtual T GetID(int id)
        {
            //return listElementos.FirstOrDefault(element => element.Id == id);
            return listElementos.FirstOrDefault(element => element.Id == id && element.Activo);
        }

        public virtual void Delete(int id)
        {
            //T elementExistente = listElementos.FirstOrDefault(element => element.Id == id);

            T elementExistente = GetID(id);

            if (elementExistente == null)
            {
                throw new KeyNotFoundException($"No se encontró el registro con el ID {id} para dar de baja.");
            }

            elementExistente.Activo = false;
        }

        public virtual void DeletePermanent(int id)
        {
            T elementoExistente = listElementos.FirstOrDefault(element => element.Id == id);

            if (elementoExistente == null)
            {
                throw new KeyNotFoundException($"No se encontró el registro con el ID {id} para eliminar definitivamente.");
            }

            listElementos.Remove(elementoExistente);
        }

        public virtual void Reactivar(int id)
        {
            T elementoExistente = listElementos.FirstOrDefault(element => element.Id == id);

            if (elementoExistente == null)
            {
                throw new KeyNotFoundException($"No se encontró el registro con el ID {id} para reactivar.");
            }

            elementoExistente.Activo = true;
        }


        public abstract void Update(T entidad);
        
    }
}
