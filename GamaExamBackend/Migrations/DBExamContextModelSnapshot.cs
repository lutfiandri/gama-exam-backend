﻿// <auto-generated />
using System;
using GamaExamBackend.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GamaExamBackend.Migrations
{
    [DbContext(typeof(DBExamContext))]
    partial class DBExamContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<int>("CreatorId")
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

                    b.HasIndex("CreatorId");

                    b.HasIndex("DParticipantId");

                    b.ToTable("dContests");
                });

            modelBuilder.Entity("GamaExamBackend.Models.ContestAttempt", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ContestId")
                        .HasColumnType("int");

                    b.Property<int>("ParticipantId")
                        .HasColumnType("int");

                    b.Property<int>("TimeLeft")
                        .HasColumnType("int");

                    b.Property<float>("score")
                        .HasColumnType("float(24)");

                    b.HasKey("Id");

                    b.HasIndex("ContestId");

                    b.HasIndex("ParticipantId");

                    b.ToTable("dContestsAttempt");
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

                    b.Property<string>("TrueAnswer")
                        .IsRequired()
                        .HasColumnType("char(1)");

                    b.HasKey("Id");

                    b.HasIndex("ContestId");

                    b.ToTable("dQuestions");
                });

            modelBuilder.Entity("GamaExamBackend.Models.QuestionAnswer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Answer")
                        .IsRequired()
                        .HasColumnType("char(1)");

                    b.Property<int>("ContestAttemptId")
                        .HasColumnType("int");

                    b.Property<int>("QuestionNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ContestAttemptId");

                    b.ToTable("dQuestionAnswer");
                });

            modelBuilder.Entity("GamaExamBackend.Models.Contest", b =>
                {
                    b.HasOne("GamaExamBackend.Models.DCreator", "Creator")
                        .WithMany("CreatedContest")
                        .HasForeignKey("CreatorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GamaExamBackend.Models.DParticipant", null)
                        .WithMany("FollowedContest")
                        .HasForeignKey("DParticipantId");

                    b.Navigation("Creator");
                });

            modelBuilder.Entity("GamaExamBackend.Models.ContestAttempt", b =>
                {
                    b.HasOne("GamaExamBackend.Models.Contest", "Contest")
                        .WithMany()
                        .HasForeignKey("ContestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GamaExamBackend.Models.DParticipant", "Participant")
                        .WithMany()
                        .HasForeignKey("ParticipantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Contest");

                    b.Navigation("Participant");
                });

            modelBuilder.Entity("GamaExamBackend.Models.Question", b =>
                {
                    b.HasOne("GamaExamBackend.Models.Contest", "Contest")
                        .WithMany("Questions")
                        .HasForeignKey("ContestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Contest");
                });

            modelBuilder.Entity("GamaExamBackend.Models.QuestionAnswer", b =>
                {
                    b.HasOne("GamaExamBackend.Models.ContestAttempt", "ContestAttempt")
                        .WithMany("AnswerCollection")
                        .HasForeignKey("ContestAttemptId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ContestAttempt");
                });

            modelBuilder.Entity("GamaExamBackend.Models.Contest", b =>
                {
                    b.Navigation("Questions");
                });

            modelBuilder.Entity("GamaExamBackend.Models.ContestAttempt", b =>
                {
                    b.Navigation("AnswerCollection");
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
