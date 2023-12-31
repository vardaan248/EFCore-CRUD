﻿// <auto-generated />
using AniccData.DB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AniccData.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AniccData.Models.StudentCSV", b =>
                {
                    b.Property<string>("Student_ID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AnnouncementsView")
                        .HasColumnType("int");

                    b.Property<string>("Class")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Discussion")
                        .HasColumnType("int");

                    b.Property<string>("GradeID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NationalITy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ParentAnsweringSurvey")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ParentschoolSatisfaction")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlaceofBirth")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Relation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SectionID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Semester")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StageID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StudentAbsenceDays")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Student_Marks")
                        .HasColumnType("int");

                    b.Property<string>("Topic")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VisITedResources")
                        .HasColumnType("int");

                    b.Property<string>("gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("raisedhands")
                        .HasColumnType("int");

                    b.HasKey("Student_ID");

                    b.ToTable("StudentsCSV");
                });
#pragma warning restore 612, 618
        }
    }
}
