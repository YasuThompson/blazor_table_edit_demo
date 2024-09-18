using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieTableEdit.Migrations
{
    /// <inheritdoc />
    public partial class AddedGermanTitles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Note",
                table: "MockProductDim",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.UpdateData(
                table: "MockProductDim",
                keyColumn: "ProductId",
                keyValue: 1111,
                columns: new[] { "Note", "TitleDE" },
                values: new object[] { "One of the only and real wild west films", "Panik am roten Fluß" });

            migrationBuilder.UpdateData(
                table: "MockProductDim",
                keyColumn: "ProductId",
                keyValue: 1112,
                column: "TitleDE",
                value: "Die letzte Vorstellung");

            migrationBuilder.UpdateData(
                table: "MockProductDim",
                keyColumn: "ProductId",
                keyValue: 1113,
                column: "TitleDE",
                value: "Network");

            migrationBuilder.UpdateData(
                table: "MockProductDim",
                keyColumn: "ProductId",
                keyValue: 1114,
                column: "TitleDE",
                value: "Traffic – Macht des Kartells");

            migrationBuilder.UpdateData(
                table: "MockProductDim",
                keyColumn: "ProductId",
                keyValue: 1115,
                column: "TitleDE",
                value: "The Florida Project");

            migrationBuilder.UpdateData(
                table: "MockProductDim",
                keyColumn: "ProductId",
                keyValue: 2222,
                column: "Note",
                value: "One of Rainer Werner Fassbinder's BRD Trilogy, besides Lola and Veronika Voss.");

            migrationBuilder.UpdateData(
                table: "MockProductDim",
                keyColumn: "ProductId",
                keyValue: 3333,
                column: "TitleDE",
                value: "Kinder des Olymp");

            migrationBuilder.UpdateData(
                table: "MockProductDim",
                keyColumn: "ProductId",
                keyValue: 3334,
                column: "TitleDE",
                value: "Lohn der Angst");

            migrationBuilder.UpdateData(
                table: "MockProductDim",
                keyColumn: "ProductId",
                keyValue: 3335,
                column: "TitleDE",
                value: "Porträt einer jungen Frau in Flammen");

            migrationBuilder.UpdateData(
                table: "MockProductDim",
                keyColumn: "ProductId",
                keyValue: 4444,
                column: "TitleDE",
                value: "Sprich mit ihr");

            migrationBuilder.UpdateData(
                table: "MockProductDim",
                keyColumn: "ProductId",
                keyValue: 4445,
                columns: new[] { "Note", "TitleDE" },
                values: new object[] { "Secretly criticizing Franco regime with metaphors in in the time. ", "Der Geist des Bienenstocks" });

            migrationBuilder.UpdateData(
                table: "MockProductDim",
                keyColumn: "ProductId",
                keyValue: 4446,
                column: "TitleDE",
                value: "Pans Labyrinth");

            migrationBuilder.UpdateData(
                table: "MockProductDim",
                keyColumn: "ProductId",
                keyValue: 5555,
                column: "TitleDE",
                value: "Die roten Schuhe");

            migrationBuilder.UpdateData(
                table: "MockProductDim",
                keyColumn: "ProductId",
                keyValue: 5556,
                column: "TitleDE",
                value: "Hot Fuzz – Zwei abgewichste Profis");

            migrationBuilder.UpdateData(
                table: "MockProductDim",
                keyColumn: "ProductId",
                keyValue: 6666,
                columns: new[] { "Note", "TitleDE" },
                values: new object[] { "A little more positive version of La Strada. ", "Die Nächte der Cabiria" });

            migrationBuilder.UpdateData(
                table: "MockProductDim",
                keyColumn: "ProductId",
                keyValue: 6667,
                column: "TitleDE",
                value: "Der große Irrtum");

            migrationBuilder.UpdateData(
                table: "MockProductDim",
                keyColumn: "ProductId",
                keyValue: 6668,
                column: "TitleDE",
                value: "Gomorrha – Reise in das Reich der Camorra");

            migrationBuilder.UpdateData(
                table: "MockProductDim",
                keyColumn: "ProductId",
                keyValue: 6669,
                column: "TitleDE",
                value: "Il Divo");

            migrationBuilder.UpdateData(
                table: "MockProductDim",
                keyColumn: "ProductId",
                keyValue: 7777,
                columns: new[] { "Note", "TitleDE" },
                values: new object[] { "The best outside-Hollywood movie according to Empire Magazine. Japanese cinema was outstanding in terms of controling water in the time. ", "Die sieben Samurai" });

            migrationBuilder.UpdateData(
                table: "MockProductDim",
                keyColumn: "ProductId",
                keyValue: 7778,
                column: "TitleDE",
                value: "Sansho Dayu – Ein Leben ohne Freiheit");

            migrationBuilder.UpdateData(
                table: "MockProductDim",
                keyColumn: "ProductId",
                keyValue: 7779,
                column: "TitleDE",
                value: "Die Frau in den Dünen");

            migrationBuilder.UpdateData(
                table: "MockProductDim",
                keyColumn: "ProductId",
                keyValue: 7780,
                column: "TitleDE",
                value: "Harakiri");

            migrationBuilder.UpdateData(
                table: "MockProductDim",
                keyColumn: "ProductId",
                keyValue: 7781,
                column: "TitleDE",
                value: "Furyo – Merry Christmas, Mr. Lawrence");

            migrationBuilder.UpdateData(
                table: "MockProductDim",
                keyColumn: "ProductId",
                keyValue: 10000,
                column: "TitleDE",
                value: "Monty Python’s Flying Circus");

            migrationBuilder.UpdateData(
                table: "MockProductDim",
                keyColumn: "ProductId",
                keyValue: 10001,
                column: "TitleDE",
                value: "M*A*S*H");

            migrationBuilder.UpdateData(
                table: "MockProductDim",
                keyColumn: "ProductId",
                keyValue: 10002,
                column: "TitleDE",
                value: "Die Sopranos");

            migrationBuilder.UpdateData(
                table: "MockProductDim",
                keyColumn: "ProductId",
                keyValue: 10004,
                column: "TitleDE",
                value: "Fanny und Alexander");

            migrationBuilder.UpdateData(
                table: "MockProductDim",
                keyColumn: "ProductId",
                keyValue: 10005,
                column: "TitleDE",
                value: "Dekalog");

            migrationBuilder.UpdateData(
                table: "MockProductDim",
                keyColumn: "ProductId",
                keyValue: 20000,
                column: "TitleDE",
                value: "Attack on Titan");

            migrationBuilder.UpdateData(
                table: "MockProductDim",
                keyColumn: "ProductId",
                keyValue: 30001,
                column: "TitleDE",
                value: "Ketzer – Tödliches Wissen über die Bewegungen der Erde");

            migrationBuilder.UpdateData(
                table: "MockProductDim",
                keyColumn: "ProductId",
                keyValue: 30004,
                column: "TitleDE",
                value: "Persepolis");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Note",
                table: "MockProductDim",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "MockProductDim",
                keyColumn: "ProductId",
                keyValue: 1111,
                columns: new[] { "Note", "TitleDE" },
                values: new object[] { "One of only real wild west films", "" });

            migrationBuilder.UpdateData(
                table: "MockProductDim",
                keyColumn: "ProductId",
                keyValue: 1112,
                column: "TitleDE",
                value: "");

            migrationBuilder.UpdateData(
                table: "MockProductDim",
                keyColumn: "ProductId",
                keyValue: 1113,
                column: "TitleDE",
                value: "");

            migrationBuilder.UpdateData(
                table: "MockProductDim",
                keyColumn: "ProductId",
                keyValue: 1114,
                column: "TitleDE",
                value: "");

            migrationBuilder.UpdateData(
                table: "MockProductDim",
                keyColumn: "ProductId",
                keyValue: 1115,
                column: "TitleDE",
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
                keyValue: 3333,
                column: "TitleDE",
                value: "");

            migrationBuilder.UpdateData(
                table: "MockProductDim",
                keyColumn: "ProductId",
                keyValue: 3334,
                column: "TitleDE",
                value: "");

            migrationBuilder.UpdateData(
                table: "MockProductDim",
                keyColumn: "ProductId",
                keyValue: 3335,
                column: "TitleDE",
                value: "");

            migrationBuilder.UpdateData(
                table: "MockProductDim",
                keyColumn: "ProductId",
                keyValue: 4444,
                column: "TitleDE",
                value: "");

            migrationBuilder.UpdateData(
                table: "MockProductDim",
                keyColumn: "ProductId",
                keyValue: 4445,
                columns: new[] { "Note", "TitleDE" },
                values: new object[] { "Secretly criticizing Franco regime", "" });

            migrationBuilder.UpdateData(
                table: "MockProductDim",
                keyColumn: "ProductId",
                keyValue: 4446,
                column: "TitleDE",
                value: "");

            migrationBuilder.UpdateData(
                table: "MockProductDim",
                keyColumn: "ProductId",
                keyValue: 5555,
                column: "TitleDE",
                value: "");

            migrationBuilder.UpdateData(
                table: "MockProductDim",
                keyColumn: "ProductId",
                keyValue: 5556,
                column: "TitleDE",
                value: "");

            migrationBuilder.UpdateData(
                table: "MockProductDim",
                keyColumn: "ProductId",
                keyValue: 6666,
                columns: new[] { "Note", "TitleDE" },
                values: new object[] { "A little more positive version of La Strada", "" });

            migrationBuilder.UpdateData(
                table: "MockProductDim",
                keyColumn: "ProductId",
                keyValue: 6667,
                column: "TitleDE",
                value: "");

            migrationBuilder.UpdateData(
                table: "MockProductDim",
                keyColumn: "ProductId",
                keyValue: 6668,
                column: "TitleDE",
                value: "");

            migrationBuilder.UpdateData(
                table: "MockProductDim",
                keyColumn: "ProductId",
                keyValue: 6669,
                column: "TitleDE",
                value: "");

            migrationBuilder.UpdateData(
                table: "MockProductDim",
                keyColumn: "ProductId",
                keyValue: 7777,
                columns: new[] { "Note", "TitleDE" },
                values: new object[] { "The best outside-Hollywood movie according to Empire Magazine", "" });

            migrationBuilder.UpdateData(
                table: "MockProductDim",
                keyColumn: "ProductId",
                keyValue: 7778,
                column: "TitleDE",
                value: "");

            migrationBuilder.UpdateData(
                table: "MockProductDim",
                keyColumn: "ProductId",
                keyValue: 7779,
                column: "TitleDE",
                value: "");

            migrationBuilder.UpdateData(
                table: "MockProductDim",
                keyColumn: "ProductId",
                keyValue: 7780,
                column: "TitleDE",
                value: "");

            migrationBuilder.UpdateData(
                table: "MockProductDim",
                keyColumn: "ProductId",
                keyValue: 7781,
                column: "TitleDE",
                value: "");

            migrationBuilder.UpdateData(
                table: "MockProductDim",
                keyColumn: "ProductId",
                keyValue: 10000,
                column: "TitleDE",
                value: "");

            migrationBuilder.UpdateData(
                table: "MockProductDim",
                keyColumn: "ProductId",
                keyValue: 10001,
                column: "TitleDE",
                value: "");

            migrationBuilder.UpdateData(
                table: "MockProductDim",
                keyColumn: "ProductId",
                keyValue: 10002,
                column: "TitleDE",
                value: "");

            migrationBuilder.UpdateData(
                table: "MockProductDim",
                keyColumn: "ProductId",
                keyValue: 10004,
                column: "TitleDE",
                value: "");

            migrationBuilder.UpdateData(
                table: "MockProductDim",
                keyColumn: "ProductId",
                keyValue: 10005,
                column: "TitleDE",
                value: "");

            migrationBuilder.UpdateData(
                table: "MockProductDim",
                keyColumn: "ProductId",
                keyValue: 20000,
                column: "TitleDE",
                value: "");

            migrationBuilder.UpdateData(
                table: "MockProductDim",
                keyColumn: "ProductId",
                keyValue: 30001,
                column: "TitleDE",
                value: "");

            migrationBuilder.UpdateData(
                table: "MockProductDim",
                keyColumn: "ProductId",
                keyValue: 30004,
                column: "TitleDE",
                value: "");
        }
    }
}
