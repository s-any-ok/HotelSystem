using Hotel.BLL.Mappers;
using Hotel.BLL.Services.Abstraction;
using Hotel.DAL.Entities;
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
    }
}
