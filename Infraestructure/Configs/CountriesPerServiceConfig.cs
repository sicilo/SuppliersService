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
    public class CountriesPerServiceConfig : IEntityTypeConfiguration<CountriesPerService>
    {
        public void Configure(EntityTypeBuilder<CountriesPerService> builder)
        {
            builder.ToTable("CountriesPerService");

            builder.Property(e => e.Name)
                .HasMaxLength(50)
                .IsFixedLength(true);

            builder.HasOne(d => d.IdServiceNavigation)
                .WithMany(p => p.CountriesPerServices)
                .HasForeignKey(d => d.IdService)
                .HasConstraintName("FK__Countries__IdSer__2B3F6F97");
        }
    }
}
