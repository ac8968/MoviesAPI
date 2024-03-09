using System.ComponentModel.DataAnnotations;

namespace MoviesAPI.Models
{
    public class Movies
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public required string Title { get; set; }
        [Required]
        public required string Description { get; set; }
        public string? Director { get; set; }
        [Required]
        public DateOnly ReleasedDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    
    }
}
