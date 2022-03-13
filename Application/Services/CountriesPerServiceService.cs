using Application.Interfaces;
using Domain.Repositories;
using Models.Entities;
using System;
using System.Collections.Generic;

namespace Application.Services
{
    public class CountriesPerServiceService : ICountriesPerServiceService<CountriesPerService, int>
    {
        private readonly ICountriesPerServiceRepository<CountriesPerService, int> countriesPerServiceRepository;

        public CountriesPerServiceService(ICountriesPerServiceRepository<CountriesPerService, int> _countriesPerServiceRepository)
        {
            countriesPerServiceRepository = _countriesPerServiceRepository;
        }

        public CountriesPerService Attach(CountriesPerService entity)
        {
            if(entity == null)
                throw new ArgumentNullException("Service is required");

            CountriesPerService result = countriesPerServiceRepository.Attach(entity);
            countriesPerServiceRepository.SaveAllChanges();
            return result;
        }

        public void Delete(int entityId)
        {
            countriesPerServiceRepository.Delete(entityId);
            countriesPerServiceRepository.SaveAllChanges();
        }

        public CountriesPerService SelectById(int entityId)
        {
            return countriesPerServiceRepository.SelectById(entityId);
        }

        public List<CountriesPerService> ToList()
        {
            return countriesPerServiceRepository.ToList();
        }
    }
}
