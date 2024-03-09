using MoviesAPI.Models;

namespace MoviesAPI.Services
{
    public interface IMovies
    {
        public Response GetAllMovies();
        public Response GetMovieById(int id);
        public Response AddMovie(Movies movie);
        public Response DeleteMovie(int id);
        public Response UpdateMovie(int id, Movies movie);
    }
}
