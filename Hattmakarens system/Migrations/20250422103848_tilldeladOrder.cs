using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hattmakarens_system.Migrations
{
    /// <inheritdoc />
    public partial class tilldeladOrder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "TilldeladOrder",
                table: "Orderrader",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Orderrader",
                keyColumn: "OrderRadId",
                keyValue: 1,
                column: "TilldeladOrder",
                value: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TilldeladOrder",
                table: "Orderrader");
        }
    }
}
