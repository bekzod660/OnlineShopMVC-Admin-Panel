using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineShopMVC.Migrations
{
    /// <inheritdoc />
    public partial class Init44 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Picture",
                table: "AspNetUsers");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Picture",
                table: "AspNetUsers",
                type: "text",
                nullable: true);
        }
    }
}
