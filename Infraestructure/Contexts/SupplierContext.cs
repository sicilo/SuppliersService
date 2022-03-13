using Infraestructure.Configs;
using Microsoft.EntityFrameworkCore;
using Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Contexts
{
    public class SupplierContext : DbContext
    {
        public DbSet<Supplier> Supplier { get; set;}
        public DbSet<Service> Service { get; set;}
        public DbSet<CountriesPerService> CountriesPerService { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost; Database=SupplierServices;Trusted_Connection=False;User ID=SA;Password=P4nd4C07n10");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new SupplierConfig());
            modelBuilder.ApplyConfiguration(new ServiceConfig());
            modelBuilder.ApplyConfiguration(new CountriesPerServiceConfig());
        }
    }
}
