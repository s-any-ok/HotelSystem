using System.Collections.Generic;
using System.Linq;
using Hotel.BLL.Mappers;
using Hotel.BLL.Model;
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
            var entityEntry = _unitOfWork.ReservationRepository.Create(reservation.ToDbEntity());
            _unitOfWork.Save();

            var reservationEntity = _unitOfWork.ReservationRepository.GetById(entityEntry.Entity.Id);
            var result = reservationEntity.ToModelEntity();
            return result;
        }
        
        public IEnumerable<Reservation<int>> GetAll()
        {
            var result = _unitOfWork
                .ReservationRepository
                .GetAll()
                .Select(r => r.ToModelEntity());
            return result;
        }
        
        public void DeleteReservations(int id)
        {
             _unitOfWork.ReservationRepository.DeleteById(id);
        }
        
    }
}
