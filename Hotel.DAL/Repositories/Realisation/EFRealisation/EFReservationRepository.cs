using Hotel.DAL;
using Hotel.DAL.Entities;
using Hotel.DAL.Repositories.Abstraction;

namespace Hotel.DAL.Repositories.Realisation.EFRealisation
{
    public class EFReservationRepository : EFGenericRepository<ReservationEntity, int>, IReservationRepository
    {
        public EFReservationRepository(HotelContext dbContext) : base(dbContext, dbContext.Reservations)
        {
        }
    }
}
