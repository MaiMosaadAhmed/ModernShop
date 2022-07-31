using Entity.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Configuration
{
    internal class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product
                {
                    Id = 1,
                    Name = "Brand: Premoda",
                    BrandId = 1,
                    CategoryId = 9,
                    Description = "Premoda womens V-Neck Jaquard Pullover Pullover Sweater",
                    Rate = 4.5
                }
                );
        }
    }
}