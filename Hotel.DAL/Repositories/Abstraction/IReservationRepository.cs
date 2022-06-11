using System;
using System.Collections.Generic;
using Hotel.DAL.Entities;

namespace Hotel.DAL.Repositories.Abstraction
{
    public interface IReservationRepository : IRepository<ReservationEntity, int>
    {
        bool IsReservedRoomInThePeriod(int roomId, DateTime start, DateTime end);
        IEnumerable<RoomEntity> GetReservedRoomsInPeriod(DateTime start, DateTime end);
        void DeleteById(int id);
    }
}
