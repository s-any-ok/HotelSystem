using Hotel.BLL.Services.Abstraction;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Hotel.API.Model.Commands.Category;
using Hotel.API.Model.Response.Category;

namespace Hotel.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService<int> _categoryService;
        public CategoryController(ICategoryService<int> categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        [ProducesResponseType(typeof(CategoriesResponse), StatusCodes.Status200OK)]
        public IActionResult GetAll()
        {
            var result = _categoryService.GetAll().ToList();
            return Ok(new CategoriesResponse() { Categories = result });
        }

        [HttpPost]
        [ProducesResponseType(typeof(CategoryResponse), StatusCodes.Status200OK)]
        public IActionResult AddCategory([FromBody] AddCategoryCommand command)
        {
            var result = _categoryService.CreateCategory(command.Category);
            return Ok(new CategoryResponse() { Category = result });
        }
    }
}
