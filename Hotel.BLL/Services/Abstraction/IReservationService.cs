using System.Collections.Generic;
using Hotel.BLL.Model;

namespace Hotel.BLL.Services.Abstraction
{
    public interface IReservationService<T>
    {
        Reservation<T> CreateReservation(Reservation<T> reservation);
        IEnumerable<Reservation<T>> GetAll();
        void DeleteReservations(T id);
    }
}
