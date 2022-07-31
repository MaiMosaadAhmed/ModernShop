using Entity.Core;
using Entity.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Entity.Configuration
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category
                {
                    Id = 1,
                    Name = "woman's Fashion"
                },
                new Category
                {
                    Id = 2,
                    Name = "Man's Fashion"
                },
                new Category
                {
                    Id = 3,
                    Name = "Kids's Fashion"
                },
                new Category
                {
                    Id = 4,
                    Name = "Furniture"
                },
                new Category
                {
                    Id = 5,
                    Name = "Clothing",
                    ParentId = 1
                },
                new Category
                {
                    Id = 6,
                    Name = "Jewelry",
                    ParentId = 1
                },
                 new Category
                 {
                     Id = 7,
                     Name = "Clothing",
                     ParentId = 2
                 },
                new Category
                {
                    Id = 8,
                    Name = "Shoes",
                    ParentId = 2
                }
                ,
                 new Category
                 {
                     Id = 9,
                     Name = "T-shirt",
                     ParentId = 5
                 }
                );
        }
    }
}