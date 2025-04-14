using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hattmakarens_system.Migrations
{
    /// <inheritdoc />
    public partial class max : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Dekoration",
                table: "Orderrader");

            migrationBuilder.DropColumn(
                name: "ExtraMaterial",
                table: "Orderrader");

            migrationBuilder.DropColumn(
                name: "Farg",
                table: "Orderrader");

            migrationBuilder.DropColumn(
                name: "Fjader",
                table: "Orderrader");

            migrationBuilder.DropColumn(
                name: "Modell",
                table: "Orderrader");

            migrationBuilder.DropColumn(
                name: "Text",
                table: "Orderrader");

            migrationBuilder.RenameColumn(
                name: "Tyg",
                table: "Orderrader",
                newName: "Referensbild");

            migrationBuilder.AlterColumn<int>(
                name: "Storlek",
                table: "Orderrader",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Orderrader",
                keyColumn: "OrderRadId",
                keyValue: 1,
                column: "Storlek",
                value: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Referensbild",
                table: "Orderrader",
                newName: "Tyg");

            migrationBuilder.AlterColumn<string>(
                name: "Storlek",
                table: "Orderrader",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Dekoration",
                table: "Orderrader",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ExtraMaterial",
                table: "Orderrader",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Farg",
                table: "Orderrader",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Fjader",
                table: "Orderrader",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Modell",
                table: "Orderrader",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Text",
                table: "Orderrader",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
