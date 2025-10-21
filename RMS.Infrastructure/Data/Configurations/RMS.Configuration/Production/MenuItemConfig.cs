using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RMS.Domain.Models.Production;

namespace RMS.Infrastructure.Data.Configurations.RMS.Configuration.Production
{
    public class MenuItemConfig : IEntityTypeConfiguration<MenuItem>
    {
        public void Configure(EntityTypeBuilder<MenuItem> builder)
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


            builder.OwnsOne(c => c.Price, price =>
            {
                price.Property(a => a.Price)
                .IsRequired()
                .HasDefaultValue(0)
                .HasColumnName("Price");
                price.Property(a => a.Currency)
                .IsRequired()
                .HasMaxLength(5)
                .HasColumnName("Currency");
                ;


            });



            builder.Property(c => c.Name)
                           .IsRequired()
                           .HasMaxLength(50);
            builder.Property(c => c.Description)
                           .HasMaxLength(1000);


        }
    }
}
