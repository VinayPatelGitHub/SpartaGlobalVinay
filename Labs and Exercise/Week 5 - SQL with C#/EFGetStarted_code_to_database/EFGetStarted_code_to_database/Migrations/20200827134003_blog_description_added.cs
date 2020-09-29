using Microsoft.EntityFrameworkCore.Migrations;

namespace EFGetStarted_code_to_database.Migrations
{
    public partial class blog_description_added : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PostId",
                table: "Blogs");

            migrationBuilder.AddColumn<string>(
                name: "BlogDescription",
                table: "Blogs",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BlogDescription",
                table: "Blogs");

            migrationBuilder.AddColumn<int>(
                name: "PostId",
                table: "Blogs",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
