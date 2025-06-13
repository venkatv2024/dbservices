using Microsoft.EntityFrameworkCore;

namespace DBServices.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        // Define DbSets for your tables, e.g.:
        // public DbSet<YourEntity> YourEntities { get; set; }
    }
}
