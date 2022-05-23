using Hotel.DAL.Entities;
using Hotel.DAL.Repositories.Abstraction;

namespace Hotel.DAL.Repositories.Realisation.EFRealisation
{
    public class EFRoomRepository : EFGenericRepository<RoomEntity, int>, IRoomRepository
    {
        public EFRoomRepository(HotelContext dbContext) : base(dbContext, dbContext.Rooms)
        {
        }
    }
}
