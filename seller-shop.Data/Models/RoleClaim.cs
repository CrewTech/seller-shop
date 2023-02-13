using Microsoft.AspNetCore.Identity;

namespace seller_shop.Data.Models;

public class RoleClaim : IdentityRoleClaim<Guid>
{
    public new Guid Id { get; set; } = Guid.NewGuid();
    public Role? Role { get; set; }
}
