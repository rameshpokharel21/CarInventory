namespace CarInventory.Models;

public class Inventory
{
    public int InventoryId { get; set; }
    public List<Car> Cars { get; set; } = new List<Car>();
    
}
