using CarInventory.Data;
using CarInventory.Models;
using Microsoft.EntityFrameworkCore;

namespace CarInventory.Repositories;

public class CarRepository : ICarRepository, IDisposable
{
    private readonly CarInventoryDbContext _carInventoryDbContext;
    public CarRepository(IDbContextFactory<CarInventoryDbContext> DbFactory)
    {
        _carInventoryDbContext = DbFactory.CreateDbContext();
    }

    

    public async Task<IEnumerable<Car>> GetCarsByMake(string carMake)
    {
        return await _carInventoryDbContext.Cars.Where(car => car.Make.Equals(carMake)).ToListAsync();
    }

    public async Task<IEnumerable<Car>> GetCarsByModel(string carModel)
    {
        return await _carInventoryDbContext.Cars.Where(car => car.Model.Equals(carModel)).ToListAsync();   
    }

    public async Task<IEnumerable<Car>> GetCarsByPriceBelow(decimal maximumPrice)
    {
        return await _carInventoryDbContext.Cars.Where(car => car.Price <= maximumPrice).ToListAsync();

    }

    public async Task<IEnumerable<Car>> GetCarsByPriceAbove(decimal minimumPrice)
    {
        return await _carInventoryDbContext.Cars.Where(car => car.Price >= minimumPrice).ToListAsync(); 
    }

   

    public async Task<IEnumerable<Car>> GetCarsByYear(int year)
    {
        return await _carInventoryDbContext.Cars.Where(car => car.Year == year).ToListAsync();
    }

    public async Task<Car> AddCar(Car car)
    {
        var addedEntity = await _carInventoryDbContext.Cars.AddAsync(car);
        await _carInventoryDbContext.SaveChangesAsync();
        return addedEntity.Entity;

    }

    public void Dispose()
    {
        _carInventoryDbContext?.Dispose();
    }
}
