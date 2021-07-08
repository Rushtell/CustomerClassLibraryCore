using CustomerClassLibraryCore;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CustomerClassLibraryWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private DataCustomerAssembler assembler { get; set; }

        public CustomerController()
        {
            assembler = new DataCustomerAssembler();
        }
        // GET: api/<CustomerController>
        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            return assembler.GetAll();
        }

        // GET api/<CustomerController>/5
        [HttpGet("{id}")]
        public Customer Get(int id)
        {
            return assembler.BuildCustomer(id);
        }

        // GET api/<CustomerController>/5/6
        [HttpGet("{id}/{id2}")]
        public IEnumerable<Customer> Get(int id, int id2)
        {
            return assembler.GetSelection(id, id2);
        }

        // GET api/<CustomerController>/5
        [HttpGet("/Count")]
        public int GetCount()
        {
            return assembler.Count();
        }

        // POST api/<CustomerController>
        [HttpPost]
        public void Post([FromBody] Customer customer)
        {
            assembler.CreateCustomer(customer);
        }

        // PUT api/<CustomerController>
        [HttpPut]
        public void Put([FromBody] Customer customer)
        {
            assembler.UpdateCustomer(customer);
        }

        // DELETE api/<CustomerController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            assembler.DeleteCustomer(id);
        }
    }
}
