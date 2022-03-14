using Application.Services;
using AutoMapper;
using Infraestructure.Repositories;
using Microsoft.AspNetCore.Mvc;
using Models.Dtos;
using Models.Entities;
using System.Collections.Generic;

namespace Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupplierController : ControllerBase
    {
        private readonly SupplierService supplierService;

        private readonly IMapper mapper;

        public SupplierController(SupplierRepository _supplier,IMapper _mapper)
        {
            supplierService = new (_supplier);
            mapper = _mapper;
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
        public ActionResult<SupplierResponse> Post([FromBody] SupplierRequest supplierRequest)
        {
            Supplier supplier = mapper.Map<Supplier>(supplierRequest);
            Supplier newSupplier = supplierService.Add(supplier);
            return Ok(mapper.Map<SupplierResponse>(newSupplier));
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
