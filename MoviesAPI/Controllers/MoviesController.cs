using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MoviesAPI.Models;
using Serilog;

namespace MoviesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        public MoviesController() { }

        [HttpGet]
        [Route("/GetMovies")]
        public IActionResult Get()
        {
            Log.Information("Get All Movies called");
            return Ok(new { id = 1 });
        }

        [HttpGet]
        [Route("/GetMovieById/{id}")]
        public IActionResult Get(int id)
        {
            return Ok(id);
        }

        [HttpPost]
        [Route("/AddMovie")]
        public IActionResult Add(Movies request)
        {
            return Ok(new { id = 1 });
        }

        [HttpPut]
        [Route("/UpdateMovie/{id}")]
        public IActionResult Update(int id, [FromBody] Movies request ) 
        {
            return Ok();
        }

        [HttpDelete]
        [Route("/DeleteMovie/{id}")]
        public IActionResult Delete(int id) 
        {
            return Ok();
        }
    }
}
