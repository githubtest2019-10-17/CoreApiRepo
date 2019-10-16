using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreApiRepo.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreApiRepo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    // Add Required Methods in the Controller for Implemeting the CustomerRepository methods
    // Please Get CustomerRepository in constructor using Dependency injection
    public class CustomerController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<Response> GetCustomers()
        {
            return new Response();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public ActionResult<Response> Post([FromBody] Customer value)
        {
            return new Response();
        }
       
    }
}
