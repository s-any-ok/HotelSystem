using Hotel.BLL.Services.Abstraction;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Hotel.API.Model.Commands.User;
using Hotel.API.Model.Response.User;

namespace Hotel.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService<int> _userService;
        public UsersController(IUserService<int> userService)
        {
            _userService = userService;
        }

        [HttpGet]
        [ProducesResponseType(typeof(UsersResponse), StatusCodes.Status200OK)]
        public IActionResult GetAll()
        {
            var result = _userService.GetAll().ToList();
            return Ok(new UsersResponse() { Users = result });
        }

        [HttpPost]
        [ProducesResponseType(typeof(UserResponse), StatusCodes.Status200OK)]
        public IActionResult AddUser([FromBody] AddUserCommand command)
        {
            var result = _userService.CreateUser(command.User);
            return Ok(new UserResponse() { User = result });
        }
    }
}
