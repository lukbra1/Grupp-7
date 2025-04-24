using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Hattmakarens_system.Migrations
{
    /// <inheritdoc />
    public partial class Maxsju : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Material",
                keyColumn: "MaterialId",
                keyValue: 6,
                column: "Farg",
                value: "Lila");

            migrationBuilder.UpdateData(
                table: "Material",
                keyColumn: "MaterialId",
                keyValue: 7,
                column: "Farg",
                value: "Svart");

            migrationBuilder.InsertData(
                table: "Material",
                columns: new[] { "MaterialId", "Beskrivning", "Enhet", "Farg", "Namn", "PrisPerEnhet" },
                values: new object[,]
                {
                    { 17, "Bomull är ett mjukt, lätt och andningsbart material som är enkelt att arbeta med. Det används ofta för att tillverka tyghattar, som till exempel kepsar eller basebollmössor.", "Kvdm", "Vit", "Bomull", 0m },
                    { 18, "Linne är ett lätt och luftigt material som passar bra för sommarhattar, eftersom det är andningsbart och absorberar fukt.", "Kvdm", "Kräm vit", "Linne", 0m },
                    { 19, "Ull är ett varmt och isolerande material som passar bra för höst- och vinterhattar, som till exempel mössor och hattar med öronlappar.", "Kvdm", "Svart/Vit-mönstrad", "Ull", 0m },
                    { 20, "Silke är ett mjukt och glansigt material som passar bra för eleganta hattar, som till exempel brudhattar eller aftonhattar.", "Kvdm", "Silver", "Silke", 0m },
                    { 21, "Satin är ett mjukt och glansigt material som passar bra för dekorativa detaljer på hattar, som till exempel band eller blommor.", "Kvdm", "Beige", "Satin", 0m },
                    { 22, "Tweed är ett tjockt och varmt material som passar bra för höst- och vinterhattar.", "Kvdm", "Grön", "Tweed", 0m },
                    { 23, ": Polyester är ett tåligt och lätt material som passar bra för sportiga hattar, som till exempel kepsar eller solhattar.", "Kvdm", "Vit", "Polyester", 0m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Material",
                keyColumn: "MaterialId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Material",
                keyColumn: "MaterialId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Material",
                keyColumn: "MaterialId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Material",
                keyColumn: "MaterialId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Material",
                keyColumn: "MaterialId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Material",
                keyColumn: "MaterialId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Material",
                keyColumn: "MaterialId",
                keyValue: 23);

            migrationBuilder.UpdateData(
                table: "Material",
                keyColumn: "MaterialId",
                keyValue: 6,
                column: "Farg",
                value: "Svart/Vit-mönstrad");

            migrationBuilder.UpdateData(
                table: "Material",
                keyColumn: "MaterialId",
                keyValue: 7,
                column: "Farg",
                value: "Svart/Vit-mönstrad");
        }
    }
}
