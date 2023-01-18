using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Exemplos.Context;
using Exemplos.Models;

namespace Exemplos.Controllers
{
    public class ContactController : Controller
    {
        private readonly ContactBookContext _context;

        public ContactController(ContactBookContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var contacts = _context.Contacts.ToList();

            return View(contacts);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Contact contact)
        {
            if (ModelState.IsValid)
            {
                _context.Contacts.Add(contact);
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            return View(contact);
        }

        public IActionResult Edit(int id)
        {
            var contact = _context.Contacts.Find(id);

            if (contact == null)
                return RedirectToAction(nameof(Index));
            
            return View(contact);
        }

        [HttpPost]
        public IActionResult Edit(Contact changeContact)
        {
            var contact = _context.Contacts.Find(changeContact.Id);

            contact.Name = changeContact.Name;
            contact.Phone = changeContact.Phone;
            contact.Active = changeContact.Active;

            _context.Contacts.Update(contact);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Details(int id)
        {
            var contact = _context.Contacts.Find(id);

            if (contact == null)
                return RedirectToAction(nameof(Index));

            return View(contact);
        }

        public IActionResult Delete(int id)
        {
            var contact = _context.Contacts.Find(id);

            if (contact == null)
                return RedirectToAction(nameof(Index));

            return View(contact);
        }

        [HttpPost]
        public IActionResult Delete(Contact changeContact)
        {
            var contact = _context.Contacts.Find(changeContact.Id);

            _context.Contacts.Remove(contact);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    }
}