using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieTableEdit.Migrations
{
    /// <inheritdoc />
    public partial class MovieDimAdjustment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MockMovieDim",
                keyColumn: "MovieId",
                keyValue: 1111,
                columns: new[] { "GenreId", "Title" },
                values: new object[] { 4, "Red River" });

            migrationBuilder.UpdateData(
                table: "MockMovieDim",
                keyColumn: "MovieId",
                keyValue: 1112,
                columns: new[] { "GenreId", "Title" },
                values: new object[] { 4, "The Last Picture Show" });

            migrationBuilder.UpdateData(
                table: "MockMovieDim",
                keyColumn: "MovieId",
                keyValue: 1113,
                columns: new[] { "GenreId", "Title", "TitleDE" },
                values: new object[] { 4, "Network", "" });

            migrationBuilder.UpdateData(
                table: "MockMovieDim",
                keyColumn: "MovieId",
                keyValue: 1114,
                columns: new[] { "GenreId", "Title" },
                values: new object[] { 4, "Traffic" });

            migrationBuilder.UpdateData(
                table: "MockMovieDim",
                keyColumn: "MovieId",
                keyValue: 1115,
                columns: new[] { "GenreId", "Title", "TitleFR" },
                values: new object[] { 4, "Florida Project", "" });

            migrationBuilder.UpdateData(
                table: "MockMovieDim",
                keyColumn: "MovieId",
                keyValue: 2223,
                columns: new[] { "Title", "TitleDE" },
                values: new object[] { "Aguirre the Wrath of God", "Aguirre der Zorn Gottes" });

            migrationBuilder.UpdateData(
                table: "MockMovieDim",
                keyColumn: "MovieId",
                keyValue: 7779,
                column: "Title",
                value: "Woman in the Dunes");

            migrationBuilder.InsertData(
                table: "MockMovieDim",
                columns: new[] { "MovieId", "GenreId", "Title", "TitleDE", "TitleES", "TitleFR", "TitleIT", "TitleJP" },
                values: new object[] { 3335, 4, "Portrait of a Lady on Fire", "", "", "Portrait de la jeune fille en feu", "", "" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MockMovieDim",
                keyColumn: "MovieId",
                keyValue: 3335);

            migrationBuilder.UpdateData(
                table: "MockMovieDim",
                keyColumn: "MovieId",
                keyValue: 1111,
                columns: new[] { "GenreId", "Title" },
                values: new object[] { 1, "Mad Max" });

            migrationBuilder.UpdateData(
                table: "MockMovieDim",
                keyColumn: "MovieId",
                keyValue: 1112,
                columns: new[] { "GenreId", "Title" },
                values: new object[] { 1, "The Road Warrior" });

            migrationBuilder.UpdateData(
                table: "MockMovieDim",
                keyColumn: "MovieId",
                keyValue: 1113,
                columns: new[] { "GenreId", "Title", "TitleDE" },
                values: new object[] { 2, "Mad Max: Beyond Thunderdome", "Mad Max: Jeneseits der Donnerkuppel" });

            migrationBuilder.UpdateData(
                table: "MockMovieDim",
                keyColumn: "MovieId",
                keyValue: 1114,
                columns: new[] { "GenreId", "Title" },
                values: new object[] { 1, "Mad Max: Fury Road" });

            migrationBuilder.UpdateData(
                table: "MockMovieDim",
                keyColumn: "MovieId",
                keyValue: 1115,
                columns: new[] { "GenreId", "Title", "TitleFR" },
                values: new object[] { 1, "Furiosa: A Mad Max Saga", "Furiosa: Une saga Mad Max" });

            migrationBuilder.UpdateData(
                table: "MockMovieDim",
                keyColumn: "MovieId",
                keyValue: 2223,
                columns: new[] { "Title", "TitleDE" },
                values: new object[] { "Aguirre, the Wrath of God", "Aguirre, der Zorn Gottes" });

            migrationBuilder.UpdateData(
                table: "MockMovieDim",
                keyColumn: "MovieId",
                keyValue: 7779,
                column: "Title",
                value: "Woman in the Dunes\r\n");
        }
    }
}
