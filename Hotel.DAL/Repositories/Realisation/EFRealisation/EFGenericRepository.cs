using Hotel.DAL.Entities;
using Hotel.DAL.Repositories.Abstraction;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Hotel.DAL.Repositories.Realisation.EFRealisation
{
    public class EFGenericRepository<T, KId> : IRepository<T, KId> where T : BaseEntity<KId>
    {
        protected readonly HotelContext _dbContext;
        protected readonly DbSet<T> _entities;

        public EFGenericRepository(HotelContext dbContext, DbSet<T> dbSet)
        {
            _dbContext = dbContext;
            _entities = dbSet;
        }

        public EntityEntry<T> Create(T entity)
        {
            return _entities.Add(entity);
        }

        public void Update(T entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
        }

        public void Delete(T entity)
        {
            _entities.Remove(entity);
        }

        public virtual T GetById(KId id)
        {
            return _entities.Find(id);
        }

        public virtual IEnumerable<T> GetAll()
        {
            return _entities.AsNoTracking();
        }
    }
}
