using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hattmakarens_system.Migrations
{
    /// <inheritdoc />
    public partial class UserIdNullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orderrader_User_UserId",
                table: "Orderrader");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Orderrader",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Orderrader_User_UserId",
                table: "Orderrader",
                column: "UserId",
                principalTable: "User",
                principalColumn: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orderrader_User_UserId",
                table: "Orderrader");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Orderrader",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Orderrader_User_UserId",
                table: "Orderrader",
                column: "UserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
