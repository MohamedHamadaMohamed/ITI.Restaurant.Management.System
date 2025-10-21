using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RMS.Domain.Models.Production;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Infrastructure.Data.Configurations.RMS.Configuration.Production
{
    public class CategoryConfig : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
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


            builder.Property(c => c.Name)
                           .IsRequired()
                           .HasMaxLength(50);
            builder.Property(c => c.Description)
                           .HasMaxLength(1000);
            builder.Property(c =>c.IsActive)
                .HasDefaultValue(true);

            builder.HasMany(c => c.MenuItems)
                .WithOne(mi => mi.Category)
                .HasForeignKey(mi => mi.CategoryId);

            builder.ToTable("Categories", "Sales");


        }
    }
}
