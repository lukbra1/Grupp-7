using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hattmakarens_system.Migrations
{
    /// <inheritdoc />
    public partial class Scrum7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hattmodeller",
                columns: table => new
                {
                    HattModellId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Namn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pris = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Beskrivning = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tillgangliga = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hattmodeller", x => x.HattModellId);
                });

            migrationBuilder.CreateTable(
                name: "Kunder",
                columns: table => new
                {
                    KundId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ForNamn = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EfterNamn = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Telefon = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Epost = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Adress = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Aktiv = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kunder", x => x.KundId);
                });

            migrationBuilder.CreateTable(
                name: "Material",
                columns: table => new
                {
                    MaterialId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Namn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Beskrivning = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Material", x => x.MaterialId);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Namn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Epost = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LosenordHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Behorighet = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserId);
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

            migrationBuilder.CreateTable(
                name: "Orderrader",
                columns: table => new
                {
                    OrderRadId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Typ = table.Column<int>(type: "int", nullable: false),
                    Pris = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ReferensBild = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    HattModellId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HattModellId1 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orderrader", x => x.OrderRadId);
                    table.ForeignKey(
                        name: "FK_Orderrader_Hattmodeller_HattModellId1",
                        column: x => x.HattModellId1,
                        principalTable: "Hattmodeller",
                        principalColumn: "HattModellId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orderrader_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SpecialHattar",
                columns: table => new
                {
                    SpecialHattId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderRadId = table.Column<int>(type: "int", nullable: false),
                    Farg = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tyg = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dekoration = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Storlek = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Modell = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fjader = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExtraMaterial = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kommentar = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                name: "Anpassningar",
                columns: table => new
                {
                    AnpassningId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Typ = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Varde = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Anpassningkostnad = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OrderRadId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Anpassningar", x => x.AnpassningId);
                });

            migrationBuilder.CreateTable(
                name: "Frakter",
                columns: table => new
                {
                    FraktId = table.Column<int>(type: "int", nullable: false)
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
                    table.PrimaryKey("PK_Frakter", x => x.FraktId);
                });

            migrationBuilder.CreateTable(
                name: "Ordrar",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Datum = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Express = table.Column<bool>(type: "bit", nullable: false),
                    TotalPris = table.Column<int>(type: "int", nullable: false),
                    KundId = table.Column<int>(type: "int", nullable: false),
                    FraktId = table.Column<int>(type: "int", nullable: false),
                    FraktId1 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ordrar", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_Ordrar_Frakter_FraktId1",
                        column: x => x.FraktId1,
                        principalTable: "Frakter",
                        principalColumn: "FraktId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ordrar_Kunder_KundId",
                        column: x => x.KundId,
                        principalTable: "Kunder",
                        principalColumn: "KundId",
                        onDelete: ReferentialAction.Cascade);
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
                name: "IX_Orderrader_HattModellId1",
                table: "Orderrader",
                column: "HattModellId1");

            migrationBuilder.CreateIndex(
                name: "IX_Orderrader_UserId",
                table: "Orderrader",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Ordrar_FraktId1",
                table: "Ordrar",
                column: "FraktId1");

            migrationBuilder.CreateIndex(
                name: "IX_Ordrar_KundId",
                table: "Ordrar",
                column: "KundId");

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
                name: "FK_Anpassningar_Ordrar_OrderRadId",
                table: "Anpassningar",
                column: "OrderRadId",
                principalTable: "Ordrar",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Frakter_Ordrar_OrderID",
                table: "Frakter",
                column: "OrderID",
                principalTable: "Ordrar",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Frakter_Ordrar_OrderID",
                table: "Frakter");

            migrationBuilder.DropTable(
                name: "Anpassningar");

            migrationBuilder.DropTable(
                name: "HattModellMaterial");

            migrationBuilder.DropTable(
                name: "Materialstatusar");

            migrationBuilder.DropTable(
                name: "SpecialHattar");

            migrationBuilder.DropTable(
                name: "Tillverkningsscheman");

            migrationBuilder.DropTable(
                name: "Material");

            migrationBuilder.DropTable(
                name: "Orderrader");

            migrationBuilder.DropTable(
                name: "Hattmodeller");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Ordrar");

            migrationBuilder.DropTable(
                name: "Frakter");

            migrationBuilder.DropTable(
                name: "Kunder");
        }
    }
}
