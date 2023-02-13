using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using seller_shop.Data.Models;

namespace seller_shop.Data.Context;

/// <summary>
/// контекст бд
/// </summary>
public abstract class IdentitySellerDbContext : IdentityDbContext<User, Role, Guid, UserClaim, UserRole, IdentityUserLogin<Guid>, RoleClaim, IdentityUserToken<Guid>>
{
    public DbSet<UserDetail> UserDetails { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderDetail> OrderDetails { get; set; }
    public DbSet<Invoice> Invoicies { get; set; }
    public DbSet<InvoiceDetail> InvoiceDetailes { get; set; }

    public IdentitySellerDbContext(DbContextOptions<DbContext> options) : base(options)
    {

    }
}
