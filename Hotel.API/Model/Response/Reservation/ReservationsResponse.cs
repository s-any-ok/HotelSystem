using System.Collections.Generic;
using Hotel.BLL.Model;

namespace Hotel.API.Model.Response.Reservation
{
    public class ReservationsResponse
    {
        public List<Reservation<int>> Reservations { get; set; }
    }
}