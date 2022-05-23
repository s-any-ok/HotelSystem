using Hotel.DAL.Entities;
using System.Collections.Generic;

namespace Hotel.DAL.Repositories.Abstraction
{
    public interface IRepository<T, KId> where T : BaseEntity<KId>
    {
        void Create(T item);
        T GetById(KId id);
        IEnumerable<T> GetAll();
        void Delete(T item);
        void Update(T item);
    }
}
