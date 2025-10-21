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
    public class ClientConfig : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {

            /*
                public TKey Id { get; set; } = default!;
                public string CreatedBy { get; set; } = default!;
                public string UpdatedBy { get; set;} = default!;
                public string DeletedBy { get; set;} = default!;
                public DateTime CreatedAt { get; set; } = DateTime.Now;
                public DateTime UpdatedAt { get; set;} = default!;
                public DateTime? DeletedAt { get; set; } = null;
                public bool IsDeleted { get; set; } = false;
                public string Name { get; set; } = null!;
                public Address Address { get; set; } = null!;
                public string Phone { get; set; } = null!;
                public string ApplicationUserId { get; set; } = null!;

             
             
             */
            builder.HasKey(c  => c.Id);
            builder.Property(c => c.CreatedBy)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(c => c.UpdatedBy)
                .HasMaxLength(50);
            builder.Property(c => c.DeletedBy)
                .HasMaxLength(50);
            builder.Property(c => c.CreatedAt)
                ;

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
