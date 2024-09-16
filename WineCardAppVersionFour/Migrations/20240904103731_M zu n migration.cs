using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WineCardAppVersionFour.Migrations
{
    /// <inheritdoc />
    public partial class Mzunmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Wines_WineCards_WineCardId",
                table: "Wines");

            migrationBuilder.DropIndex(
                name: "IX_Wines_WineCardId",
                table: "Wines");

            migrationBuilder.DropColumn(
                name: "WineCardId",
                table: "Wines");

            migrationBuilder.AddColumn<int>(
                name: "WineId",
                table: "WineCards",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "AccountId",
                keyValue: 1,
                column: "HashPassword",
                value: "$2a$11$okkUCnPF3D4a9lJjFr2RqeP7HU7ucMbnMJfr87DOurTjU1EWsOU7O");

            migrationBuilder.CreateIndex(
                name: "IX_WineCards_WineId",
                table: "WineCards",
                column: "WineId");

            migrationBuilder.AddForeignKey(
                name: "FK_WineCards_Wines_WineId",
                table: "WineCards",
                column: "WineId",
                principalTable: "Wines",
                principalColumn: "WineId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WineCards_Wines_WineId",
                table: "WineCards");

            migrationBuilder.DropIndex(
                name: "IX_WineCards_WineId",
                table: "WineCards");

            migrationBuilder.DropColumn(
                name: "WineId",
                table: "WineCards");

            migrationBuilder.AddColumn<int>(
                name: "WineCardId",
                table: "Wines",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "AccountId",
                keyValue: 1,
                column: "HashPassword",
                value: "$2a$11$YTQgKh8ESSUg2lUVlc6mw.h4qXjKnG8/f6bu1eJd50GKvewnylRHu");

            migrationBuilder.CreateIndex(
                name: "IX_Wines_WineCardId",
                table: "Wines",
                column: "WineCardId");

            migrationBuilder.AddForeignKey(
                name: "FK_Wines_WineCards_WineCardId",
                table: "Wines",
                column: "WineCardId",
                principalTable: "WineCards",
                principalColumn: "WineCardId");
        }
    }
}
