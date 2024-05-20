using ECommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommerApi.Persistence.Configurations;
public class BrandConfiguration : IEntityTypeConfiguration<Brand>
{
    public void Configure(EntityTypeBuilder<Brand> builder)
    {
        builder.Property(b => b.Name).IsRequired().HasMaxLength(100);
        builder.HasData(new Brand()
        {
            CreatedDate = DateTime.Now,
            Id = 1,
            IsDeleted = false,
            Name = "Asus",
        }, 
        new Brand() 
        {
            CreatedDate = DateTime.Now,
            Id = 2,
            IsDeleted = false,
            Name = "Lenovo"
        }); ;
    }
}
