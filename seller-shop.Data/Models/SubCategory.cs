using System.ComponentModel.DataAnnotations;

namespace seller_shop.Data.Models;

/// <summary>
/// подкатегории товара
/// </summary>
public class SubCategory
{
    public Guid Id { get; set; }
    public Guid CategoryID { get; set; }

    [Required]
    [StringLength(200)]
    public string Name { get; set; } = null!;

    public Category Category { get; set; } = null!;
}