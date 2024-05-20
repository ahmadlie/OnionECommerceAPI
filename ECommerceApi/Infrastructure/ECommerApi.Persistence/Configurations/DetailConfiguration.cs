using ECommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommerApi.Persistence.Configurations;
public class DetailConfiguration : IEntityTypeConfiguration<Detail>
{
    public void Configure(EntityTypeBuilder<Detail> builder)
    {
        builder.Property(d => d.Title)
               .IsRequired()
               .HasMaxLength(30);

        builder.Property(d => d.Description)
               .IsRequired()
               .HasMaxLength(256);

        builder.HasOne(d => d.Product)
               .WithMany(d => d.Details);
    }
}
