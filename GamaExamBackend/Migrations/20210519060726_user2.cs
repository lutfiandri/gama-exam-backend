using Microsoft.EntityFrameworkCore.Migrations;

namespace GamaExamBackend.Migrations
{
    public partial class user2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "dUser");

            migrationBuilder.RenameColumn(
                name: "password",
                table: "dUser",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "dUser",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "institute",
                table: "dUser",
                newName: "Institute");

            migrationBuilder.RenameColumn(
                name: "doneContestIds",
                table: "dUser",
                newName: "DoneContestIds");

            migrationBuilder.RenameColumn(
                name: "createdContestIds",
                table: "dUser",
                newName: "CreatedContestIds");

            migrationBuilder.AddPrimaryKey(
                name: "PK_dUser",
                table: "dUser",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_dUser",
                table: "dUser");

            migrationBuilder.RenameTable(
                name: "dUser",
                newName: "User");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "User",
                newName: "password");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "User",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Institute",
                table: "User",
                newName: "institute");

            migrationBuilder.RenameColumn(
                name: "DoneContestIds",
                table: "User",
                newName: "doneContestIds");

            migrationBuilder.RenameColumn(
                name: "CreatedContestIds",
                table: "User",
                newName: "createdContestIds");

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "Id");
        }
    }
}
