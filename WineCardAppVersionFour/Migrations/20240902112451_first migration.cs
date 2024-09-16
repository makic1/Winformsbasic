using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WineCardAppVersionFour.Migrations
{
    /// <inheritdoc />
    public partial class firstmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    AccountId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    HashPassword = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.AccountId);
                });

            migrationBuilder.CreateTable(
                name: "GrapeVarieties",
                columns: table => new
                {
                    GrapeVarietyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GrapeVarietyName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GrapeVarieties", x => x.GrapeVarietyId);
                });

            migrationBuilder.CreateTable(
                name: "Vintage",
                columns: table => new
                {
                    VintageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VintageYear = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vintage", x => x.VintageId);
                });

            migrationBuilder.CreateTable(
                name: "WineCard",
                columns: table => new
                {
                    WineCardId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WineCard", x => x.WineCardId);
                });

            migrationBuilder.CreateTable(
                name: "WinesCountries",
                columns: table => new
                {
                    WineCountryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WineCountryName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WinesCountries", x => x.WineCountryId);
                });

            migrationBuilder.CreateTable(
                name: "WineTypes",
                columns: table => new
                {
                    WineTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WineTypeName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WineTypes", x => x.WineTypeId);
                });

            migrationBuilder.CreateTable(
                name: "WineRegions",
                columns: table => new
                {
                    WineRegionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegionName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    WineCountryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WineRegions", x => x.WineRegionId);
                    table.ForeignKey(
                        name: "FK_WineRegions_WinesCountries_WineCountryId",
                        column: x => x.WineCountryId,
                        principalTable: "WinesCountries",
                        principalColumn: "WineCountryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Wineries",
                columns: table => new
                {
                    WineryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WineryName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    WineRegionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wineries", x => x.WineryId);
                    table.ForeignKey(
                        name: "FK_Wineries_WineRegions_WineRegionId",
                        column: x => x.WineRegionId,
                        principalTable: "WineRegions",
                        principalColumn: "WineRegionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Wines",
                columns: table => new
                {
                    WineId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WineName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
                    WineTypeId = table.Column<int>(type: "int", nullable: false),
                    GrapeVarietyId = table.Column<int>(type: "int", nullable: false),
                    WineryId = table.Column<int>(type: "int", nullable: false),
                    VintageId = table.Column<int>(type: "int", nullable: false),
                    WineCardId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wines", x => x.WineId);
                    table.ForeignKey(
                        name: "FK_Wines_GrapeVarieties_GrapeVarietyId",
                        column: x => x.GrapeVarietyId,
                        principalTable: "GrapeVarieties",
                        principalColumn: "GrapeVarietyId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Wines_Vintage_VintageId",
                        column: x => x.VintageId,
                        principalTable: "Vintage",
                        principalColumn: "VintageId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Wines_WineCard_WineCardId",
                        column: x => x.WineCardId,
                        principalTable: "WineCard",
                        principalColumn: "WineCardId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Wines_WineTypes_WineTypeId",
                        column: x => x.WineTypeId,
                        principalTable: "WineTypes",
                        principalColumn: "WineTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Wines_Wineries_WineryId",
                        column: x => x.WineryId,
                        principalTable: "Wineries",
                        principalColumn: "WineryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "AccountId", "HashPassword", "Username" },
                values: new object[] { 1, "$2a$11$.Dhky7Ixe7O7WwBX2L50se4TS4K0kyT5XQ5mgOih0PooKzsPCQom.", "admin" });

            migrationBuilder.CreateIndex(
                name: "IX_WineRegions_WineCountryId",
                table: "WineRegions",
                column: "WineCountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Wineries_WineRegionId",
                table: "Wineries",
                column: "WineRegionId");

            migrationBuilder.CreateIndex(
                name: "IX_Wines_GrapeVarietyId",
                table: "Wines",
                column: "GrapeVarietyId");

            migrationBuilder.CreateIndex(
                name: "IX_Wines_VintageId",
                table: "Wines",
                column: "VintageId");

            migrationBuilder.CreateIndex(
                name: "IX_Wines_WineCardId",
                table: "Wines",
                column: "WineCardId");

            migrationBuilder.CreateIndex(
                name: "IX_Wines_WineryId",
                table: "Wines",
                column: "WineryId");

            migrationBuilder.CreateIndex(
                name: "IX_Wines_WineTypeId",
                table: "Wines",
                column: "WineTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropTable(
                name: "Wines");

            migrationBuilder.DropTable(
                name: "GrapeVarieties");

            migrationBuilder.DropTable(
                name: "Vintage");

            migrationBuilder.DropTable(
                name: "WineCard");

            migrationBuilder.DropTable(
                name: "WineTypes");

            migrationBuilder.DropTable(
                name: "Wineries");

            migrationBuilder.DropTable(
                name: "WineRegions");

            migrationBuilder.DropTable(
                name: "WinesCountries");
        }
    }
}
