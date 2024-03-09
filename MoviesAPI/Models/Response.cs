using System.Net;

namespace MoviesAPI.Models
{
    public class Response
    {
        public HttpStatusCode StatusCode { get; set; }
        public string? Content { get; set; }
    }
}
