using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WineCardAppVersionFour.Migrations
{
    /// <inheritdoc />
    public partial class nulablemigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Wines_WineCards_WineCardId",
                table: "Wines");

            migrationBuilder.AlterColumn<int>(
                name: "WineCardId",
                table: "Wines",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "AccountId",
                keyValue: 1,
                column: "HashPassword",
                value: "$2a$11$YTQgKh8ESSUg2lUVlc6mw.h4qXjKnG8/f6bu1eJd50GKvewnylRHu");

            migrationBuilder.AddForeignKey(
                name: "FK_Wines_WineCards_WineCardId",
                table: "Wines",
                column: "WineCardId",
                principalTable: "WineCards",
                principalColumn: "WineCardId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Wines_WineCards_WineCardId",
                table: "Wines");

            migrationBuilder.AlterColumn<int>(
                name: "WineCardId",
                table: "Wines",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "AccountId",
                keyValue: 1,
                column: "HashPassword",
                value: "$2a$11$aCspQ1NV5NsRKa7.wE3ymuS1TDm.S4pmgkrHSIH8cTkpnpBONLxvC");

            migrationBuilder.AddForeignKey(
                name: "FK_Wines_WineCards_WineCardId",
                table: "Wines",
                column: "WineCardId",
                principalTable: "WineCards",
                principalColumn: "WineCardId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
