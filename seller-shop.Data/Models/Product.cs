using System.ComponentModel.DataAnnotations;

namespace seller_shop.Data.Models;

/// <summary>
/// Продуктовая сущность
/// </summary>
public class Product
{
    public Guid Id { get; set; }
    public Guid ProducerId { get; set; }
    public Guid CategoryId { get; set; }
    public Guid SubcategoryId { get; set; }

    /// <summary>
    /// Название продукта
    /// </summary>
    [Required]
    [StringLength(200)]
    public string Name { get; set; } = null!;

    /// <summary>
    /// Стоимость продукта
    /// </summary>
    [Required]
    public decimal Price { get; set; }

    /// <summary>
    /// Кол-во товара на складе
    /// </summary>
    [Required]
    internal int QuantityOnStock { get; set; }

    internal Producer Producer { get; set; } = null!;
    internal Category Category { get; set; } = null!;
    internal SubCategory SubCategory { get; set; } = null!;
    internal ICollection<Review> Reviews { get; set; } = null!;
    internal ICollection<Discount> Discounts { get; set; } = null!;
}
