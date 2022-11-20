namespace seller_shop.Main.ProjectCfg;

/// <summary>
/// объект конфигурации проекта
/// </summary>
public class ProjectConfigurations
{
    private IConfiguration _configuration;

    public string HostPsql => GetEnvironmentVariable("Psql__Host");
    public string PortPsql => GetEnvironmentVariable("Psql__Port");
    public string DatabasePsql => GetEnvironmentVariable("Psql__Database");
    public string UserNamePsql => GetEnvironmentVariable("Psql__User");
    public string PasswordPsql => GetEnvironmentVariable("Psql__Password");
    public string ConnectionStringPsql => $"Server={HostPsql};Port={PortPsql};Database={DatabasePsql};User Id={UserNamePsql};Password={PasswordPsql};";

    public ProjectConfigurations(IConfiguration configuration)
    {
        _configuration = configuration;
    }
    public string GetEnvironmentVariable(string keyConfig)
    {
        //взять переменную или из Enviroment или из Convfiguration
        string? value = Environment.GetEnvironmentVariable(keyConfig);

        if(value is not null && string.IsNullOrEmpty(value))
        {
            // получаю из конфигурации
            value = _configuration.GetValue<string>(keyConfig);
        }

        if (value is null)
        {
            throw new KeyNotFoundException($"{keyConfig} не найден в конфигурации");
        }

        return value;
    }
}
