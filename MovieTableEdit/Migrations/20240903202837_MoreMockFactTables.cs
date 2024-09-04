using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieTableEdit.Migrations
{
    /// <inheritdoc />
    public partial class MoreMockFactTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TitleDE",
                table: "MockMovieDim",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TitleFR",
                table: "MockMovieDim",
                type: "TEXT",
                nullable: true);

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
                columns: new[] { "TitleDE", "TitleFR" },
                values: new object[] { null, null });

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
                columns: new[] { "TitleDE", "TitleFR" },
                values: new object[] { null, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TitleDE",
                table: "MockMovieDim");

            migrationBuilder.DropColumn(
                name: "TitleFR",
                table: "MockMovieDim");
        }
    }
}
