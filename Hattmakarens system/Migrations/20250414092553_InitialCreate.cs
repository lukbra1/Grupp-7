using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Hattmakarens_system.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orderrader_Hattmodeller_HattModellId",
                table: "Orderrader");

            migrationBuilder.DropForeignKey(
                name: "FK_Orderrader_Ordrar_OrderId",
                table: "Orderrader");

            migrationBuilder.DropTable(
                name: "Anpassningar");

            migrationBuilder.DropTable(
                name: "Frakter");

            migrationBuilder.DropTable(
                name: "HattModellMaterial");

            migrationBuilder.DropTable(
                name: "Materialstatusar");

            migrationBuilder.DropTable(
                name: "SpecialHattar");

            migrationBuilder.DropTable(
                name: "Tillverkningsscheman");

            migrationBuilder.DropTable(
                name: "Hattmodeller");

            migrationBuilder.DropIndex(
                name: "IX_Orderrader_HattModellId",
                table: "Orderrader");

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
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Kunder",
                keyColumn: "KundId",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "HattModellId",
                table: "Orderrader");

            migrationBuilder.DropColumn(
                name: "Pris",
                table: "Orderrader");

            migrationBuilder.RenameColumn(
                name: "LosenordHash",
                table: "User",
                newName: "Losenord");

            migrationBuilder.RenameColumn(
                name: "FraktId",
                table: "Ordrar",
                newName: "FraktSedelId");

            migrationBuilder.RenameColumn(
                name: "Datum",
                table: "Ordrar",
                newName: "Skapad");

            migrationBuilder.RenameColumn(
                name: "Typ",
                table: "Orderrader",
                newName: "StatusOrderrad");

            migrationBuilder.RenameColumn(
                name: "ReferensBild",
                table: "Orderrader",
                newName: "Tyg");

            migrationBuilder.RenameColumn(
                name: "ForNamn",
                table: "Kunder",
                newName: "Fornamn");

            migrationBuilder.RenameColumn(
                name: "EfterNamn",
                table: "Kunder",
                newName: "Efternamn");

            migrationBuilder.RenameColumn(
                name: "Telefon",
                table: "Kunder",
                newName: "TelefonNr");

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalPris",
                table: "Ordrar",
                type: "decimal(18,2)",
                nullable: false,
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
                name: "Kommentar",
                table: "Orderrader",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Modell",
                table: "Orderrader",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModellId",
                table: "Orderrader",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OrderTyp",
                table: "Orderrader",
                type: "nvarchar(8)",
                maxLength: 8,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Storlek",
                table: "Orderrader",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Text",
                table: "Orderrader",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Tillverkad",
                table: "Orderrader",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Enhet",
                table: "Material",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Farg",
                table: "Material",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "PrisPerEnhet",
                table: "Material",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateTable(
                name: "Fraktsedlar",
                columns: table => new
                {
                    FraktSedelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExportKod = table.Column<int>(type: "int", nullable: false),
                    Vikt = table.Column<int>(type: "int", nullable: false),
                    Värde = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Moms = table.Column<double>(type: "float", nullable: false),
                    PrisInkMoms = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SkapatDatum = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OrderID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fraktsedlar", x => x.FraktSedelId);
                    table.ForeignKey(
                        name: "FK_Fraktsedlar_Ordrar_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Ordrar",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MaterialOrderrader",
                columns: table => new
                {
                    MaterialId = table.Column<int>(type: "int", nullable: false),
                    OrderRadId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialOrderrader", x => new { x.MaterialId, x.OrderRadId });
                    table.ForeignKey(
                        name: "FK_MaterialOrderrader_Material_MaterialId",
                        column: x => x.MaterialId,
                        principalTable: "Material",
                        principalColumn: "MaterialId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MaterialOrderrader_Orderrader_OrderRadId",
                        column: x => x.OrderRadId,
                        principalTable: "Orderrader",
                        principalColumn: "OrderRadId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Modeller",
                columns: table => new
                {
                    ModellId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Namn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Beskrivning = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tillganglig = table.Column<bool>(type: "bit", nullable: false),
                    Pris = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modeller", x => x.ModellId);
                });

            migrationBuilder.CreateTable(
                name: "MaterialModeller",
                columns: table => new
                {
                    ModellId = table.Column<int>(type: "int", nullable: false),
                    MaterialId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialModeller", x => new { x.MaterialId, x.ModellId });
                    table.ForeignKey(
                        name: "FK_MaterialModeller_Material_MaterialId",
                        column: x => x.MaterialId,
                        principalTable: "Material",
                        principalColumn: "MaterialId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MaterialModeller_Modeller_ModellId",
                        column: x => x.ModellId,
                        principalTable: "Modeller",
                        principalColumn: "ModellId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Fraktsedlar",
                columns: new[] { "FraktSedelId", "ExportKod", "Moms", "OrderID", "PrisInkMoms", "SkapatDatum", "Vikt", "Värde" },
                values: new object[] { 1, 100, 25.0, 1, 1000m, new DateTime(2025, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 800m });

            migrationBuilder.UpdateData(
                table: "Material",
                keyColumn: "MaterialId",
                keyValue: 1,
                columns: new[] { "Enhet", "Farg", "PrisPerEnhet" },
                values: new object[] { "m", "Blå", 100m });

            migrationBuilder.InsertData(
                table: "Modeller",
                columns: new[] { "ModellId", "Beskrivning", "Namn", "Pris", "Tillganglig" },
                values: new object[] { 1, "En klassisk hatt", "Studentmössa", 500m, true });

            migrationBuilder.UpdateData(
                table: "Ordrar",
                keyColumn: "OrderId",
                keyValue: 1,
                columns: new[] { "Skapad", "TotalPris" },
                values: new object[] { new DateTime(2025, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1000m });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 1,
                column: "Losenord",
                value: "admin123");

            migrationBuilder.InsertData(
                table: "MaterialModeller",
                columns: new[] { "MaterialId", "ModellId" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "Orderrader",
                columns: new[] { "OrderRadId", "ModellId", "OrderId", "OrderTyp", "StatusOrderrad", "Tillverkad", "UserId" },
                values: new object[] { 1, 1, 1, "Lager", 0, false, 1 });

            migrationBuilder.InsertData(
                table: "MaterialOrderrader",
                columns: new[] { "MaterialId", "OrderRadId" },
                values: new object[] { 1, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Orderrader_ModellId",
                table: "Orderrader",
                column: "ModellId");

            migrationBuilder.CreateIndex(
                name: "IX_Fraktsedlar_OrderID",
                table: "Fraktsedlar",
                column: "OrderID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MaterialModeller_ModellId",
                table: "MaterialModeller",
                column: "ModellId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialOrderrader_OrderRadId",
                table: "MaterialOrderrader",
                column: "OrderRadId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orderrader_Modeller_ModellId",
                table: "Orderrader",
                column: "ModellId",
                principalTable: "Modeller",
                principalColumn: "ModellId",
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
                name: "FK_Orderrader_Modeller_ModellId",
                table: "Orderrader");

            migrationBuilder.DropForeignKey(
                name: "FK_Orderrader_Ordrar_OrderId",
                table: "Orderrader");

            migrationBuilder.DropTable(
                name: "Fraktsedlar");

            migrationBuilder.DropTable(
                name: "MaterialModeller");

            migrationBuilder.DropTable(
                name: "MaterialOrderrader");

            migrationBuilder.DropTable(
                name: "Modeller");

            migrationBuilder.DropIndex(
                name: "IX_Orderrader_ModellId",
                table: "Orderrader");

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
                name: "Kommentar",
                table: "Orderrader");

            migrationBuilder.DropColumn(
                name: "Modell",
                table: "Orderrader");

            migrationBuilder.DropColumn(
                name: "ModellId",
                table: "Orderrader");

            migrationBuilder.DropColumn(
                name: "OrderTyp",
                table: "Orderrader");

            migrationBuilder.DropColumn(
                name: "Storlek",
                table: "Orderrader");

            migrationBuilder.DropColumn(
                name: "Text",
                table: "Orderrader");

            migrationBuilder.DropColumn(
                name: "Tillverkad",
                table: "Orderrader");

            migrationBuilder.DropColumn(
                name: "Enhet",
                table: "Material");

            migrationBuilder.DropColumn(
                name: "Farg",
                table: "Material");

            migrationBuilder.DropColumn(
                name: "PrisPerEnhet",
                table: "Material");

            migrationBuilder.RenameColumn(
                name: "Losenord",
                table: "User",
                newName: "LosenordHash");

            migrationBuilder.RenameColumn(
                name: "Skapad",
                table: "Ordrar",
                newName: "Datum");

            migrationBuilder.RenameColumn(
                name: "FraktSedelId",
                table: "Ordrar",
                newName: "FraktId");

            migrationBuilder.RenameColumn(
                name: "Tyg",
                table: "Orderrader",
                newName: "ReferensBild");

            migrationBuilder.RenameColumn(
                name: "StatusOrderrad",
                table: "Orderrader",
                newName: "Typ");

            migrationBuilder.RenameColumn(
                name: "Fornamn",
                table: "Kunder",
                newName: "ForNamn");

            migrationBuilder.RenameColumn(
                name: "Efternamn",
                table: "Kunder",
                newName: "EfterNamn");

            migrationBuilder.RenameColumn(
                name: "TelefonNr",
                table: "Kunder",
                newName: "Telefon");

            migrationBuilder.AlterColumn<int>(
                name: "TotalPris",
                table: "Ordrar",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AddColumn<int>(
                name: "HattModellId",
                table: "Orderrader",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "Pris",
                table: "Orderrader",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateTable(
                name: "Anpassningar",
                columns: table => new
                {
                    AnpassningId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderRadId = table.Column<int>(type: "int", nullable: false),
                    Anpassningkostnad = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Typ = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Varde = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Anpassningar", x => x.AnpassningId);
                    table.ForeignKey(
                        name: "FK_Anpassningar_Orderrader_OrderRadId",
                        column: x => x.OrderRadId,
                        principalTable: "Orderrader",
                        principalColumn: "OrderRadId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Frakter",
                columns: table => new
                {
                    FraktId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderID = table.Column<int>(type: "int", nullable: false),
                    ExportKod = table.Column<int>(type: "int", nullable: false),
                    Moms = table.Column<double>(type: "float", nullable: false),
                    PrisInkMoms = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SkapatDatum = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Vikt = table.Column<int>(type: "int", nullable: false),
                    Värde = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Frakter", x => x.FraktId);
                    table.ForeignKey(
                        name: "FK_Frakter_Ordrar_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Ordrar",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Hattmodeller",
                columns: table => new
                {
                    HattModellId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Beskrivning = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Namn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pris = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Tillgangliga = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hattmodeller", x => x.HattModellId);
                });

            migrationBuilder.CreateTable(
                name: "Materialstatusar",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    MaterialId = table.Column<int>(type: "int", nullable: false),
                    Bestallt = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materialstatusar", x => new { x.OrderId, x.MaterialId });
                    table.ForeignKey(
                        name: "FK_Materialstatusar_Material_MaterialId",
                        column: x => x.MaterialId,
                        principalTable: "Material",
                        principalColumn: "MaterialId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Materialstatusar_Ordrar_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Ordrar",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SpecialHattar",
                columns: table => new
                {
                    SpecialHattId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderRadId = table.Column<int>(type: "int", nullable: false),
                    Dekoration = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExtraMaterial = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Farg = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fjader = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kommentar = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Modell = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Storlek = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tyg = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpecialHattar", x => x.SpecialHattId);
                    table.ForeignKey(
                        name: "FK_SpecialHattar_Orderrader_OrderRadId",
                        column: x => x.OrderRadId,
                        principalTable: "Orderrader",
                        principalColumn: "OrderRadId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tillverkningsscheman",
                columns: table => new
                {
                    SchemaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderRadId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Startdatum = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tillverkningsscheman", x => x.SchemaId);
                    table.ForeignKey(
                        name: "FK_Tillverkningsscheman_Orderrader_OrderRadId",
                        column: x => x.OrderRadId,
                        principalTable: "Orderrader",
                        principalColumn: "OrderRadId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tillverkningsscheman_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HattModellMaterial",
                columns: table => new
                {
                    HattModellId = table.Column<int>(type: "int", nullable: false),
                    MaterialId = table.Column<int>(type: "int", nullable: false),
                    Mangd = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HattModellMaterial", x => new { x.HattModellId, x.MaterialId });
                    table.ForeignKey(
                        name: "FK_HattModellMaterial_Hattmodeller_HattModellId",
                        column: x => x.HattModellId,
                        principalTable: "Hattmodeller",
                        principalColumn: "HattModellId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HattModellMaterial_Material_MaterialId",
                        column: x => x.MaterialId,
                        principalTable: "Material",
                        principalColumn: "MaterialId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Anpassningar",
                columns: new[] { "AnpassningId", "Anpassningkostnad", "OrderRadId", "Typ", "Varde" },
                values: new object[] { 1, 100m, 1, "Färg", "Röd" });

            migrationBuilder.InsertData(
                table: "Frakter",
                columns: new[] { "FraktId", "ExportKod", "Moms", "OrderID", "PrisInkMoms", "SkapatDatum", "Vikt", "Värde" },
                values: new object[] { 1, 100, 25.0, 1, 625m, new DateTime(2025, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 500m });

            migrationBuilder.InsertData(
                table: "Hattmodeller",
                columns: new[] { "HattModellId", "Beskrivning", "Namn", "Pris", "Tillgangliga" },
                values: new object[,]
                {
                    { 1, "En klassisk hatt", "Klassisk", 500m, true },
                    { 2, "En modern hatt", "Modern", 750m, true },
                    { 3, "En studentmössa", "Studentmössa", 800m, true },
                    { 4, "En doktormössa", "Doktormössa", 400m, true },
                    { 5, "En oktoberhatt", "Oktoberhatt", 1000m, true },
                    { 6, "En fez hatt", "Fez hatt", 300m, true },
                    { 7, "En Sherlock hatt", "Sherlock hatt", 1200m, true }
                });

            migrationBuilder.InsertData(
                table: "Kunder",
                columns: new[] { "KundId", "Adress", "Aktiv", "EfterNamn", "Epost", "ForNamn", "Telefon" },
                values: new object[] { 2, "Vägen 2", true, "Eriksson", "erik@example.com", "Erik", "0707654321" });

            migrationBuilder.InsertData(
                table: "Material",
                columns: new[] { "MaterialId", "Beskrivning", "Namn" },
                values: new object[] { 2, "Lyxigt material", "Siden" });

            migrationBuilder.InsertData(
                table: "Materialstatusar",
                columns: new[] { "MaterialId", "OrderId", "Bestallt" },
                values: new object[] { 1, 1, true });

            migrationBuilder.UpdateData(
                table: "Orderrader",
                keyColumn: "OrderRadId",
                keyValue: 1,
                columns: new[] { "HattModellId", "OrderId", "Pris", "ReferensBild" },
                values: new object[] { 1, 2, 1000m, null });

            migrationBuilder.UpdateData(
                table: "Ordrar",
                keyColumn: "OrderId",
                keyValue: 1,
                columns: new[] { "Datum", "TotalPris" },
                values: new object[] { new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1000 });

            migrationBuilder.InsertData(
                table: "SpecialHattar",
                columns: new[] { "SpecialHattId", "Dekoration", "ExtraMaterial", "Farg", "Fjader", "Kommentar", "Modell", "OrderRadId", "Storlek", "Text", "Tyg" },
                values: new object[] { 1, "Fjäder", "Snöre", "Blå", "Svart", "Ingen", "Klassisk", 1, "M", "Initialer", "Filt" });

            migrationBuilder.InsertData(
                table: "Tillverkningsscheman",
                columns: new[] { "SchemaId", "OrderRadId", "Startdatum", "Status", "UserId" },
                values: new object[] { 1, 1, new DateTime(2025, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ej startad", 1 });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 1,
                column: "LosenordHash",
                value: "hash1");

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "UserId", "Behorighet", "Epost", "LosenordHash", "Namn" },
                values: new object[] { 2, false, "medarbetare@example.com", "hash2", "Medarbetare" });

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
                columns: new[] { "OrderRadId", "HattModellId", "OrderId", "Pris", "ReferensBild", "Typ", "UserId" },
                values: new object[] { 2, 2, 1, 1500m, null, 1, 2 });

            migrationBuilder.InsertData(
                table: "Ordrar",
                columns: new[] { "OrderId", "Datum", "Express", "FraktId", "KundId", "Status", "TotalPris" },
                values: new object[] { 2, new DateTime(2025, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, 2, 1, 1500 });

            migrationBuilder.InsertData(
                table: "Anpassningar",
                columns: new[] { "AnpassningId", "Anpassningkostnad", "OrderRadId", "Typ", "Varde" },
                values: new object[] { 2, 150m, 2, "Storlek", "L" });

            migrationBuilder.InsertData(
                table: "Frakter",
                columns: new[] { "FraktId", "ExportKod", "Moms", "OrderID", "PrisInkMoms", "SkapatDatum", "Vikt", "Värde" },
                values: new object[] { 2, 200, 25.0, 2, 875m, new DateTime(2025, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 700m });

            migrationBuilder.InsertData(
                table: "Materialstatusar",
                columns: new[] { "MaterialId", "OrderId", "Bestallt" },
                values: new object[] { 2, 2, false });

            migrationBuilder.InsertData(
                table: "SpecialHattar",
                columns: new[] { "SpecialHattId", "Dekoration", "ExtraMaterial", "Farg", "Fjader", "Kommentar", "Modell", "OrderRadId", "Storlek", "Text", "Tyg" },
                values: new object[] { 2, "Ros", "Spänne", "Grön", "Vit", "Snabb leverans", "Modern", 2, "L", "Logo", "Siden" });

            migrationBuilder.InsertData(
                table: "Tillverkningsscheman",
                columns: new[] { "SchemaId", "OrderRadId", "Startdatum", "Status", "UserId" },
                values: new object[] { 2, 2, new DateTime(2025, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Startad", 2 });

            migrationBuilder.CreateIndex(
                name: "IX_Orderrader_HattModellId",
                table: "Orderrader",
                column: "HattModellId");

            migrationBuilder.CreateIndex(
                name: "IX_Anpassningar_OrderRadId",
                table: "Anpassningar",
                column: "OrderRadId");

            migrationBuilder.CreateIndex(
                name: "IX_Frakter_OrderID",
                table: "Frakter",
                column: "OrderID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_HattModellMaterial_MaterialId",
                table: "HattModellMaterial",
                column: "MaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_Materialstatusar_MaterialId",
                table: "Materialstatusar",
                column: "MaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_SpecialHattar_OrderRadId",
                table: "SpecialHattar",
                column: "OrderRadId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tillverkningsscheman_OrderRadId",
                table: "Tillverkningsscheman",
                column: "OrderRadId");

            migrationBuilder.CreateIndex(
                name: "IX_Tillverkningsscheman_UserId",
                table: "Tillverkningsscheman",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orderrader_Hattmodeller_HattModellId",
                table: "Orderrader",
                column: "HattModellId",
                principalTable: "Hattmodeller",
                principalColumn: "HattModellId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orderrader_Ordrar_OrderId",
                table: "Orderrader",
                column: "OrderId",
                principalTable: "Ordrar",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
