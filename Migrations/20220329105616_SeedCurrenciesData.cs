using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SelfCheckoutMachine.Migrations
{
    public partial class SeedCurrenciesData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "Amount", "Value" },
                values: new object[,]
                {
                    { 1, 0, 5 },
                    { 2, 0, 10 },
                    { 3, 0, 20 },
                    { 4, 0, 50 },
                    { 5, 0, 100 },
                    { 6, 0, 200 },
                    { 7, 0, 500 },
                    { 8, 0, 1000 },
                    { 9, 0, 2000 },
                    { 10, 0, 5000 },
                    { 11, 0, 10000 },
                    { 12, 0, 20000 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: 12);
        }
    }
}
