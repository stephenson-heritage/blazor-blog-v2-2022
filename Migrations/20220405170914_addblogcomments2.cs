using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace blazor_blog_v2_2022.Migrations
{
    public partial class addblogcomments2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    BlogCommentId = table.Column<uint>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Content = table.Column<string>(type: "TEXT", nullable: false),
                    TimePosted = table.Column<DateTime>(type: "datetime", nullable: false),
                    UserId = table.Column<string>(type: "TEXT", nullable: true),
                    BlogEntryId = table.Column<uint>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.BlogCommentId);
                    table.ForeignKey(
                        name: "FK_Comments_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Comments_Blog_BlogEntryId",
                        column: x => x.BlogEntryId,
                        principalTable: "Blog",
                        principalColumn: "BlogEntryId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_BlogEntryId",
                table: "Comments",
                column: "BlogEntryId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_UserId",
                table: "Comments",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");
        }
    }
}
