using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Exemplos.Context;
using Exemplos.Entities;

namespace Exemplos.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContactController : ControllerBase
    {
        private readonly ContactBookContext _context;

        public ContactController (ContactBookContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult Create(Contact contact)
        {
            _context.Add(contact);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetById), new { id = contact.Id }, contact);
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var contacts = _context.Contacts.ToList();

            if (contacts == null)
                return NotFound();
            return Ok(contacts);
        }

        [HttpGet("GetById/{id}")]
        public IActionResult GetById(int id)
        {
            var contact = _context.Contacts.Find(id);

            if (contact == null)
                return NotFound();
            return Ok(contact);
        }

        [HttpGet("GetByName")]
        public IActionResult GetByName(string name)
        {
            var contacts = _context.Contacts.Where(x => x.Name.Contains(name));

            return Ok(contacts);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Contact changeContact)
        {
            var contact = _context.Contacts.Find(id);

            if (contact == null)
                return NotFound();

            contact.Name = changeContact.Name;
            contact.Phone = changeContact.Phone;
            contact.Active = changeContact.Active;

            _context.Contacts.Update(contact);
            _context.SaveChanges();

            return Ok(contact);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var contact = _context.Contacts.Find(id);

            if (contact == null)
                return NotFound();

            _context.Contacts.Remove(contact);
            _context.SaveChanges();

            return NoContent();
        }
    }
}