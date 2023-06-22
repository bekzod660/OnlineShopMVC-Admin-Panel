using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineShopMVC.Migrations
{
    /// <inheritdoc />
    public partial class Inii : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "UserIdId",
                table: "Cart",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Cart_UserIdId",
                table: "Cart",
                column: "UserIdId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cart_Users_UserIdId",
                table: "Cart",
                column: "UserIdId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cart_Users_UserIdId",
                table: "Cart");

            migrationBuilder.DropIndex(
                name: "IX_Cart_UserIdId",
                table: "Cart");

            migrationBuilder.DropColumn(
                name: "UserIdId",
                table: "Cart");
        }
    }
}
