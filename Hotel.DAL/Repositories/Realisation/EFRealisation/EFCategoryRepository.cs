using Hotel.DAL.Entities;
using Hotel.DAL.Repositories.Abstraction;

namespace Hotel.DAL.Repositories.Realisation.EFRealisation
{
    public class EFCategoryRepository : EFGenericRepository<CategoryEntity, int>, ICategoryRepository
    {
        public EFCategoryRepository(HotelContext dbContext) : base(dbContext, dbContext.Categories)
        {
        }
    }
}
