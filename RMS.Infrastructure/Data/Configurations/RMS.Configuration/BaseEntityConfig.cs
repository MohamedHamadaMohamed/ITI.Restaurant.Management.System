using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RMS.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Infrastructure.Data.Configurations.RMS.Configuration
{
    public abstract class BaseEntityConfig<TEntity, TKey> : IEntityTypeConfiguration<TEntity> where TEntity : BaseEntity<TKey>
    {
        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.CreatedBy)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(c => c.UpdatedBy)
                .HasMaxLength(50);

            builder.Property(c => c.DeletedBy)
                .HasMaxLength(50);


            builder.HasQueryFilter(c => !c.IsDeleted);

            builder.Property(c => c.IsDeleted)
                .HasDefaultValue(false);
        }
    }
}
