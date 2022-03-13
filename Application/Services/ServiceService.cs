using Application.Interfaces;
using Domain.Repositories;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class ServiceService : IBaseService<Service, int>
    {
        private readonly IBaseRepository<Service, int> serviceRepository; 

        public ServiceService(IBaseRepository<Service, int> _serviceRepository)
        {
            serviceRepository = _serviceRepository;
        }

        public Service Attach(Service entity)
        {
            if(entity == null)
                throw new ArgumentNullException("Service is required");

            Service result = serviceRepository.Attach(entity);
            serviceRepository.SaveAllChanges();

            return result;
        }

        public void Delete(int entityId)
        {
            serviceRepository.Delete(entityId);
            serviceRepository.SaveAllChanges();
        }

        public void Edit(Service entity)
        {
            if (entity == null)
                throw new ArgumentNullException("Service is required");

            serviceRepository.Edit(entity);
            serviceRepository.SaveAllChanges();
        }

        public Service SelectById(int entityId)
        {
            return serviceRepository.SelectById(entityId);
        }

        public List<Service> ToList()
        {
            return serviceRepository.ToList();
        }
    }
}
