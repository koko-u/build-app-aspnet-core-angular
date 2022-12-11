using Dating.Db.Entities;
using Microsoft.EntityFrameworkCore;

namespace Dating.Db.Data;

public class AppDbContext : DbContext
{
    public DbSet<AppUser> Users => Set<AppUser>();

    public AppDbContext(DbContextOptions<AppDbContext> options)
       : base(options)
    {
    }
}
