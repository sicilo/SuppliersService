using Domain.Repositories;
using Infraestructure.Migrations;
using Models.Dtos;
using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repositories
{
    public class SuppliersRepository : ISupplierRepository
    {
        private SupplierServicesContext _context;

        public SuppliersRepository(SupplierServicesContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public void Create(Supplier supplier)
        {
            _context.Suppliers.Add(supplier);
            _context.SaveChanges();
        }

        public void Update(Supplier supplier)
        {
            _context.Suppliers.Attach(supplier);
            _context.Entry(supplier).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            _context.Suppliers.Remove(_context.Suppliers.Find(id));
            _context.SaveChanges();
        }

        public List<Supplier> GetSuppliers()
        {
            List<Supplier> suppliers = 
                (from s in _context.Suppliers 
                 select new Supplier { 
                     Id = s.Id,
                     Name = s.Name,
                     Email = s.Email,
                     Created = s.Created
                 }).ToList();
            return suppliers;
        }

        public Supplier GetSupplier(int id)
        {
            return _context.Suppliers.Find(id);
        }
    }
}
