using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WineCardAppVersionFour.Migrations
{
    /// <inheritdoc />
    public partial class Dbsetmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Wines_Vintage_VintageId",
                table: "Wines");

            migrationBuilder.DropForeignKey(
                name: "FK_Wines_WineCard_WineCardId",
                table: "Wines");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WineCard",
                table: "WineCard");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vintage",
                table: "Vintage");

            migrationBuilder.RenameTable(
                name: "WineCard",
                newName: "WineCards");

            migrationBuilder.RenameTable(
                name: "Vintage",
                newName: "Vintages");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WineCards",
                table: "WineCards",
                column: "WineCardId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vintages",
                table: "Vintages",
                column: "VintageId");

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "AccountId",
                keyValue: 1,
                column: "HashPassword",
                value: "$2a$11$05QqQBLXOugyIp4KSzFxlus/.zzZEOd9OkPU59t8bz/Z9U.YNZMGy");

            migrationBuilder.AddForeignKey(
                name: "FK_Wines_Vintages_VintageId",
                table: "Wines",
                column: "VintageId",
                principalTable: "Vintages",
                principalColumn: "VintageId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Wines_WineCards_WineCardId",
                table: "Wines",
                column: "WineCardId",
                principalTable: "WineCards",
                principalColumn: "WineCardId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Wines_Vintages_VintageId",
                table: "Wines");

            migrationBuilder.DropForeignKey(
                name: "FK_Wines_WineCards_WineCardId",
                table: "Wines");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WineCards",
                table: "WineCards");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vintages",
                table: "Vintages");

            migrationBuilder.RenameTable(
                name: "WineCards",
                newName: "WineCard");

            migrationBuilder.RenameTable(
                name: "Vintages",
                newName: "Vintage");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WineCard",
                table: "WineCard",
                column: "WineCardId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vintage",
                table: "Vintage",
                column: "VintageId");

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "AccountId",
                keyValue: 1,
                column: "HashPassword",
                value: "$2a$11$.Dhky7Ixe7O7WwBX2L50se4TS4K0kyT5XQ5mgOih0PooKzsPCQom.");

            migrationBuilder.AddForeignKey(
                name: "FK_Wines_Vintage_VintageId",
                table: "Wines",
                column: "VintageId",
                principalTable: "Vintage",
                principalColumn: "VintageId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Wines_WineCard_WineCardId",
                table: "Wines",
                column: "WineCardId",
                principalTable: "WineCard",
                principalColumn: "WineCardId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
