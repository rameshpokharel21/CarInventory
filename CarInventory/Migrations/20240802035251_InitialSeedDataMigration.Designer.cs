﻿// <auto-generated />
using CarInventory.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CarInventory.Migrations
{
    [DbContext(typeof(CarInventoryDbContext))]
    [Migration("20240802035251_InitialSeedDataMigration")]
    partial class InitialSeedDataMigration
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
                        },
                        new
                        {
                            CarId = 501,
                            InventoryId = 50001,
                            Make = "Volvo",
                            Model = "C70",
                            Price = 46000m,
                            Trim = "Sedan",
                            Year = 2018
                        },
                        new
                        {
                            CarId = 401,
                            InventoryId = 40001,
                            Make = "Hyundai",
                            Model = "Elantra",
                            Price = 34000m,
                            Trim = "SE",
                            Year = 2023
                        },
                        new
                        {
                            CarId = 420,
                            InventoryId = 20002,
                            Make = "Toyota",
                            Model = "Sienna",
                            Price = 40000m,
                            Trim = "SUV",
                            Year = 2024
                        },
                        new
                        {
                            CarId = 130,
                            InventoryId = 10002,
                            Make = "HONDA",
                            Model = "Civic",
                            Price = 25000m,
                            Trim = "Hatchback",
                            Year = 2024
                        },
                        new
                        {
                            CarId = 131,
                            InventoryId = 10002,
                            Make = "HONDA",
                            Model = "Civic ",
                            Price = 45000m,
                            Trim = "Type R",
                            Year = 2024
                        },
                        new
                        {
                            CarId = 132,
                            InventoryId = 10002,
                            Make = "HONDA",
                            Model = "Civic",
                            Price = 29000m,
                            Trim = "C Sedan",
                            Year = 2024
                        },
                        new
                        {
                            CarId = 133,
                            InventoryId = 10052,
                            Make = "HONDA",
                            Model = "Accord",
                            Price = 28000m,
                            Trim = "Sedan",
                            Year = 2025
                        },
                        new
                        {
                            CarId = 134,
                            InventoryId = 10051,
                            Make = "HONDA",
                            Model = "Pilot",
                            Price = 40000m,
                            Trim = "SUV",
                            Year = 2024
                        },
                        new
                        {
                            CarId = 251,
                            InventoryId = 30002,
                            Make = "Genesis",
                            Model = "GV80",
                            Price = 80000m,
                            Trim = "Luxury SUV",
                            Year = 2025
                        },
                        new
                        {
                            CarId = 161,
                            InventoryId = 10002,
                            Make = "Acura",
                            Model = "Ingegra",
                            Price = 37400m,
                            Trim = "SUV",
                            Year = 2025
                        },
                        new
                        {
                            CarId = 162,
                            InventoryId = 30001,
                            Make = "Chevrolet",
                            Model = "TrailBlazor",
                            Price = 27000m,
                            Trim = "SUV",
                            Year = 2025
                        },
                        new
                        {
                            CarId = 137,
                            InventoryId = 30002,
                            Make = "Kia",
                            Model = "Seltos",
                            Price = 31000m,
                            Trim = "SUV",
                            Year = 2025
                        },
                        new
                        {
                            CarId = 138,
                            InventoryId = 20002,
                            Make = "Lexus",
                            Model = "NX",
                            Price = 50000m,
                            Trim = "Luxury SUV",
                            Year = 2025
                        },
                        new
                        {
                            CarId = 139,
                            InventoryId = 20002,
                            Make = "Infinity",
                            Model = "Q50",
                            Price = 38000m,
                            Trim = "Hatchback",
                            Year = 2024
                        },
                        new
                        {
                            CarId = 140,
                            InventoryId = 30002,
                            Make = "Subaru",
                            Model = "Forester",
                            Price = 40000m,
                            Trim = "SUV",
                            Year = 2025
                        },
                        new
                        {
                            CarId = 141,
                            InventoryId = 40002,
                            Make = "Alfa",
                            Model = "Romeo Tonale",
                            Price = 41000m,
                            Trim = "Hybrid",
                            Year = 2024
                        },
                        new
                        {
                            CarId = 142,
                            InventoryId = 50002,
                            Make = "Audi",
                            Model = "A3",
                            Price = 38000m,
                            Trim = "AWD",
                            Year = 2024
                        },
                        new
                        {
                            CarId = 143,
                            InventoryId = 30002,
                            Make = "Mazda",
                            Model = "Mazda3",
                            Price = 36000m,
                            Trim = "AWD",
                            Year = 2024
                        },
                        new
                        {
                            CarId = 144,
                            InventoryId = 60001,
                            Make = "Tesla",
                            Model = "Model3",
                            Price = 47000m,
                            Trim = "Hybrid",
                            Year = 2024
                        },
                        new
                        {
                            CarId = 145,
                            InventoryId = 60001,
                            Make = "Nissan",
                            Model = "Sentra",
                            Price = 23000m,
                            Trim = "Compact",
                            Year = 2025
                        },
                        new
                        {
                            CarId = 146,
                            InventoryId = 60001,
                            Make = "Volkswagan",
                            Model = "Jetta",
                            Price = 28000m,
                            Trim = "Sedan",
                            Year = 2023
                        },
                        new
                        {
                            CarId = 147,
                            InventoryId = 60001,
                            Make = "Ford",
                            Model = "F-150",
                            Price = 45000m,
                            Trim = "XLT",
                            Year = 2023
                        },
                        new
                        {
                            CarId = 148,
                            InventoryId = 60001,
                            Make = "Mazda",
                            Model = "CX-5",
                            Price = 51000m,
                            Trim = "S",
                            Year = 2023
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
                            InventoryId = 10002
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
                        },
                        new
                        {
                            InventoryId = 30002
                        },
                        new
                        {
                            InventoryId = 40001
                        },
                        new
                        {
                            InventoryId = 40002
                        },
                        new
                        {
                            InventoryId = 50001
                        },
                        new
                        {
                            InventoryId = 50002
                        },
                        new
                        {
                            InventoryId = 60001
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
