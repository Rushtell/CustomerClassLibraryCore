using CustomerClassLibraryCore;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CustomerClassLibraryWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NoteController : ControllerBase
    {
        private EFNotesRepository repository { get; set; }

        public NoteController()
        {
            repository = new EFNotesRepository();
        }

        // GET: api/<NoteController>
        [HttpGet("ByCustomer/{id}")]
        public IEnumerable<Note> GetByCustomer(int id)
        {
            return repository.ReadCustomerNotes(id);
        }

        // GET api/<NoteController>/5
        [HttpGet("{id}")]
        public Note Get(int id)
        {
            return repository.Read(id);
        }

        // POST api/<NoteController>
        [HttpPost]
        public int Post([FromBody] Note note)
        {
            return repository.Create(note);
        }

        // PUT api/<NoteController>
        [HttpPut("{id}")]
        public void Put([FromBody] Note note)
        {
            repository.Update(note);
        }

        // DELETE api/<NoteController>/5
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
