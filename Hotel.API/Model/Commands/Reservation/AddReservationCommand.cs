using Hotel.BLL.Model;

namespace Hotel.API.Model.Commands.Reservation
{
    public class AddReservationCommand
    {
        public Reservation<int> Reservation { get; set; }
    }
}