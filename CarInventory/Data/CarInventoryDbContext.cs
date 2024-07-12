using CarInventory.Models;
using Microsoft.EntityFrameworkCore;



namespace CarInventory.Data;

public class CarInventoryDbContext : DbContext
{
    /*
    public CarInventoryContext(DbContextOptions<CarInventoryContext> options) : base(options)
    {

    }
    */

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string databaseFile = "Inventory.db";
        string path = Path.Combine(Environment.CurrentDirectory, databaseFile);
        string connectionString = $"Data Source={path}";
        Console.WriteLine($"Connection: {connectionString}");
        optionsBuilder.UseSqlite(connectionString);
    }

    public DbSet<Car> Cars => Set<Car>();
    public DbSet<Inventory> Inventories => Set<Inventory>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Car>().HasData(
            new Car{
                CarId = 101, Make = "Honda", Model = "CRV", Year = 2023, Trim = "LX", Price = 38000,
                InventoryId = 10001
            },
            new Car
            {
                CarId = 104,
                Make = "Honda",
                Model = "Odyssey",
                Year = 2024,
                Trim = "LX",
                Price = 55000,
                InventoryId = 10001
            },
            new Car
            {
                CarId = 102,
                Make = "Honda",
                Model = "Civic",
                Year = 2024,
                Trim = "EX",
                Price = 35000,
                InventoryId = 10001
            },
            new Car
            {
                CarId = 103,
                Make = "Honda",
                Model = "Pilot",
                Year = 2024,
                Trim = "LX",
                Price = 50000,
                InventoryId = 10001
            },
            new Car
            {
                CarId = 201,
                Make = "Toyota",
                Model = "RAV4",
                Year = 2024,
                Trim = "LE",
                Price = 35000,
                InventoryId = 20001
            },
            new Car
            {
                CarId = 202,
                Make = "Toyota",
                Model = "CAMRY",
                Year = 2022,
                Trim = "XLE",
                Price = 26000,
                InventoryId = 20001
            },
            new Car
            {
                CarId = 105,
                Make = "Honda",
                Model = "CRV",
                Year = 2025,
                Trim = "EX",
                Price = 40000,
                InventoryId = 10001
            }

            );

        modelBuilder.Entity<Inventory>().HasData(
            new Inventory { InventoryId = 10001},
            new Inventory { InventoryId = 10051},
            new Inventory { InventoryId = 10052 },
            new Inventory { InventoryId = 20001 },
            new Inventory { InventoryId = 20002},
            new Inventory { InventoryId = 30001}
            );
    }

}
