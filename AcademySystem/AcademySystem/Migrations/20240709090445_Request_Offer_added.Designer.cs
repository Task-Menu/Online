﻿// <auto-generated />
using System;
using AcademySystem.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AcademySystem.Migrations
{
    [DbContext(typeof(AcademySystemDbContext))]
    [Migration("20240709090445_Request_Offer_added")]
    partial class Request_Offer_added
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AcademySystem.Models.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("TotalHours")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("AcademySystem.Models.CourseTeacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("TeacherId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CourseId")
                        .IsUnique();

                    b.HasIndex("TeacherId")
                        .IsUnique();

                    b.ToTable("CourseTeachers");
                });

            modelBuilder.Entity("AcademySystem.Models.Group", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CourseTeacherId")
                        .HasColumnType("int");

                    b.Property<string>("GroupName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CourseTeacherId")
                        .IsUnique();

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("AcademySystem.Models.RequestOffer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MessageText")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("RequestOffer");
                });

            modelBuilder.Entity("AcademySystem.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GroupId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TelNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("AcademySystem.Models.Teacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("AcademySystem.Models.CourseTeacher", b =>
                {
                    b.HasOne("AcademySystem.Models.Course", "Course")
                        .WithOne("CourseTeacher")
                        .HasForeignKey("AcademySystem.Models.CourseTeacher", "CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AcademySystem.Models.Teacher", "Teacher")
                        .WithOne("CourseTeacher")
                        .HasForeignKey("AcademySystem.Models.CourseTeacher", "TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("AcademySystem.Models.Group", b =>
                {
                    b.HasOne("AcademySystem.Models.CourseTeacher", "CourseTeacher")
                        .WithOne("Group")
                        .HasForeignKey("AcademySystem.Models.Group", "CourseTeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CourseTeacher");
                });

            modelBuilder.Entity("AcademySystem.Models.Course", b =>
                {
                    b.Navigation("CourseTeacher");
                });

            modelBuilder.Entity("AcademySystem.Models.CourseTeacher", b =>
                {
                    b.Navigation("Group");
                });

            modelBuilder.Entity("AcademySystem.Models.Teacher", b =>
                {
                    b.Navigation("CourseTeacher");
                });
#pragma warning restore 612, 618
        }
    }
}
