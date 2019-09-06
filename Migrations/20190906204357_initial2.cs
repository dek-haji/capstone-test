using Microsoft.EntityFrameworkCore.Migrations;

namespace testDemo.Migrations
{
    public partial class initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_QuestionTypes_Question_QuestionId",
                table: "QuestionTypes");

            migrationBuilder.DropIndex(
                name: "IX_QuestionTypes_QuestionId",
                table: "QuestionTypes");

            migrationBuilder.DropColumn(
                name: "QuestionId",
                table: "QuestionTypes");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "QuestionId",
                table: "QuestionTypes",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_QuestionTypes_QuestionId",
                table: "QuestionTypes",
                column: "QuestionId");

            migrationBuilder.AddForeignKey(
                name: "FK_QuestionTypes_Question_QuestionId",
                table: "QuestionTypes",
                column: "QuestionId",
                principalTable: "Question",
                principalColumn: "QuestionId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
