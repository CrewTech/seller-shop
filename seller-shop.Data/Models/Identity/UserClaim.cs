using Microsoft.AspNetCore.Identity;

namespace seller_shop.Data.Models.Identity;

public class UserClaim : IdentityUserClaim<Guid>
{
    public new Guid Id { get; set; } = Guid.NewGuid();
    public User? User { get; set; }
}
