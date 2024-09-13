using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MovieTableEdit.Migrations
{
    /// <inheritdoc />
    public partial class VersionDataTypeAdjustment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Timestamp",
                table: "MockTVPriceFR",
                newName: "Version");

            migrationBuilder.RenameColumn(
                name: "Timestamp",
                table: "MockTVPriceDE",
                newName: "Version");

            migrationBuilder.RenameColumn(
                name: "Timestamp",
                table: "MockMoviePriceFR",
                newName: "Version");

            migrationBuilder.RenameColumn(
                name: "Timestamp",
                table: "MockMoviePriceDE",
                newName: "Version");

            migrationBuilder.RenameColumn(
                name: "Timestamp",
                table: "MockComicPriceFR",
                newName: "Version");

            migrationBuilder.RenameColumn(
                name: "Timestamp",
                table: "MockComicPriceDE",
                newName: "Version");

            migrationBuilder.RenameColumn(
                name: "Timestamp",
                table: "MockAnimePriceFR",
                newName: "Version");

            migrationBuilder.RenameColumn(
                name: "Timestamp",
                table: "MockAnimePriceDE",
                newName: "Version");

            migrationBuilder.UpdateData(
                table: "MockAnimePriceDE",
                keyColumn: "Id",
                keyValue: 1,
                column: "Version",
                value: 1.00m);

            migrationBuilder.UpdateData(
                table: "MockAnimePriceDE",
                keyColumn: "Id",
                keyValue: 2,
                column: "Version",
                value: 1.00m);

            migrationBuilder.UpdateData(
                table: "MockAnimePriceDE",
                keyColumn: "Id",
                keyValue: 3,
                column: "Version",
                value: 1.00m);

            migrationBuilder.UpdateData(
                table: "MockAnimePriceDE",
                keyColumn: "Id",
                keyValue: 4,
                column: "Version",
                value: 1.00m);

            migrationBuilder.UpdateData(
                table: "MockAnimePriceDE",
                keyColumn: "Id",
                keyValue: 5,
                column: "Version",
                value: 1.00m);

            migrationBuilder.UpdateData(
                table: "MockAnimePriceDE",
                keyColumn: "Id",
                keyValue: 6,
                column: "Version",
                value: 1.01m);

            migrationBuilder.UpdateData(
                table: "MockAnimePriceDE",
                keyColumn: "Id",
                keyValue: 7,
                column: "Version",
                value: 1.01m);

            migrationBuilder.UpdateData(
                table: "MockAnimePriceDE",
                keyColumn: "Id",
                keyValue: 8,
                column: "Version",
                value: 1.01m);

            migrationBuilder.UpdateData(
                table: "MockAnimePriceDE",
                keyColumn: "Id",
                keyValue: 9,
                column: "Version",
                value: 1.01m);

            migrationBuilder.UpdateData(
                table: "MockAnimePriceDE",
                keyColumn: "Id",
                keyValue: 10,
                column: "Version",
                value: 1.01m);

            migrationBuilder.UpdateData(
                table: "MockAnimePriceFR",
                keyColumn: "Id",
                keyValue: 1,
                column: "Version",
                value: 1.00m);

            migrationBuilder.UpdateData(
                table: "MockAnimePriceFR",
                keyColumn: "Id",
                keyValue: 2,
                column: "Version",
                value: 1.00m);

            migrationBuilder.UpdateData(
                table: "MockAnimePriceFR",
                keyColumn: "Id",
                keyValue: 3,
                column: "Version",
                value: 1.00m);

            migrationBuilder.UpdateData(
                table: "MockAnimePriceFR",
                keyColumn: "Id",
                keyValue: 4,
                column: "Version",
                value: 1.00m);

            migrationBuilder.UpdateData(
                table: "MockAnimePriceFR",
                keyColumn: "Id",
                keyValue: 5,
                column: "Version",
                value: 1.00m);

            migrationBuilder.UpdateData(
                table: "MockAnimePriceFR",
                keyColumn: "Id",
                keyValue: 6,
                column: "Version",
                value: 1.01m);

            migrationBuilder.UpdateData(
                table: "MockAnimePriceFR",
                keyColumn: "Id",
                keyValue: 7,
                column: "Version",
                value: 1.01m);

            migrationBuilder.UpdateData(
                table: "MockAnimePriceFR",
                keyColumn: "Id",
                keyValue: 8,
                column: "Version",
                value: 1.01m);

            migrationBuilder.UpdateData(
                table: "MockAnimePriceFR",
                keyColumn: "Id",
                keyValue: 9,
                column: "Version",
                value: 1.01m);

            migrationBuilder.UpdateData(
                table: "MockAnimePriceFR",
                keyColumn: "Id",
                keyValue: 10,
                column: "Version",
                value: 1.01m);

            migrationBuilder.UpdateData(
                table: "MockComicPriceDE",
                keyColumn: "Id",
                keyValue: 1,
                column: "Version",
                value: 1.00m);

            migrationBuilder.UpdateData(
                table: "MockComicPriceDE",
                keyColumn: "Id",
                keyValue: 2,
                column: "Version",
                value: 1.00m);

            migrationBuilder.UpdateData(
                table: "MockComicPriceDE",
                keyColumn: "Id",
                keyValue: 3,
                column: "Version",
                value: 1.00m);

            migrationBuilder.UpdateData(
                table: "MockComicPriceDE",
                keyColumn: "Id",
                keyValue: 4,
                column: "Version",
                value: 1.00m);

            migrationBuilder.UpdateData(
                table: "MockComicPriceDE",
                keyColumn: "Id",
                keyValue: 5,
                column: "Version",
                value: 1.00m);

            migrationBuilder.UpdateData(
                table: "MockComicPriceDE",
                keyColumn: "Id",
                keyValue: 6,
                column: "Version",
                value: 1.01m);

            migrationBuilder.UpdateData(
                table: "MockComicPriceDE",
                keyColumn: "Id",
                keyValue: 7,
                column: "Version",
                value: 1.01m);

            migrationBuilder.UpdateData(
                table: "MockComicPriceDE",
                keyColumn: "Id",
                keyValue: 8,
                column: "Version",
                value: 1.01m);

            migrationBuilder.UpdateData(
                table: "MockComicPriceDE",
                keyColumn: "Id",
                keyValue: 9,
                column: "Version",
                value: 1.01m);

            migrationBuilder.UpdateData(
                table: "MockComicPriceDE",
                keyColumn: "Id",
                keyValue: 10,
                column: "Version",
                value: 1.01m);

            migrationBuilder.UpdateData(
                table: "MockComicPriceFR",
                keyColumn: "Id",
                keyValue: 1,
                column: "Version",
                value: 1.00m);

            migrationBuilder.UpdateData(
                table: "MockComicPriceFR",
                keyColumn: "Id",
                keyValue: 2,
                column: "Version",
                value: 1.00m);

            migrationBuilder.UpdateData(
                table: "MockComicPriceFR",
                keyColumn: "Id",
                keyValue: 3,
                column: "Version",
                value: 1.00m);

            migrationBuilder.UpdateData(
                table: "MockComicPriceFR",
                keyColumn: "Id",
                keyValue: 4,
                column: "Version",
                value: 1.00m);

            migrationBuilder.UpdateData(
                table: "MockComicPriceFR",
                keyColumn: "Id",
                keyValue: 5,
                column: "Version",
                value: 1.00m);

            migrationBuilder.UpdateData(
                table: "MockComicPriceFR",
                keyColumn: "Id",
                keyValue: 6,
                column: "Version",
                value: 1.01m);

            migrationBuilder.UpdateData(
                table: "MockComicPriceFR",
                keyColumn: "Id",
                keyValue: 7,
                column: "Version",
                value: 1.01m);

            migrationBuilder.UpdateData(
                table: "MockComicPriceFR",
                keyColumn: "Id",
                keyValue: 8,
                column: "Version",
                value: 1.01m);

            migrationBuilder.UpdateData(
                table: "MockComicPriceFR",
                keyColumn: "Id",
                keyValue: 9,
                column: "Version",
                value: 1.01m);

            migrationBuilder.UpdateData(
                table: "MockComicPriceFR",
                keyColumn: "Id",
                keyValue: 10,
                column: "Version",
                value: 1.01m);

            migrationBuilder.UpdateData(
                table: "MockGenreDim",
                keyColumn: "GenreId",
                keyValue: 3,
                column: "Genre",
                value: "Esoteric");

            migrationBuilder.UpdateData(
                table: "MockMoviePriceDE",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ProductId", "Version" },
                values: new object[] { 1111, 1.00m });

            migrationBuilder.UpdateData(
                table: "MockMoviePriceDE",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ProductId", "Version" },
                values: new object[] { 1112, 1.00m });

            migrationBuilder.UpdateData(
                table: "MockMoviePriceDE",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ProductId", "Version" },
                values: new object[] { 1113, 1.00m });

            migrationBuilder.UpdateData(
                table: "MockMoviePriceDE",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ProductId", "Version" },
                values: new object[] { 1114, 1.00m });

            migrationBuilder.UpdateData(
                table: "MockMoviePriceDE",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ProductId", "Version" },
                values: new object[] { 1115, 1.00m });

            migrationBuilder.UpdateData(
                table: "MockMoviePriceDE",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ProductId", "Version" },
                values: new object[] { 1111, 1.01m });

            migrationBuilder.UpdateData(
                table: "MockMoviePriceDE",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ProductId", "Version" },
                values: new object[] { 1112, 1.01m });

            migrationBuilder.UpdateData(
                table: "MockMoviePriceDE",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ProductId", "Version" },
                values: new object[] { 1113, 1.01m });

            migrationBuilder.UpdateData(
                table: "MockMoviePriceDE",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ProductId", "Version" },
                values: new object[] { 1114, 1.01m });

            migrationBuilder.UpdateData(
                table: "MockMoviePriceDE",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ProductId", "Version" },
                values: new object[] { 1115, 1.01m });

            migrationBuilder.UpdateData(
                table: "MockMoviePriceFR",
                keyColumn: "Id",
                keyValue: 1,
                column: "Version",
                value: 1.00m);

            migrationBuilder.UpdateData(
                table: "MockMoviePriceFR",
                keyColumn: "Id",
                keyValue: 2,
                column: "Version",
                value: 1.00m);

            migrationBuilder.UpdateData(
                table: "MockMoviePriceFR",
                keyColumn: "Id",
                keyValue: 3,
                column: "Version",
                value: 1.00m);

            migrationBuilder.UpdateData(
                table: "MockMoviePriceFR",
                keyColumn: "Id",
                keyValue: 4,
                column: "Version",
                value: 1.00m);

            migrationBuilder.UpdateData(
                table: "MockMoviePriceFR",
                keyColumn: "Id",
                keyValue: 5,
                column: "Version",
                value: 1.00m);

            migrationBuilder.InsertData(
                table: "MockMoviePriceFR",
                columns: new[] { "Id", "Price", "ProductId", "RatingFR", "Version" },
                values: new object[,]
                {
                    { 6, 2.51m, 1111, 1, 1.01m },
                    { 7, 2.78m, 1112, 1, 1.01m },
                    { 8, 3.55m, 1113, 1, 1.01m },
                    { 9, 8.43m, 1114, 1, 1.01m },
                    { 10, 13.49m, 1115, 1, 1.01m }
                });

            migrationBuilder.UpdateData(
                table: "MockTVPriceDE",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ProductId", "Version" },
                values: new object[] { 10001, 1.00m });

            migrationBuilder.UpdateData(
                table: "MockTVPriceDE",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ProductId", "Version" },
                values: new object[] { 10002, 1.00m });

            migrationBuilder.UpdateData(
                table: "MockTVPriceDE",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ProductId", "Version" },
                values: new object[] { 10003, 1.00m });

            migrationBuilder.UpdateData(
                table: "MockTVPriceDE",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ProductId", "Version" },
                values: new object[] { 10004, 1.00m });

            migrationBuilder.UpdateData(
                table: "MockTVPriceDE",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ProductId", "Version" },
                values: new object[] { 10005, 1.00m });

            migrationBuilder.UpdateData(
                table: "MockTVPriceDE",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ProductId", "Version" },
                values: new object[] { 10001, 1.01m });

            migrationBuilder.UpdateData(
                table: "MockTVPriceDE",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ProductId", "Version" },
                values: new object[] { 10002, 1.01m });

            migrationBuilder.UpdateData(
                table: "MockTVPriceDE",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ProductId", "Version" },
                values: new object[] { 10003, 1.01m });

            migrationBuilder.UpdateData(
                table: "MockTVPriceDE",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ProductId", "Version" },
                values: new object[] { 10004, 1.01m });

            migrationBuilder.UpdateData(
                table: "MockTVPriceDE",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ProductId", "Version" },
                values: new object[] { 10005, 1.01m });

            migrationBuilder.UpdateData(
                table: "MockTVPriceFR",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ProductId", "Version" },
                values: new object[] { 10001, 1.00m });

            migrationBuilder.UpdateData(
                table: "MockTVPriceFR",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ProductId", "Version" },
                values: new object[] { 10002, 1.00m });

            migrationBuilder.UpdateData(
                table: "MockTVPriceFR",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ProductId", "Version" },
                values: new object[] { 10003, 1.00m });

            migrationBuilder.UpdateData(
                table: "MockTVPriceFR",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ProductId", "Version" },
                values: new object[] { 10004, 1.00m });

            migrationBuilder.UpdateData(
                table: "MockTVPriceFR",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ProductId", "Version" },
                values: new object[] { 10005, 1.00m });

            migrationBuilder.UpdateData(
                table: "MockTVPriceFR",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ProductId", "Version" },
                values: new object[] { 10001, 1.01m });

            migrationBuilder.UpdateData(
                table: "MockTVPriceFR",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ProductId", "Version" },
                values: new object[] { 10002, 1.01m });

            migrationBuilder.UpdateData(
                table: "MockTVPriceFR",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ProductId", "Version" },
                values: new object[] { 10003, 1.01m });

            migrationBuilder.UpdateData(
                table: "MockTVPriceFR",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ProductId", "Version" },
                values: new object[] { 10004, 1.01m });

            migrationBuilder.UpdateData(
                table: "MockTVPriceFR",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ProductId", "Version" },
                values: new object[] { 10005, 1.01m });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MockMoviePriceFR",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "MockMoviePriceFR",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "MockMoviePriceFR",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "MockMoviePriceFR",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "MockMoviePriceFR",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.RenameColumn(
                name: "Version",
                table: "MockTVPriceFR",
                newName: "Timestamp");

            migrationBuilder.RenameColumn(
                name: "Version",
                table: "MockTVPriceDE",
                newName: "Timestamp");

            migrationBuilder.RenameColumn(
                name: "Version",
                table: "MockMoviePriceFR",
                newName: "Timestamp");

            migrationBuilder.RenameColumn(
                name: "Version",
                table: "MockMoviePriceDE",
                newName: "Timestamp");

            migrationBuilder.RenameColumn(
                name: "Version",
                table: "MockComicPriceFR",
                newName: "Timestamp");

            migrationBuilder.RenameColumn(
                name: "Version",
                table: "MockComicPriceDE",
                newName: "Timestamp");

            migrationBuilder.RenameColumn(
                name: "Version",
                table: "MockAnimePriceFR",
                newName: "Timestamp");

            migrationBuilder.RenameColumn(
                name: "Version",
                table: "MockAnimePriceDE",
                newName: "Timestamp");

            migrationBuilder.UpdateData(
                table: "MockAnimePriceDE",
                keyColumn: "Id",
                keyValue: 1,
                column: "Timestamp",
                value: new DateOnly(2023, 4, 12));

            migrationBuilder.UpdateData(
                table: "MockAnimePriceDE",
                keyColumn: "Id",
                keyValue: 2,
                column: "Timestamp",
                value: new DateOnly(2023, 4, 12));

            migrationBuilder.UpdateData(
                table: "MockAnimePriceDE",
                keyColumn: "Id",
                keyValue: 3,
                column: "Timestamp",
                value: new DateOnly(2023, 4, 12));

            migrationBuilder.UpdateData(
                table: "MockAnimePriceDE",
                keyColumn: "Id",
                keyValue: 4,
                column: "Timestamp",
                value: new DateOnly(2023, 4, 12));

            migrationBuilder.UpdateData(
                table: "MockAnimePriceDE",
                keyColumn: "Id",
                keyValue: 5,
                column: "Timestamp",
                value: new DateOnly(2023, 4, 12));

            migrationBuilder.UpdateData(
                table: "MockAnimePriceDE",
                keyColumn: "Id",
                keyValue: 6,
                column: "Timestamp",
                value: new DateOnly(2023, 7, 17));

            migrationBuilder.UpdateData(
                table: "MockAnimePriceDE",
                keyColumn: "Id",
                keyValue: 7,
                column: "Timestamp",
                value: new DateOnly(2023, 7, 17));

            migrationBuilder.UpdateData(
                table: "MockAnimePriceDE",
                keyColumn: "Id",
                keyValue: 8,
                column: "Timestamp",
                value: new DateOnly(2023, 7, 17));

            migrationBuilder.UpdateData(
                table: "MockAnimePriceDE",
                keyColumn: "Id",
                keyValue: 9,
                column: "Timestamp",
                value: new DateOnly(2023, 7, 17));

            migrationBuilder.UpdateData(
                table: "MockAnimePriceDE",
                keyColumn: "Id",
                keyValue: 10,
                column: "Timestamp",
                value: new DateOnly(2023, 7, 17));

            migrationBuilder.UpdateData(
                table: "MockAnimePriceFR",
                keyColumn: "Id",
                keyValue: 1,
                column: "Timestamp",
                value: new DateOnly(2023, 4, 12));

            migrationBuilder.UpdateData(
                table: "MockAnimePriceFR",
                keyColumn: "Id",
                keyValue: 2,
                column: "Timestamp",
                value: new DateOnly(2023, 4, 12));

            migrationBuilder.UpdateData(
                table: "MockAnimePriceFR",
                keyColumn: "Id",
                keyValue: 3,
                column: "Timestamp",
                value: new DateOnly(2023, 4, 12));

            migrationBuilder.UpdateData(
                table: "MockAnimePriceFR",
                keyColumn: "Id",
                keyValue: 4,
                column: "Timestamp",
                value: new DateOnly(2023, 4, 12));

            migrationBuilder.UpdateData(
                table: "MockAnimePriceFR",
                keyColumn: "Id",
                keyValue: 5,
                column: "Timestamp",
                value: new DateOnly(2023, 4, 12));

            migrationBuilder.UpdateData(
                table: "MockAnimePriceFR",
                keyColumn: "Id",
                keyValue: 6,
                column: "Timestamp",
                value: new DateOnly(2023, 7, 17));

            migrationBuilder.UpdateData(
                table: "MockAnimePriceFR",
                keyColumn: "Id",
                keyValue: 7,
                column: "Timestamp",
                value: new DateOnly(2023, 7, 17));

            migrationBuilder.UpdateData(
                table: "MockAnimePriceFR",
                keyColumn: "Id",
                keyValue: 8,
                column: "Timestamp",
                value: new DateOnly(2023, 7, 17));

            migrationBuilder.UpdateData(
                table: "MockAnimePriceFR",
                keyColumn: "Id",
                keyValue: 9,
                column: "Timestamp",
                value: new DateOnly(2023, 7, 17));

            migrationBuilder.UpdateData(
                table: "MockAnimePriceFR",
                keyColumn: "Id",
                keyValue: 10,
                column: "Timestamp",
                value: new DateOnly(2023, 7, 17));

            migrationBuilder.UpdateData(
                table: "MockComicPriceDE",
                keyColumn: "Id",
                keyValue: 1,
                column: "Timestamp",
                value: new DateOnly(2023, 4, 12));

            migrationBuilder.UpdateData(
                table: "MockComicPriceDE",
                keyColumn: "Id",
                keyValue: 2,
                column: "Timestamp",
                value: new DateOnly(2023, 4, 12));

            migrationBuilder.UpdateData(
                table: "MockComicPriceDE",
                keyColumn: "Id",
                keyValue: 3,
                column: "Timestamp",
                value: new DateOnly(2023, 4, 12));

            migrationBuilder.UpdateData(
                table: "MockComicPriceDE",
                keyColumn: "Id",
                keyValue: 4,
                column: "Timestamp",
                value: new DateOnly(2023, 4, 12));

            migrationBuilder.UpdateData(
                table: "MockComicPriceDE",
                keyColumn: "Id",
                keyValue: 5,
                column: "Timestamp",
                value: new DateOnly(2023, 4, 12));

            migrationBuilder.UpdateData(
                table: "MockComicPriceDE",
                keyColumn: "Id",
                keyValue: 6,
                column: "Timestamp",
                value: new DateOnly(2023, 7, 17));

            migrationBuilder.UpdateData(
                table: "MockComicPriceDE",
                keyColumn: "Id",
                keyValue: 7,
                column: "Timestamp",
                value: new DateOnly(2023, 7, 17));

            migrationBuilder.UpdateData(
                table: "MockComicPriceDE",
                keyColumn: "Id",
                keyValue: 8,
                column: "Timestamp",
                value: new DateOnly(2023, 7, 17));

            migrationBuilder.UpdateData(
                table: "MockComicPriceDE",
                keyColumn: "Id",
                keyValue: 9,
                column: "Timestamp",
                value: new DateOnly(2023, 7, 17));

            migrationBuilder.UpdateData(
                table: "MockComicPriceDE",
                keyColumn: "Id",
                keyValue: 10,
                column: "Timestamp",
                value: new DateOnly(2023, 7, 17));

            migrationBuilder.UpdateData(
                table: "MockComicPriceFR",
                keyColumn: "Id",
                keyValue: 1,
                column: "Timestamp",
                value: new DateOnly(2023, 4, 12));

            migrationBuilder.UpdateData(
                table: "MockComicPriceFR",
                keyColumn: "Id",
                keyValue: 2,
                column: "Timestamp",
                value: new DateOnly(2023, 4, 12));

            migrationBuilder.UpdateData(
                table: "MockComicPriceFR",
                keyColumn: "Id",
                keyValue: 3,
                column: "Timestamp",
                value: new DateOnly(2023, 4, 12));

            migrationBuilder.UpdateData(
                table: "MockComicPriceFR",
                keyColumn: "Id",
                keyValue: 4,
                column: "Timestamp",
                value: new DateOnly(2023, 4, 12));

            migrationBuilder.UpdateData(
                table: "MockComicPriceFR",
                keyColumn: "Id",
                keyValue: 5,
                column: "Timestamp",
                value: new DateOnly(2023, 4, 12));

            migrationBuilder.UpdateData(
                table: "MockComicPriceFR",
                keyColumn: "Id",
                keyValue: 6,
                column: "Timestamp",
                value: new DateOnly(2023, 7, 17));

            migrationBuilder.UpdateData(
                table: "MockComicPriceFR",
                keyColumn: "Id",
                keyValue: 7,
                column: "Timestamp",
                value: new DateOnly(2023, 7, 17));

            migrationBuilder.UpdateData(
                table: "MockComicPriceFR",
                keyColumn: "Id",
                keyValue: 8,
                column: "Timestamp",
                value: new DateOnly(2023, 7, 17));

            migrationBuilder.UpdateData(
                table: "MockComicPriceFR",
                keyColumn: "Id",
                keyValue: 9,
                column: "Timestamp",
                value: new DateOnly(2023, 7, 17));

            migrationBuilder.UpdateData(
                table: "MockComicPriceFR",
                keyColumn: "Id",
                keyValue: 10,
                column: "Timestamp",
                value: new DateOnly(2023, 7, 17));

            migrationBuilder.UpdateData(
                table: "MockGenreDim",
                keyColumn: "GenreId",
                keyValue: 3,
                column: "Genre",
                value: "Eseteric");

            migrationBuilder.UpdateData(
                table: "MockMoviePriceDE",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ProductId", "Timestamp" },
                values: new object[] { 10000, new DateOnly(2023, 4, 12) });

            migrationBuilder.UpdateData(
                table: "MockMoviePriceDE",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ProductId", "Timestamp" },
                values: new object[] { 10001, new DateOnly(2023, 4, 12) });

            migrationBuilder.UpdateData(
                table: "MockMoviePriceDE",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ProductId", "Timestamp" },
                values: new object[] { 10002, new DateOnly(2023, 4, 12) });

            migrationBuilder.UpdateData(
                table: "MockMoviePriceDE",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ProductId", "Timestamp" },
                values: new object[] { 10003, new DateOnly(2023, 4, 12) });

            migrationBuilder.UpdateData(
                table: "MockMoviePriceDE",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ProductId", "Timestamp" },
                values: new object[] { 10004, new DateOnly(2023, 4, 12) });

            migrationBuilder.UpdateData(
                table: "MockMoviePriceDE",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ProductId", "Timestamp" },
                values: new object[] { 10000, new DateOnly(2023, 7, 17) });

            migrationBuilder.UpdateData(
                table: "MockMoviePriceDE",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ProductId", "Timestamp" },
                values: new object[] { 10001, new DateOnly(2023, 7, 17) });

            migrationBuilder.UpdateData(
                table: "MockMoviePriceDE",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ProductId", "Timestamp" },
                values: new object[] { 10002, new DateOnly(2023, 7, 17) });

            migrationBuilder.UpdateData(
                table: "MockMoviePriceDE",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ProductId", "Timestamp" },
                values: new object[] { 10003, new DateOnly(2023, 7, 17) });

            migrationBuilder.UpdateData(
                table: "MockMoviePriceDE",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ProductId", "Timestamp" },
                values: new object[] { 10004, new DateOnly(2023, 7, 17) });

            migrationBuilder.UpdateData(
                table: "MockMoviePriceFR",
                keyColumn: "Id",
                keyValue: 1,
                column: "Timestamp",
                value: new DateOnly(2023, 4, 12));

            migrationBuilder.UpdateData(
                table: "MockMoviePriceFR",
                keyColumn: "Id",
                keyValue: 2,
                column: "Timestamp",
                value: new DateOnly(2023, 12, 24));

            migrationBuilder.UpdateData(
                table: "MockMoviePriceFR",
                keyColumn: "Id",
                keyValue: 3,
                column: "Timestamp",
                value: new DateOnly(2023, 7, 10));

            migrationBuilder.UpdateData(
                table: "MockMoviePriceFR",
                keyColumn: "Id",
                keyValue: 4,
                column: "Timestamp",
                value: new DateOnly(2023, 5, 15));

            migrationBuilder.UpdateData(
                table: "MockMoviePriceFR",
                keyColumn: "Id",
                keyValue: 5,
                column: "Timestamp",
                value: new DateOnly(2023, 5, 24));

            migrationBuilder.UpdateData(
                table: "MockTVPriceDE",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ProductId", "Timestamp" },
                values: new object[] { 1111, new DateOnly(2023, 4, 12) });

            migrationBuilder.UpdateData(
                table: "MockTVPriceDE",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ProductId", "Timestamp" },
                values: new object[] { 1112, new DateOnly(2023, 4, 12) });

            migrationBuilder.UpdateData(
                table: "MockTVPriceDE",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ProductId", "Timestamp" },
                values: new object[] { 1113, new DateOnly(2023, 4, 12) });

            migrationBuilder.UpdateData(
                table: "MockTVPriceDE",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ProductId", "Timestamp" },
                values: new object[] { 1114, new DateOnly(2023, 4, 12) });

            migrationBuilder.UpdateData(
                table: "MockTVPriceDE",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ProductId", "Timestamp" },
                values: new object[] { 1115, new DateOnly(2023, 4, 12) });

            migrationBuilder.UpdateData(
                table: "MockTVPriceDE",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ProductId", "Timestamp" },
                values: new object[] { 1111, new DateOnly(2023, 7, 17) });

            migrationBuilder.UpdateData(
                table: "MockTVPriceDE",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ProductId", "Timestamp" },
                values: new object[] { 1112, new DateOnly(2023, 7, 17) });

            migrationBuilder.UpdateData(
                table: "MockTVPriceDE",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ProductId", "Timestamp" },
                values: new object[] { 1113, new DateOnly(2023, 7, 17) });

            migrationBuilder.UpdateData(
                table: "MockTVPriceDE",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ProductId", "Timestamp" },
                values: new object[] { 1114, new DateOnly(2023, 7, 17) });

            migrationBuilder.UpdateData(
                table: "MockTVPriceDE",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ProductId", "Timestamp" },
                values: new object[] { 1115, new DateOnly(2023, 7, 17) });

            migrationBuilder.UpdateData(
                table: "MockTVPriceFR",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ProductId", "Timestamp" },
                values: new object[] { 1111, new DateOnly(2023, 4, 12) });

            migrationBuilder.UpdateData(
                table: "MockTVPriceFR",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ProductId", "Timestamp" },
                values: new object[] { 1112, new DateOnly(2023, 4, 12) });

            migrationBuilder.UpdateData(
                table: "MockTVPriceFR",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ProductId", "Timestamp" },
                values: new object[] { 1113, new DateOnly(2023, 4, 12) });

            migrationBuilder.UpdateData(
                table: "MockTVPriceFR",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ProductId", "Timestamp" },
                values: new object[] { 1114, new DateOnly(2023, 4, 12) });

            migrationBuilder.UpdateData(
                table: "MockTVPriceFR",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ProductId", "Timestamp" },
                values: new object[] { 1115, new DateOnly(2023, 4, 12) });

            migrationBuilder.UpdateData(
                table: "MockTVPriceFR",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ProductId", "Timestamp" },
                values: new object[] { 1111, new DateOnly(2023, 7, 17) });

            migrationBuilder.UpdateData(
                table: "MockTVPriceFR",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ProductId", "Timestamp" },
                values: new object[] { 1112, new DateOnly(2023, 7, 17) });

            migrationBuilder.UpdateData(
                table: "MockTVPriceFR",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ProductId", "Timestamp" },
                values: new object[] { 1113, new DateOnly(2023, 7, 17) });

            migrationBuilder.UpdateData(
                table: "MockTVPriceFR",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ProductId", "Timestamp" },
                values: new object[] { 1114, new DateOnly(2023, 7, 17) });

            migrationBuilder.UpdateData(
                table: "MockTVPriceFR",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ProductId", "Timestamp" },
                values: new object[] { 1115, new DateOnly(2023, 7, 17) });
        }
    }
}
