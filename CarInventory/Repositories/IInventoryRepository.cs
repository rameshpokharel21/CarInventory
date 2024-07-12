using CarInventory.Models;

namespace CarInventory.Repositories;

public interface IInventoryRepository
{

    Task<IEnumerable<Inventory>> GetAllInventories();
    Task<Car> GetCarsByInventoryId(int inventoryId);
}