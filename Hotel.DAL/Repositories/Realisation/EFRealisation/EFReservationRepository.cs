using System;
using System.Collections.Generic;
using System.Linq;
using Hotel.DAL.Entities;
using Hotel.DAL.Repositories.Abstraction;

namespace Hotel.DAL.Repositories.Realisation.EFRealisation
{
    public class EFReservationRepository : EFGenericRepository<ReservationEntity, int>, IReservationRepository
    {
        public EFReservationRepository(HotelContext dbContext) : base(dbContext, dbContext.Reservations)
        {
        }
        
        public bool IsReservedRoomInThePeriod(int roomId, DateTime start, DateTime end)
        {
            var reservations = GetReservedRoomsInPeriod(start, end).Select(x => x.Id);
            var result = reservations.Contains(roomId);
            return result;
        }
        
        public IEnumerable<RoomEntity> GetReservedRoomsInPeriod(DateTime start, DateTime end)
        {
            var result = _dbContext.Reservations.AsEnumerable().Where(x =>
            {
                var startDate = x.StartTime;
                var endDate = startDate.AddSeconds(x.Duration);
                if (endDate < start || startDate > end) return true;
                return false;
            }).Select(x => x.Room).ToList();
            return result;
        }
        
        public void DeleteById(int id)
        {
            var itemForRemoving = _dbContext
                .Reservations
                .FirstOrDefault(r => r.Id == id);
            if (itemForRemoving != null) _dbContext.Reservations.Remove(itemForRemoving);
        }
    }
}
