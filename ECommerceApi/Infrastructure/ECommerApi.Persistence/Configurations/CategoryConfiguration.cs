using ECommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommerApi.Persistence.Configurations;
public class CategoryConfiguration : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.HasData(new Category()
        {
            Id = 1,
            Name = "Electronics",
            ParentId = 0,
            Priority = 1,
        }, new Category()
        {
            Id = 2,
            Name = "Moda",
            ParentId = 0,
            Priority = 1,
        }, new Category()
        {
            Id = 3,
            Name = "LapTop",
            ParentId = 1,
            Priority = 1,
        }, new Category()
        {
            Id = 4,
            Name = "Kadin",
            ParentId = 2,
            Priority = 1,
        });
    }
}
