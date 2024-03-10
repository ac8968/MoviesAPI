namespace MoviesAPI.Services
{
    public class MoviesService : IMovies
    {
        private readonly MoviesDbCotext _dbContext;
        private readonly Response response = new();

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
            response.Content = JsonSerializer.Serialize(_dbContext.Movies.Where(x=>x.Id == id).SingleOrDefault());
            response.StatusCode = HttpStatusCode.OK;
            return response;
        }

        public Response AddMovie(Movies movie)
        {
            _dbContext.Movies.Add(movie);
            _dbContext.SaveChanges();
            response.Content = JsonSerializer.Serialize(movie);
            response.StatusCode = HttpStatusCode.OK;
            return response;
        }
        
        public Response DeleteMovie(int id)
        {
            Movies data = _dbContext.Movies.Where(x => x.Id == id).FirstOrDefault()!;
            _dbContext.Movies.Remove(data);
            _dbContext.SaveChanges();
            response.Content = "Record deleted successfully";
            response.StatusCode = HttpStatusCode.OK;
            return response;
        }

        public Response UpdateMovie(int id, Movies movie)
        {
            Movies movies = _dbContext.Movies.Where(_x => _x.Id == id).SingleOrDefault()!;
            movies.Title=movie.Title;
            movies.Description = movie.Description;
            movies.Director = movie.Director;
            movies.UpdatedDate = DateTime.Now;

            _dbContext.Movies.Update(movies);
            _dbContext.SaveChanges();

            response.StatusCode = HttpStatusCode.OK;
            response.Content = "Record updated successfully";
            return response;
        }
    }
}
