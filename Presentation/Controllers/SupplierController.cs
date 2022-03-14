using Application.Services;
using Infraestructure.Contexts;
using Infraestructure.Repositories;
using Microsoft.AspNetCore.Mvc;
using Models.Dtos;
using System.Collections.Generic;

namespace Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupplierController : ControllerBase
    {
        private readonly SupplierService supplierService;

        SupplierService CreateService()
        {
            SupplierContext context = new();
            SupplierRepository supplierRepo = new(context);
            return new SupplierService(supplierRepo);
        }

        public SupplierController()
        {
            supplierService = CreateService();
        }

        // GET: api/<SuppliersController>
        [HttpGet]
        public ActionResult<List<Supplier>> Get()
        {
            return Ok(supplierService.ToList());
        }

        // GET api/<SuppliersController>/5
        [HttpGet("{id}")]
        public ActionResult<Supplier> Get(int id)
        {
            return Ok(supplierService.SelectById(id));
        }

        // POST api/<SuppliersController>
        [HttpPost]
        public ActionResult Post([FromBody] Supplier supplier)
        {
            return Ok(supplierService.Add(supplier));
        }

        // PUT api/<SuppliersController>/5
        //[HttpPut("{id}")]
        public ActionResult Put([FromBody] Supplier supplier)
        {
            supplierService.Edit(supplier);
            return Ok("Supplier Updated");
        }

        // DELETE api/<SuppliersController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            supplierService.Delete(id);
            return Ok("Supplier Deleted");
        }
    }
}
