using Ambev.DeveloperEvaluation.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ambev.DeveloperEvaluation.ORM.Mapping
{
    public class SaleConfiguration : IEntityTypeConfiguration<Sale>
    {
        public void Configure(EntityTypeBuilder<Sale> builder)
        {
            builder.ToTable("Sales");

            builder.HasKey(u => u.Id);
            builder.Property(u => u.Id).HasColumnType("uuid").HasDefaultValueSql("gen_random_uuid()");

            builder.Property(u => u.Branch).IsRequired().HasMaxLength(50);
            builder.Property(u => u.CustomerId).IsRequired().HasMaxLength(36);
            builder.Property(u => u.OrderSale).IsRequired();

            builder.HasOne(p => p.Customer)
                   .WithOne(u => u.Sale)
                   .HasForeignKey<Customers>(p => p.Id);

            builder.Property(u => u.Status)
                .HasConversion<string>()
                .HasMaxLength(20);
        }
    }
}
