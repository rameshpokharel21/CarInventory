﻿// <auto-generated />
using CarInventory.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CarInventory.Migrations
{
    [DbContext(typeof(CarInventoryContext))]
    [Migration("20240711183340_InitialData")]
    partial class InitialData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.7");

            modelBuilder.Entity("CarInventory.Models.Car", b =>
                {
                    b.Property<int>("CarId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("InventoryId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Make")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<string>("Trim")
                        .HasColumnType("TEXT");

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("CarId");

                    b.HasIndex("InventoryId");

                    b.ToTable("Cars");

                    b.HasData(
                        new
                        {
                            CarId = 101,
                            InventoryId = 10001,
                            Make = "Honda",
                            Model = "CRV",
                            Price = 38000m,
                            Trim = "LX",
                            Year = 2023
                        },
                        new
                        {
                            CarId = 104,
                            InventoryId = 10001,
                            Make = "Honda",
                            Model = "Odyssey",
                            Price = 55000m,
                            Trim = "LX",
                            Year = 2024
                        },
                        new
                        {
                            CarId = 102,
                            InventoryId = 10001,
                            Make = "Honda",
                            Model = "Civic",
                            Price = 35000m,
                            Trim = "EX",
                            Year = 2024
                        },
                        new
                        {
                            CarId = 103,
                            InventoryId = 10001,
                            Make = "Honda",
                            Model = "Pilot",
                            Price = 50000m,
                            Trim = "LX",
                            Year = 2024
                        },
                        new
                        {
                            CarId = 201,
                            InventoryId = 20001,
                            Make = "Toyota",
                            Model = "RAV4",
                            Price = 35000m,
                            Trim = "LE",
                            Year = 2024
                        },
                        new
                        {
                            CarId = 202,
                            InventoryId = 20001,
                            Make = "Toyota",
                            Model = "CAMRY",
                            Price = 26000m,
                            Trim = "XLE",
                            Year = 2022
                        },
                        new
                        {
                            CarId = 105,
                            InventoryId = 10001,
                            Make = "Honda",
                            Model = "CRV",
                            Price = 40000m,
                            Trim = "EX",
                            Year = 2025
                        });
                });

            modelBuilder.Entity("CarInventory.Models.Inventory", b =>
                {
                    b.Property<int>("InventoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.HasKey("InventoryId");

                    b.ToTable("Inventories");

                    b.HasData(
                        new
                        {
                            InventoryId = 10001
                        },
                        new
                        {
                            InventoryId = 10051
                        },
                        new
                        {
                            InventoryId = 10052
                        },
                        new
                        {
                            InventoryId = 20001
                        },
                        new
                        {
                            InventoryId = 20002
                        },
                        new
                        {
                            InventoryId = 30001
                        });
                });

            modelBuilder.Entity("CarInventory.Models.Car", b =>
                {
                    b.HasOne("CarInventory.Models.Inventory", "Inventory")
                        .WithMany("Cars")
                        .HasForeignKey("InventoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Inventory");
                });

            modelBuilder.Entity("CarInventory.Models.Inventory", b =>
                {
                    b.Navigation("Cars");
                });
#pragma warning restore 612, 618
        }
    }
}