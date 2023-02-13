namespace seller_shop.Data.Models;

public class InvoiceDetail
{
    public Guid Id { get; set; }
    public Guid InvoiceId { get; set; }
    public Guid ProductId { get; set; }

    public int ItemQuantity { get; set; }

    public decimal ItemPrice { get; set; }

    public Invoice Invoice { get; set; } = null!;
    public Product Product { get; set; } = null!;
}