using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineShopMVC.Migrations
{
    /// <inheritdoc />
    public partial class Initb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Cart");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Cart");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Cart",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Cart",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
