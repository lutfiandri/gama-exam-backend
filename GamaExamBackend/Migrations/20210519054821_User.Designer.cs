﻿// <auto-generated />
using System;
using GamaExamBackend.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GamaExamBackend.Migrations
{
    [DbContext(typeof(DBExamContext))]
    [Migration("20210519054821_User")]
    partial class User
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GamaExamBackend.Models.Contest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("DCreatorId")
                        .HasColumnType("int");

                    b.Property<int?>("DParticipantId")
                        .HasColumnType("int");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime2(7)");

                    b.Property<int>("NumOfQuestion")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2(7)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("DCreatorId");

                    b.HasIndex("DParticipantId");

                    b.ToTable("dContests");
                });

            modelBuilder.Entity("GamaExamBackend.Models.DCreator", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("institute")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("password")
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("username")
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("dCreators");
                });

            modelBuilder.Entity("GamaExamBackend.Models.DParticipant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("institute")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("password")
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("username")
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("dParticipants");
                });

            modelBuilder.Entity("GamaExamBackend.Models.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Answers_A")
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Answers_B")
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Answers_C")
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Answers_D")
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Answers_E")
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("ContestId")
                        .HasColumnType("int");

                    b.Property<int>("QuestionNumber")
                        .HasColumnType("int");

                    b.Property<string>("QuestionText")
                        .HasColumnType("nvarchar(400)");

                    b.Property<int>("TrueAnswer")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("dQuestions");
                });

            modelBuilder.Entity("GamaExamBackend.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("createdContestIds")
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("doneContestIds")
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("institute")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("password")
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("GamaExamBackend.Models.Contest", b =>
                {
                    b.HasOne("GamaExamBackend.Models.DCreator", null)
                        .WithMany("CreatedContest")
                        .HasForeignKey("DCreatorId");

                    b.HasOne("GamaExamBackend.Models.DParticipant", null)
                        .WithMany("FollowedContest")
                        .HasForeignKey("DParticipantId");
                });

            modelBuilder.Entity("GamaExamBackend.Models.DCreator", b =>
                {
                    b.Navigation("CreatedContest");
                });

            modelBuilder.Entity("GamaExamBackend.Models.DParticipant", b =>
                {
                    b.Navigation("FollowedContest");
                });
#pragma warning restore 612, 618
        }
    }
}
