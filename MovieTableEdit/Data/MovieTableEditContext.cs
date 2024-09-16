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

        public DbSet<MockProductPriceDE> DbSetMockProductPriceDE { get; set; }
        public DbSet<MockProductPriceFR> DbSetMockProductPriceFR { get; set; }

        public DbSet<MockProductDim> DbSetMockProductDim { get; set; }
        public DbSet<MockGenreDim> DbSetMockGenreDim { get; set; }
        public DbSet<MockProductTypeDim> DbSetMockProductTypeDim { get; set; }
        public DbSet<MockRatingDEDim> DbSetMockRatingDEDim { get; set; }
        public DbSet<MockRatingFRDim> DbSetMockRatingFRDim { get; set; }


        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {   
            // TODO: should the processes below generalised and written in a for loop?
            // TODO: Naming rules might not be coherent

            string mock_product_price_de_csv_path = "Data/MockProductPriceDE.csv";
            List<MockProductPriceDE> mock_product_price_de = ReadCsvAsClassList<MockProductPriceDE>(mock_product_price_de_csv_path);

            string mock_product_price_fr_csv_path = "Data/MockProductPriceFR.csv";
            List<MockProductPriceFR> mock_product_price_fr = ReadCsvAsClassList<MockProductPriceFR>(mock_product_price_fr_csv_path);


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


            modelBuilder.Entity<MockProductPriceDE>().ToTable("MockProductPriceDE");
            modelBuilder.Entity<MockProductPriceDE>().HasData(mock_product_price_de);

            modelBuilder.Entity<MockProductPriceFR>().ToTable("MockProductPriceFR");
            modelBuilder.Entity<MockProductPriceFR>().HasData(mock_product_price_fr);


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