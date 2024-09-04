using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using System.IO;
using CsvHelper;
using System.Globalization;

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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {   

            string mock_de_csv_path = "Data/MockMovieFactDE.csv";
            List<MockMovieFactDE> mock_movie_facts_de = ReadCsvAsClassList<MockMovieFactDE>(mock_de_csv_path);

            string mock_fr_csv_path = "Data/MockMovieFactFR.csv";
            List<MockMovieFactFR> mock_movie_facts_fr = ReadCsvAsClassList<MockMovieFactFR>(mock_fr_csv_path);

            string mock_movie_dim_csv_path = "Data/MockMovieDim.csv";
            List<MockMovieDim> mock_movie_dims = ReadCsvAsClassList<MockMovieDim>(mock_movie_dim_csv_path);

            string mock_genre_dim_csv_path = "Data/MockGenreDim.csv";
            List<MockGenreDim> mock_genre_dims = ReadCsvAsClassList<MockGenreDim>(mock_genre_dim_csv_path);

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


        static List<T> ReadCsvAsClassList<T>(string filePath)
        {
            var RecordList = new List<T>();
            
            using (var reader = new StreamReader(filePath))
            {
                // string headerLine = reader.ReadLine();
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {   
                    RecordList = csv.GetRecords<T>().ToList();
                }

            }
            return RecordList;
        }

    }
}