using System.ComponentModel.DataAnnotations;

namespace SixteenClothings.ViewModels;

public class ProductCreateVM
{
    [Required, MinLength(3), MaxLength(256)]
    public string Name { get; set; } = string.Empty;
    [Required, MinLength(3), MaxLength(1024)]
    public string Description { get; set; } = string.Empty;
    [Required, Range(0,10000000)]
    public decimal Price { get; set; }
    [Required, Range(0,5)]
    public int Rating { get; set; }
    [Required]
    public int CategoryId { get; set; }
    [Required]
    public IFormFile Image { get; set; }
}