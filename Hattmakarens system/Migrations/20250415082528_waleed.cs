using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hattmakarens_system.Migrations
{
    /// <inheritdoc />
    public partial class waleed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Bestallt",
                table: "MaterialOrderrader",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "MaterialOrderrader",
                keyColumns: new[] { "MaterialId", "OrderRadId" },
                keyValues: new object[] { 1, 1 },
                column: "Bestallt",
                value: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Bestallt",
                table: "MaterialOrderrader");
        }
    }
}
