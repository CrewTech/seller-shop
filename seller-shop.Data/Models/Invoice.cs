using System.ComponentModel.DataAnnotations;

namespace seller_shop.Data.Models;

public class Invoice
{
    public Guid Id { get; set; }
    public Guid ApplicationUserId { get; set; }
    public Guid OrderId { get; set; }

    public decimal TotalValue { get; set; }

    [Required]
    public DateTime DateIssued { get; set; }

    public User ApplicationUser { get; set; } = null!;
    public Order Order { get; set; } = null!;

    public ICollection<InvoiceDetail> Details { get; set; } = null!;
}
