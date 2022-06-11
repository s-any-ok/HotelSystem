using Hotel.DAL.Entities;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Hotel.DAL.Repositories.Abstraction
{
    public interface IRepository<T, KId> where T : BaseEntity<KId>
    {
        EntityEntry<T> Create(T item);
        T GetById(KId id);
        IEnumerable<T> GetAll();
        void Delete(T item);
        void Update(T item);
    }
}
