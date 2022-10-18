﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using manBackend.Models;

#nullable disable

namespace manBackend.Migrations
{
    [DbContext(typeof(BackendDbContext))]
    [Migration("20221017150658_addRooms")]
    partial class addRooms
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("manBackend.Models.Auth.Email", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Email");
                });

            modelBuilder.Entity("manBackend.Models.Auth.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("ClassroomId")
                        .HasColumnType("int");

                    b.Property<string>("Login")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MailId")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ClassroomId");

                    b.HasIndex("MailId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("manBackend.Models.Classroom", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("TeacherId")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TeacherId");

                    b.HasIndex("UserId");

                    b.ToTable("Classroom");
                });

            modelBuilder.Entity("manBackend.Models.Auth.User", b =>
                {
                    b.HasOne("manBackend.Models.Classroom", null)
                        .WithMany("Students")
                        .HasForeignKey("ClassroomId");

                    b.HasOne("manBackend.Models.Auth.Email", "Mail")
                        .WithMany()
                        .HasForeignKey("MailId");

                    b.Navigation("Mail");
                });

            modelBuilder.Entity("manBackend.Models.Classroom", b =>
                {
                    b.HasOne("manBackend.Models.Auth.User", "Teacher")
                        .WithMany()
                        .HasForeignKey("TeacherId");

                    b.HasOne("manBackend.Models.Auth.User", null)
                        .WithMany("Rooms")
                        .HasForeignKey("UserId");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("manBackend.Models.Auth.User", b =>
                {
                    b.Navigation("Rooms");
                });

            modelBuilder.Entity("manBackend.Models.Classroom", b =>
                {
                    b.Navigation("Students");
                });
#pragma warning restore 612, 618
        }
    }
}
