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
    public class ClinetMapping : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.Property(c=> c.Name)
                .IsRequired()
                .HasMaxLength(20);

            builder.Property(c => c.Cpf)
                .IsRequired()
                .HasColumnType("VARCHAR")
                .HasMaxLength(14);
        }
    }
}
