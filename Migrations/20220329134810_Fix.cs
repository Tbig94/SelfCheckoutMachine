using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SelfCheckoutMachine.Migrations
{
    public partial class Fix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CurrencyValue",
                table: "Currencies",
                newName: "Unit");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Unit",
                table: "Currencies",
                newName: "CurrencyValue");
        }
    }
}
