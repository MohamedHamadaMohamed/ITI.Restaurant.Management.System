using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RMS.Domain.Models.Sales;

namespace RMS.Infrastructure.Data.Configurations.RMS.Configuration.Sales
{
    public  class ClientConfig : BaseEntityConfig<Client,int>
    {
        public override void Configure(EntityTypeBuilder<Client> builder)
        {

            base.Configure(builder);

            builder.Property(c =>c.Name)
                .IsRequired()
                .HasMaxLength(50);
            builder.OwnsOne(c => c.Address,address =>
            {
                address.Property(a =>a.City)
                .IsRequired()
                .HasMaxLength (50)
                .HasColumnName("City")
                ;
                address.Property(a => a.State)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("State")
                ;
                address.Property(a => a.Street)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("Street");

            });

            builder.Property(c => c.Phone)
                .IsRequired()
                .HasMaxLength(50);


            builder.Property(c => c.IsDeleted)
                .HasDefaultValue(false);


            builder.HasMany(c => c.Orders)
                .WithOne(o => o.Client);
            




            builder.ToTable("Clients","Sales");

        }
    }
}
