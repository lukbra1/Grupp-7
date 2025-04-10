using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hattmakarens_system.Migrations
{
    /// <inheritdoc />
    public partial class nytt1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orderrader_Ordrar_OrderId",
                table: "Orderrader");

            migrationBuilder.AlterColumn<int>(
                name: "FraktId",
                table: "Ordrar",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Ordrar",
                keyColumn: "OrderId",
                keyValue: 1,
                column: "FraktId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Ordrar",
                keyColumn: "OrderId",
                keyValue: 2,
                column: "FraktId",
                value: null);

            migrationBuilder.AddForeignKey(
                name: "FK_Orderrader_Ordrar_OrderId",
                table: "Orderrader",
                column: "OrderId",
                principalTable: "Ordrar",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orderrader_Ordrar_OrderId",
                table: "Orderrader");

            migrationBuilder.AlterColumn<int>(
                name: "FraktId",
                table: "Ordrar",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Ordrar",
                keyColumn: "OrderId",
                keyValue: 1,
                column: "FraktId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Ordrar",
                keyColumn: "OrderId",
                keyValue: 2,
                column: "FraktId",
                value: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Orderrader_Ordrar_OrderId",
                table: "Orderrader",
                column: "OrderId",
                principalTable: "Ordrar",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
