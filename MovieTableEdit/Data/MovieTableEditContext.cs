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

        public DbSet<MockMoviePriceDE> MockMoviePriceDE { get; set; }
        public DbSet<MockTVPriceDE> MockTVPriceDE { get; set; }
        public DbSet<MockAnimePriceDE> MockAnimePriceDE { get; set; }
        public DbSet<MockComicPriceDE> MockComicPriceDE { get; set; }

        public DbSet<MockMoviePriceFR> MockMoviePriceFR { get; set; }
        public DbSet<MockTVPriceFR> MockTVPriceFR { get; set; }
        public DbSet<MockAnimePriceFR> MockAnimePriceFR { get; set; }
        public DbSet<MockComicPriceFR> MockComicPriceFR { get; set; }

        public DbSet<MockProductDim> MockProductDim { get; set; }
        public DbSet<MockGenreDim> MockGenreDim { get; set; }
        public DbSet<MockProductTypeDim> MockProductTypeDim { get; set; }
        public DbSet<MockRatingDEDim> MockRatingDEDim { get; set; }
        public DbSet<MockRatingFRDim> MockRatingFRDim { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {   
            // TODO: should the processes below generalised and written in a for loop?
            // TODO: Naming rules might not be coherent

            string mock_movie_price_de_csv_path = "Data/MockMoviePriceDE.csv";
            List<MockMoviePriceDE> mock_movie_price_de = ReadCsvAsClassList<MockMoviePriceDE>(mock_movie_price_de_csv_path);

            string mock_tv_price_de_csv_path = "Data/MockTVPriceDE.csv";
            List<MockTVPriceDE> mock_tv_price_de = ReadCsvAsClassList<MockTVPriceDE>(mock_tv_price_de_csv_path);

            string mock_anime_price_de_csv_path = "Data/MockAnimePriceDE.csv";
            List<MockAnimePriceDE> mock_anime_price_de = ReadCsvAsClassList<MockAnimePriceDE>(mock_anime_price_de_csv_path);

            string mock_comic_price_de_csv_path = "Data/MockComicPriceDE.csv";
            List<MockComicPriceDE> mock_comic_price_de = ReadCsvAsClassList<MockComicPriceDE>(mock_comic_price_de_csv_path);


            string mock_movie_price_fr_csv_path = "Data/MockMoviePriceFR.csv";
            List<MockMoviePriceFR> mock_movie_price_fr = ReadCsvAsClassList<MockMoviePriceFR>(mock_movie_price_fr_csv_path);

            string mock_tv_price_fr_csv_path = "Data/MockTVPriceFR.csv";
            List<MockTVPriceFR> mock_tv_price_fr = ReadCsvAsClassList<MockTVPriceFR>(mock_tv_price_fr_csv_path);

            string mock_anime_price_fr_csv_path = "Data/MockAnimePriceFR.csv";
            List<MockAnimePriceFR> mock_anime_price_fr = ReadCsvAsClassList<MockAnimePriceFR>(mock_anime_price_fr_csv_path);

            string mock_comic_price_fr_csv_path = "Data/MockComicPriceFR.csv";
            List<MockComicPriceFR> mock_comic_price_fr = ReadCsvAsClassList<MockComicPriceFR>(mock_comic_price_fr_csv_path);


            string mock_product_dim_csv_path = "Data/MockProductDim.csv";
            List<MockProductDim> mock_product_dims = ReadCsvAsClassList<MockProductDim>(mock_product_dim_csv_path);

            string mock_genre_dim_csv_path = "Data/MockGenreDim.csv";
            List<MockGenreDim> mock_genre_dims = ReadCsvAsClassList<MockGenreDim>(mock_genre_dim_csv_path);

            string mock_product_type_dim_csv_path = "Data/MockProductTypeDim.csv";
            List<MockProductTypeDim> mock_product_type_dims = ReadCsvAsClassList<MockProductTypeDim>(mock_product_type_dim_csv_path);

            string mock_rating_de_dim_csv_path = "Data/MockRatingDEDim.csv";
            List<MockRatingDEDim> mock_rating_de_dims = ReadCsvAsClassList<MockRatingDEDim>(mock_rating_de_dim_csv_path);

            string mock_rating_fr_dim_csv_path = "Data/MockRatingFRDim.csv";
            List<MockRatingFRDim> mock_rating_fr_dims = ReadCsvAsClassList<MockRatingFRDim>(mock_rating_fr_dim_csv_path);


            modelBuilder.Entity<MockMoviePriceDE>().ToTable("MockMoviePriceDE");
            modelBuilder.Entity<MockMoviePriceDE>().HasData(mock_movie_price_de);

            modelBuilder.Entity<MockTVPriceDE>().ToTable("MockTVPriceDE");
            modelBuilder.Entity<MockTVPriceDE>().HasData(mock_tv_price_de);

            modelBuilder.Entity<MockAnimePriceDE>().ToTable("MockAnimePriceDE");
            modelBuilder.Entity<MockAnimePriceDE>().HasData(mock_anime_price_de);

            modelBuilder.Entity<MockComicPriceDE>().ToTable("MockComicPriceDE");
            modelBuilder.Entity<MockComicPriceDE>().HasData(mock_comic_price_de);


            modelBuilder.Entity<MockMoviePriceFR>().ToTable("MockMoviePriceFR");
            modelBuilder.Entity<MockMoviePriceFR>().HasData(mock_movie_price_fr);

            modelBuilder.Entity<MockTVPriceFR>().ToTable("MockTVPriceFR");
            modelBuilder.Entity<MockTVPriceFR>().HasData(mock_tv_price_fr);

            modelBuilder.Entity<MockAnimePriceFR>().ToTable("MockAnimePriceFR");
            modelBuilder.Entity<MockAnimePriceFR>().HasData(mock_anime_price_fr);

            modelBuilder.Entity<MockComicPriceFR>().ToTable("MockComicPriceFR");
            modelBuilder.Entity<MockComicPriceFR>().HasData(mock_comic_price_fr);


            modelBuilder.Entity<MockProductDim>().ToTable("MockProductDim");
            modelBuilder.Entity<MockProductDim>().HasData(mock_product_dims);

            modelBuilder.Entity<MockProductTypeDim>().ToTable("MockProductTypeDim");
            modelBuilder.Entity<MockProductTypeDim>().HasData(mock_product_type_dims);

            modelBuilder.Entity<MockGenreDim>().ToTable("MockGenreDim");
            modelBuilder.Entity<MockGenreDim>().HasData(mock_genre_dims);

            modelBuilder.Entity<MockRatingDEDim>().ToTable("MockRatingDEDim");
            modelBuilder.Entity<MockRatingDEDim>().HasData(mock_rating_de_dims);

            modelBuilder.Entity<MockRatingFRDim>().ToTable("MockRatingFRDim");
            modelBuilder.Entity<MockRatingFRDim>().HasData(mock_rating_fr_dims);

        }


        static List<T> ReadCsvAsClassList<T>(string filePath)
        {
            var RecordList = new List<T>();
            
            using (var reader = new StreamReader(filePath))
            {
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {   
                    RecordList = csv.GetRecords<T>().ToList();
                }

            }
            return RecordList;
        }

    }
}