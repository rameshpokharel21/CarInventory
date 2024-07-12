namespace CarInventory.Models;

public class Inventory
{
    public int InventoryId { get; set; }
    public IEnumerable<Car> Cars { get; set; } = new List<Car>();
    
}
