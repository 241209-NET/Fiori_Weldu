using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NannyAgency.API.Migrations
{
    /// <inheritdoc />
    public partial class Clientupdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Clients",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Clients",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "email",
                table: "Clients",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Nannies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExprienceYear = table.Column<int>(type: "int", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nannies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ClientNannies",
                columns: table => new
                {
                    nanniesId = table.Column<int>(type: "int", nullable: false),
                    nanniesId1 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientNannies", x => new { x.nanniesId, x.nanniesId1 });
                    table.ForeignKey(
                        name: "FK_ClientNannies_Clients_nanniesId",
                        column: x => x.nanniesId,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClientNannies_Nannies_nanniesId1",
                        column: x => x.nanniesId1,
                        principalTable: "Nannies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClientNannies_nanniesId1",
                table: "ClientNannies",
                column: "nanniesId1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClientNannies");

            migrationBuilder.DropTable(
                name: "Nannies");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "email",
                table: "Clients");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Clients",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
