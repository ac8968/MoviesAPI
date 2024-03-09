
using MoviesAPI.Models;
using MoviesAPI.Services.Interfaces;
using System.Reflection.Metadata.Ecma335;

namespace MoviesAPI.Services
{
    public class MoviesService : IMovies
    {
        public MoviesService() { }

        public Response GetAllMovies() 
        {
            return new Response();
        }

        public Response GetMovieById(int id)
        {
            return new Response();
        }

        public Response AddMovie(Movies movie)
        {
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
