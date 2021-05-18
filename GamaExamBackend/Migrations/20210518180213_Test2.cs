using Microsoft.EntityFrameworkCore.Migrations;

namespace GamaExamBackend.Migrations
{
    public partial class Test2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_dContests_dCreators_CreatorId",
                table: "dContests");

            migrationBuilder.DropIndex(
                name: "IX_dContests_CreatorId",
                table: "dContests");

            migrationBuilder.DropColumn(
                name: "CreatorId",
                table: "dContests");

            migrationBuilder.AddColumn<int>(
                name: "DCreatorId",
                table: "dContests",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_dContests_DCreatorId",
                table: "dContests",
                column: "DCreatorId");

            migrationBuilder.AddForeignKey(
                name: "FK_dContests_dCreators_DCreatorId",
                table: "dContests",
                column: "DCreatorId",
                principalTable: "dCreators",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_dContests_dCreators_DCreatorId",
                table: "dContests");

            migrationBuilder.DropIndex(
                name: "IX_dContests_DCreatorId",
                table: "dContests");

            migrationBuilder.DropColumn(
                name: "DCreatorId",
                table: "dContests");

            migrationBuilder.AddColumn<int>(
                name: "CreatorId",
                table: "dContests",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_dContests_CreatorId",
                table: "dContests",
                column: "CreatorId");

            migrationBuilder.AddForeignKey(
                name: "FK_dContests_dCreators_CreatorId",
                table: "dContests",
                column: "CreatorId",
                principalTable: "dCreators",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
