namespace seller_shop.Data.Models;

/// <summary>
/// Сущность представляет категории товара
/// </summary>
public class Category
{
    public Guid Id { get; set; }
    public ICollection<SubCategory>? SubCategories { get; set; }
}
