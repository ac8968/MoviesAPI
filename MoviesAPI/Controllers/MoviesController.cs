using Azure.Core;
using System.Net.Http.Headers;

namespace MoviesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController(IMovies movies) : ControllerBase
    {
        private readonly IMovies movies = movies;
        private Response response = new();

        [HttpGet]
        [Route("/GetMovies")]
        public IActionResult Get()
        {
            Log.Information("Get All Movies called");
            response = movies.GetAllMovies();
            return StatusCode((int)response.StatusCode,response.Content);
        }

        [HttpGet]
        [Route("/GetMovieById/{id}")]
        public IActionResult Get(int id)
        {
            Log.Information("Get Movies by id called");
            response = movies.GetMovieById(id);
            return StatusCode((int)response.StatusCode, response.Content);
        }

        [HttpPost]
        [Route("/AddMovie")]
        public IActionResult Add(Movies movie)
        {
            Log.Information("Add Movies called");
            response = movies.AddMovie(movie);
            return StatusCode((int)response.StatusCode, response.Content);
        }

        [HttpPut]
        [Route("/UpdateMovie/{id}")]
        public IActionResult Update(int id, [FromBody] Movies request)
        {
            Log.Information("Update Movies called");
            response = movies.UpdateMovie(id, request);
            return StatusCode((int)response.StatusCode, response.Content);
        }

        [HttpDelete]
        [Route("/DeleteMovie/{id}")]
        public IActionResult Delete(int id)
        {
            Log.Information("Delete Movies called");
            response = movies.DeleteMovie(id);
            return StatusCode((int)response.StatusCode, response.Content);
        }
    }
}
