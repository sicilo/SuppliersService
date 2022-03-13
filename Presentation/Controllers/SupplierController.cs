using Domain.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;
using Models.Entities;
using AutoMapper;
using Models.Dtos;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupplierController : ControllerBase
    {
        private readonly ISupplierRepository iSupplierRepository;
        private readonly IMapper mapper;

        public SupplierController(ISupplierRepository _iSupplierRepository,IMapper _mapper)
        {
            iSupplierRepository = _iSupplierRepository;
            mapper = _mapper;
        }
        // GET: api/<SupplierController>
        [HttpGet]
        public List<Supplier> Get()
        {
            List<Supplier> sup = iSupplierRepository.GetSuppliers();
            //List<SupplierResponse> suppliers = mapper.Map<List<SupplierResponse>>(sup);
            return sup;
        }

        // GET api/<SupplierController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<SupplierController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<SupplierController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SupplierController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
