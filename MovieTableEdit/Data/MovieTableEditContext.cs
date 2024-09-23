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

        public DbSet<TempProductPriceDE> DbSetTempProductPriceDE { get; set; }
        public DbSet<TempProductPriceFR> DbSetTempProductPriceFR { get; set; }
        public DbSet<ProductPriceDE> DbSetProductPriceDE { get; set; }
        public DbSet<ProductPriceFR> DbSetProductPriceFR { get; set; }

        public DbSet<ProductDim> DbSetProductDim { get; set; }
        public DbSet<GenreDim> DbSetGenreDim { get; set; }
        public DbSet<ProductTypeDim> DbSetProductTypeDim { get; set; }
        public DbSet<RatingDEDim> DbSetRatingDEDim { get; set; }
        public DbSet<RatingFRDim> DbSetRatingFRDim { get; set; }


        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {   
            // TODO: should the processes below generalised and written in a for loop?
            // TODO: Naming rules might not be coherent

            string product_price_de_csv_path = "Data/MockProductPriceDE.csv";
            List<ProductPriceDE> product_price_de = ReadCsvAsClassList<ProductPriceDE>(product_price_de_csv_path);

            string product_price_fr_csv_path = "Data/MockProductPriceFR.csv";
            List<ProductPriceFR> product_price_fr = ReadCsvAsClassList<ProductPriceFR>(product_price_fr_csv_path);


            string product_dim_csv_path = "Data/MockProductDim.csv";
            List<ProductDim> product_dims = ReadCsvAsClassList<ProductDim>(product_dim_csv_path);

            string genre_dim_csv_path = "Data/MockGenreDim.csv";
            List<GenreDim> genre_dims = ReadCsvAsClassList<GenreDim>(genre_dim_csv_path);

            string product_type_dim_csv_path = "Data/MockProductTypeDim.csv";
            List<ProductTypeDim> product_type_dims = ReadCsvAsClassList<ProductTypeDim>(product_type_dim_csv_path);

            string rating_de_dim_csv_path = "Data/MockRatingDEDim.csv";
            List<RatingDEDim> rating_de_dims = ReadCsvAsClassList<RatingDEDim>(rating_de_dim_csv_path);

            string rating_fr_dim_csv_path = "Data/MockRatingFRDim.csv";
            List<RatingFRDim> rating_fr_dims = ReadCsvAsClassList<RatingFRDim>(rating_fr_dim_csv_path);


            modelBuilder.Entity<ProductPriceDE>().ToTable("ProductPriceDE");
            modelBuilder.Entity<ProductPriceDE>().HasData(product_price_de);
            modelBuilder.Entity<ProductPriceFR>().ToTable("ProductPriceFR");
            modelBuilder.Entity<ProductPriceFR>().HasData(product_price_fr);

            modelBuilder.Entity<TempProductPriceDE>().ToTable("TempProductPriceDE");
            modelBuilder.Entity<TempProductPriceFR>().ToTable("TempProductPriceFR");


            modelBuilder.Entity<ProductDim>().ToTable("ProductDim");
            modelBuilder.Entity<ProductDim>().HasData(product_dims);
            modelBuilder.Entity<ProductTypeDim>().ToTable("ProductTypeDim");
            modelBuilder.Entity<ProductTypeDim>().HasData(product_type_dims);
            modelBuilder.Entity<GenreDim>().ToTable("GenreDim");
            modelBuilder.Entity<GenreDim>().HasData(genre_dims);
            modelBuilder.Entity<RatingDEDim>().ToTable("RatingDEDim");
            modelBuilder.Entity<RatingDEDim>().HasData(rating_de_dims);
            modelBuilder.Entity<RatingFRDim>().ToTable("RatingFRDim");
            modelBuilder.Entity<RatingFRDim>().HasData(rating_fr_dims);

            modelBuilder.Entity<TempProductDim>().ToTable("TempProductDim");
            modelBuilder.Entity<TempProductTypeDim>().ToTable("TempProductTypeDim");
            modelBuilder.Entity<TempGenreDim>().ToTable("TempGenreDim");
            modelBuilder.Entity<TempRatingDEDim>().ToTable("TempRatingDEDim");
            modelBuilder.Entity<TempRatingFRDim>().ToTable("TempRatingFRDim");

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