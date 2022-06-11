using Hotel.BLL.Services.Abstraction;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Hotel.API.Model.Commands.Room;
using Hotel.API.Model.Response.Room;

namespace Hotel.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        private readonly IRoomService<int> _roomService;
        public RoomController(IRoomService<int> roomService)
        {
            _roomService = roomService;
        }

        [HttpGet("all")]
        [ProducesResponseType(typeof(RoomsResponse), StatusCodes.Status200OK)]
        public IActionResult GetAll()
        {
            var result = _roomService.GetAll().ToList();
            return Ok(new RoomsResponse() { Rooms = result });
        }
        
        [HttpGet("free")]
        [ProducesResponseType(typeof(RoomsResponse), StatusCodes.Status200OK)]
        public IActionResult GetFreeRoomsInPeriod([FromQuery] GetRoomsInPeriodCommand command)
        {
            var result = _roomService.GetFreeRoomsInPeriod(command.startTime, command.endTime).ToList();
            return Ok(new RoomsResponse() { Rooms = result });
        }

        [HttpPost]
        [ProducesResponseType(typeof(RoomResponse), StatusCodes.Status200OK)]
        public IActionResult AddRoom([FromBody] AddRoomCommand command)
        {
            var result = _roomService.CreateRoom(command.Room);
            return Ok(new RoomResponse() { Room = result });
        }
    }
}
