using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Configs
{
    public class ServiceConfig : IEntityTypeConfiguration<Service>
    {
        public void Configure(EntityTypeBuilder<Service> builder)
        {
            builder.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

            builder.Property(e => e.Name)
                .HasMaxLength(50)
                .IsFixedLength(true);

            builder.Property(e => e.ValuePerHour).HasColumnType("decimal(18, 2)");

            builder.HasOne(d => d.IdSupplierNavigation)
                .WithMany(p => p.Services)
                .HasForeignKey(d => d.IdSupplier)
                .HasConstraintName("FK__Services__IdSupp__276EDEB3");
        }
    }
}
