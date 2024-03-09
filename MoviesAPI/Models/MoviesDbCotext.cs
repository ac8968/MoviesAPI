using Microsoft.EntityFrameworkCore;

namespace MoviesAPI.Models
{
    public partial class MoviesDbCotext : DbContext
    {
        public MoviesDbCotext(DbContextOptions
       <MoviesDbCotext> options)
           : base(options)
        {
        }

        public virtual DbSet<Movies> Movies { get; set; }
        public virtual DbSet<Categories> Categories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            List<string> ModelName = new List<string>() { "Movies", "Categories" };
            foreach (var item in ModelName)
            {
                modelBuilder.Entity<Movies>(entity => {
                    entity.HasKey(k => k.Id);
                });
            }
            
            OnModelCreatingPartial(modelBuilder);
        }

        
        
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
