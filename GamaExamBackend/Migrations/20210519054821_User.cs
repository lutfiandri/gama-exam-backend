using Microsoft.EntityFrameworkCore.Migrations;

namespace GamaExamBackend.Migrations
{
    public partial class User : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    password = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    institute = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    doneContestIds = table.Column<string>(type: "nvarchar(1000)", nullable: true),
                    createdContestIds = table.Column<string>(type: "nvarchar(1000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
