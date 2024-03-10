namespace MoviesAPI.Services
{
    public class MoviesService : IMovies
    {
        private readonly MoviesDbCotext _dbContext;
        private Response response;

        public MoviesService(MoviesDbCotext dbContext)
        {
            _dbContext = dbContext;
        }

        public Response GetAllMovies() 
        {
            response.Content = JsonSerializer.Serialize(_dbContext.Movies.ToList());
            response.StatusCode = HttpStatusCode.OK;
            return response;
        }

        public Response GetMovieById(int id)
        {
            response.Content = JsonSerializer.Serialize(_dbContext.Movies.Select(x=>x.Id == id).ToList());
            response.StatusCode = HttpStatusCode.OK;
            return new Response();
        }

        public Response AddMovie(Movies movie)
        {
            var result = _dbContext.Movies.Add(movie);
            _dbContext.SaveChanges();

            return new Response();
        }
        
        public Response DeleteMovie(int id)
        {
            return new Response();
        }

        public Response UpdateMovie(int id, Movies movie)
        {
            return new Response();
        }
    }
}
