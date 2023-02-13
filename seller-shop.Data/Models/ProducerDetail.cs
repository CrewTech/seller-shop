using System.ComponentModel.DataAnnotations;

namespace seller_shop.Data.Models;

public class ProducerDetail
{
    public Guid Id { get; set; }

    public Guid ProducerId { get; set; }

    [StringLength(30)]
    public string PhoneNumber { get; set; } = null!;

    [StringLength(200)]
    public string Email { get; set; } = null!;

    [StringLength(200)]
    public string Address1 { get; set; } = null!;

    [StringLength(200)]
    public string Address2 { get; set; } = null!;

    [StringLength(200)]
    public string City { get; set; } = null!;

    [StringLength(200)] 
    public string Country { get; set; } = null!;

    public Producer Producer { get; set; } = null!;
}