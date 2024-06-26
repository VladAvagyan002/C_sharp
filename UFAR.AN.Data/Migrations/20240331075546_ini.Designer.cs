﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UFAR.AN.Data.DAO;

#nullable disable

namespace UFAR.AN.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240331075546_ini")]
    partial class ini
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("UFAR.AN.Data.Entities.CarsEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ItemEntityId")
                        .HasColumnType("int");

                    b.Property<string>("Manufacturer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StartVin")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ItemEntityId");

                    b.ToTable("Cars");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Compact car produced by Toyota",
                            Manufacturer = "Toyota",
                            Model = "Corolla",
                            Name = "Toyota Corolla",
                            StartVin = "KMHDU8UDP",
                            Year = 2022
                        },
                        new
                        {
                            Id = 2,
                            Description = "Popular compact car manufactured by Honda",
                            Manufacturer = "Honda",
                            Model = "Civic",
                            Name = "Honda Civic",
                            StartVin = "JH4DA9350L",
                            Year = 2023
                        },
                        new
                        {
                            Id = 3,
                            Description = "Iconic American muscle car produced by Ford",
                            Manufacturer = "Ford",
                            Model = "Mustang",
                            Name = "Ford Mustang",
                            StartVin = "1G6KD54Y7V",
                            Year = 2024
                        },
                        new
                        {
                            Id = 4,
                            Description = "Luxury compact executive car manufactured by BMW",
                            Manufacturer = "BMW",
                            Model = "3 Series",
                            Name = "BMW 3 Series",
                            StartVin = "WAUZZZ8DZV",
                            Year = 2025
                        },
                        new
                        {
                            Id = 5,
                            Description = "Electric luxury sedan produced by Tesla, Inc.",
                            Manufacturer = "Tesla",
                            Model = "Model S",
                            Name = "Tesla Model S",
                            StartVin = "YV1LW5715P",
                            Year = 2026
                        });
                });

            modelBuilder.Entity("UFAR.AN.Data.Entities.ItemEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Condition")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsOEM")
                        .HasColumnType("bit");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OEM_Number")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Items");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Condition = "New",
                            Description = "Description1",
                            IsOEM = true,
                            Location = "Location1",
                            Name = "Item1",
                            OEM_Number = "OEM1"
                        },
                        new
                        {
                            Id = 2,
                            Condition = "New",
                            Description = "Description2",
                            IsOEM = true,
                            Location = "Location2",
                            Name = "Item2",
                            OEM_Number = "OEM2"
                        },
                        new
                        {
                            Id = 3,
                            Condition = "New",
                            Description = "Description3",
                            IsOEM = true,
                            Location = "Location3",
                            Name = "Item3",
                            OEM_Number = "OEM3"
                        },
                        new
                        {
                            Id = 4,
                            Condition = "New",
                            Description = "Description4",
                            IsOEM = true,
                            Location = "Location4",
                            Name = "Item4",
                            OEM_Number = "OEM4"
                        },
                        new
                        {
                            Id = 5,
                            Condition = "New",
                            Description = "Description5",
                            IsOEM = true,
                            Location = "Location5",
                            Name = "Item5",
                            OEM_Number = "OEM5"
                        });
                });

            modelBuilder.Entity("UFAR.AN.Data.Entities.CarsEntity", b =>
                {
                    b.HasOne("UFAR.AN.Data.Entities.ItemEntity", null)
                        .WithMany("CarsFit")
                        .HasForeignKey("ItemEntityId");
                });

            modelBuilder.Entity("UFAR.AN.Data.Entities.ItemEntity", b =>
                {
                    b.Navigation("CarsFit");
                });
#pragma warning restore 612, 618
        }
    }
}
