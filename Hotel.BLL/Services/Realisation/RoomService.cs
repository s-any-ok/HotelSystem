using System;
using System.Collections.Generic;
using System.Linq;
using Hotel.BLL.Mappers;
using Hotel.BLL.Model;
using Hotel.BLL.Services.Abstraction;
using Hotel.DAL.UnitOfWork.Abstraction;

namespace Hotel.BLL.Services.Realisation
{
    public class RoomService : IRoomService<int>
    {

        private readonly IUnitOfWork _unitOfWork;

        public RoomService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        
        public Room<int> CreateRoom(Room<int> room)
        {
            _unitOfWork.RoomRepository.Create(room.ToDbEntity());
            _unitOfWork.Save();
            var result = _unitOfWork.RoomRepository.GetById(room.Id).ToModelEntity();
            return result;
        }
        
        public IEnumerable<Room<int>> GetAll()
        {
            var result = _unitOfWork
                .RoomRepository
                .GetAll()
                .Select(r => r.ToModelEntity());
            return result;
        }
        
        public IEnumerable<Room<int>> GetFreeRoomsInPeriod(DateTime start, DateTime end)
        {
            var reservedRoomsIds = _unitOfWork
                .ReservationRepository
                .GetReservedRoomsInPeriod(start, end)
                .Select(r => r.ToModelEntity())
                .Select(r => r.Id);
            
            var result = _unitOfWork
                .RoomRepository
                .GetAll()
                .Where(x => !reservedRoomsIds.Contains(x.Id))
                .Select(r => r.ToModelEntity());
            return result;
        }
    }
}
