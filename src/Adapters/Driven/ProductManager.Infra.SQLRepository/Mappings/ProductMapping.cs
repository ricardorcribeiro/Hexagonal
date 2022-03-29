using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductManager.Domain.Entities;

namespace ProductManager.Infra.SQLRepository.Mappings;

public class ProductMapping : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.ToTable("Product");

        builder
            .Property(p => p.Name)
            .IsRequired(true)
            .HasMaxLength(50);
        
        builder
            .Property(p => p.Price)
            .IsRequired(true)
            .HasMaxLength(999999999);
    }
}