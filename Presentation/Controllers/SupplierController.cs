using Application.Services;
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

        public SupplierController(SupplierRepository _supplier)
        {
            supplierService = new (_supplier);
        }

        [HttpGet]
        public ActionResult<List<Supplier>> Get()
        {
            return Ok(supplierService.ToList());
        }

        [HttpGet("{id}")]
        public ActionResult<Supplier> Get(int id)
        {
            return Ok(supplierService.SelectById(id));
        }

        [HttpPost]
        public ActionResult Post([FromBody] Supplier supplier)
        {
            return Ok(supplierService.Add(supplier));
        }

        [HttpPut]
        public ActionResult Put([FromBody] Supplier supplier)
        {
            supplierService.Edit(supplier);
            return Ok("Supplier Updated");
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            supplierService.Delete(id);
            return Ok("Supplier Deleted");
        }
    }
}
