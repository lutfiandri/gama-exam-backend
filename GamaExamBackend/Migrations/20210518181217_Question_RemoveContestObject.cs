using Microsoft.EntityFrameworkCore.Migrations;

namespace GamaExamBackend.Migrations
{
    public partial class Question_RemoveContestObject : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_dQuestions_dContests_ContestId",
                table: "dQuestions");

            migrationBuilder.DropIndex(
                name: "IX_dQuestions_ContestId",
                table: "dQuestions");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_dQuestions_ContestId",
                table: "dQuestions",
                column: "ContestId");

            migrationBuilder.AddForeignKey(
                name: "FK_dQuestions_dContests_ContestId",
                table: "dQuestions",
                column: "ContestId",
                principalTable: "dContests",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
