using Microsoft.EntityFrameworkCore.Migrations;

namespace EFGetStarted_code_to_database.Migrations
{
    public partial class Structure_Correct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserBlogs_Blogs_BlogId",
                table: "UserBlogs");

            migrationBuilder.DropIndex(
                name: "IX_UserBlogs_BlogId",
                table: "UserBlogs");

            migrationBuilder.DropColumn(
                name: "BlogId",
                table: "UserBlogs");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BlogId",
                table: "UserBlogs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_UserBlogs_BlogId",
                table: "UserBlogs",
                column: "BlogId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserBlogs_Blogs_BlogId",
                table: "UserBlogs",
                column: "BlogId",
                principalTable: "Blogs",
                principalColumn: "BlogId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
