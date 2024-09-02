using Microsoft.EntityFrameworkCore;
using MovieTableEdit.Models;

namespace MovieTableEdit.Data
{
    public class MovieTableEditContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public MovieTableEditContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(Configuration.GetConnectionString("MovieTableEditContext"));
        }

        public DbSet<MockMovieFact> MockMovieFact { get; set; }
        public DbSet<MockMovieDim> MockMovieDim { get; set; }
        public DbSet<MockGenreDim> MockGenreDim { get; set; }
    }
}