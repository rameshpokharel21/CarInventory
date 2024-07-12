using CarInventory.Models;

namespace CarInventory.Services;

public interface IInventoryDataService
{
    
    Task<IEnumerable<Inventory>> GetAllInventories();
    Task<Car> GetCarsByInventoryId(int inventoryId);
}