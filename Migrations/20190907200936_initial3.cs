using Microsoft.EntityFrameworkCore.Migrations;

namespace testDemo.Migrations
{
    public partial class initial3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Answers_AspNetUsers_ApplicationUserId1",
                table: "Answers");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Answers");

            migrationBuilder.RenameColumn(
                name: "ApplicationUserId1",
                table: "Answers",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Answers_ApplicationUserId1",
                table: "Answers",
                newName: "IX_Answers_UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Answers_AspNetUsers_UserId",
                table: "Answers",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Answers_AspNetUsers_UserId",
                table: "Answers");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Answers",
                newName: "ApplicationUserId1");

            migrationBuilder.RenameIndex(
                name: "IX_Answers_UserId",
                table: "Answers",
                newName: "IX_Answers_ApplicationUserId1");

            migrationBuilder.AddColumn<int>(
                name: "ApplicationUserId",
                table: "Answers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Answers_AspNetUsers_ApplicationUserId1",
                table: "Answers",
                column: "ApplicationUserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
