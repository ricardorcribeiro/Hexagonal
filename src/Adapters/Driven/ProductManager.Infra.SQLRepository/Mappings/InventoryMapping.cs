using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductManager.Domain.Entities;

namespace ProductManager.Infra.SQLRepository.Mappings
{
    internal class InventoryMapping : IEntityTypeConfiguration<Inventory>
    {
        public void Configure(EntityTypeBuilder<Inventory> builder)
        {
            builder
                .HasOne(i => i.Product)
                .WithOne()
                .HasForeignKey<Inventory>(i => i.ProductId)
                .IsRequired();

            builder
                .Property(i => i.Amount)
                .IsRequired();
        }
    }
}
