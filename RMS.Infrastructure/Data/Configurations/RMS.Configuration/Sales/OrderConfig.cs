using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RMS.Domain.Constants;
using RMS.Domain.Models.Sales;

namespace RMS.Infrastructure.Data.Configurations.RMS.Configuration.Sales
{
    public class OrderConfig : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
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


            var statusConverter = new ValueConverter<OrderStatus, string>(
                Status => Status.Value,
                Value => new OrderStatus(Value)
                );

            builder.Property(o=>o.status)
                .HasConversion(statusConverter)
                .HasDefaultValue(OrderStatus.Pending)
                .HasMaxLength(30);

            var paymentConerter = new ValueConverter<Payment, string>(
                Payment => Payment.Value,
                Value => new Payment(Value)
                );
            builder.Property(o => o.Payment)
                .HasConversion(paymentConerter)
                .HasMaxLength(30)
                .HasDefaultValue(Payment.Cash);

            builder.HasOne(o => o.Client)
                  .WithMany(c => c.Orders)
                  .HasForeignKey(o => o.CLientId);
            builder.HasMany(o => o.OrderItems)
                .WithOne(oi => oi.Order)
                .HasForeignKey(oi => oi.OrderId);

            builder.ToTable("Orders", "Sales");

        }
    }
}
