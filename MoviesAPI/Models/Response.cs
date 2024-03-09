using System.Net;

namespace MoviesAPI.Models
{
    public class Response
    {
        public HttpStatusCode StatusCode { get; set; }
        public JsonContent? Content { get; set; }
    }
}
