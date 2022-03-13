﻿using Domain.Repositories;
using Infraestructure.Migrations;
using Models.Dtos;
using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infraestructure.Contexts;

namespace Infraestructure.Repositories
{
    public class SuppliersRepository : IBaseRepository<Supplier, int>
    {
        private SupplierContext context;

        public SuppliersRepository(SupplierContext _context)
        {
            context = _context;
        }

        public Supplier Add(Supplier entity)
        {
            context.Supplier.Add(entity);
            return entity;
        }

        public void Delete(int entityId)
        {
            Supplier supplier = context.Supplier.Where(s => s.Id == entityId).FirstOrDefault();
            if (supplier != null)
                context.Supplier.Remove(supplier);
        }

        public void Edit(Supplier entity)
        {
            Supplier supplier = context.Supplier.Where(s => s.Id == entity.Id).FirstOrDefault();
            if (supplier != null)
            {
                context.Supplier.Attach(supplier);
                context.Entry(supplier).State = EntityState.Modified;
            }
        }

        public void SaveAllChanges()
        {
            context.SaveChanges();
        }

        public Supplier SelectById(int entityId)
        {
            Supplier supplier = context.Supplier.Where(s => s.Id == entityId).FirstOrDefault();
            return supplier;
        }

        public List<Supplier> ToList()
        {
            return context.Supplier.ToList();
        }
    }
    //public class SuppliersRepository : ISupplierRepository
    //{
    //    private SupplierServicesContext _context;

    //    public SuppliersRepository(SupplierServicesContext context)
    //    {
    //        _context = context ?? throw new ArgumentNullException(nameof(context));
    //    }

    //    public void Create(Supplier supplier)
    //    {
    //        _context.Suppliers.Add(supplier);
    //        _context.SaveChanges();
    //    }

    //    public void Update(Supplier supplier)
    //    {
    //        _context.Suppliers.Attach(supplier);
    //        _context.Entry(supplier).State = EntityState.Modified;
    //        _context.SaveChanges();
    //    }

    //    public void Delete(int id)
    //    {
    //        _context.Suppliers.Remove(_context.Suppliers.Find(id));
    //        _context.SaveChanges();
    //    }

    //    public List<Supplier> GetSuppliers()
    //    {
    //        List<Supplier> suppliers = 
    //            (from s in _context.Suppliers 
    //             select new Supplier { 
    //                 Id = s.Id,
    //                 Name = s.Name,
    //                 Email = s.Email,
    //                 Created = s.Created
    //             }).ToList();
    //        return suppliers;
    //    }

    //    public Supplier GetSupplier(int id)
    //    {
    //        return _context.Suppliers.Find(id);
    //    }
    //}
}
