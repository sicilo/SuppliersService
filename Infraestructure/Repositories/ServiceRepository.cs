using Domain.Repositories;
using Infraestructure.Contexts;
using Microsoft.EntityFrameworkCore;
using Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repositories
{
    public class ServiceRepository : IBaseRepository<Service, int>
    {
        private SupplierContext context;

        public ServiceRepository(SupplierContext _context)
        {
            context = _context;
        }

        public Service Add(Service entity)
        {
            context.Service.Add(entity);
            return entity;
        }

        public void Delete(int entityId)
        {
            Service service = context.Service.Where(s => s.Id == entityId).FirstOrDefault();
            if (service != null)
                context.Service.Remove(service);
        }

        public void Edit(Service entity)
        {
            Service service = context.Service.Where(s => s.Id == entity.Id).FirstOrDefault();
            if (service != null)
            {
                context.Service.Attach(service);
                context.Entry(service).State = EntityState.Modified;
            }
        }

        public void SaveAllChanges()
        {
            context.SaveChanges();
        }

        public Service SelectById(int entityId)
        {
            Service service = context.Service.Where(s => s.Id == entityId).FirstOrDefault();
            return service;
        }

        public List<Service> ToList()
        {
            return context.Service.ToList();
        }
    }
}
