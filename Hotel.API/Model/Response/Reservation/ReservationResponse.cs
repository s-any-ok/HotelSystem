using Hotel.BLL.Model;

namespace Hotel.API.Model.Response.Reservation
{
    public class ReservationResponse
    {
        public Reservation<int> Reservation { get; set; }
    }
}