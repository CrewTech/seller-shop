using System.ComponentModel.DataAnnotations;

namespace seller_shop.Data.Models.Identity;

public class UserDetail
{
    public Guid Id { get; set; }

    public string ApplicationUserID { get; set; } = null!;

    [Required]
    [StringLength(128)]
    public string Name { get; set; } = null!;

    [Required]
    [StringLength(200)]
    public string Surname { get; set; } = null!;

    [StringLength(200)]
    public string Address1 { get; set; } = null!;

    [StringLength(200)]
    public string Address2 { get; set; } = null!;

    [StringLength(200)]
    public string Address3 { get; set; } = null!;

    public User ApplicationUser { get; set; } = null!;
}