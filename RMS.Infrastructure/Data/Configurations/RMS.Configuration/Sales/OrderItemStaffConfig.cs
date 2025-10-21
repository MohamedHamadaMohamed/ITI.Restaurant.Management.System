using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RMS.Domain.Models.Sales;

namespace RMS.Infrastructure.Data.Configurations.RMS.Configuration.Sales
{
    public class OrderItemStaffConfig : IEntityTypeConfiguration<OrderItemStaff>
    {
        public void Configure(EntityTypeBuilder<OrderItemStaff> builder)
        {
            builder.HasKey(orderStaff => new { orderStaff.StaffId, orderStaff.OrderItemId });

            builder.HasOne(orderStaff => orderStaff.Staff)
                .WithMany(staff => staff.OrderItemStaffs)
                .HasForeignKey(OrderItem => OrderItem.StaffId);

            builder.HasOne(orderStaff => orderStaff.OrderItem)
                .WithMany(orderItem => orderItem.OrderItemStaffs)
                .HasForeignKey(OrderItem => OrderItem.OrderItemId);
            builder.ToTable("OrderItemStaffs", "Sales");

        }
    }
}
