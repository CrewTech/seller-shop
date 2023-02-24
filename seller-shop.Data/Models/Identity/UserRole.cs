using Microsoft.AspNetCore.Identity;

namespace seller_shop.Data.Models.Identity;

/// <summary>
/// Сущность для связи Пользователя и Роли
/// </summary>
public class UserRole : IdentityUserRole<Guid>
{
    public Guid Id { get; set; } = Guid.NewGuid();

    public User? User { get; set; }
    public Role? Role { get; set; }
}