﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GamaExamBackend.Migrations
{
    public partial class TestMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "dCreators",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    username = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    name = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    password = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    institute = table.Column<string>(type: "nvarchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dCreators", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "dParticipants",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    username = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    name = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    password = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    institute = table.Column<string>(type: "nvarchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dParticipants", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "dContests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    NumOfQuestion = table.Column<int>(type: "int", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2(7)", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime2(7)", nullable: false),
                    CreatorId = table.Column<int>(type: "int", nullable: false),
                    DParticipantId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dContests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_dContests_dCreators_CreatorId",
                        column: x => x.CreatorId,
                        principalTable: "dCreators",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_dContests_dParticipants_DParticipantId",
                        column: x => x.DParticipantId,
                        principalTable: "dParticipants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "dQuestions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionNumber = table.Column<int>(type: "int", nullable: false),
                    QuestionText = table.Column<string>(type: "nvarchar(400)", nullable: true),
                    Answers_A = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    Answers_B = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    Answers_C = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    Answers_D = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    Answers_E = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    TrueAnswer = table.Column<int>(type: "int", nullable: false),
                    ContestId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dQuestions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_dQuestions_dContests_ContestId",
                        column: x => x.ContestId,
                        principalTable: "dContests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_dContests_CreatorId",
                table: "dContests",
                column: "CreatorId");

            migrationBuilder.CreateIndex(
                name: "IX_dContests_DParticipantId",
                table: "dContests",
                column: "DParticipantId");

            migrationBuilder.CreateIndex(
                name: "IX_dQuestions_ContestId",
                table: "dQuestions",
                column: "ContestId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "dQuestions");

            migrationBuilder.DropTable(
                name: "dContests");

            migrationBuilder.DropTable(
                name: "dCreators");

            migrationBuilder.DropTable(
                name: "dParticipants");
        }
    }
}
