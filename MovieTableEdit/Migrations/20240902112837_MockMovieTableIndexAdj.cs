using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MovieTableEdit.Migrations
{
    /// <inheritdoc />
    public partial class MockMovieTableIndexAdj : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_MockMovieFact",
                table: "MockMovieFact");

            migrationBuilder.DeleteData(
                table: "MockMovieFact",
                keyColumn: "MovieId",
                keyValue: 1111);

            migrationBuilder.DeleteData(
                table: "MockMovieFact",
                keyColumn: "MovieId",
                keyValue: 1112);

            migrationBuilder.DeleteData(
                table: "MockMovieFact",
                keyColumn: "MovieId",
                keyValue: 1113);

            migrationBuilder.DeleteData(
                table: "MockMovieFact",
                keyColumn: "MovieId",
                keyValue: 1114);

            migrationBuilder.DeleteData(
                table: "MockMovieFact",
                keyColumn: "MovieId",
                keyValue: 1115);

            migrationBuilder.AlterColumn<int>(
                name: "MovieId",
                table: "MockMovieFact",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "MockMovieFact",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0)
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_MockMovieFact",
                table: "MockMovieFact",
                column: "Id");

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_MockMovieFact",
                table: "MockMovieFact");

            migrationBuilder.DeleteData(
                table: "MockMovieFact",
                keyColumn: "Id",
                keyColumnType: "INTEGER",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MockMovieFact",
                keyColumn: "Id",
                keyColumnType: "INTEGER",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MockMovieFact",
                keyColumn: "Id",
                keyColumnType: "INTEGER",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "MockMovieFact",
                keyColumn: "Id",
                keyColumnType: "INTEGER",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "MockMovieFact",
                keyColumn: "Id",
                keyColumnType: "INTEGER",
                keyValue: 5);

            migrationBuilder.DropColumn(
                name: "Id",
                table: "MockMovieFact");

            migrationBuilder.AlterColumn<int>(
                name: "MovieId",
                table: "MockMovieFact",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_MockMovieFact",
                table: "MockMovieFact",
                column: "MovieId");

            migrationBuilder.InsertData(
                table: "MockMovieFact",
                columns: new[] { "MovieId", "Date", "Price" },
                values: new object[,]
                {
                    { 1111, new DateOnly(1979, 4, 12), 2.51m },
                    { 1112, new DateOnly(1981, 12, 24), 2.78m },
                    { 1113, new DateOnly(1985, 7, 10), 3.55m },
                    { 1114, new DateOnly(2015, 5, 15), 8.43m },
                    { 1115, new DateOnly(2024, 5, 24), 13.49m }
                });
        }
    }
}
