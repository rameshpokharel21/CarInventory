using CarInventory.Data;
using CarInventory.Models;
using Microsoft.EntityFrameworkCore;

namespace CarInventory.Repositories;

public class InventoryRepository : IInventoryRepository, IDisposable
{

    private readonly CarInventoryDbContext _carInventoryDbContext;

    public InventoryRepository(IDbContextFactory<CarInventoryDbContext> DbFactory)
    {
        _carInventoryDbContext = DbFactory.CreateDbContext();
    }

    public async Task<IEnumerable<Inventory>> GetAllInventories()
    {
        return await _carInventoryDbContext.Inventories.Include(inv => inv.Cars).ToListAsync();
    }

    //if not found returns null
    public async Task<Car> GetCarsByInventoryId(int inventoryId)
    {
       return await _carInventoryDbContext.Cars.FirstOrDefaultAsync(inv => inv.InventoryId == inventoryId);
    }

    public void Dispose()
    {
        _carInventoryDbContext?.Dispose();
    }
}
