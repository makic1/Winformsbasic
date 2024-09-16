using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WineCardAppVersionFour.Migrations
{
    /// <inheritdoc />
    public partial class asdfasdfmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "AccountId",
                keyValue: 1,
                column: "HashPassword",
                value: "$2a$11$nztoHBuEuQpP4TGqjaDst.E/RK/zhN59KSqxq9ma.RB67bAeh3kMq");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "AccountId",
                keyValue: 1,
                column: "HashPassword",
                value: "$2a$11$05QqQBLXOugyIp4KSzFxlus/.zzZEOd9OkPU59t8bz/Z9U.YNZMGy");
        }
    }
}
