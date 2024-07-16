using CarInventory.Models;

namespace CarInventory.Services;

public interface ICarDataService
{
    Task<Car> GetCarById(int carId);
    Task<IEnumerable<Car>> GetCarsByMake(string carMake);
    Task<IEnumerable<Car>> GetCarsByModel(string carModel);
    Task<IEnumerable<Car>> GetCarsByYear(int year);
    Task<IEnumerable<Car>> GetCarsByPriceBelow(decimal maximumPrice);
    Task<IEnumerable<Car>> GetCarsByPriceAbove(decimal minimumPrice);
    Task<Car> AddCar(Car car);
    Task UpdateCar(Car car);
    Task DeleteCar(int carId);
}