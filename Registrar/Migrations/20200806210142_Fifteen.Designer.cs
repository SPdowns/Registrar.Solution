﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Registrar.Models;

namespace Registrar.Migrations
{
    [DbContext(typeof(RegistrarContext))]
    [Migration("20200806210142_Fifteen")]
    partial class Fifteen
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Registrar.Models.Course", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("DepartmentId");

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<int>("Number");

                    b.Property<int?>("ProfessorId");

                    b.HasKey("CourseId");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("ProfessorId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("Registrar.Models.CourseStudent", b =>
                {
                    b.Property<int>("CourseStudentId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CourseId");

                    b.Property<int>("StudentId");

                    b.HasKey("CourseStudentId");

                    b.HasIndex("CourseId");

                    b.HasIndex("StudentId");

                    b.ToTable("CourseStudent");
                });

            modelBuilder.Entity("Registrar.Models.Department", b =>
                {
                    b.Property<int>("DepartmentId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CourseId");

                    b.Property<string>("DepartmentDescription");

                    b.Property<string>("DepartmentName");

                    b.Property<int>("ProfessorId");

                    b.Property<int>("StudentId");

                    b.HasKey("DepartmentId");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("Registrar.Models.Professor", b =>
                {
                    b.Property<int>("ProfessorId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CourseId");

                    b.Property<int?>("DepartmentId");

                    b.Property<string>("ProfessorName");

                    b.Property<bool>("Tenure");

                    b.HasKey("ProfessorId");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Professors");
                });

            modelBuilder.Entity("Registrar.Models.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("DepartmentId");

                    b.Property<DateTime>("EnrollmentDate");

                    b.Property<string>("StudentName");

                    b.Property<string>("StudentSocialScore");

                    b.HasKey("StudentId");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("Registrar.Models.Course", b =>
                {
                    b.HasOne("Registrar.Models.Department", "Department")
                        .WithMany("Courses")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Registrar.Models.Professor", "Professor")
                        .WithMany("Courses")
                        .HasForeignKey("ProfessorId");
                });

            modelBuilder.Entity("Registrar.Models.CourseStudent", b =>
                {
                    b.HasOne("Registrar.Models.Course", "Course")
                        .WithMany("Students")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Registrar.Models.Student", "Student")
                        .WithMany("Courses")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Registrar.Models.Professor", b =>
                {
                    b.HasOne("Registrar.Models.Department", "Department")
                        .WithMany("Professors")
                        .HasForeignKey("DepartmentId");
                });

            modelBuilder.Entity("Registrar.Models.Student", b =>
                {
                    b.HasOne("Registrar.Models.Department", "Department")
                        .WithMany("Students")
                        .HasForeignKey("DepartmentId");
                });
#pragma warning restore 612, 618
        }
    }
}
