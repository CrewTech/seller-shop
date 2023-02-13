using System.ComponentModel.DataAnnotations;

namespace seller_shop.Data.Models;

/// <summary>
/// Сущность скидки
/// </summary>
public class Discount
{
    public Guid Id { get; set; }

    public Guid ProductID { get; set; }

    [Required]
    public decimal Percentage { get; set; }

    public DateTime StartTime { get; set; }

    [Required]
    public DateTime EndTime { get; set; }

    public Product Product { get; set; } = null!;
}
