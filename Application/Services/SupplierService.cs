using Application.Interfaces;
using Domain.Repositories;
using Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class SupplierService : IBaseService<Supplier, int>
    {
        private readonly IBaseRepository<Supplier, int> supplierRepository;

        public SupplierService (IBaseRepository<Supplier, int> _supplierRepository)
        {
            supplierRepository = _supplierRepository;
        }

        public Supplier Attach(Supplier entity)
        {
            if (entity == null)
                throw new ArgumentNullException("Supplier is required");

            Supplier result = supplierRepository.Attach(entity);
            supplierRepository.SaveAllChanges();

            return result;
        }

        public void Delete(int entityId)
        {
            supplierRepository.Delete(entityId);
            supplierRepository.SaveAllChanges();
        }

        public void Edit(Supplier entity)
        {
            if (entity == null)
                throw new ArgumentNullException("Supplier is required");

            supplierRepository.Edit(entity);
            supplierRepository.SaveAllChanges();
        }

        public Supplier SelectById(int entityId)
        {
            return supplierRepository.SelectById(entityId);
        }

        public List<Supplier> ToList()
        {
            return supplierRepository.ToList();
        }
    }
}
