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

    public async Task<Car> GetCarById(int carId)
    {
        return await _carInventoryDbContext.Cars.FirstOrDefaultAsync(car => car.CarId == carId);
    }

    public async Task<IEnumerable<Car>> GetAllCars()
    {
        return await _carInventoryDbContext.Cars.ToListAsync();
    }

    public async Task<IEnumerable<Car>> GetCarsByMake(string carMake)
    {
        string carMakeTemp = carMake.ToLower();
        return await _carInventoryDbContext.Cars.Where(car => car.Make.ToLower().Equals(carMakeTemp)).ToListAsync();
    }

    public async Task<IEnumerable<Car>> GetCarsByModel(string carModel)
    {
        string carModelTemp = carModel.ToLower();
        return await _carInventoryDbContext.Cars.Where(car => car.Model.ToLower().Equals(carModelTemp)).ToListAsync();   
    }

    public async Task<IEnumerable<Car>> GetCarsByPriceBelow(decimal maximumPrice)
    {
        return await _carInventoryDbContext.Cars.Where(car => car.Price <= maximumPrice).ToListAsync();

    }

    public async Task<IEnumerable<Car>> GetCarsByPriceAbove(decimal minimumPrice)
    {
        return await _carInventoryDbContext.Cars.Where(car => car.Price >= minimumPrice).ToListAsync(); 
    }

	public async Task<IEnumerable<Car>> GetCarsByPriceRange(decimal minimumPrice, decimal maximumPrice)
	{
		return await _carInventoryDbContext.Cars.Where(car => car.Price >= minimumPrice && car.Price <= maximumPrice).ToListAsync();
	}

	public async Task<IEnumerable<Car>> GetCarsByYear(int year)
    {
        return await _carInventoryDbContext.Cars.Where(car => car.Year == year).ToListAsync();
    }

    public async Task<IEnumerable<Car>> GetCarsByInventoryId(int inventoryid)
    {
        return await _carInventoryDbContext.Cars.Where(car => car.InventoryId == inventoryid).ToListAsync();
    }

    public async Task<Car> AddCar(Car car)
    {
        var addedEntity = await _carInventoryDbContext.Cars.AddAsync(car);
        await _carInventoryDbContext.SaveChangesAsync();
        return addedEntity.Entity;

    }

    public async Task<Car> UpdateCar(Car car)
    {
        var foundCar = await _carInventoryDbContext.Cars.FirstOrDefaultAsync(c => c.CarId == car.CarId);

        if (foundCar != null)
        {
            foundCar.InventoryId = car.InventoryId;
            foundCar.Make = car.Make;
            foundCar.Model = car.Model;
            foundCar.Price = car.Price;
            foundCar.Year = car.Year;

            await _carInventoryDbContext.SaveChangesAsync();
            return foundCar;
        }
        return null;
    }

    public async Task DeleteCar(int carId)
    {
        var foundCar = await _carInventoryDbContext.Cars.FirstOrDefaultAsync(c => c.CarId == carId);

        if (foundCar == null) return;
        _carInventoryDbContext.Cars.Remove(foundCar);
        await _carInventoryDbContext.SaveChangesAsync();
    }

    public void Dispose()
    {
        _carInventoryDbContext?.Dispose();
    }

   
}
