using Hotel.BLL.Mappers;
using Hotel.BLL.Services.Abstraction;
using Hotel.DAL.Entities;
using Hotel.DAL.UnitOfWork.Abstraction;

namespace Hotel.BLL.Services.Realisation
{
    public class ReservationService : IReservationService<int>
    {

        private readonly IUnitOfWork _unitOfWork;

        public ReservationService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Reservation<int> CreateReservation(Reservation<int> reservation)
        {
            _unitOfWork.ReservationRepository.Create(reservation.ToDbntity());
            _unitOfWork.Save();
            var result = _unitOfWork.ReservationRepository.GetById(reservation.Id).ToModelEntity();
            return result;
        }
    }
}
