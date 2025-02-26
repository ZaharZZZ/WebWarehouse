using Microsoft.EntityFrameworkCore;
using WebWarehouse.Model;

namespace WebWarehouse.Data
{
    public class ApplicationDbContext : DbContext
    {
        
            public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
               : base(options)
            {
                Database.Migrate();
            }

            public DbSet<Category> categories { get; set; } 
            public DbSet<Product> products { get; set; } 
            public DbSet<Suppliers> suppliers { get; set; } 
            public DbSet<Warehouse> warehouses { get; set; } 
        
    }
}
