using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hattmakarens_system.Migrations
{
    /// <inheritdoc />
    public partial class nytt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Anpassningar_Ordrar_OrderRadId",
                table: "Anpassningar");

            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "Orderrader",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Orderrader",
                keyColumn: "OrderRadId",
                keyValue: 1,
                column: "OrderId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Orderrader",
                keyColumn: "OrderRadId",
                keyValue: 2,
                column: "OrderId",
                value: 1);

            migrationBuilder.CreateIndex(
                name: "IX_Orderrader_OrderId",
                table: "Orderrader",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Anpassningar_Orderrader_OrderRadId",
                table: "Anpassningar",
                column: "OrderRadId",
                principalTable: "Orderrader",
                principalColumn: "OrderRadId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orderrader_Ordrar_OrderId",
                table: "Orderrader",
                column: "OrderId",
                principalTable: "Ordrar",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Anpassningar_Orderrader_OrderRadId",
                table: "Anpassningar");

            migrationBuilder.DropForeignKey(
                name: "FK_Orderrader_Ordrar_OrderId",
                table: "Orderrader");

            migrationBuilder.DropIndex(
                name: "IX_Orderrader_OrderId",
                table: "Orderrader");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "Orderrader");

            migrationBuilder.AddForeignKey(
                name: "FK_Anpassningar_Ordrar_OrderRadId",
                table: "Anpassningar",
                column: "OrderRadId",
                principalTable: "Ordrar",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
