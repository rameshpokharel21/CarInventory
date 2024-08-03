using CarInventory.Models;
using Microsoft.EntityFrameworkCore;



namespace CarInventory.Data;

public class CarInventoryDbContext : DbContext
{
    
    public CarInventoryDbContext(DbContextOptions<CarInventoryDbContext> options) : base(options)
    {

    }
    

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
            },
            new Car
            {
                CarId = 501,
                Make = "Volvo",
                Model = "C70",
                Year = 2018,
                Trim = "Sedan",
                Price = 46000,
                InventoryId = 50001
            },
             new Car
             {
                 CarId = 401,
                 Make = "Hyundai",
                 Model = "Elantra",
                 Year = 2023,
                 Trim = "SE",
                 Price = 34000,
                 InventoryId = 40001
             },
              new Car
              {
                  CarId = 420,
                  Make = "Toyota",
                  Model = "Sienna",
                  Year = 2024,
                  Trim = "SUV",
                  Price = 40000,
                  InventoryId = 20002
              },
               new Car
               {
                   CarId = 130,
                   Make = "HONDA",
                   Model = "Civic",
                   Year = 2024,
                   Trim = "Hatchback",
                   Price = 25000,
                   InventoryId = 10002
               },
                new Car
                {
                    CarId = 131,
                    Make = "HONDA",
                    Model = "Civic ",
                    Year = 2024,
                    Trim = "Type R",
                    Price = 45000,
                    InventoryId = 10002
                },
                 new Car
                 {
                     CarId = 132,
                     Make = "HONDA",
                     Model = "Civic",
                     Year = 2024,
                     Trim = "C Sedan",
                     Price = 29000,
                     InventoryId = 10002
                 },
                  new Car
                  {
                      CarId = 133,
                      Make = "HONDA",
                      Model = "Accord",
                      Year = 2025,
                      Trim = "Sedan",
                      Price = 28000,
                      InventoryId = 10052
                  },
                   new Car
                   {
                       CarId = 134,
                       Make = "HONDA",
                       Model = "Pilot",
                       Year = 2024,
                       Trim = "SUV",
                       Price = 40000,
                       InventoryId = 10051
                   },
                    
                     new Car
                     {
                         CarId = 251,
                         Make = "Genesis",
                         Model = "GV80",
                         Year = 2025,
                         Trim = "Luxury SUV",
                         Price = 80000,
                         InventoryId = 30002
                     },
                      new Car
                      {
                          CarId = 161,
                          Make = "Acura",
                          Model = "Ingegra",
                          Year = 2025,
                          Trim = "SUV",
                          Price = 37400,
                          InventoryId = 10002
                      },
                       new Car
                       {
                           CarId = 162,
                           Make = "Chevrolet",
                           Model = "TrailBlazor",
                           Year = 2025,
                           Trim = "SUV",
                           Price = 27000,
                           InventoryId = 30001
                       },
                        new Car
                        {
                            CarId = 137,
                            Make = "Kia",
                            Model = "Seltos",
                            Year = 2025,
                            Trim = "SUV",
                            Price = 31000,
                            InventoryId = 30002
                        },
                         new Car
                         {
                             CarId = 138,
                             Make = "Lexus",
                             Model = "NX",
                             Year = 2025,
                             Trim = "Luxury SUV",
                             Price = 50000,
                             InventoryId = 20002
                         },
                          new Car
                          {
                              CarId = 139,
                              Make = "Infinity",
                              Model = "Q50",
                              Year = 2024,
                              Trim = "Hatchback",
                              Price = 38000,
                              InventoryId = 20002
                          },
                           new Car
                           {
                               CarId = 140,
                               Make = "Subaru",
                               Model = "Forester",
                               Year = 2025,
                               Trim = "SUV",
                               Price = 40000,
                               InventoryId = 30002
                           },
                            new Car
                            {
                                CarId = 141,
                                Make = "Alfa",
                                Model = "Romeo Tonale",
                                Year = 2024,
                                Trim = "Hybrid",
                                Price = 41000,
                                InventoryId = 40002
                            },
                             new Car
                             {
                                 CarId = 142,
                                 Make = "Audi",
                                 Model = "A3",
                                 Year = 2024,
                                 Trim = "AWD",
                                 Price = 38000,
                                 InventoryId = 50002
                             },
                              new Car
                              {
                                  CarId = 143,
                                  Make = "Mazda",
                                  Model = "Mazda3",
                                  Year = 2024,
                                  Trim = "AWD",
                                  Price = 36000,
                                  InventoryId = 30002
                              },
                               new Car
                               {
                                   CarId = 144,
                                   Make = "Tesla",
                                   Model = "Model3",
                                   Year = 2024,
                                   Trim = "Hybrid",
                                   Price = 47000,
                                   InventoryId = 60001
                               },
                               new Car
                               {
                                   CarId = 145,
                                   Make = "Nissan",
                                   Model = "Sentra",
                                   Year = 2025,
                                   Trim = "Compact",
                                   Price = 23000,
                                   InventoryId = 60001
                               },
                               new Car
                               {
                                   CarId = 146,
                                   Make = "Volkswagan",
                                   Model = "Jetta",
                                   Year = 2023,
                                   Trim = "Sedan",
                                   Price = 28000,
                                   InventoryId = 60001
                               },
                               new Car
                               {
                                   CarId = 147,
                                   Make = "Ford",
                                   Model = "F-150",
                                   Year = 2023,
                                   Trim = "XLT",
                                   Price = 45000,
                                   InventoryId = 60001
                               },
                               new Car
                               {
                                   CarId = 148,
                                   Make = "Mazda",
                                   Model = "CX-5",
                                   Year = 2023,
                                   Trim = "S",
                                   Price = 51000,
                                   InventoryId = 60001
                               }
            );

        modelBuilder.Entity<Inventory>().HasData(
            new Inventory { InventoryId = 10001},
             new Inventory { InventoryId = 10002 },
            new Inventory { InventoryId = 10051},
            new Inventory { InventoryId = 10052 },
            new Inventory { InventoryId = 20001 },
            new Inventory { InventoryId = 20002},
            new Inventory { InventoryId = 30001},
            new Inventory { InventoryId = 30002 },
            new Inventory { InventoryId = 40001 },
            new Inventory {InventoryId = 40002},
            new Inventory { InventoryId = 50001 },
             new Inventory { InventoryId = 50002 },
            new Inventory { InventoryId = 60001 }
            );
    }

}
