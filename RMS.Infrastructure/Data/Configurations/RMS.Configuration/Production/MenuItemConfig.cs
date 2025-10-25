using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RMS.Domain.Models.Production;

namespace RMS.Infrastructure.Data.Configurations.RMS.Configuration.Production
{
    public class MenuItemConfig : BaseEntityConfig<MenuItem,int>
    {
        public override void Configure(EntityTypeBuilder<MenuItem> builder)
        {
            base.Configure(builder);
           

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
