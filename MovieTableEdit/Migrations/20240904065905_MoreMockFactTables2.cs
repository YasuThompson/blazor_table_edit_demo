using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MovieTableEdit.Migrations
{
    /// <inheritdoc />
    public partial class MoreMockFactTables2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MockMovieFactDE",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MovieId = table.Column<int>(type: "INTEGER", nullable: false),
                    Date = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    RatingDE = table.Column<string>(type: "TEXT", nullable: true)
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
                    Date = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    RatingFR = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MockMovieFactFR", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "MockMovieDim",
                keyColumn: "MovieId",
                keyValue: 1113,
                column: "TitleDE",
                value: "Mad Max: Jeneseits der Donnerkuppel");

            migrationBuilder.UpdateData(
                table: "MockMovieDim",
                keyColumn: "MovieId",
                keyValue: 1115,
                column: "TitleFR",
                value: "Furiosa: Une saga Mad Max");

            migrationBuilder.InsertData(
                table: "MockMovieFactDE",
                columns: new[] { "Id", "Date", "MovieId", "Price", "RatingDE" },
                values: new object[,]
                {
                    { 1, new DateOnly(1979, 4, 12), 1111, 2.51m, "German-G" },
                    { 2, new DateOnly(1981, 12, 24), 1112, 2.78m, "German-G" },
                    { 3, new DateOnly(1985, 7, 10), 1113, 3.55m, "German-G" },
                    { 4, new DateOnly(2015, 5, 15), 1114, 8.43m, "German-G" },
                    { 5, new DateOnly(2024, 5, 24), 1115, 13.49m, "German-G" }
                });

            migrationBuilder.InsertData(
                table: "MockMovieFactFR",
                columns: new[] { "Id", "Date", "MovieId", "Price", "RatingFR" },
                values: new object[,]
                {
                    { 1, new DateOnly(1979, 4, 12), 1111, 2.51m, "French-R" },
                    { 2, new DateOnly(1981, 12, 24), 1112, 2.78m, "French-R" },
                    { 3, new DateOnly(1985, 7, 10), 1113, 3.55m, "French-R" },
                    { 4, new DateOnly(2015, 5, 15), 1114, 8.43m, "French-R" },
                    { 5, new DateOnly(2024, 5, 24), 1115, 13.49m, "French-R" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MockMovieFactDE");

            migrationBuilder.DropTable(
                name: "MockMovieFactFR");

            migrationBuilder.UpdateData(
                table: "MockMovieDim",
                keyColumn: "MovieId",
                keyValue: 1113,
                column: "TitleDE",
                value: null);

            migrationBuilder.UpdateData(
                table: "MockMovieDim",
                keyColumn: "MovieId",
                keyValue: 1115,
                column: "TitleFR",
                value: null);
        }
    }
}
