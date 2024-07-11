using System.ComponentModel.DataAnnotations;

namespace CarInventory.Models;

public class Car
{
    public int CarId { get; set; }

    [Required]
    [StringLength(20)]
    public string Make { get; set; } = string.Empty;

    [Required]
    [StringLength(20)]
    public string Model { get; set; } = string.Empty;

    [Required]
    public decimal Price { get; set;} = decimal.Zero;

    [Required]
    public int Year { get; set; }

    public string? Trim { get; set; } = string.Empty;

    public Inventory? Inventory { get; set; }
    public int InventoryId { get; set; }
}
