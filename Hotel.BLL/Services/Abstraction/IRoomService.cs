using System;
using System.Collections.Generic;
using Hotel.BLL.Model;

namespace Hotel.BLL.Services.Abstraction
{
    public interface IRoomService<T>
    {
        IEnumerable<Room<T>> GetFreeRoomsInPeriod(DateTime start, DateTime end);
        Room<T> CreateRoom(Room<T> room);
        IEnumerable<Room<T>> GetAll();
    }
}
