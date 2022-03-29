using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductManager.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManager.Infra.SQLRepository.Mappings
{
    public class BuyMapping : IEntityTypeConfiguration<Buy>
    {
        public void Configure(EntityTypeBuilder<Buy> builder)
        {
            builder
                .HasOne(b=> b.Client)
                .WithMany()
                .HasForeignKey(b=>b.ClientId)
                .IsRequired();

            builder
                .HasMany(b => b.BuyItens)
                .WithOne(bi => bi.Buy);
        }
    }
}
