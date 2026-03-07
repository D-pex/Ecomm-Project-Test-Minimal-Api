using Microsoft.EntityFrameworkCore; 
namespace Ecommerce.Persistence;

public sealed class AppDbContext(DbContextOptions  options ) : DbContext(options) 
{
    public DbSet<Users> Users { get; set; }
    public DbSet<OrderItems> OrderItems { get; set; }
    public DbSet<Orders> Orders { get; set; }
    public DbSet<Categories> Categories { get; set; }
    public DbSet<Products> Products { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
         var t = typeof(AppDbContext);
         modelBuilder.ApplyConfigurationsFromAssembly(t.Assembly);
         base.OnModelCreating(modelBuilder);
    }
}