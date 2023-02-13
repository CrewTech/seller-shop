using System.ComponentModel.DataAnnotations;

namespace seller_shop.Data.Models;

public class Review
{
    public Guid Id { get; set; }
    public Guid ApplicationUserId { get; set; }
    public Guid ProductId { get; set; }

    [Required]
    [Range(1, 6)]
    public int Rating { get; set; }

    [Required]
    [StringLength(1024)]
    public string Content { get; set; } = string.Empty;

    public User ApplicationUser { get; set; } = null!;
    public Product Product { get; set; } = null!;
}
