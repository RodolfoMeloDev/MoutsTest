using Ambev.DeveloperEvaluation.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ambev.DeveloperEvaluation.ORM.Mapping
{
    public class SaleItensConfiguration : IEntityTypeConfiguration<SaleItens>
    {
        public void Configure(EntityTypeBuilder<SaleItens> builder)
        {
            builder.ToTable("SalesItens");

            builder.HasKey(u => u.Id);
            builder.Property(u => u.Id).UseIdentityColumn();

            builder.Property(u => u.ProductId).IsRequired().HasMaxLength(36);
            builder.Property(u => u.Quantities).IsRequired();
            builder.Property(u => u.UnitPrice).IsRequired();
            builder.Property(u => u.TotalPrice).IsRequired();

            builder.HasOne(p => p.Sale)
                   .WithMany(u => u.Itens)
                   .HasForeignKey(o => o.SaleId);

            builder.HasOne(p => p.Product)
                   .WithOne(u => u.SaleItens)
                   .HasForeignKey<SaleItens>(o => o.SaleId);
        }
    }
}
