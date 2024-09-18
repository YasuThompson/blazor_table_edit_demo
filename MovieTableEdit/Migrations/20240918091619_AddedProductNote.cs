using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieTableEdit.Migrations
{
    /// <inheritdoc />
    public partial class AddedProductNote : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Note",
                table: "MockProductDim",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "MockProductDim",
                keyColumn: "ProductId",
                keyValue: 1111,
                column: "Note",
                value: "One of only real wild west films");

            migrationBuilder.UpdateData(
                table: "MockProductDim",
                keyColumn: "ProductId",
                keyValue: 1112,
                column: "Note",
                value: "");

            migrationBuilder.UpdateData(
                table: "MockProductDim",
                keyColumn: "ProductId",
                keyValue: 1113,
                column: "Note",
                value: "Greatest American satire");

            migrationBuilder.UpdateData(
                table: "MockProductDim",
                keyColumn: "ProductId",
                keyValue: 1114,
                column: "Note",
                value: "");

            migrationBuilder.UpdateData(
                table: "MockProductDim",
                keyColumn: "ProductId",
                keyValue: 1115,
                column: "Note",
                value: "");

            migrationBuilder.UpdateData(
                table: "MockProductDim",
                keyColumn: "ProductId",
                keyValue: 2222,
                column: "Note",
                value: "");

            migrationBuilder.UpdateData(
                table: "MockProductDim",
                keyColumn: "ProductId",
                keyValue: 2223,
                column: "Note",
                value: "");

            migrationBuilder.UpdateData(
                table: "MockProductDim",
                keyColumn: "ProductId",
                keyValue: 2224,
                column: "Note",
                value: "Every Turkish woman likes this");

            migrationBuilder.UpdateData(
                table: "MockProductDim",
                keyColumn: "ProductId",
                keyValue: 3333,
                column: "Note",
                value: "");

            migrationBuilder.UpdateData(
                table: "MockProductDim",
                keyColumn: "ProductId",
                keyValue: 3334,
                column: "Note",
                value: "");

            migrationBuilder.UpdateData(
                table: "MockProductDim",
                keyColumn: "ProductId",
                keyValue: 3335,
                column: "Note",
                value: "The best French lesbian film");

            migrationBuilder.UpdateData(
                table: "MockProductDim",
                keyColumn: "ProductId",
                keyValue: 4444,
                column: "Note",
                value: "My favorite Almodovar film");

            migrationBuilder.UpdateData(
                table: "MockProductDim",
                keyColumn: "ProductId",
                keyValue: 4445,
                column: "Note",
                value: "Secretly criticizing Franco regime");

            migrationBuilder.UpdateData(
                table: "MockProductDim",
                keyColumn: "ProductId",
                keyValue: 4446,
                column: "Note",
                value: "");

            migrationBuilder.UpdateData(
                table: "MockProductDim",
                keyColumn: "ProductId",
                keyValue: 5555,
                column: "Note",
                value: "");

            migrationBuilder.UpdateData(
                table: "MockProductDim",
                keyColumn: "ProductId",
                keyValue: 5556,
                column: "Note",
                value: "");

            migrationBuilder.UpdateData(
                table: "MockProductDim",
                keyColumn: "ProductId",
                keyValue: 6666,
                column: "Note",
                value: "A little more positive version of La Strada");

            migrationBuilder.UpdateData(
                table: "MockProductDim",
                keyColumn: "ProductId",
                keyValue: 6667,
                column: "Note",
                value: "");

            migrationBuilder.UpdateData(
                table: "MockProductDim",
                keyColumn: "ProductId",
                keyValue: 6668,
                column: "Note",
                value: "");

            migrationBuilder.UpdateData(
                table: "MockProductDim",
                keyColumn: "ProductId",
                keyValue: 6669,
                column: "Note",
                value: "");

            migrationBuilder.UpdateData(
                table: "MockProductDim",
                keyColumn: "ProductId",
                keyValue: 7777,
                column: "Note",
                value: "The best outside-Hollywood movie according to Empire Magazine");

            migrationBuilder.UpdateData(
                table: "MockProductDim",
                keyColumn: "ProductId",
                keyValue: 7778,
                column: "Note",
                value: "");

            migrationBuilder.UpdateData(
                table: "MockProductDim",
                keyColumn: "ProductId",
                keyValue: 7779,
                column: "Note",
                value: "");

            migrationBuilder.UpdateData(
                table: "MockProductDim",
                keyColumn: "ProductId",
                keyValue: 7780,
                column: "Note",
                value: "");

            migrationBuilder.UpdateData(
                table: "MockProductDim",
                keyColumn: "ProductId",
                keyValue: 7781,
                column: "Note",
                value: "");

            migrationBuilder.UpdateData(
                table: "MockProductDim",
                keyColumn: "ProductId",
                keyValue: 7782,
                column: "Note",
                value: "");

            migrationBuilder.UpdateData(
                table: "MockProductDim",
                keyColumn: "ProductId",
                keyValue: 10000,
                column: "Note",
                value: "");

            migrationBuilder.UpdateData(
                table: "MockProductDim",
                keyColumn: "ProductId",
                keyValue: 10001,
                column: "Note",
                value: "");

            migrationBuilder.UpdateData(
                table: "MockProductDim",
                keyColumn: "ProductId",
                keyValue: 10002,
                column: "Note",
                value: "");

            migrationBuilder.UpdateData(
                table: "MockProductDim",
                keyColumn: "ProductId",
                keyValue: 10003,
                column: "Note",
                value: "My favorite TV show");

            migrationBuilder.UpdateData(
                table: "MockProductDim",
                keyColumn: "ProductId",
                keyValue: 10004,
                column: "Note",
                value: "Ingmar Bergman temporarily retired after this");

            migrationBuilder.UpdateData(
                table: "MockProductDim",
                keyColumn: "ProductId",
                keyValue: 10005,
                column: "Note",
                value: "");

            migrationBuilder.UpdateData(
                table: "MockProductDim",
                keyColumn: "ProductId",
                keyValue: 20000,
                column: "Note",
                value: "");

            migrationBuilder.UpdateData(
                table: "MockProductDim",
                keyColumn: "ProductId",
                keyValue: 20001,
                columns: new[] { "Note", "Title" },
                values: new object[] { "My sunshine", "JoJo's Bizarre Adventure Stardust Crusaders" });

            migrationBuilder.UpdateData(
                table: "MockProductDim",
                keyColumn: "ProductId",
                keyValue: 20002,
                columns: new[] { "Note", "Title" },
                values: new object[] { "My sunshine", "JoJo's Bizarre Adventure Diamond Is Unbreakable" });

            migrationBuilder.UpdateData(
                table: "MockProductDim",
                keyColumn: "ProductId",
                keyValue: 20003,
                columns: new[] { "Note", "Title" },
                values: new object[] { "My sunshine", "JoJo's Bizarre Adventure Golden Wind" });

            migrationBuilder.UpdateData(
                table: "MockProductDim",
                keyColumn: "ProductId",
                keyValue: 20004,
                columns: new[] { "Note", "Title" },
                values: new object[] { "My sunshine", "JoJo's Bizarre Adventure Stone Ocean" });

            migrationBuilder.UpdateData(
                table: "MockProductDim",
                keyColumn: "ProductId",
                keyValue: 30000,
                column: "Note",
                value: "Released every Wednesday at 5 pm in German time");

            migrationBuilder.UpdateData(
                table: "MockProductDim",
                keyColumn: "ProductId",
                keyValue: 30001,
                column: "Note",
                value: "Also Anime version being released in 2024 September");

            migrationBuilder.UpdateData(
                table: "MockProductDim",
                keyColumn: "ProductId",
                keyValue: 30002,
                column: "Note",
                value: "");

            migrationBuilder.UpdateData(
                table: "MockProductDim",
                keyColumn: "ProductId",
                keyValue: 30003,
                column: "Note",
                value: "Largely influenced Dark Soul series");

            migrationBuilder.UpdateData(
                table: "MockProductDim",
                keyColumn: "ProductId",
                keyValue: 30004,
                column: "Note",
                value: "Snobish people's cliche favorite");

            migrationBuilder.UpdateData(
                table: "MockProductDim",
                keyColumn: "ProductId",
                keyValue: 30005,
                column: "Note",
                value: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Note",
                table: "MockProductDim");

            migrationBuilder.UpdateData(
                table: "MockProductDim",
                keyColumn: "ProductId",
                keyValue: 20001,
                column: "Title",
                value: "JoJo's Bizarre Adventure Stardust Crusaders\r\n");

            migrationBuilder.UpdateData(
                table: "MockProductDim",
                keyColumn: "ProductId",
                keyValue: 20002,
                column: "Title",
                value: "JoJo's Bizarre Adventure Diamond Is Unbreakable\r\n");

            migrationBuilder.UpdateData(
                table: "MockProductDim",
                keyColumn: "ProductId",
                keyValue: 20003,
                column: "Title",
                value: "JoJo's Bizarre Adventure Golden Wind\r\n");

            migrationBuilder.UpdateData(
                table: "MockProductDim",
                keyColumn: "ProductId",
                keyValue: 20004,
                column: "Title",
                value: "JoJo's Bizarre Adventure Stone Ocean\r\n");
        }
    }
}
