using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Hattmakarens_system.Migrations
{
    /// <inheritdoc />
    public partial class seeddata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Modeller",
                columns: new[] { "ModellId", "Beskrivning", "Namn", "Pris", "Tillganglig" },
                values: new object[,]
                {
                    { 2, "En doktormössa", "Doktormössa", 400m, true },
                    { 3, "En oktoberhatt", "Oktoberhatt", 1000m, true },
                    { 4, "En fez hatt", "Fez hatt", 300m, true },
                    { 5, "En Sherlock hatt", "Sherlock hatt", 1200m, true }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Modeller",
                keyColumn: "ModellId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Modeller",
                keyColumn: "ModellId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Modeller",
                keyColumn: "ModellId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Modeller",
                keyColumn: "ModellId",
                keyValue: 5);
        }
    }
}
