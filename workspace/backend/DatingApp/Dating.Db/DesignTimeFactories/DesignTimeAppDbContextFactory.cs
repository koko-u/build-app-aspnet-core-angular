using Dating.Config;
using Dating.Db.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Dating.Db.DesignTimeFactories;

public class DesignTimeAppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
{
    public AppDbContext CreateDbContext(string[] args)
    {
        var builder = new DbContextOptionsBuilder<AppDbContext>()
            .UseSqlServer(ConnectionStrings.Default);

        return new AppDbContext(builder.Options);
    }
}
