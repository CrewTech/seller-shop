using System.ComponentModel.DataAnnotations;

namespace seller_shop.Data.Models;

public class Producer
{
    public Guid Id { get; set; }

    [Required]
    [StringLength(200)]
    public string Name { get; set; } = null!;

    public ICollection<ProducerDetail> Details = null!;
}
