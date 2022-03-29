using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SelfCheckoutMachine.Migrations
{
    public partial class UpdatedCurrenciesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Value",
                table: "Currencies");

            migrationBuilder.AddColumn<string>(
                name: "CurrencyValue",
                table: "Currencies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CurrencyValue",
                value: "5");

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: 2,
                column: "CurrencyValue",
                value: "10");

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: 3,
                column: "CurrencyValue",
                value: "20");

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: 4,
                column: "CurrencyValue",
                value: "50");

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: 5,
                column: "CurrencyValue",
                value: "100");

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: 6,
                column: "CurrencyValue",
                value: "200");

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: 7,
                column: "CurrencyValue",
                value: "500");

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: 8,
                column: "CurrencyValue",
                value: "1000");

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: 9,
                column: "CurrencyValue",
                value: "2000");

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: 10,
                column: "CurrencyValue",
                value: "5000");

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: 11,
                column: "CurrencyValue",
                value: "10000");

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: 12,
                column: "CurrencyValue",
                value: "20000");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CurrencyValue",
                table: "Currencies");

            migrationBuilder.AddColumn<int>(
                name: "Value",
                table: "Currencies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: 1,
                column: "Value",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: 2,
                column: "Value",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: 3,
                column: "Value",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: 4,
                column: "Value",
                value: 50);

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: 5,
                column: "Value",
                value: 100);

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: 6,
                column: "Value",
                value: 200);

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: 7,
                column: "Value",
                value: 500);

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: 8,
                column: "Value",
                value: 1000);

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: 9,
                column: "Value",
                value: 2000);

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: 10,
                column: "Value",
                value: 5000);

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: 11,
                column: "Value",
                value: 10000);

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: 12,
                column: "Value",
                value: 20000);
        }
    }
}
