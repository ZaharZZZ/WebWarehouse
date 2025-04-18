﻿using Microsoft.EntityFrameworkCore;
using WebWarehouse.Model;
using WebWarehouse.Model.AuthApp;

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
            public DbSet<Сounterparty> suppliers { get; set; } 
            public DbSet<Warehouse> warehouses { get; set; }
            public DbSet<AuthUser> AuthUsers { get; set; }

    }
}
