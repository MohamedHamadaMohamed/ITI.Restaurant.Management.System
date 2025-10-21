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
    public class StaffConfig : IEntityTypeConfiguration<Staff>
    {
        public void Configure(EntityTypeBuilder<Staff> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.CreatedBy)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(c => c.UpdatedBy)
                .HasMaxLength(50);
            builder.Property(c => c.DeletedBy)
                .HasMaxLength(50);
            builder.Property(c => c.CreatedAt)
                ;


            builder.Property(c => c.Phone)
               .IsRequired()
               .HasMaxLength(50);

            builder.OwnsOne(c => c.Name,name  =>
            {
                name.Property(a => a.FirstName)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("FirstName");
                name.Property(a => a.LastName)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("LastName");

            });



            builder.HasMany(s => s.OrderItemStaffs)
                .WithOne(orderStaff => orderStaff.Staff)
                .HasForeignKey(orderStaff => orderStaff.StaffId);

            builder.ToTable("Staffs", "Sales");

        }
    }
}
