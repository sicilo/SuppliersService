using Domain.Repositories;
using Infraestructure.Contexts;
using Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repositories
{
    internal class CountriesPerServiceRepository : ICountriesPerServiceRepository<CountriesPerService,int>
    {
        private SupplierContext context;

        public CountriesPerServiceRepository(SupplierContext _context)
        {
            context = _context;
        }

        public CountriesPerService Add(CountriesPerService entity)
        {
            context.CountriesPerService.Add(entity);
            return entity;
        }

        public void Delete(int entityId)
        {
            CountriesPerService country = context.CountriesPerService.Where(s => s.Id == entityId).FirstOrDefault();
            if (country != null)
                context.CountriesPerService.Remove(country);
        }

        public void SaveAllChanges()
        {
            context.SaveChanges();
        }

        public CountriesPerService SelectById(int entityId)
        {
            CountriesPerService country = context.CountriesPerService.Where(s => s.Id == entityId).FirstOrDefault();
            return country;
        }

        public List<CountriesPerService> ToList()
        {
            return context.CountriesPerService.ToList();
        }
    }
}
