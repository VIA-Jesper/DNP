using Microsoft.EntityFrameworkCore.Migrations;

namespace Efcore_ExampleWarehouse.Migrations
{
    public partial class one : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Username = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Username);
                });

            migrationBuilder.CreateTable(
                name: "Warehouses",
                columns: table => new
                {
                    WarehouseId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    UnitPrice = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Warehouses", x => x.WarehouseId);
                });

            migrationBuilder.CreateTable(
                name: "Pallets",
                columns: table => new
                {
                    PalletId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Height = table.Column<int>(nullable: false),
                    Weight = table.Column<int>(nullable: false),
                    Content = table.Column<string>(nullable: true),
                    ClientUsername = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pallets", x => x.PalletId);
                    table.ForeignKey(
                        name: "FK_Pallets_Clients_ClientUsername",
                        column: x => x.ClientUsername,
                        principalTable: "Clients",
                        principalColumn: "Username",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    Position = table.Column<string>(nullable: false),
                    WarehouseId = table.Column<int>(nullable: false),
                    PalletId = table.Column<int>(nullable: true),
                    ClientUsername = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => new { x.WarehouseId, x.Position });
                    table.ForeignKey(
                        name: "FK_Locations_Clients_ClientUsername",
                        column: x => x.ClientUsername,
                        principalTable: "Clients",
                        principalColumn: "Username",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Locations_Pallets_PalletId",
                        column: x => x.PalletId,
                        principalTable: "Pallets",
                        principalColumn: "PalletId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Locations_Warehouses_WarehouseId",
                        column: x => x.WarehouseId,
                        principalTable: "Warehouses",
                        principalColumn: "WarehouseId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Locations_ClientUsername",
                table: "Locations",
                column: "ClientUsername");

            migrationBuilder.CreateIndex(
                name: "IX_Locations_PalletId",
                table: "Locations",
                column: "PalletId");

            migrationBuilder.CreateIndex(
                name: "IX_Pallets_ClientUsername",
                table: "Pallets",
                column: "ClientUsername");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "Pallets");

            migrationBuilder.DropTable(
                name: "Warehouses");

            migrationBuilder.DropTable(
                name: "Clients");
        }
    }
}
