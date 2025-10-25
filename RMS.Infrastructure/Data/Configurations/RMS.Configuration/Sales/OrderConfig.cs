using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RMS.Domain.Constants;
using RMS.Domain.Models.Sales;

namespace RMS.Infrastructure.Data.Configurations.RMS.Configuration.Sales
{
    public class OrderConfig : BaseEntityConfig<Order, int>
    {
        public override void Configure(EntityTypeBuilder<Order> builder)
        {
            base.Configure(builder);


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
