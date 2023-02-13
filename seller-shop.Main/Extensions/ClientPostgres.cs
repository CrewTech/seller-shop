using Microsoft.EntityFrameworkCore;
using seller_shop.Data.Context;
using seller_shop.Main.ProjectCfg;

namespace seller_shop.Main.Extensions;

public static class ClientPostgres
{
    public static void AddClientPostgreSql(this IServiceCollection services, ProjectConfigurations configurations)
    {
        string connectionString = configurations.ConnectionStringPsql;

        services.AddDbContext<SellerDbContext>(options => options.UseNpgsql(connectionString));
    }
}
