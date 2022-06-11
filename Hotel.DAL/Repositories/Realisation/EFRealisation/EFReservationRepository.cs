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
            var roomEntities = new List<RoomEntity>();
            var reservations = _dbContext.Reservations.AsEnumerable().Where(x =>
            {
                var startDate = x.StartTime;
                var endDate = startDate.AddSeconds(x.Duration);
                if (endDate < start || startDate > end) return false;
                return true;
            });
         
            var reservationEntities = reservations.ToList();
            if(reservationEntities.Any())
            { 
                roomEntities = reservationEntities.Select(x => x.Room).ToList();
            }
            return roomEntities;
        }
        
        public void DeleteById(int id)
        {
            var itemForRemoving = _dbContext
                .Reservations
                .FirstOrDefault(r => r.Id == id);
            if (itemForRemoving != null) _dbContext.Reservations.Remove(itemForRemoving);
        }
        
        public override ReservationEntity GetById(int id)
        {
            var result1 =
                _dbContext.Reservations
                    .Join(_dbContext.Rooms,
                        res => res.RoomId,
                        room => room.Id,
                        (res, room) => res)
                    .Join(_dbContext.Users,
                        res => res.UserId,
                        user => user.Id,
                        (res, user) => res)
                    .Where(x => x.Id == id)
                    .Select(x => new ReservationEntity()
                    {
                        Id = x.Id,
                        Room = x.Room,
                        User = x.User,
                        Duration = x.Duration,
                        StartTime = x.StartTime
                    })
                    .FirstOrDefault();
            return result1;
        }
        
        public override IEnumerable<ReservationEntity> GetAll()
        {
            var result = _dbContext.Reservations
                .Join(_dbContext.Rooms,
                    res => res.RoomId,
                    room => room.Id,
                    (res, room) => res)
                .Join(_dbContext.Users,
                    res => res.UserId,
                    user => user.Id,
                    (res, user) => res).ToList();
            return result;
        }
    }
}
