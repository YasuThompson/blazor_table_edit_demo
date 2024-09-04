using Microsoft.CodeAnalysis.CSharp.Syntax;
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
        public DbSet<MockMovieFactDE> MockMovieFactDE { get; set; }
        public DbSet<MockMovieFactFR> MockMovieFactFR { get; set; }
        public DbSet<MockMovieDim> MockMovieDim { get; set; }
        public DbSet<MockGenreDim> MockGenreDim { get; set; }

        List<MockMovieFact> mock_movie_facts = new List<MockMovieFact>{
            new MockMovieFact
            {   
                Id = 1, 
                MovieId = 1111, 
                Date = new DateOnly(1979, 4, 12),
                Price = 2.51M,
                
            },
            new MockMovieFact
            {   
                Id = 2, 
                MovieId = 1112, 
                Date = new DateOnly(1981, 12, 24),
                Price = 2.78M,
            },
            new MockMovieFact
            {   
                Id = 3, 
                MovieId = 1113,
                Date = new DateOnly(1985, 7, 10),
                Price = 3.55M,
            },
            new MockMovieFact
            {
                Id = 4, 
                MovieId = 1114, 
                Date = new DateOnly(2015, 5, 15),
                Price = 8.43M,
            },
            new MockMovieFact
            {
                Id = 5, 
                MovieId = 1115, 
                Date = new DateOnly(2024, 5, 24),
                Price = 13.49M,
            }
        };

        List<MockMovieFactDE> mock_movie_facts_de = new List<MockMovieFactDE>{
            new MockMovieFactDE
            {   
                Id = 1, 
                MovieId = 1111, 
                Date = new DateOnly(1979, 4, 12),
                Price = 2.51M,
                RatingDE = "German-G"
                
            },
            new MockMovieFactDE
            {   
                Id = 2, 
                MovieId = 1112, 
                Date = new DateOnly(1981, 12, 24),
                Price = 2.78M,
                RatingDE = "German-G"
            },
            new MockMovieFactDE
            {   
                Id = 3, 
                MovieId = 1113,
                Date = new DateOnly(1985, 7, 10),
                Price = 3.55M,
                RatingDE = "German-G"
            },
            new MockMovieFactDE
            {
                Id = 4, 
                MovieId = 1114, 
                Date = new DateOnly(2015, 5, 15),
                Price = 8.43M,
                RatingDE = "German-G"
            },
            new MockMovieFactDE
            {
                Id = 5, 
                MovieId = 1115, 
                Date = new DateOnly(2024, 5, 24),
                Price = 13.49M,
                RatingDE = "German-G"
            }
        };

        List<MockMovieFactFR> mock_movie_facts_fr= new List<MockMovieFactFR>{
            new MockMovieFactFR
            {   
                Id = 1, 
                MovieId = 1111, 
                Date = new DateOnly(1979, 4, 12),
                Price = 2.51M,
                RatingFR = "French-R"
                
            },
            new MockMovieFactFR
            {   
                Id = 2, 
                MovieId = 1112, 
                Date = new DateOnly(1981, 12, 24),
                Price = 2.78M,
                RatingFR = "French-R"
            },
            new MockMovieFactFR
            {   
                Id = 3, 
                MovieId = 1113,
                Date = new DateOnly(1985, 7, 10),
                Price = 3.55M,
                RatingFR = "French-R"
            },
            new MockMovieFactFR
            {
                Id = 4, 
                MovieId = 1114, 
                Date = new DateOnly(2015, 5, 15),
                Price = 8.43M,
                RatingFR = "French-R"
            },
            new MockMovieFactFR
            {
                Id = 5, 
                MovieId = 1115, 
                Date = new DateOnly(2024, 5, 24),
                Price = 13.49M,
                RatingFR = "French-R"
            }
        };

        List<MockMovieDim> mock_movie_dims = new List<MockMovieDim>{
            new MockMovieDim
            {   
                MovieId = 1111, 
                Title = "Mad Max",
                GenreId = 1,
            },
            new MockMovieDim
            {   
                MovieId = 1112, 
                Title = "The Road Warrior",
                GenreId = 1,
            },
            new MockMovieDim
            {
                Title = "Mad Max: Beyond Thunderdome",
                MovieId = 1113,
                GenreId = 2,
                TitleDE = "Mad Max: Jeneseits der Donnerkuppel"

            },
            new MockMovieDim
            {
                Title = "Mad Max: Fury Road",
                MovieId = 1114, 
                GenreId = 1,
            },
            new MockMovieDim
            {
                Title = "Furiosa: A Mad Max Saga",
                MovieId = 1115, 
                GenreId = 1,
                TitleFR = "Furiosa: Une saga Mad Max"
            }
        };


        List<MockGenreDim> mock_genre_dims = new List<MockGenreDim>
        {
            new MockGenreDim
            {   
                GenreId = 1, 
                Genre = "SciFi",
            },
            new MockGenreDim
            {   
                GenreId = 2, 
                Genre = "Action",
            },
        };


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {   
            modelBuilder.Entity<MockMovieFact>().ToTable("MockMovieFact");
            modelBuilder.Entity<MockMovieFact>().HasData(mock_movie_facts);

            modelBuilder.Entity<MockMovieFactDE>().ToTable("MockMovieFactDE");
            modelBuilder.Entity<MockMovieFactDE>().HasData(mock_movie_facts_de);

            modelBuilder.Entity<MockMovieFactFR>().ToTable("MockMovieFactFR");
            modelBuilder.Entity<MockMovieFactFR>().HasData(mock_movie_facts_fr);

            modelBuilder.Entity<MockMovieDim>().ToTable("MockMovieDim");
            modelBuilder.Entity<MockMovieDim>().HasData(mock_movie_dims);

            modelBuilder.Entity<MockGenreDim>().ToTable("MockGenreDim");
            modelBuilder.Entity<MockGenreDim>().HasData(mock_genre_dims);
        }

        
    }
}