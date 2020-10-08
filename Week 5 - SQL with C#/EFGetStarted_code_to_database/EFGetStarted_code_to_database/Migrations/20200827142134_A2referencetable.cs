using Microsoft.EntityFrameworkCore.Migrations;

namespace EFGetStarted_code_to_database.Migrations
{
    public partial class A2referencetable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BlogId",
                table: "UserPosts",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserPosts_BlogId",
                table: "UserPosts",
                column: "BlogId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserPosts_Blogs_BlogId",
                table: "UserPosts",
                column: "BlogId",
                principalTable: "Blogs",
                principalColumn: "BlogId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserPosts_Blogs_BlogId",
                table: "UserPosts");

            migrationBuilder.DropIndex(
                name: "IX_UserPosts_BlogId",
                table: "UserPosts");

            migrationBuilder.DropColumn(
                name: "BlogId",
                table: "UserPosts");
        }
    }
}
