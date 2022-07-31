using System;
using Entity.Configuration;
using Entity.Core;
using Entity.Core.authentication;
using Entity.Core.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Entity.Context
{
    public class AppEccommerceDbContext : IdentityDbContext<userIdentity, roleIdentity, int>
    {
        public AppEccommerceDbContext(DbContextOptions<AppEccommerceDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new BrandConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
        }

        public DbSet<Category> categories { get; set; }
        public DbSet<Brand> brands { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<Stock> stocks { get; set; }
    }
}