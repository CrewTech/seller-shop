using Microsoft.EntityFrameworkCore;
using seller_shop.Data.Models;

namespace seller_shop.Data.Context;

public class SellerDbContext : IdentitySellerDbContext
{
    public DbSet<Category> Categories { get; set; } 
    public DbSet<SubCategory> SubCategories { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Discount> Discounties { get; set; }
    public DbSet<Producer> Producers { get; set; }
    public DbSet<ProducerDetail> ProducerDetails { get; set; }
    public DbSet<Review> Reviews { get; set; }

    public SellerDbContext(DbContextOptions<DbContext> options) : base(options)
    {

    }
}
