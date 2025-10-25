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
    public class OrderItemConfig : BaseEntityConfig<OrderItem, int>
    {
        public override void Configure(EntityTypeBuilder<OrderItem> builder)
        {
            base.Configure(builder);

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
