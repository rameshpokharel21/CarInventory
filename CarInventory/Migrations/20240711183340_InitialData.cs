using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarInventory.Migrations
{
    /// <inheritdoc />
    public partial class InitialData : Migration
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
                    10051,
                    10052,
                    20001,
                    20002,
                    30001
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
                    { 201, 20001, "Toyota", "RAV4", 35000m, "LE", 2024 },
                    { 202, 20001, "Toyota", "CAMRY", 26000m, "XLE", 2022 }
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
