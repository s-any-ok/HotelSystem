using Hotel.BLL.Services.Abstraction;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Security.Authentication;
using System.Threading.Tasks;

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

        /*[HttpGet]
        [ProducesResponseType(typeof(BasketResponse), StatusCodes.Status200OK)]
        public IActionResult GetBasketById([FromQuery] GetBasketCommand command)
        {
            var result = _basketService.GetBasketById(command.BasketId);
            return Ok(new BasketResponse() { Basket = result });
        }

        [HttpPost]
        [ProducesResponseType(typeof(BasketResponse), StatusCodes.Status200OK)]
        public IActionResult AddBasket([FromBody] AddBasketCommand command)
        {
            var result = _basketService.CreateBasket(command.UserName);
            return Ok(new BasketResponse() { Basket = result });
        }*/
    }
}
