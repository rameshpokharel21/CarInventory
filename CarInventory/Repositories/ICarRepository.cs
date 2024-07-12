using CarInventory.Models;

namespace CarInventory.Repositories;

public interface ICarRepository
{
    Task<IEnumerable<Car>> GetCarsByMake(string carMake);
    Task<IEnumerable<Car>> GetCarsByModel(string carModel);
    Task<IEnumerable<Car>> GetCarsByYear(int year);
    Task<IEnumerable<Car>> GetCarsByPriceBelow(decimal maximumPrice);
    Task<IEnumerable<Car>> GetCarsByPriceAbove(decimal minimumPrice);
    Task<Car> AddCar(Car car);

}