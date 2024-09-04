using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MovieTableEdit.Migrations
{
    /// <inheritdoc />
    public partial class MockFackTableFromCSV : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Date",
                table: "MockMovieFactFR",
                newName: "Timestamp");

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "MockMovieFactDE",
                newName: "Timestamp");

            migrationBuilder.AddColumn<string>(
                name: "TitleES",
                table: "MockMovieDim",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TitleIT",
                table: "MockMovieDim",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TitleJP",
                table: "MockMovieDim",
                type: "TEXT",
                nullable: true);

            migrationBuilder.InsertData(
                table: "MockGenreDim",
                columns: new[] { "GenreId", "Genre" },
                values: new object[,]
                {
                    { 3, "Eseteric" },
                    { 4, "Drama" },
                    { 5, "Fantasy" },
                    { 6, "Musical" },
                    { 7, "Comedy" }
                });

            migrationBuilder.UpdateData(
                table: "MockMovieDim",
                keyColumn: "MovieId",
                keyValue: 1111,
                columns: new[] { "TitleDE", "TitleES", "TitleFR", "TitleIT", "TitleJP" },
                values: new object[] { "", "", "", "", "" });

            migrationBuilder.UpdateData(
                table: "MockMovieDim",
                keyColumn: "MovieId",
                keyValue: 1112,
                columns: new[] { "TitleDE", "TitleES", "TitleFR", "TitleIT", "TitleJP" },
                values: new object[] { "", "", "", "", "" });

            migrationBuilder.UpdateData(
                table: "MockMovieDim",
                keyColumn: "MovieId",
                keyValue: 1113,
                columns: new[] { "TitleES", "TitleFR", "TitleIT", "TitleJP" },
                values: new object[] { "", "", "", "" });

            migrationBuilder.UpdateData(
                table: "MockMovieDim",
                keyColumn: "MovieId",
                keyValue: 1114,
                columns: new[] { "TitleDE", "TitleES", "TitleFR", "TitleIT", "TitleJP" },
                values: new object[] { "", "", "", "", "" });

            migrationBuilder.UpdateData(
                table: "MockMovieDim",
                keyColumn: "MovieId",
                keyValue: 1115,
                columns: new[] { "TitleDE", "TitleES", "TitleIT", "TitleJP" },
                values: new object[] { "", "", "", "" });

            migrationBuilder.InsertData(
                table: "MockMovieDim",
                columns: new[] { "MovieId", "GenreId", "Title", "TitleDE", "TitleES", "TitleFR", "TitleIT", "TitleJP" },
                values: new object[,]
                {
                    { 2222, 3, "The Marriage of Maria Braun", "Die Ehe der Maria Braun", "", "", "", "" },
                    { 2223, 3, "Aguirre, the Wrath of God", "Aguirre, der Zorn Gottes", "", "", "", "" },
                    { 2224, 4, "Head-On", "Gegen die Wand", "", "", "", "" },
                    { 3333, 4, "Children of Paradise", "", "", "Les Enfants du Paradis", "", "" },
                    { 3334, 4, "The Wages of Fear", "", "", "Le Salaire de la peur", "", "" },
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
                    { 7779, 3, "Woman in the Dunes\r\n", "", "", "", "", "砂の女" },
                    { 7780, 4, "Harakiri", "", "", "", "", "切腹" },
                    { 7781, 4, "Merry Christmas, Mr. Lawrence ", "", "", "", "", "戦場のメリークリスマス" },
                    { 7782, 4, "In This Corner of the World", "", "", "", "", "この世界の片隅に" }
                });

            migrationBuilder.UpdateData(
                table: "MockMovieFactDE",
                keyColumn: "Id",
                keyValue: 1,
                column: "Timestamp",
                value: new DateOnly(2023, 4, 12));

            migrationBuilder.UpdateData(
                table: "MockMovieFactDE",
                keyColumn: "Id",
                keyValue: 2,
                column: "Timestamp",
                value: new DateOnly(2023, 12, 24));

            migrationBuilder.UpdateData(
                table: "MockMovieFactDE",
                keyColumn: "Id",
                keyValue: 3,
                column: "Timestamp",
                value: new DateOnly(2023, 7, 10));

            migrationBuilder.UpdateData(
                table: "MockMovieFactDE",
                keyColumn: "Id",
                keyValue: 4,
                column: "Timestamp",
                value: new DateOnly(2023, 5, 15));

            migrationBuilder.UpdateData(
                table: "MockMovieFactDE",
                keyColumn: "Id",
                keyValue: 5,
                column: "Timestamp",
                value: new DateOnly(2023, 5, 24));

            migrationBuilder.UpdateData(
                table: "MockMovieFactFR",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "RatingFR", "Timestamp" },
                values: new object[] { "French-G", new DateOnly(2023, 4, 12) });

            migrationBuilder.UpdateData(
                table: "MockMovieFactFR",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "RatingFR", "Timestamp" },
                values: new object[] { "French-G", new DateOnly(2023, 12, 24) });

            migrationBuilder.UpdateData(
                table: "MockMovieFactFR",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "RatingFR", "Timestamp" },
                values: new object[] { "French-G", new DateOnly(2023, 7, 10) });

            migrationBuilder.UpdateData(
                table: "MockMovieFactFR",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "RatingFR", "Timestamp" },
                values: new object[] { "French-G", new DateOnly(2023, 5, 15) });

            migrationBuilder.UpdateData(
                table: "MockMovieFactFR",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "RatingFR", "Timestamp" },
                values: new object[] { "French-G", new DateOnly(2023, 5, 24) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MockGenreDim",
                keyColumn: "GenreId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "MockGenreDim",
                keyColumn: "GenreId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "MockGenreDim",
                keyColumn: "GenreId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "MockGenreDim",
                keyColumn: "GenreId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "MockGenreDim",
                keyColumn: "GenreId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "MockMovieDim",
                keyColumn: "MovieId",
                keyValue: 2222);

            migrationBuilder.DeleteData(
                table: "MockMovieDim",
                keyColumn: "MovieId",
                keyValue: 2223);

            migrationBuilder.DeleteData(
                table: "MockMovieDim",
                keyColumn: "MovieId",
                keyValue: 2224);

            migrationBuilder.DeleteData(
                table: "MockMovieDim",
                keyColumn: "MovieId",
                keyValue: 3333);

            migrationBuilder.DeleteData(
                table: "MockMovieDim",
                keyColumn: "MovieId",
                keyValue: 3334);

            migrationBuilder.DeleteData(
                table: "MockMovieDim",
                keyColumn: "MovieId",
                keyValue: 4444);

            migrationBuilder.DeleteData(
                table: "MockMovieDim",
                keyColumn: "MovieId",
                keyValue: 4445);

            migrationBuilder.DeleteData(
                table: "MockMovieDim",
                keyColumn: "MovieId",
                keyValue: 4446);

            migrationBuilder.DeleteData(
                table: "MockMovieDim",
                keyColumn: "MovieId",
                keyValue: 5555);

            migrationBuilder.DeleteData(
                table: "MockMovieDim",
                keyColumn: "MovieId",
                keyValue: 5556);

            migrationBuilder.DeleteData(
                table: "MockMovieDim",
                keyColumn: "MovieId",
                keyValue: 6666);

            migrationBuilder.DeleteData(
                table: "MockMovieDim",
                keyColumn: "MovieId",
                keyValue: 6667);

            migrationBuilder.DeleteData(
                table: "MockMovieDim",
                keyColumn: "MovieId",
                keyValue: 6668);

            migrationBuilder.DeleteData(
                table: "MockMovieDim",
                keyColumn: "MovieId",
                keyValue: 7777);

            migrationBuilder.DeleteData(
                table: "MockMovieDim",
                keyColumn: "MovieId",
                keyValue: 7778);

            migrationBuilder.DeleteData(
                table: "MockMovieDim",
                keyColumn: "MovieId",
                keyValue: 7779);

            migrationBuilder.DeleteData(
                table: "MockMovieDim",
                keyColumn: "MovieId",
                keyValue: 7780);

            migrationBuilder.DeleteData(
                table: "MockMovieDim",
                keyColumn: "MovieId",
                keyValue: 7781);

            migrationBuilder.DeleteData(
                table: "MockMovieDim",
                keyColumn: "MovieId",
                keyValue: 7782);

            migrationBuilder.DropColumn(
                name: "TitleES",
                table: "MockMovieDim");

            migrationBuilder.DropColumn(
                name: "TitleIT",
                table: "MockMovieDim");

            migrationBuilder.DropColumn(
                name: "TitleJP",
                table: "MockMovieDim");

            migrationBuilder.RenameColumn(
                name: "Timestamp",
                table: "MockMovieFactFR",
                newName: "Date");

            migrationBuilder.RenameColumn(
                name: "Timestamp",
                table: "MockMovieFactDE",
                newName: "Date");

            migrationBuilder.UpdateData(
                table: "MockMovieDim",
                keyColumn: "MovieId",
                keyValue: 1111,
                columns: new[] { "TitleDE", "TitleFR" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "MockMovieDim",
                keyColumn: "MovieId",
                keyValue: 1112,
                columns: new[] { "TitleDE", "TitleFR" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "MockMovieDim",
                keyColumn: "MovieId",
                keyValue: 1113,
                column: "TitleFR",
                value: null);

            migrationBuilder.UpdateData(
                table: "MockMovieDim",
                keyColumn: "MovieId",
                keyValue: 1114,
                columns: new[] { "TitleDE", "TitleFR" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "MockMovieDim",
                keyColumn: "MovieId",
                keyValue: 1115,
                column: "TitleDE",
                value: null);

            migrationBuilder.UpdateData(
                table: "MockMovieFactDE",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateOnly(1979, 4, 12));

            migrationBuilder.UpdateData(
                table: "MockMovieFactDE",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateOnly(1981, 12, 24));

            migrationBuilder.UpdateData(
                table: "MockMovieFactDE",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateOnly(1985, 7, 10));

            migrationBuilder.UpdateData(
                table: "MockMovieFactDE",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateOnly(2015, 5, 15));

            migrationBuilder.UpdateData(
                table: "MockMovieFactDE",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateOnly(2024, 5, 24));

            migrationBuilder.UpdateData(
                table: "MockMovieFactFR",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date", "RatingFR" },
                values: new object[] { new DateOnly(1979, 4, 12), "French-R" });

            migrationBuilder.UpdateData(
                table: "MockMovieFactFR",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date", "RatingFR" },
                values: new object[] { new DateOnly(1981, 12, 24), "French-R" });

            migrationBuilder.UpdateData(
                table: "MockMovieFactFR",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Date", "RatingFR" },
                values: new object[] { new DateOnly(1985, 7, 10), "French-R" });

            migrationBuilder.UpdateData(
                table: "MockMovieFactFR",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Date", "RatingFR" },
                values: new object[] { new DateOnly(2015, 5, 15), "French-R" });

            migrationBuilder.UpdateData(
                table: "MockMovieFactFR",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Date", "RatingFR" },
                values: new object[] { new DateOnly(2024, 5, 24), "French-R" });
        }
    }
}
