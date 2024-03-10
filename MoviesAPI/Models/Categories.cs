namespace MoviesAPI.Models
{
    public class Categories
    {
        [Key]
        public int Id { get; set; }
        public required string Name { get; set; }
        public bool IsDeleted { get; set; } = false;
    }
}
