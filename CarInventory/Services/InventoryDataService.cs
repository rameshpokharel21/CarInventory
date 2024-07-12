using CarInventory.Models;
using CarInventory.Repositories;

namespace CarInventory.Services;

public class InventoryDataService : IInventoryDataService
{
    private readonly IInventoryRepository _inventoryRepository;

    public InventoryDataService(IInventoryRepository inventoryRepository)
    {
        _inventoryRepository = inventoryRepository;
    }
    public async Task<IEnumerable<Inventory>> GetAllInventories()
    {
       return await _inventoryRepository.GetAllInventories();
    }

    public async Task<Car> GetCarsByInventoryId(int inventoryId)
    {
        return await _inventoryRepository.GetCarsByInventoryId(inventoryId);
    }
}
