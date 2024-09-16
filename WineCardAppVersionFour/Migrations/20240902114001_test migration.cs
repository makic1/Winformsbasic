using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WineCardAppVersionFour.Migrations
{
    /// <inheritdoc />
    public partial class testmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "AccountId",
                keyValue: 1,
                column: "HashPassword",
                value: "$2a$11$aCspQ1NV5NsRKa7.wE3ymuS1TDm.S4pmgkrHSIH8cTkpnpBONLxvC");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "AccountId",
                keyValue: 1,
                column: "HashPassword",
                value: "$2a$11$nztoHBuEuQpP4TGqjaDst.E/RK/zhN59KSqxq9ma.RB67bAeh3kMq");
        }
    }
}
