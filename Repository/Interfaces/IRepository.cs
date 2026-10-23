using EventoPresupuestado.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventoPresupuestado.Repository.Interfaces
{
    public interface IRepository<T> where T : ModelBase
    {
        void Create(T objectBase);
        List<T> GetAlls();
        List<T> GetAlls_NoActivos();
        T GetID(int id);
        void Update(T objectBase);
        void Delete(int id);
        void DeletePermanent(int id);
        void Reactivar(int id);
    }
}
