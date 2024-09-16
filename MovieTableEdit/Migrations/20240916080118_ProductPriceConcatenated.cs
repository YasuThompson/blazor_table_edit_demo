using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MovieTableEdit.Migrations
{
    /// <inheritdoc />
    public partial class ProductPriceConcatenated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MockAnimePriceDE");

            migrationBuilder.DropTable(
                name: "MockAnimePriceFR");

            migrationBuilder.DropTable(
                name: "MockComicPriceDE");

            migrationBuilder.DropTable(
                name: "MockComicPriceFR");

            migrationBuilder.DropTable(
                name: "MockMoviePriceDE");

            migrationBuilder.DropTable(
                name: "MockMoviePriceFR");

            migrationBuilder.DropTable(
                name: "MockTVPriceDE");

            migrationBuilder.DropTable(
                name: "MockTVPriceFR");

            migrationBuilder.CreateTable(
                name: "MockProductPriceDE",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProductId = table.Column<int>(type: "INTEGER", nullable: false),
                    ProductTypeId = table.Column<int>(type: "INTEGER", nullable: false),
                    Version = table.Column<float>(type: "REAL", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    RatingDE = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MockProductPriceDE", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MockProductPriceFR",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProductId = table.Column<int>(type: "INTEGER", nullable: false),
                    ProductTypeId = table.Column<int>(type: "INTEGER", nullable: false),
                    Version = table.Column<float>(type: "REAL", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    RatingFR = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MockProductPriceFR", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "MockProductPriceDE",
                columns: new[] { "Id", "Price", "ProductId", "ProductTypeId", "RatingDE", "Version" },
                values: new object[,]
                {
                    { 1, 2.51m, 1111, 1, 1, 1f },
                    { 2, 2.78m, 1112, 1, 1, 1f },
                    { 3, 3.55m, 1113, 1, 1, 1f },
                    { 4, 8.43m, 1114, 1, 1, 1f },
                    { 5, 13.49m, 1115, 1, 1, 1f },
                    { 6, 2.51m, 1111, 1, 1, 1.01f },
                    { 7, 2.78m, 1112, 1, 1, 1.01f },
                    { 8, 3.55m, 1113, 1, 1, 1.01f },
                    { 9, 8.43m, 1114, 1, 1, 1.01f },
                    { 10, 13.49m, 1115, 1, 1, 1.01f },
                    { 11, 2.51m, 10001, 2, 1, 2f },
                    { 12, 2.78m, 10002, 2, 1, 2f },
                    { 13, 3.55m, 10003, 2, 1, 2f },
                    { 14, 8.43m, 10004, 2, 1, 2f },
                    { 15, 13.49m, 10005, 2, 1, 2f },
                    { 16, 2.51m, 10001, 2, 1, 2.01f },
                    { 17, 2.78m, 10002, 2, 1, 2.01f },
                    { 18, 3.55m, 10003, 2, 1, 2.01f },
                    { 19, 8.43m, 10004, 2, 1, 2.01f },
                    { 20, 13.49m, 10005, 2, 1, 2.01f },
                    { 21, 2.51m, 20000, 3, 1, 3f },
                    { 22, 2.78m, 20001, 3, 1, 3f },
                    { 23, 3.55m, 20002, 3, 1, 3f },
                    { 24, 8.43m, 20003, 3, 1, 3f },
                    { 25, 13.49m, 20004, 3, 1, 3f },
                    { 26, 2.51m, 20000, 3, 1, 3.01f },
                    { 27, 2.78m, 20001, 3, 1, 3.01f },
                    { 28, 3.55m, 20002, 3, 1, 3.01f },
                    { 29, 8.43m, 20003, 3, 1, 3.01f },
                    { 30, 13.49m, 20004, 3, 1, 3.01f },
                    { 31, 2.51m, 30000, 4, 1, 4f },
                    { 32, 2.78m, 30001, 4, 1, 4f },
                    { 33, 3.55m, 30002, 4, 1, 4f },
                    { 34, 8.43m, 30003, 4, 1, 4f },
                    { 35, 13.49m, 30004, 4, 1, 4f },
                    { 36, 2.51m, 30000, 4, 1, 4.01f },
                    { 37, 2.78m, 30001, 4, 1, 4.01f },
                    { 38, 3.55m, 30002, 4, 1, 4.01f },
                    { 39, 8.43m, 30003, 4, 1, 4.01f },
                    { 40, 13.49m, 30004, 4, 1, 4.01f }
                });

            migrationBuilder.InsertData(
                table: "MockProductPriceFR",
                columns: new[] { "Id", "Price", "ProductId", "ProductTypeId", "RatingFR", "Version" },
                values: new object[,]
                {
                    { 1, 2.51m, 1111, 1, 1, 1f },
                    { 2, 2.78m, 1112, 1, 1, 1f },
                    { 3, 3.55m, 1113, 1, 1, 1f },
                    { 4, 8.43m, 1114, 1, 1, 1f },
                    { 5, 13.49m, 1115, 1, 1, 1f },
                    { 6, 2.51m, 1111, 1, 1, 1.01f },
                    { 7, 2.78m, 1112, 1, 1, 1.01f },
                    { 8, 3.55m, 1113, 1, 1, 1.01f },
                    { 9, 8.43m, 1114, 1, 1, 1.01f },
                    { 10, 13.49m, 1115, 1, 1, 1.01f },
                    { 11, 2.51m, 10001, 2, 1, 2f },
                    { 12, 2.78m, 10002, 2, 1, 2f },
                    { 13, 3.55m, 10003, 2, 1, 2f },
                    { 14, 8.43m, 10004, 2, 1, 2f },
                    { 15, 13.49m, 10005, 2, 1, 2f },
                    { 16, 2.51m, 10001, 2, 1, 2.01f },
                    { 17, 2.78m, 10002, 2, 1, 2.01f },
                    { 18, 3.55m, 10003, 2, 1, 2.01f },
                    { 19, 8.43m, 10004, 2, 1, 2.01f },
                    { 20, 13.49m, 10005, 2, 1, 2.01f },
                    { 21, 2.51m, 20000, 3, 1, 3f },
                    { 22, 2.78m, 20001, 3, 1, 3f },
                    { 23, 3.55m, 20002, 3, 1, 3f },
                    { 24, 8.43m, 20003, 3, 1, 3f },
                    { 25, 13.49m, 20004, 3, 1, 3f },
                    { 26, 2.51m, 20000, 3, 1, 3.01f },
                    { 27, 2.78m, 20001, 3, 1, 3.01f },
                    { 28, 3.55m, 20002, 3, 1, 3.01f },
                    { 29, 8.43m, 20003, 3, 1, 3.01f },
                    { 30, 13.49m, 20004, 3, 1, 3.01f },
                    { 31, 2.51m, 30000, 4, 1, 4f },
                    { 32, 2.78m, 30001, 4, 1, 4f },
                    { 33, 3.55m, 30002, 4, 1, 4f },
                    { 34, 8.43m, 30003, 4, 1, 4f },
                    { 35, 13.49m, 30004, 4, 1, 4f },
                    { 36, 2.51m, 30000, 4, 1, 4.01f },
                    { 37, 2.78m, 30001, 4, 1, 4.01f },
                    { 38, 3.55m, 30002, 4, 1, 4.01f },
                    { 39, 8.43m, 30003, 4, 1, 4.01f },
                    { 40, 13.49m, 30004, 4, 1, 4.01f }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MockProductPriceDE");

            migrationBuilder.DropTable(
                name: "MockProductPriceFR");

            migrationBuilder.CreateTable(
                name: "MockAnimePriceDE",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Price = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    ProductId = table.Column<int>(type: "INTEGER", nullable: false),
                    RatingDE = table.Column<int>(type: "INTEGER", nullable: true),
                    Version = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MockAnimePriceDE", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MockAnimePriceFR",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Price = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    ProductId = table.Column<int>(type: "INTEGER", nullable: false),
                    RatingFR = table.Column<int>(type: "INTEGER", nullable: true),
                    Version = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MockAnimePriceFR", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MockComicPriceDE",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Price = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    ProductId = table.Column<int>(type: "INTEGER", nullable: false),
                    RatingDE = table.Column<int>(type: "INTEGER", nullable: true),
                    Version = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MockComicPriceDE", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MockComicPriceFR",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Price = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    ProductId = table.Column<int>(type: "INTEGER", nullable: false),
                    RatingFR = table.Column<int>(type: "INTEGER", nullable: true),
                    Version = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MockComicPriceFR", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MockMoviePriceDE",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Price = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    ProductId = table.Column<int>(type: "INTEGER", nullable: false),
                    RatingDE = table.Column<int>(type: "INTEGER", nullable: true),
                    Version = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MockMoviePriceDE", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MockMoviePriceFR",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Price = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    ProductId = table.Column<int>(type: "INTEGER", nullable: false),
                    RatingFR = table.Column<int>(type: "INTEGER", nullable: true),
                    Version = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MockMoviePriceFR", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MockTVPriceDE",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Price = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    ProductId = table.Column<int>(type: "INTEGER", nullable: false),
                    RatingDE = table.Column<int>(type: "INTEGER", nullable: true),
                    Version = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MockTVPriceDE", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MockTVPriceFR",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Price = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    ProductId = table.Column<int>(type: "INTEGER", nullable: false),
                    RatingFR = table.Column<int>(type: "INTEGER", nullable: true),
                    Version = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MockTVPriceFR", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "MockAnimePriceDE",
                columns: new[] { "Id", "Price", "ProductId", "RatingDE", "Version" },
                values: new object[,]
                {
                    { 1, 2.51m, 20000, 1, 1.00m },
                    { 2, 2.78m, 20001, 1, 1.00m },
                    { 3, 3.55m, 20002, 1, 1.00m },
                    { 4, 8.43m, 20003, 1, 1.00m },
                    { 5, 13.49m, 20004, 1, 1.00m },
                    { 6, 2.51m, 20000, 1, 1.01m },
                    { 7, 2.78m, 20001, 1, 1.01m },
                    { 8, 3.55m, 20002, 1, 1.01m },
                    { 9, 8.43m, 20003, 1, 1.01m },
                    { 10, 13.49m, 20004, 1, 1.01m }
                });

            migrationBuilder.InsertData(
                table: "MockAnimePriceFR",
                columns: new[] { "Id", "Price", "ProductId", "RatingFR", "Version" },
                values: new object[,]
                {
                    { 1, 2.51m, 20000, 1, 1.00m },
                    { 2, 2.78m, 20001, 1, 1.00m },
                    { 3, 3.55m, 20002, 1, 1.00m },
                    { 4, 8.43m, 20003, 1, 1.00m },
                    { 5, 13.49m, 20004, 1, 1.00m },
                    { 6, 2.51m, 20000, 1, 1.01m },
                    { 7, 2.78m, 20001, 1, 1.01m },
                    { 8, 3.55m, 20002, 1, 1.01m },
                    { 9, 8.43m, 20003, 1, 1.01m },
                    { 10, 13.49m, 20004, 1, 1.01m }
                });

            migrationBuilder.InsertData(
                table: "MockComicPriceDE",
                columns: new[] { "Id", "Price", "ProductId", "RatingDE", "Version" },
                values: new object[,]
                {
                    { 1, 2.51m, 30000, 1, 1.00m },
                    { 2, 2.78m, 30001, 1, 1.00m },
                    { 3, 3.55m, 30002, 1, 1.00m },
                    { 4, 8.43m, 30003, 1, 1.00m },
                    { 5, 13.49m, 30004, 1, 1.00m },
                    { 6, 2.51m, 30000, 1, 1.01m },
                    { 7, 2.78m, 30001, 1, 1.01m },
                    { 8, 3.55m, 30002, 1, 1.01m },
                    { 9, 8.43m, 30003, 1, 1.01m },
                    { 10, 13.49m, 30004, 1, 1.01m }
                });

            migrationBuilder.InsertData(
                table: "MockComicPriceFR",
                columns: new[] { "Id", "Price", "ProductId", "RatingFR", "Version" },
                values: new object[,]
                {
                    { 1, 2.51m, 30000, 1, 1.00m },
                    { 2, 2.78m, 30001, 1, 1.00m },
                    { 3, 3.55m, 30002, 1, 1.00m },
                    { 4, 8.43m, 30003, 1, 1.00m },
                    { 5, 13.49m, 30004, 1, 1.00m },
                    { 6, 2.51m, 30000, 1, 1.01m },
                    { 7, 2.78m, 30001, 1, 1.01m },
                    { 8, 3.55m, 30002, 1, 1.01m },
                    { 9, 8.43m, 30003, 1, 1.01m },
                    { 10, 13.49m, 30004, 1, 1.01m }
                });

            migrationBuilder.InsertData(
                table: "MockMoviePriceDE",
                columns: new[] { "Id", "Price", "ProductId", "RatingDE", "Version" },
                values: new object[,]
                {
                    { 1, 2.51m, 1111, 1, 1.00m },
                    { 2, 2.78m, 1112, 1, 1.00m },
                    { 3, 3.55m, 1113, 1, 1.00m },
                    { 4, 8.43m, 1114, 1, 1.00m },
                    { 5, 13.49m, 1115, 1, 1.00m },
                    { 6, 2.51m, 1111, 1, 1.01m },
                    { 7, 2.78m, 1112, 1, 1.01m },
                    { 8, 3.55m, 1113, 1, 1.01m },
                    { 9, 8.43m, 1114, 1, 1.01m },
                    { 10, 13.49m, 1115, 1, 1.01m }
                });

            migrationBuilder.InsertData(
                table: "MockMoviePriceFR",
                columns: new[] { "Id", "Price", "ProductId", "RatingFR", "Version" },
                values: new object[,]
                {
                    { 1, 2.51m, 1111, 1, 1.00m },
                    { 2, 2.78m, 1112, 1, 1.00m },
                    { 3, 3.55m, 1113, 1, 1.00m },
                    { 4, 8.43m, 1114, 1, 1.00m },
                    { 5, 13.49m, 1115, 1, 1.00m },
                    { 6, 2.51m, 1111, 1, 1.01m },
                    { 7, 2.78m, 1112, 1, 1.01m },
                    { 8, 3.55m, 1113, 1, 1.01m },
                    { 9, 8.43m, 1114, 1, 1.01m },
                    { 10, 13.49m, 1115, 1, 1.01m }
                });

            migrationBuilder.InsertData(
                table: "MockTVPriceDE",
                columns: new[] { "Id", "Price", "ProductId", "RatingDE", "Version" },
                values: new object[,]
                {
                    { 1, 2.51m, 10001, 1, 1.00m },
                    { 2, 2.78m, 10002, 1, 1.00m },
                    { 3, 3.55m, 10003, 1, 1.00m },
                    { 4, 8.43m, 10004, 1, 1.00m },
                    { 5, 13.49m, 10005, 1, 1.00m },
                    { 6, 2.51m, 10001, 1, 1.01m },
                    { 7, 2.78m, 10002, 1, 1.01m },
                    { 8, 3.55m, 10003, 1, 1.01m },
                    { 9, 8.43m, 10004, 1, 1.01m },
                    { 10, 13.49m, 10005, 1, 1.01m }
                });

            migrationBuilder.InsertData(
                table: "MockTVPriceFR",
                columns: new[] { "Id", "Price", "ProductId", "RatingFR", "Version" },
                values: new object[,]
                {
                    { 1, 2.51m, 10001, 1, 1.00m },
                    { 2, 2.78m, 10002, 1, 1.00m },
                    { 3, 3.55m, 10003, 1, 1.00m },
                    { 4, 8.43m, 10004, 1, 1.00m },
                    { 5, 13.49m, 10005, 1, 1.00m },
                    { 6, 2.51m, 10001, 1, 1.01m },
                    { 7, 2.78m, 10002, 1, 1.01m },
                    { 8, 3.55m, 10003, 1, 1.01m },
                    { 9, 8.43m, 10004, 1, 1.01m },
                    { 10, 13.49m, 10005, 1, 1.01m }
                });
        }
    }
}
