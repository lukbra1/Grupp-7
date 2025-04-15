using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Hattmakarens_system.Migrations
{
    /// <inheritdoc />
    public partial class Max20 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Kostnad",
                table: "Orderrader",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Material",
                keyColumn: "MaterialId",
                keyValue: 1,
                columns: new[] { "Beskrivning", "Enhet", "Namn" },
                values: new object[] { "Mjukt material.", "Kvm", "Snuttefilt" });

            migrationBuilder.InsertData(
                table: "Material",
                columns: new[] { "MaterialId", "Beskrivning", "Enhet", "Farg", "Namn", "PrisPerEnhet" },
                values: new object[,]
                {
                    { 2, "Färgat Kalv Läder.", "Kvm", "Svart", "Läder", 325m },
                    { 3, "Fjädrar från den Australiensiska strudsen som endast födar på  japanska böngroddar.", "st", "Vit", "Struds Fjäder", 45m },
                    { 4, "Tråd producerad av lejonman utav högsta kvalité direkt från Arkenzoo.", "g", "Sunsetred", "Lejonman", 15m },
                    { 5, "Saphirer från mallorcas östra bergras.", "karat", "Blå", "Saphir", 9000m },
                    { 6, "Pläd ifrån vildfångad zebra i östra Zimbabwe.", "m", "Svart/Vit-mönstrad", "Zebrapläd", 750m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Material",
                keyColumn: "MaterialId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Material",
                keyColumn: "MaterialId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Material",
                keyColumn: "MaterialId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Material",
                keyColumn: "MaterialId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Material",
                keyColumn: "MaterialId",
                keyValue: 6);

            migrationBuilder.DropColumn(
                name: "Kostnad",
                table: "Orderrader");

            migrationBuilder.UpdateData(
                table: "Material",
                keyColumn: "MaterialId",
                keyValue: 1,
                columns: new[] { "Beskrivning", "Enhet", "Namn" },
                values: new object[] { "Mjukt material", "m", "Filt" });
        }
    }
}
