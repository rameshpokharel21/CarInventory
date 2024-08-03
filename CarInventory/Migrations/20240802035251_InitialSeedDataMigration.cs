using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarInventory.Migrations
{
    /// <inheritdoc />
    public partial class InitialSeedDataMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Inventories",
                columns: table => new
                {
                    InventoryId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventories", x => x.InventoryId);
                });

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    CarId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Make = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    Model = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false),
                    Year = table.Column<int>(type: "INTEGER", nullable: false),
                    Trim = table.Column<string>(type: "TEXT", nullable: true),
                    InventoryId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.CarId);
                    table.ForeignKey(
                        name: "FK_Cars_Inventories_InventoryId",
                        column: x => x.InventoryId,
                        principalTable: "Inventories",
                        principalColumn: "InventoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Inventories",
                column: "InventoryId",
                values: new object[]
                {
                    10001,
                    10002,
                    10051,
                    10052,
                    20001,
                    20002,
                    30001,
                    30002,
                    40001,
                    40002,
                    50001,
                    50002,
                    60001
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "CarId", "InventoryId", "Make", "Model", "Price", "Trim", "Year" },
                values: new object[,]
                {
                    { 101, 10001, "Honda", "CRV", 38000m, "LX", 2023 },
                    { 102, 10001, "Honda", "Civic", 35000m, "EX", 2024 },
                    { 103, 10001, "Honda", "Pilot", 50000m, "LX", 2024 },
                    { 104, 10001, "Honda", "Odyssey", 55000m, "LX", 2024 },
                    { 105, 10001, "Honda", "CRV", 40000m, "EX", 2025 },
                    { 130, 10002, "HONDA", "Civic", 25000m, "Hatchback", 2024 },
                    { 131, 10002, "HONDA", "Civic ", 45000m, "Type R", 2024 },
                    { 132, 10002, "HONDA", "Civic", 29000m, "C Sedan", 2024 },
                    { 133, 10052, "HONDA", "Accord", 28000m, "Sedan", 2025 },
                    { 134, 10051, "HONDA", "Pilot", 40000m, "SUV", 2024 },
                    { 137, 30002, "Kia", "Seltos", 31000m, "SUV", 2025 },
                    { 138, 20002, "Lexus", "NX", 50000m, "Luxury SUV", 2025 },
                    { 139, 20002, "Infinity", "Q50", 38000m, "Hatchback", 2024 },
                    { 140, 30002, "Subaru", "Forester", 40000m, "SUV", 2025 },
                    { 141, 40002, "Alfa", "Romeo Tonale", 41000m, "Hybrid", 2024 },
                    { 142, 50002, "Audi", "A3", 38000m, "AWD", 2024 },
                    { 143, 30002, "Mazda", "Mazda3", 36000m, "AWD", 2024 },
                    { 144, 60001, "Tesla", "Model3", 47000m, "Hybrid", 2024 },
                    { 145, 60001, "Nissan", "Sentra", 23000m, "Compact", 2025 },
                    { 146, 60001, "Volkswagan", "Jetta", 28000m, "Sedan", 2023 },
                    { 147, 60001, "Ford", "F-150", 45000m, "XLT", 2023 },
                    { 148, 60001, "Mazda", "CX-5", 51000m, "S", 2023 },
                    { 161, 10002, "Acura", "Ingegra", 37400m, "SUV", 2025 },
                    { 162, 30001, "Chevrolet", "TrailBlazor", 27000m, "SUV", 2025 },
                    { 201, 20001, "Toyota", "RAV4", 35000m, "LE", 2024 },
                    { 202, 20001, "Toyota", "CAMRY", 26000m, "XLE", 2022 },
                    { 251, 30002, "Genesis", "GV80", 80000m, "Luxury SUV", 2025 },
                    { 401, 40001, "Hyundai", "Elantra", 34000m, "SE", 2023 },
                    { 420, 20002, "Toyota", "Sienna", 40000m, "SUV", 2024 },
                    { 501, 50001, "Volvo", "C70", 46000m, "Sedan", 2018 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cars_InventoryId",
                table: "Cars",
                column: "InventoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "Inventories");
        }
    }
}
