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
    public class BookController : ControllerBase
    {
        private readonly LibraryContext _context;

        public BookController(LibraryContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult Create(Book book)
        {
            _context.Add(book);
            _context.SaveChanges();

            return Ok(book);
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var books = _context.Books.ToList();

            if (books == null)
                return NotFound();
            return Ok(books);
        }

        [HttpGet("GetById/{id}")]
        public IActionResult GetById(int id)
        {
            var book = _context.Books.Find(id);

            if (book == null)
                return NotFound();
            return Ok(book);
        }

        [HttpGet("GetByTitle/{title}")]
        public IActionResult GetByTitle(string title)
        {
            var books = _context.Books.Where(x => x.Title.Contains(title));

            return Ok(books);
        }

        [HttpGet("GetByAuthor/{author}")]
        public IActionResult GetByAuthor(string author)
        {
            var books = _context.Books.Where(x => x.Author.Contains(author));

            return Ok(books);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Book changeBook)
        {
            var book = _context.Books.Find(id);

            if (book == null)
                return NotFound();

            book.Title = changeBook.Title;
            book.Author = changeBook.Author;
            book.NumberOfPages = changeBook.NumberOfPages;
            book.ReleaseYear = changeBook.ReleaseYear;
            book.Publisher = changeBook.Publisher;
            book.Ratings = changeBook.Ratings;
            book.Synopsis = changeBook.Synopsis;

            _context.Books.Update(book);
            _context.SaveChanges();

            return Ok(book);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var book = _context.Books.Find(id);

            if (book == null)
                return NotFound();

            _context.Books.Remove(book);
            _context.SaveChanges();

            return Ok(book);
        }
    }
}