﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Полигон_Для_Шрд.Classes;

#nullable disable

namespace Полигон_Для_Шрд.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20240403144619_MainMigration")]
    partial class MainMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.17");

            modelBuilder.Entity("Полигон_Для_Шрд.Classes.NumberOfClass", b =>
                {
                    b.Property<int>("NumberOfClassId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("Number_of_class");

                    b.Property<int?>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("NumberOfClassId");

                    b.HasIndex("UserId");

                    b.ToTable("NumbersOfClasses");

                    b.HasData(
                        new
                        {
                            NumberOfClassId = 7
                        },
                        new
                        {
                            NumberOfClassId = 8
                        },
                        new
                        {
                            NumberOfClassId = 9
                        });
                });

            modelBuilder.Entity("Полигон_Для_Шрд.Classes.Tasks", b =>
                {
                    b.Property<int>("TaskId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("Id");

                    b.Property<string>("Anwer")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("Answer");

                    b.Property<int?>("NumberOfClassId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Task")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("Task");

                    b.HasKey("TaskId");

                    b.HasIndex("NumberOfClassId");

                    b.ToTable("Tasks");
                });

            modelBuilder.Entity("Полигон_Для_Шрд.Classes.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("Id");

                    b.Property<int>("Class")
                        .HasColumnType("INTEGER")
                        .HasColumnName("Class");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("Login");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("Password");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Полигон_Для_Шрд.Classes.NumberOfClass", b =>
                {
                    b.HasOne("Полигон_Для_Шрд.Classes.User", null)
                        .WithMany("NumberOfClasses")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Полигон_Для_Шрд.Classes.Tasks", b =>
                {
                    b.HasOne("Полигон_Для_Шрд.Classes.NumberOfClass", "NumberOfClass")
                        .WithMany("Tasks")
                        .HasForeignKey("NumberOfClassId");

                    b.Navigation("NumberOfClass");
                });

            modelBuilder.Entity("Полигон_Для_Шрд.Classes.NumberOfClass", b =>
                {
                    b.Navigation("Tasks");
                });

            modelBuilder.Entity("Полигон_Для_Шрд.Classes.User", b =>
                {
                    b.Navigation("NumberOfClasses");
                });
#pragma warning restore 612, 618
        }
    }
}
