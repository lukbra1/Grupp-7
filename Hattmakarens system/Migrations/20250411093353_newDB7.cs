using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Hattmakarens_system.Migrations
{
    /// <inheritdoc />
    public partial class newDB7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Hattmodeller",
                columns: new[] { "HattModellId", "Beskrivning", "Namn", "Pris", "Tillgangliga" },
                values: new object[,]
                {
                    { 3, "En studentmössa", "Studentmössa", 800m, true },
                    { 4, "En doktormössa", "Doktormössa", 400m, true },
                    { 5, "En oktoberhatt", "Oktoberhatt", 1000m, true },
                    { 6, "En fez hatt", "Fez hatt", 300m, true },
                    { 7, "En Sherlock hatt", "Sherlock hatt", 1200m, true }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Hattmodeller",
                keyColumn: "HattModellId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Hattmodeller",
                keyColumn: "HattModellId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Hattmodeller",
                keyColumn: "HattModellId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Hattmodeller",
                keyColumn: "HattModellId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Hattmodeller",
                keyColumn: "HattModellId",
                keyValue: 7);
        }
    }
}
