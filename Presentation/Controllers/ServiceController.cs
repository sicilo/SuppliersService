using Application.Services;
using Infraestructure.Contexts;
using Infraestructure.Repositories;
using Microsoft.AspNetCore.Mvc;
using Models.Dtos;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {

        private readonly ServiceService serviceService;

        ServiceService CreateService()
        {
            SupplierContext context = new();
            ServiceRepository serviceRepo = new(context);
            return new ServiceService(serviceRepo);
        }

        public ServiceController()
        {
            serviceService = CreateService();
        }

        [HttpGet]
        public ActionResult<List<Service>> Get()
        {
            return Ok(serviceService.ToList());
        }

        [HttpGet("{id}")]
        public ActionResult<Supplier> Get(int id)
        {
            return Ok(serviceService.SelectById(id));
        }

        [HttpPost]
        public ActionResult Post([FromBody] Service service)
        {
            return Ok(serviceService.Add(service));
        }

        [HttpPut]
        public ActionResult Put([FromBody] Service service)
        {
            serviceService.Edit(service);
            return Ok("Supplier Updated");
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            serviceService.Delete(id);
            return Ok("Supplier Deleted");
        }
    }
}
