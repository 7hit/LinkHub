using LinkHub.Api.Entities;
using LinkHub.Core.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LinkHub.Api.Database;

public class AppDbContext(DbContextOptions<AppDbContext> options)
    : IdentityDbContext<AppUser, AppRole, Guid>(options)
{
    public DbSet<Device> Devices { get; set; }
    public DbSet<Block> Blocks { get; set; }
    public DbSet<DeviceOptions> DeviceOptions { get; set; }
    public DbSet<Flow> Flows { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // TODO: Add database configuration
        optionsBuilder.UseSqlite("Data Source=lh-data.db");
    }
}