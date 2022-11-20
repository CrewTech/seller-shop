using seller_shop.Main.ProjectCfg;

namespace seller_shop.Main.Extensions;

public static class ClientPostgres
{
    public static void AddClientPostgress(this IServiceCollection services, ProjectConfigurations configurations)
    {
        string connectionString = configurations.ConnectionStringPsql;
        ;
    }
}
