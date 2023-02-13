using Microsoft.AspNetCore.Identity;

namespace seller_shop.Data.Models;

public class User : IdentityUser<Guid>
{
    public string FullName { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;

    public DateTimeOffset? UserExpitation { get; set; }

    public ICollection<UserRole> UserRole { get; set; } = new HashSet<UserRole>();
    public ICollection<UserClaim> UserClaims { get; set; } = new HashSet<UserClaim>();
    public ICollection<UserDetail> Details { get; set; } = default!;
    public ICollection<Review> Reviews { get; set; } = default!;
    public ICollection<Invoice> Invoices { get; set; } = default!;
}
