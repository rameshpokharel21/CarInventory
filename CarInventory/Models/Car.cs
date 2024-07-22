using System.ComponentModel.DataAnnotations;

namespace CarInventory.Models;

public class Car
{
    public int CarId { get; set; }

    [Required (ErrorMessage="Car make is required")]
    [StringLength(20, ErrorMessage ="Should be < 20")]
    public string Make { get; set; } = string.Empty;

    [Required(ErrorMessage ="Car model is required")]
    [StringLength(20, ErrorMessage = "Should be < 20")]
    public string Model { get; set; } = string.Empty;

    [Required(ErrorMessage ="Car Price is required")]
    public decimal Price { get; set;} = decimal.Zero;

    [Required(ErrorMessage ="Manufactured year is required.")]
    public int Year { get; set; }

    public string? Trim { get; set; } = string.Empty;

    public Inventory? Inventory { get; set; }
    public int InventoryId { get; set; }
}
