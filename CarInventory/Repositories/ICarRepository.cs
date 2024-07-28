using CarInventory.Models;

namespace CarInventory.Repositories;

public interface ICarRepository
{
    Task<Car> GetCarById(int carId);
    Task<IEnumerable<Car>> GetAllCars();
    Task<IEnumerable<Car>> GetCarsByMake(string carMake);
    Task<IEnumerable<Car>> GetCarsByModel(string carModel);
    Task<IEnumerable<Car>> GetCarsByYear(int year);
    Task<IEnumerable<Car>> GetCarsByInventoryId(int inventoryid);
    Task<IEnumerable<Car>> GetCarsByPriceBelow(decimal maximumPrice);
    Task<IEnumerable<Car>> GetCarsByPriceAbove(decimal minimumPrice);
    Task<IEnumerable<Car>> GetCarsByPriceRange(decimal minimumPrice, decimal maximumPrice);

	Task<Car> AddCar(Car car);
    Task<Car> UpdateCar(Car car);
    Task DeleteCar(int carId);

}