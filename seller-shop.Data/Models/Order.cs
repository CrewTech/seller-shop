using System.ComponentModel.DataAnnotations;
using seller_shop.Data.Models.Identity;

namespace seller_shop.Data.Models;

public class Order
{
    public Guid Id { get; set; }
    public Guid ApplicationUserId { get; set; }
    public Guid ShippingMethodId { get; set; }

    [Required]
    public DateTime DateAndTime { get; set; }

    [StringLength(400)]
    public string Note { get; set; } = null!;

    public decimal ShippingMethodPrice { get; set; }

    public User ApplicationUser { get; set; } = null!;

    public ICollection<OrderDetail> Details { get; set; } = null!;
    public ICollection<Invoice> Invoices { get; set; } = null!;
}
