using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hattmakarens_system.Migrations
{
    /// <inheritdoc />
    public partial class newM : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ordrar_Kunder_KundId",
                table: "Ordrar");

            migrationBuilder.RenameColumn(
                name: "Kostnad",
                table: "Orderrader",
                newName: "pris");

            migrationBuilder.AlterColumn<int>(
                name: "KundId",
                table: "Ordrar",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<DateTime>(
                name: "TilldelningsDatum",
                table: "Orderrader",
                type: "datetime2",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Orderrader",
                keyColumn: "OrderRadId",
                keyValue: 1,
                columns: new[] { "TilldelningsDatum", "pris" },
                values: new object[] { null, null });

            migrationBuilder.AddForeignKey(
                name: "FK_Ordrar_Kunder_KundId",
                table: "Ordrar",
                column: "KundId",
                principalTable: "Kunder",
                principalColumn: "KundId",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ordrar_Kunder_KundId",
                table: "Ordrar");

            migrationBuilder.DropColumn(
                name: "TilldelningsDatum",
                table: "Orderrader");

            migrationBuilder.RenameColumn(
                name: "pris",
                table: "Orderrader",
                newName: "Kostnad");

            migrationBuilder.AlterColumn<int>(
                name: "KundId",
                table: "Ordrar",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Ordrar_Kunder_KundId",
                table: "Ordrar",
                column: "KundId",
                principalTable: "Kunder",
                principalColumn: "KundId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
