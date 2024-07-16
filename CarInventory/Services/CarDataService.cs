using CarInventory.Models;
using CarInventory.Repositories;

namespace CarInventory.Services;

public class CarDataService : ICarDataService

{
    private readonly ICarRepository _carRepository;

    public CarDataService(ICarRepository carRepository)
    {
        this._carRepository = carRepository;
    }

    public async Task<Car> GetCarById(int carId)
    {
        return await _carRepository.GetCarById(carId);
    }
    public async Task<IEnumerable<Car>> GetCarsByMake(string carMake)
    {
       return await _carRepository.GetCarsByMake(carMake);
    }

    public async Task<IEnumerable<Car>> GetCarsByModel(string carModel)
    {
        return await _carRepository.GetCarsByModel(carModel);
    }

    public async Task<IEnumerable<Car>> GetCarsByPriceAbove(decimal minimumPrice)
    {
       return await _carRepository.GetCarsByPriceAbove(minimumPrice);
    }

    public async Task<IEnumerable<Car>> GetCarsByPriceBelow(decimal maximumPrice)
    {
        return await _carRepository.GetCarsByPriceBelow(maximumPrice);
    }

    public async Task<IEnumerable<Car>> GetCarsByYear(int year)
    {
        return await _carRepository.GetCarsByYear(year);
    }

    public async Task<Car> AddCar(Car car)
    {
        return await _carRepository.AddCar(car);
    }

    public async Task UpdateCar(Car car)
    {
        await _carRepository.UpdateCar(car);
    }

    public async Task DeleteCar(int carId)
    {
        await _carRepository.DeleteCar(carId);
    }
}
