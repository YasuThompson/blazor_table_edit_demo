using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MovieTableEdit.Migrations
{
    /// <inheritdoc />
    public partial class SchemaUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MockMovieDim");

            migrationBuilder.DropTable(
                name: "MockMovieFact");

            migrationBuilder.DropTable(
                name: "MockMovieFactDE");

            migrationBuilder.DropTable(
                name: "MockMovieFactFR");

            migrationBuilder.CreateTable(
                name: "MockAnimePriceDE",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProductId = table.Column<int>(type: "INTEGER", nullable: false),
                    Timestamp = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    RatingDE = table.Column<int>(type: "INTEGER", nullable: true)
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
                    ProductId = table.Column<int>(type: "INTEGER", nullable: false),
                    Timestamp = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    RatingFR = table.Column<int>(type: "INTEGER", nullable: true)
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
                    ProductId = table.Column<int>(type: "INTEGER", nullable: false),
                    Timestamp = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    RatingDE = table.Column<int>(type: "INTEGER", nullable: true)
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
                    ProductId = table.Column<int>(type: "INTEGER", nullable: false),
                    Timestamp = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    RatingFR = table.Column<int>(type: "INTEGER", nullable: true)
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
                    ProductId = table.Column<int>(type: "INTEGER", nullable: false),
                    Timestamp = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    RatingDE = table.Column<int>(type: "INTEGER", nullable: true)
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
                    ProductId = table.Column<int>(type: "INTEGER", nullable: false),
                    Timestamp = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    RatingFR = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MockMoviePriceFR", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MockProductDim",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    ProductTypeId = table.Column<int>(type: "INTEGER", nullable: false),
                    GenreId = table.Column<int>(type: "INTEGER", nullable: false),
                    TitleDE = table.Column<string>(type: "TEXT", nullable: true),
                    TitleFR = table.Column<string>(type: "TEXT", nullable: true),
                    TitleES = table.Column<string>(type: "TEXT", nullable: true),
                    TitleIT = table.Column<string>(type: "TEXT", nullable: true),
                    TitleJP = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MockProductDim", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "MockProductTypeDim",
                columns: table => new
                {
                    ProductTypeId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProductType = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MockProductTypeDim", x => x.ProductTypeId);
                });

            migrationBuilder.CreateTable(
                name: "MockRatingDEDim",
                columns: table => new
                {
                    RatingDEId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RatingDE = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MockRatingDEDim", x => x.RatingDEId);
                });

            migrationBuilder.CreateTable(
                name: "MockRatingFRDim",
                columns: table => new
                {
                    RatingFRId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RatingFR = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MockRatingFRDim", x => x.RatingFRId);
                });

            migrationBuilder.CreateTable(
                name: "MockTVPriceDE",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProductId = table.Column<int>(type: "INTEGER", nullable: false),
                    Timestamp = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    RatingDE = table.Column<int>(type: "INTEGER", nullable: true)
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
                    ProductId = table.Column<int>(type: "INTEGER", nullable: false),
                    Timestamp = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    RatingFR = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MockTVPriceFR", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "MockAnimePriceDE",
                columns: new[] { "Id", "Price", "ProductId", "RatingDE", "Timestamp" },
                values: new object[,]
                {
                    { 1, 2.51m, 20000, 1, new DateOnly(2023, 4, 12) },
                    { 2, 2.78m, 20001, 1, new DateOnly(2023, 4, 12) },
                    { 3, 3.55m, 20002, 1, new DateOnly(2023, 4, 12) },
                    { 4, 8.43m, 20003, 1, new DateOnly(2023, 4, 12) },
                    { 5, 13.49m, 20004, 1, new DateOnly(2023, 4, 12) },
                    { 6, 2.51m, 20000, 1, new DateOnly(2023, 7, 17) },
                    { 7, 2.78m, 20001, 1, new DateOnly(2023, 7, 17) },
                    { 8, 3.55m, 20002, 1, new DateOnly(2023, 7, 17) },
                    { 9, 8.43m, 20003, 1, new DateOnly(2023, 7, 17) },
                    { 10, 13.49m, 20004, 1, new DateOnly(2023, 7, 17) }
                });

            migrationBuilder.InsertData(
                table: "MockAnimePriceFR",
                columns: new[] { "Id", "Price", "ProductId", "RatingFR", "Timestamp" },
                values: new object[,]
                {
                    { 1, 2.51m, 20000, 1, new DateOnly(2023, 4, 12) },
                    { 2, 2.78m, 20001, 1, new DateOnly(2023, 4, 12) },
                    { 3, 3.55m, 20002, 1, new DateOnly(2023, 4, 12) },
                    { 4, 8.43m, 20003, 1, new DateOnly(2023, 4, 12) },
                    { 5, 13.49m, 20004, 1, new DateOnly(2023, 4, 12) },
                    { 6, 2.51m, 20000, 1, new DateOnly(2023, 7, 17) },
                    { 7, 2.78m, 20001, 1, new DateOnly(2023, 7, 17) },
                    { 8, 3.55m, 20002, 1, new DateOnly(2023, 7, 17) },
                    { 9, 8.43m, 20003, 1, new DateOnly(2023, 7, 17) },
                    { 10, 13.49m, 20004, 1, new DateOnly(2023, 7, 17) }
                });

            migrationBuilder.InsertData(
                table: "MockComicPriceDE",
                columns: new[] { "Id", "Price", "ProductId", "RatingDE", "Timestamp" },
                values: new object[,]
                {
                    { 1, 2.51m, 30000, 1, new DateOnly(2023, 4, 12) },
                    { 2, 2.78m, 30001, 1, new DateOnly(2023, 4, 12) },
                    { 3, 3.55m, 30002, 1, new DateOnly(2023, 4, 12) },
                    { 4, 8.43m, 30003, 1, new DateOnly(2023, 4, 12) },
                    { 5, 13.49m, 30004, 1, new DateOnly(2023, 4, 12) },
                    { 6, 2.51m, 30000, 1, new DateOnly(2023, 7, 17) },
                    { 7, 2.78m, 30001, 1, new DateOnly(2023, 7, 17) },
                    { 8, 3.55m, 30002, 1, new DateOnly(2023, 7, 17) },
                    { 9, 8.43m, 30003, 1, new DateOnly(2023, 7, 17) },
                    { 10, 13.49m, 30004, 1, new DateOnly(2023, 7, 17) }
                });

            migrationBuilder.InsertData(
                table: "MockComicPriceFR",
                columns: new[] { "Id", "Price", "ProductId", "RatingFR", "Timestamp" },
                values: new object[,]
                {
                    { 1, 2.51m, 30000, 1, new DateOnly(2023, 4, 12) },
                    { 2, 2.78m, 30001, 1, new DateOnly(2023, 4, 12) },
                    { 3, 3.55m, 30002, 1, new DateOnly(2023, 4, 12) },
                    { 4, 8.43m, 30003, 1, new DateOnly(2023, 4, 12) },
                    { 5, 13.49m, 30004, 1, new DateOnly(2023, 4, 12) },
                    { 6, 2.51m, 30000, 1, new DateOnly(2023, 7, 17) },
                    { 7, 2.78m, 30001, 1, new DateOnly(2023, 7, 17) },
                    { 8, 3.55m, 30002, 1, new DateOnly(2023, 7, 17) },
                    { 9, 8.43m, 30003, 1, new DateOnly(2023, 7, 17) },
                    { 10, 13.49m, 30004, 1, new DateOnly(2023, 7, 17) }
                });

            migrationBuilder.InsertData(
                table: "MockGenreDim",
                columns: new[] { "GenreId", "Genre" },
                values: new object[] { 8, "History/biography" });

            migrationBuilder.InsertData(
                table: "MockMoviePriceDE",
                columns: new[] { "Id", "Price", "ProductId", "RatingDE", "Timestamp" },
                values: new object[,]
                {
                    { 1, 2.51m, 10000, 1, new DateOnly(2023, 4, 12) },
                    { 2, 2.78m, 10001, 1, new DateOnly(2023, 4, 12) },
                    { 3, 3.55m, 10002, 1, new DateOnly(2023, 4, 12) },
                    { 4, 8.43m, 10003, 1, new DateOnly(2023, 4, 12) },
                    { 5, 13.49m, 10004, 1, new DateOnly(2023, 4, 12) },
                    { 6, 2.51m, 10000, 1, new DateOnly(2023, 7, 17) },
                    { 7, 2.78m, 10001, 1, new DateOnly(2023, 7, 17) },
                    { 8, 3.55m, 10002, 1, new DateOnly(2023, 7, 17) },
                    { 9, 8.43m, 10003, 1, new DateOnly(2023, 7, 17) },
                    { 10, 13.49m, 10004, 1, new DateOnly(2023, 7, 17) }
                });

            migrationBuilder.InsertData(
                table: "MockMoviePriceFR",
                columns: new[] { "Id", "Price", "ProductId", "RatingFR", "Timestamp" },
                values: new object[,]
                {
                    { 1, 2.51m, 1111, 1, new DateOnly(2023, 4, 12) },
                    { 2, 2.78m, 1112, 1, new DateOnly(2023, 12, 24) },
                    { 3, 3.55m, 1113, 1, new DateOnly(2023, 7, 10) },
                    { 4, 8.43m, 1114, 1, new DateOnly(2023, 5, 15) },
                    { 5, 13.49m, 1115, 1, new DateOnly(2023, 5, 24) }
                });

            migrationBuilder.InsertData(
                table: "MockProductDim",
                columns: new[] { "ProductId", "GenreId", "ProductTypeId", "Title", "TitleDE", "TitleES", "TitleFR", "TitleIT", "TitleJP" },
                values: new object[,]
                {
                    { 1111, 4, 1, "Red River", "", "", "", "", "" },
                    { 1112, 4, 1, "The Last Picture Show", "", "", "", "", "" },
                    { 1113, 4, 1, "Network", "", "", "", "", "" },
                    { 1114, 4, 1, "Traffic", "", "", "", "", "" },
                    { 1115, 4, 1, "Florida Project", "", "", "", "", "" },
                    { 2222, 3, 1, "The Marriage of Maria Braun", "Die Ehe der Maria Braun", "", "", "", "" },
                    { 2223, 3, 1, "Aguirre the Wrath of God", "Aguirre der Zorn Gottes", "", "", "", "" },
                    { 2224, 4, 1, "Head-On", "Gegen die Wand", "", "", "", "" },
                    { 3333, 4, 1, "Children of Paradise", "", "", "Les Enfants du Paradis", "", "" },
                    { 3334, 4, 1, "The Wages of Fear", "", "", "Le Salaire de la peur", "", "" },
                    { 3335, 4, 1, "Portrait of a Lady on Fire", "", "", "Portrait de la jeune fille en feu", "", "" },
                    { 4444, 4, 1, "Talk to Her", "", "Hable Con Ella", "", "", "" },
                    { 4445, 3, 1, "The Spirit of the Beehive", "", "El espíritu de la colmena", "", "", "" },
                    { 4446, 5, 1, "Pan's Labyrinth", "", "El Laberinto Del Fauno", "", "", "" },
                    { 5555, 6, 1, "The Red Shoes", "", "", "", "", "" },
                    { 5556, 7, 1, "Hot Fuzz", "", "", "", "", "" },
                    { 6666, 4, 1, "Nights of Cabiria", "", "", "", "Le notti di Cabiria", "" },
                    { 6667, 3, 1, "The Conformist", "", "", "", "Il conformista", "" },
                    { 6668, 4, 1, "Gomorrah", "", "", "", "Gomorra", "" },
                    { 6669, 8, 1, "Il Divo", "", "", "", "Il Divo", "" },
                    { 7777, 2, 1, "Seven Samurai", "", "", "", "", "七人の侍" },
                    { 7778, 4, 1, "Sansho the Bailiff", "", "", "", "", "山椒大夫" },
                    { 7779, 3, 1, "Woman in the Dunes", "", "", "", "", "砂の女" },
                    { 7780, 4, 1, "Harakiri", "", "", "", "", "切腹" },
                    { 7781, 4, 1, "Merry Christmas, Mr. Lawrence ", "", "", "", "", "戦場のメリークリスマス" },
                    { 7782, 4, 1, "In This Corner of the World", "", "", "", "", "この世界の片隅に" },
                    { 10000, 7, 2, "Monty Python’s Flying Circus", "", "", "", "", "" },
                    { 10001, 7, 2, "M*A*S*H", "", "", "", "", "" },
                    { 10002, 4, 2, "The Sopranos", "", "", "", "", "" },
                    { 10003, 4, 2, "Mad Men", "", "", "", "", "" },
                    { 10004, 4, 2, "Fanny and Alexander", "", "", "", "", "" },
                    { 10005, 4, 2, "Dekalog", "", "", "", "", "" },
                    { 20000, 2, 3, "Attack on Titan", "", "", "", "", "進撃の巨人" },
                    { 20001, 2, 3, "JoJo's Bizarre Adventure Stardust Crusaders\r\n", "", "", "", "", "ジョジョの奇妙な冒険 スターダストクルセイダース" },
                    { 20002, 2, 3, "JoJo's Bizarre Adventure Diamond Is Unbreakable\r\n", "", "", "", "", "ジョジョの奇妙な冒険 ダイヤモンドは砕けない" },
                    { 20003, 2, 3, "JoJo's Bizarre Adventure Golden Wind\r\n", "", "", "", "", "ジョジョの奇妙な冒険 黄金の風" },
                    { 20004, 2, 3, "JoJo's Bizarre Adventure Stone Ocean\r\n", "", "", "", "", "ジョジョの奇妙な冒険 ストーンオーシャン" },
                    { 30000, 8, 4, "Kingdom", "", "", "", "", "キングダム" },
                    { 30001, 4, 4, "Orb: On the Movements of the Earth", "", "", "", "", "チ。地球の運動について" },
                    { 30002, 4, 4, "Blood on Tracks", "", "", "", "", "血の轍" },
                    { 30003, 5, 4, "Berserk", "", "", "", "", "ベルセルク" },
                    { 30004, 8, 4, "Persepolis", "", "", "", "", "" },
                    { 30005, 4, 4, "Watchmen", "", "", "", "", "" }
                });

            migrationBuilder.InsertData(
                table: "MockProductTypeDim",
                columns: new[] { "ProductTypeId", "ProductType" },
                values: new object[,]
                {
                    { 1, "Movie" },
                    { 2, "TV Show" },
                    { 3, "Animated Series" },
                    { 4, "Comic" }
                });

            migrationBuilder.InsertData(
                table: "MockRatingDEDim",
                columns: new[] { "RatingDEId", "RatingDE" },
                values: new object[,]
                {
                    { 1, "German-G" },
                    { 2, "German-PG" },
                    { 3, "German-PG-13" },
                    { 4, "German-R" },
                    { 5, "German-NC-17" }
                });

            migrationBuilder.InsertData(
                table: "MockRatingFRDim",
                columns: new[] { "RatingFRId", "RatingFR" },
                values: new object[,]
                {
                    { 1, "French-G" },
                    { 2, "French-PG" },
                    { 3, "French-PG-13" },
                    { 4, "French-R" },
                    { 5, "French-NC-17" }
                });

            migrationBuilder.InsertData(
                table: "MockTVPriceDE",
                columns: new[] { "Id", "Price", "ProductId", "RatingDE", "Timestamp" },
                values: new object[,]
                {
                    { 1, 2.51m, 1111, 1, new DateOnly(2023, 4, 12) },
                    { 2, 2.78m, 1112, 1, new DateOnly(2023, 4, 12) },
                    { 3, 3.55m, 1113, 1, new DateOnly(2023, 4, 12) },
                    { 4, 8.43m, 1114, 1, new DateOnly(2023, 4, 12) },
                    { 5, 13.49m, 1115, 1, new DateOnly(2023, 4, 12) },
                    { 6, 2.51m, 1111, 1, new DateOnly(2023, 7, 17) },
                    { 7, 2.78m, 1112, 1, new DateOnly(2023, 7, 17) },
                    { 8, 3.55m, 1113, 1, new DateOnly(2023, 7, 17) },
                    { 9, 8.43m, 1114, 1, new DateOnly(2023, 7, 17) },
                    { 10, 13.49m, 1115, 1, new DateOnly(2023, 7, 17) }
                });

            migrationBuilder.InsertData(
                table: "MockTVPriceFR",
                columns: new[] { "Id", "Price", "ProductId", "RatingFR", "Timestamp" },
                values: new object[,]
                {
                    { 1, 2.51m, 1111, 1, new DateOnly(2023, 4, 12) },
                    { 2, 2.78m, 1112, 1, new DateOnly(2023, 4, 12) },
                    { 3, 3.55m, 1113, 1, new DateOnly(2023, 4, 12) },
                    { 4, 8.43m, 1114, 1, new DateOnly(2023, 4, 12) },
                    { 5, 13.49m, 1115, 1, new DateOnly(2023, 4, 12) },
                    { 6, 2.51m, 1111, 1, new DateOnly(2023, 7, 17) },
                    { 7, 2.78m, 1112, 1, new DateOnly(2023, 7, 17) },
                    { 8, 3.55m, 1113, 1, new DateOnly(2023, 7, 17) },
                    { 9, 8.43m, 1114, 1, new DateOnly(2023, 7, 17) },
                    { 10, 13.49m, 1115, 1, new DateOnly(2023, 7, 17) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "MockProductDim");

            migrationBuilder.DropTable(
                name: "MockProductTypeDim");

            migrationBuilder.DropTable(
                name: "MockRatingDEDim");

            migrationBuilder.DropTable(
                name: "MockRatingFRDim");

            migrationBuilder.DropTable(
                name: "MockTVPriceDE");

            migrationBuilder.DropTable(
                name: "MockTVPriceFR");

            migrationBuilder.DeleteData(
                table: "MockGenreDim",
                keyColumn: "GenreId",
                keyValue: 8);

            migrationBuilder.CreateTable(
                name: "MockMovieDim",
                columns: table => new
                {
                    MovieId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    GenreId = table.Column<int>(type: "INTEGER", nullable: false),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    TitleDE = table.Column<string>(type: "TEXT", nullable: true),
                    TitleES = table.Column<string>(type: "TEXT", nullable: true),
                    TitleFR = table.Column<string>(type: "TEXT", nullable: true),
                    TitleIT = table.Column<string>(type: "TEXT", nullable: true),
                    TitleJP = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MockMovieDim", x => x.MovieId);
                });

            migrationBuilder.CreateTable(
                name: "MockMovieFact",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Date = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    MovieId = table.Column<int>(type: "INTEGER", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18, 2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MockMovieFact", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MockMovieFactDE",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MovieId = table.Column<int>(type: "INTEGER", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    RatingDE = table.Column<string>(type: "TEXT", nullable: true),
                    Timestamp = table.Column<DateOnly>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MockMovieFactDE", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MockMovieFactFR",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MovieId = table.Column<int>(type: "INTEGER", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    RatingFR = table.Column<string>(type: "TEXT", nullable: true),
                    Timestamp = table.Column<DateOnly>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MockMovieFactFR", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "MockMovieDim",
                columns: new[] { "MovieId", "GenreId", "Title", "TitleDE", "TitleES", "TitleFR", "TitleIT", "TitleJP" },
                values: new object[,]
                {
                    { 1111, 4, "Red River", "", "", "", "", "" },
                    { 1112, 4, "The Last Picture Show", "", "", "", "", "" },
                    { 1113, 4, "Network", "", "", "", "", "" },
                    { 1114, 4, "Traffic", "", "", "", "", "" },
                    { 1115, 4, "Florida Project", "", "", "", "", "" },
                    { 2222, 3, "The Marriage of Maria Braun", "Die Ehe der Maria Braun", "", "", "", "" },
                    { 2223, 3, "Aguirre the Wrath of God", "Aguirre der Zorn Gottes", "", "", "", "" },
                    { 2224, 4, "Head-On", "Gegen die Wand", "", "", "", "" },
                    { 3333, 4, "Children of Paradise", "", "", "Les Enfants du Paradis", "", "" },
                    { 3334, 4, "The Wages of Fear", "", "", "Le Salaire de la peur", "", "" },
                    { 3335, 4, "Portrait of a Lady on Fire", "", "", "Portrait de la jeune fille en feu", "", "" },
                    { 4444, 4, "Talk to Her", "", "Hable Con Ella", "", "", "" },
                    { 4445, 3, "The Spirit of the Beehive", "", "El espíritu de la colmena", "", "", "" },
                    { 4446, 5, "Pan's Labyrinth", "", "El Laberinto Del Fauno", "", "", "" },
                    { 5555, 6, "The Red Shoes", "", "", "", "", "" },
                    { 5556, 7, "Hot Fuzz", "", "", "", "", "" },
                    { 6666, 4, "Nights of Cabiria", "", "", "", "Le notti di Cabiria", "" },
                    { 6667, 3, "The Conformist", "", "", "", "Il conformista", "" },
                    { 6668, 4, "Gomorrah", "", "", "", "Gomorra", "" },
                    { 7777, 2, "Seven Samurai", "", "", "", "", "七人の侍" },
                    { 7778, 4, "Sansho the Bailiff ", "", "", "", "", "山椒大夫" },
                    { 7779, 3, "Woman in the Dunes", "", "", "", "", "砂の女" },
                    { 7780, 4, "Harakiri", "", "", "", "", "切腹" },
                    { 7781, 4, "Merry Christmas, Mr. Lawrence ", "", "", "", "", "戦場のメリークリスマス" },
                    { 7782, 4, "In This Corner of the World", "", "", "", "", "この世界の片隅に" }
                });

            migrationBuilder.InsertData(
                table: "MockMovieFact",
                columns: new[] { "Id", "Date", "MovieId", "Price" },
                values: new object[,]
                {
                    { 1, new DateOnly(1979, 4, 12), 1111, 2.51m },
                    { 2, new DateOnly(1981, 12, 24), 1112, 2.78m },
                    { 3, new DateOnly(1985, 7, 10), 1113, 3.55m },
                    { 4, new DateOnly(2015, 5, 15), 1114, 8.43m },
                    { 5, new DateOnly(2024, 5, 24), 1115, 13.49m }
                });

            migrationBuilder.InsertData(
                table: "MockMovieFactDE",
                columns: new[] { "Id", "MovieId", "Price", "RatingDE", "Timestamp" },
                values: new object[,]
                {
                    { 1, 1111, 2.51m, "German-G", new DateOnly(2023, 4, 12) },
                    { 2, 1112, 2.78m, "German-G", new DateOnly(2023, 12, 24) },
                    { 3, 1113, 3.55m, "German-G", new DateOnly(2023, 7, 10) },
                    { 4, 1114, 8.43m, "German-G", new DateOnly(2023, 5, 15) },
                    { 5, 1115, 13.49m, "German-G", new DateOnly(2023, 5, 24) }
                });

            migrationBuilder.InsertData(
                table: "MockMovieFactFR",
                columns: new[] { "Id", "MovieId", "Price", "RatingFR", "Timestamp" },
                values: new object[,]
                {
                    { 1, 1111, 2.51m, "French-G", new DateOnly(2023, 4, 12) },
                    { 2, 1112, 2.78m, "French-G", new DateOnly(2023, 12, 24) },
                    { 3, 1113, 3.55m, "French-G", new DateOnly(2023, 7, 10) },
                    { 4, 1114, 8.43m, "French-G", new DateOnly(2023, 5, 15) },
                    { 5, 1115, 13.49m, "French-G", new DateOnly(2023, 5, 24) }
                });
        }
    }
}
