using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Hattmakarens_system.Migrations
{
    /// <inheritdoc />
    public partial class FixPendingChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orderrader_Hattmodeller_HattModellId1",
                table: "Orderrader");

            migrationBuilder.DropForeignKey(
                name: "FK_Ordrar_Frakter_FraktId1",
                table: "Ordrar");

            migrationBuilder.DropIndex(
                name: "IX_Ordrar_FraktId1",
                table: "Ordrar");

            migrationBuilder.DropIndex(
                name: "IX_Orderrader_HattModellId1",
                table: "Orderrader");

            migrationBuilder.DropColumn(
                name: "FraktId1",
                table: "Ordrar");

            migrationBuilder.DropColumn(
                name: "HattModellId1",
                table: "Orderrader");

            migrationBuilder.AlterColumn<int>(
                name: "HattModellId",
                table: "Orderrader",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Hattmodeller",
                columns: new[] { "HattModellId", "Beskrivning", "Namn", "Pris", "Tillgangliga" },
                values: new object[,]
                {
                    { 1, "En klassisk hatt", "Klassisk", 500m, true },
                    { 2, "En modern hatt", "Modern", 750m, true }
                });

            migrationBuilder.InsertData(
                table: "Kunder",
                columns: new[] { "KundId", "Adress", "Aktiv", "EfterNamn", "Epost", "ForNamn", "Telefon" },
                values: new object[,]
                {
                    { 1, "Gatan 1", true, "Andersson", "anna@example.com", "Anna", "0701234567" },
                    { 2, "Vägen 2", true, "Eriksson", "erik@example.com", "Erik", "0707654321" }
                });

            migrationBuilder.InsertData(
                table: "Material",
                columns: new[] { "MaterialId", "Beskrivning", "Namn" },
                values: new object[,]
                {
                    { 1, "Mjukt material", "Filt" },
                    { 2, "Lyxigt material", "Siden" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "UserId", "Behorighet", "Epost", "LosenordHash", "Namn" },
                values: new object[,]
                {
                    { 1, true, "admin@example.com", "hash1", "Admin" },
                    { 2, false, "medarbetare@example.com", "hash2", "Medarbetare" }
                });

            migrationBuilder.InsertData(
                table: "HattModellMaterial",
                columns: new[] { "HattModellId", "MaterialId", "Mangd" },
                values: new object[,]
                {
                    { 1, 1, 1.5m },
                    { 2, 2, 2.0m }
                });

            migrationBuilder.InsertData(
                table: "Orderrader",
                columns: new[] { "OrderRadId", "HattModellId", "Pris", "ReferensBild", "Typ", "UserId" },
                values: new object[,]
                {
                    { 1, 1, 1000m, null, 0, 1 },
                    { 2, 2, 1500m, null, 1, 2 }
                });

            migrationBuilder.InsertData(
                table: "Ordrar",
                columns: new[] { "OrderId", "Datum", "Express", "FraktId", "KundId", "Status", "TotalPris" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 0, 1, 0, 1000 },
                    { 2, new DateTime(2025, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 0, 2, 1, 1500 }
                });

            migrationBuilder.InsertData(
                table: "Anpassningar",
                columns: new[] { "AnpassningId", "Anpassningkostnad", "OrderRadId", "Typ", "Varde" },
                values: new object[,]
                {
                    { 1, 100m, 1, "Färg", "Röd" },
                    { 2, 150m, 2, "Storlek", "L" }
                });

            migrationBuilder.InsertData(
                table: "Frakter",
                columns: new[] { "FraktId", "ExportKod", "Moms", "OrderID", "PrisInkMoms", "SkapatDatum", "Vikt", "Värde" },
                values: new object[,]
                {
                    { 1, 100, 25.0, 1, 625m, new DateTime(2025, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 500m },
                    { 2, 200, 25.0, 2, 875m, new DateTime(2025, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 700m }
                });

            migrationBuilder.InsertData(
                table: "Materialstatusar",
                columns: new[] { "MaterialId", "OrderId", "Bestallt" },
                values: new object[,]
                {
                    { 1, 1, true },
                    { 2, 2, false }
                });

            migrationBuilder.InsertData(
                table: "SpecialHattar",
                columns: new[] { "SpecialHattId", "Dekoration", "ExtraMaterial", "Farg", "Fjader", "Kommentar", "Modell", "OrderRadId", "Storlek", "Text", "Tyg" },
                values: new object[,]
                {
                    { 1, "Fjäder", "Snöre", "Blå", "Svart", "Ingen", "Klassisk", 1, "M", "Initialer", "Filt" },
                    { 2, "Ros", "Spänne", "Grön", "Vit", "Snabb leverans", "Modern", 2, "L", "Logo", "Siden" }
                });

            migrationBuilder.InsertData(
                table: "Tillverkningsscheman",
                columns: new[] { "SchemaId", "OrderRadId", "Startdatum", "Status", "UserId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2025, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ej startad", 1 },
                    { 2, 2, new DateTime(2025, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Startad", 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orderrader_HattModellId",
                table: "Orderrader",
                column: "HattModellId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orderrader_Hattmodeller_HattModellId",
                table: "Orderrader",
                column: "HattModellId",
                principalTable: "Hattmodeller",
                principalColumn: "HattModellId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orderrader_Hattmodeller_HattModellId",
                table: "Orderrader");

            migrationBuilder.DropIndex(
                name: "IX_Orderrader_HattModellId",
                table: "Orderrader");

            migrationBuilder.DeleteData(
                table: "Anpassningar",
                keyColumn: "AnpassningId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Anpassningar",
                keyColumn: "AnpassningId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Frakter",
                keyColumn: "FraktId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Frakter",
                keyColumn: "FraktId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "HattModellMaterial",
                keyColumns: new[] { "HattModellId", "MaterialId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "HattModellMaterial",
                keyColumns: new[] { "HattModellId", "MaterialId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "Materialstatusar",
                keyColumns: new[] { "MaterialId", "OrderId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "Materialstatusar",
                keyColumns: new[] { "MaterialId", "OrderId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "SpecialHattar",
                keyColumn: "SpecialHattId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SpecialHattar",
                keyColumn: "SpecialHattId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tillverkningsscheman",
                keyColumn: "SchemaId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tillverkningsscheman",
                keyColumn: "SchemaId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Material",
                keyColumn: "MaterialId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Material",
                keyColumn: "MaterialId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Orderrader",
                keyColumn: "OrderRadId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Orderrader",
                keyColumn: "OrderRadId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Ordrar",
                keyColumn: "OrderId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Ordrar",
                keyColumn: "OrderId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Hattmodeller",
                keyColumn: "HattModellId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Hattmodeller",
                keyColumn: "HattModellId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Kunder",
                keyColumn: "KundId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Kunder",
                keyColumn: "KundId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 2);

            migrationBuilder.AddColumn<int>(
                name: "FraktId1",
                table: "Ordrar",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "HattModellId",
                table: "Orderrader",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "HattModellId1",
                table: "Orderrader",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Ordrar_FraktId1",
                table: "Ordrar",
                column: "FraktId1");

            migrationBuilder.CreateIndex(
                name: "IX_Orderrader_HattModellId1",
                table: "Orderrader",
                column: "HattModellId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Orderrader_Hattmodeller_HattModellId1",
                table: "Orderrader",
                column: "HattModellId1",
                principalTable: "Hattmodeller",
                principalColumn: "HattModellId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ordrar_Frakter_FraktId1",
                table: "Ordrar",
                column: "FraktId1",
                principalTable: "Frakter",
                principalColumn: "FraktId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
