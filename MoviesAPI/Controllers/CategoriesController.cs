using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MoviesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        public CategoriesController() { }

        [HttpGet]
        [Route("/GetCategories")]
        public IActionResult Get()
        {
            return Ok(new { id = 1 });
        }

        [HttpGet]
        [Route("/GetCategoryById/{id}")]
        public IActionResult Get(int id)
        {
            return Ok(id);
        }

        [HttpPost]
        [Route("/AddCategory")]
        public IActionResult Add()
        {
            return Ok(new { id = 1 });
        }

        [HttpPut]
        [Route("/UpdateCategory/{id}")]
        public IActionResult Update(int id, [FromBody] string request ) 
        {
            return Ok();
        }

        [HttpDelete]
        [Route("/DeleteCategory/{id}")]
        public IActionResult Delete(int id) 
        {
            return Ok();
        }
    }
}
