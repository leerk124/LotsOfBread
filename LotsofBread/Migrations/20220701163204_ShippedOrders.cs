using Microsoft.EntityFrameworkCore.Migrations;

namespace LotsofBread.Migrations
{
    public partial class ShippedOrders : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CVV",
                table: "Orders",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CardNumber",
                table: "Orders",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ExpMonth",
                table: "Orders",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ExpYear",
                table: "Orders",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NameOnCard",
                table: "Orders",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CVV",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "CardNumber",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "ExpMonth",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "ExpYear",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "NameOnCard",
                table: "Orders");
        }
    }
}
