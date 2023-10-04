﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StudentsManagement.Helpers.DbHelpers;

#nullable disable

namespace StudentsManagement.Migrations
{
    [DbContext(typeof(StudentsManagementContext))]
    [Migration("20230922105355_updated")]
    partial class updated
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("StudentsManagement.DAL.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RegistrationYear")
                        .HasColumnType("datetime2");

                    b.Property<int>("StudentYear")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateOfBirth = new DateTime(2001, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "vanesa@gmail.com",
                            FirstName = "Vanesa",
                            Gender = 1,
                            LastName = "Ismailaj",
                            Password = "vanesa123$",
                            PhoneNumber = "0681245789",
                            RegistrationYear = new DateTime(2020, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StudentYear = 3
                        },
                        new
                        {
                            Id = 2,
                            DateOfBirth = new DateTime(2003, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "mary@gmail.com",
                            FirstName = "Mary",
                            Gender = 1,
                            LastName = "John",
                            Password = "mary123$",
                            PhoneNumber = "0681298456",
                            RegistrationYear = new DateTime(2019, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StudentYear = 2
                        },
                        new
                        {
                            Id = 3,
                            DateOfBirth = new DateTime(2004, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "elon@gmail.com",
                            FirstName = "Elon",
                            Gender = 0,
                            LastName = "Smith",
                            Password = "elon123$",
                            PhoneNumber = "0694590123",
                            RegistrationYear = new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StudentYear = 1
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
