using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Hattmakarens_system.Migrations
{
    /// <inheritdoc />
    public partial class Max40 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Material",
                keyColumn: "MaterialId",
                keyValue: 1,
                columns: new[] { "Beskrivning", "Enhet", "Namn", "PrisPerEnhet" },
                values: new object[] { "Fjädrar kan användas för att lägga till dekoration eller ge en hatt en speciell stil. Fjädrarna kan komma från fåglar som strutsar, påfåglar eller höns.", "st", "Fjädrar", 0m });

            migrationBuilder.UpdateData(
                table: "Material",
                keyColumn: "MaterialId",
                keyValue: 2,
                columns: new[] { "Beskrivning", "Enhet", "Namn", "PrisPerEnhet" },
                values: new object[] { "Tygblommor kan användas för att ge en hatt en feminin och romantisk stil.", "st", "Tygblommor", 0m });

            migrationBuilder.UpdateData(
                table: "Material",
                keyColumn: "MaterialId",
                keyValue: 3,
                columns: new[] { "Beskrivning", "Namn", "PrisPerEnhet" },
                values: new object[] { "Pärlor kan användas för att lägga till en elegant och sofistikerad touch till en hatt.", "Pärlor", 0m });

            migrationBuilder.UpdateData(
                table: "Material",
                keyColumn: "MaterialId",
                keyValue: 4,
                column: "PrisPerEnhet",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "Material",
                keyColumn: "MaterialId",
                keyValue: 5,
                columns: new[] { "Beskrivning", "Enhet", "Namn", "PrisPerEnhet" },
                values: new object[] { "Spetsar kan användas för att lägga till en vintage känsla till en hatt.", "st", "Spets", 0m });

            migrationBuilder.UpdateData(
                table: "Material",
                keyColumn: "MaterialId",
                keyValue: 6,
                columns: new[] { "Beskrivning", "Enhet", "Namn", "PrisPerEnhet" },
                values: new object[] { "Lackerat papper kan användas för att skapa en högteknologisk eller futuristisk stil till en hatt.", "Kvdm", "Lackerat papper", 0m });

            migrationBuilder.InsertData(
                table: "Material",
                columns: new[] { "MaterialId", "Beskrivning", "Enhet", "Farg", "Namn", "PrisPerEnhet" },
                values: new object[,]
                {
                    { 7, "Lurextråd kan användas för att lägga till en glittrig och festlig touch till en hatt.", "dm", "Svart/Vit-mönstrad", "Lurextråd", 0m },
                    { 8, ": Fuskpäls kan användas för att ge en hatt en mjuk och fluffig yta, eller för att skapa en djurisk känsla.", "Kvdm", "Svart/Vit-mönstrad", "Fuskpäls", 0m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Material",
                keyColumn: "MaterialId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Material",
                keyColumn: "MaterialId",
                keyValue: 8);

            migrationBuilder.UpdateData(
                table: "Material",
                keyColumn: "MaterialId",
                keyValue: 1,
                columns: new[] { "Beskrivning", "Enhet", "Namn", "PrisPerEnhet" },
                values: new object[] { "Mjukt material.", "Kvm", "Snuttefilt", 100m });

            migrationBuilder.UpdateData(
                table: "Material",
                keyColumn: "MaterialId",
                keyValue: 2,
                columns: new[] { "Beskrivning", "Enhet", "Namn", "PrisPerEnhet" },
                values: new object[] { "Färgat Kalv Läder.", "Kvm", "Läder", 325m });

            migrationBuilder.UpdateData(
                table: "Material",
                keyColumn: "MaterialId",
                keyValue: 3,
                columns: new[] { "Beskrivning", "Namn", "PrisPerEnhet" },
                values: new object[] { "Fjädrar från den Australiensiska strudsen som endast födar på  japanska böngroddar.", "Struds Fjäder", 45m });

            migrationBuilder.UpdateData(
                table: "Material",
                keyColumn: "MaterialId",
                keyValue: 4,
                column: "PrisPerEnhet",
                value: 15m);

            migrationBuilder.UpdateData(
                table: "Material",
                keyColumn: "MaterialId",
                keyValue: 5,
                columns: new[] { "Beskrivning", "Enhet", "Namn", "PrisPerEnhet" },
                values: new object[] { "Saphirer från mallorcas östra bergras.", "karat", "Saphir", 9000m });

            migrationBuilder.UpdateData(
                table: "Material",
                keyColumn: "MaterialId",
                keyValue: 6,
                columns: new[] { "Beskrivning", "Enhet", "Namn", "PrisPerEnhet" },
                values: new object[] { "Pläd ifrån vildfångad zebra i östra Zimbabwe.", "m", "Zebrapläd", 750m });
        }
    }
}
