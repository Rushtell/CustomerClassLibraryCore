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
    public class AddressController : ControllerBase
    {
        private EFAddressesRepository repository { get; set; }

        public AddressController()
        {
            repository = new EFAddressesRepository();
        }

        // GET: api/<AddressController>/ByCustomer/5
        [HttpGet]
        [Route("ByCustomer/{id}")]
        public IEnumerable<Address> GetByCustomer(int id)
        {
            return repository.ReadCustomerAddresses(id);
        }

        // GET api/<AddressController>/5
        [HttpGet("{id}")]
        public Address Get(int id)
        {
            return repository.Read(id);
        }

        // POST api/<AddressController>
        [HttpPost]
        public int Post([FromBody] Address address)
        {
            return repository.Create(address);
        }

        // PUT api/<AddressController>
        [HttpPut]
        public void Put([FromBody] Address address)
        {
            repository.Update(address);
        }

        // DELETE api/<AddressController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            repository.Delete(id);
        }

        [HttpDelete("ByCustomer/{id}")]
        public void DeleteAllByCustomer(int id)
        {
            repository.DeleteAllByCustomerId(id);
        }
    }
}
