using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductManager.Domain.Entities;

namespace ProductManager.Infra.SQLRepository.Mappings
{
    public class BuyItenMapping : IEntityTypeConfiguration<BuyIten>
    {
        public void Configure(EntityTypeBuilder<BuyIten> builder)
        {
            builder
                .HasOne(bi => bi.Buy)
                .WithMany()
                .HasForeignKey(bi => bi.BuyId)
                .IsRequired();

            builder
                .HasOne(bi => bi.Product)
                .WithOne()
                .HasForeignKey<BuyIten>(bi => bi.ProductId)
                .IsRequired();

            builder
                .Property(bi=> bi.Quantity)
                .IsRequired();
        }
    }
}
