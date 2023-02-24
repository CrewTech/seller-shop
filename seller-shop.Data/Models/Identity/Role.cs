using Microsoft.AspNetCore.Identity;

namespace seller_shop.Data.Models.Identity;

public class Role : IdentityRole<Guid>
{
    public new Guid Id { get; set; }
    public Role? UserRole { get; set; }

    public ICollection<RoleClaim> RoleClaims { get; set; } = new HashSet<RoleClaim>();
    public ICollection<UserRole> UserRoles { get; set; } = new HashSet<UserRole>();

}
