using Hotel.BLL.Services.Abstraction;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Hotel.API.Model.Commands.Reservation;
using Hotel.API.Model.Response.Reservation;

namespace Hotel.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationController : ControllerBase
    {
        private readonly IReservationService<int> _reservationService;
        public ReservationController(IReservationService<int> reservationService)
        {
            _reservationService = reservationService;
        }

        [HttpGet]
        [ProducesResponseType(typeof(ReservationsResponse), StatusCodes.Status200OK)]
        public IActionResult GetAll()
        {
            var result = _reservationService.GetAll().ToList();
            return Ok(new ReservationsResponse() { Reservations = result });
        }

        [HttpPost]
        [ProducesResponseType(typeof(ReservationResponse), StatusCodes.Status200OK)]
        public IActionResult AddReservation([FromBody] AddReservationCommand command)
        {
            var result = _reservationService.CreateReservation(command.Reservation);
            return Ok(new ReservationResponse() { Reservation = result });
        }
        
        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult CancelReservation([FromQuery] CancelReservationCommand command)
        {
            _reservationService.DeleteReservations(command.Id);
            return Ok();
        }
    }
}
