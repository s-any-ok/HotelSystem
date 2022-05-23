using Hotel.DAL.Entities;
using Hotel.DAL.Repositories.Abstraction;

namespace Hotel.DAL.Repositories.Realisation.EFRealisation
{
    public class EFStatusRepository : EFGenericRepository<StatusEntity, int>, IStatusRepository
    {
        public EFStatusRepository(HotelContext dbContext) : base(dbContext, dbContext.Statuses)
        {
        }
    }
}
