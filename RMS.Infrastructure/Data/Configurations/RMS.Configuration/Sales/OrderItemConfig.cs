using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RMS.Domain.Models.Sales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Infrastructure.Data.Configurations.RMS.Configuration.Sales
{
    public class OrderItemConfig : IEntityTypeConfiguration<OrderItem>
    {
        public void Configure(EntityTypeBuilder<OrderItem> builder)
        {
            builder.HasKey(o => o.Id);
            builder.Property(o => o.CreatedBy)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(o => o.UpdatedBy)
                .HasMaxLength(50);
            builder.Property(o => o.DeletedBy)
                .HasMaxLength(50);
            builder.Property(o => o.CreatedAt)
                ;

            builder.HasOne(oi => oi.Order)
                .WithMany(o => o.OrderItems)
                .HasForeignKey(oi => oi.Id);
            builder.HasOne(oi =>oi.MenuItem)
                .WithMany(m =>m.OrderItems)
                .HasForeignKey(oi => oi.OrderId);


            builder.ToTable("OrderItems", "Sales");

        }
    }
}
