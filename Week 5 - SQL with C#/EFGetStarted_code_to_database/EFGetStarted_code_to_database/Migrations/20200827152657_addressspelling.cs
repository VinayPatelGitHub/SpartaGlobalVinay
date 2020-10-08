using Microsoft.EntityFrameworkCore.Migrations;

namespace EFGetStarted_code_to_database.Migrations
{
    public partial class addressspelling : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WebsiteAdress",
                table: "Websites");

            migrationBuilder.AddColumn<string>(
                name: "WebsiteAddress",
                table: "Websites",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WebsiteAddress",
                table: "Websites");

            migrationBuilder.AddColumn<string>(
                name: "WebsiteAdress",
                table: "Websites",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
