using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hattmakarens_system.Migrations
{
    /// <inheritdoc />
    public partial class fraktfix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Adress",
                table: "Fraktsedlar",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Avsändare",
                table: "Fraktsedlar",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Beskrivning",
                table: "Fraktsedlar",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Mottagare",
                table: "Fraktsedlar",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Fraktsedlar",
                keyColumn: "FraktSedelId",
                keyValue: 1,
                columns: new[] { "Adress", "Avsändare", "Beskrivning", "Mottagare" },
                values: new object[] { "Gatan 1", "Otto AB", "Hatt", "Bob" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Adress",
                table: "Fraktsedlar");

            migrationBuilder.DropColumn(
                name: "Avsändare",
                table: "Fraktsedlar");

            migrationBuilder.DropColumn(
                name: "Beskrivning",
                table: "Fraktsedlar");

            migrationBuilder.DropColumn(
                name: "Mottagare",
                table: "Fraktsedlar");
        }
    }
}
