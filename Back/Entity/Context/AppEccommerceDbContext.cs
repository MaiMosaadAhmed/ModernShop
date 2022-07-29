using System;
using Entity.Core;
using Entity.Core.authentication;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace Entity.Context
{
    public class AppEccommerceDbContext : IdentityDbContext<userIdentity,roleIdentity,int>
    {
        public AppEccommerceDbContext(DbContextOptions<AppEccommerceDbContext> options):base(options)
        {
            
        }
    protected  override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        // modelBuilder.ApplyConfiguration(new AddressBookConfiguration());
    }

    }
}