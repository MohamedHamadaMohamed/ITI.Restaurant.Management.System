using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RMS.Domain.Models.Sales;

namespace RMS.Infrastructure.Data.Configurations.RMS.Configuration.Sales
{
    public class StaffConfig : BaseEntityConfig<Staff, int>
    {
        public override void Configure(EntityTypeBuilder<Staff> builder)
        {
            base.Configure(builder);


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
