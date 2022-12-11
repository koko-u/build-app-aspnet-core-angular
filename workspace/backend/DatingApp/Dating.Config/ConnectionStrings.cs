using Microsoft.Extensions.Configuration;

namespace Dating.Config;

public sealed class ConnectionStrings
{
    private static readonly IConfiguration _configuration;

    public static string Default => _configuration.GetConnectionString("Default");

    static ConnectionStrings()
    {
        var basePath = Path.GetDirectoryName(typeof(ConnectionStrings).Assembly.Location);

        var builder = new ConfigurationBuilder()
                    .SetBasePath(basePath)
                    .AddJsonFile("dbsettings.json")
                    .AddUserSecrets<ConnectionStrings>(optional: true)
                    .AddEnvironmentVariables();

        _configuration = builder.Build();
    }
}
