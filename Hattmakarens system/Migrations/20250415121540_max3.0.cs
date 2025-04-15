using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hattmakarens_system.Migrations
{
    /// <inheritdoc />
    public partial class max30 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Kostnad",
                table: "Orderrader",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AntalMaterial",
                table: "MaterialOrderrader",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "MaterialOrderrader",
                keyColumns: new[] { "MaterialId", "OrderRadId" },
                keyValues: new object[] { 1, 1 },
                column: "AntalMaterial",
                value: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AntalMaterial",
                table: "MaterialOrderrader");

            migrationBuilder.AlterColumn<int>(
                name: "Kostnad",
                table: "Orderrader",
                type: "int",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);
        }
    }
}
