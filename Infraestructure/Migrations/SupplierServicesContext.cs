using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Models.Dtos;

#nullable disable

namespace Infraestructure.Migrations
{
    public partial class SupplierServicesContext : DbContext
    {
        public SupplierServicesContext()
        {
        }

        public SupplierServicesContext(DbContextOptions<SupplierServicesContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CountriesPerService> CountriesPerServices { get; set; }
        public virtual DbSet<Service> Services { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost; Database=SupplierServices;Trusted_Connection=False;User ID=SA;Password=P4nd4C07n10");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<CountriesPerService>(entity =>
            {
                entity.ToTable("CountriesPerService");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsFixedLength(true);

                entity.HasOne(d => d.IdServiceNavigation)
                    .WithMany(p => p.CountriesPerServices)
                    .HasForeignKey(d => d.IdService)
                    .HasConstraintName("FK__Countries__IdSer__2B3F6F97");
            });

            modelBuilder.Entity<Service>(entity =>
            {
                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsFixedLength(true);

                entity.Property(e => e.ValuePerHour).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.IdSupplierNavigation)
                    .WithMany(p => p.Services)
                    .HasForeignKey(d => d.IdSupplier)
                    .HasConstraintName("FK__Services__IdSupp__276EDEB3");
            });

            modelBuilder.Entity<Supplier>(entity =>
            {
                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsFixedLength(true);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsFixedLength(true);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
