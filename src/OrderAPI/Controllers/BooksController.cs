using Microsoft.AspNetCore.Mvc;
using OrderAPI.Data;
using OrderAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IOrderAPIRepo _repository;

        public BooksController(IOrderAPIRepo repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Book>> GetAllBooks()
        {
            var books = _repository.GetAllBooks();
            return Ok(books);
        }

        [HttpGet("{id}")]
        public ActionResult<Book> GetBookById(int id)
        {
            var book = _repository.GetBookById(id);
            if (book == null)
            {
                return NotFound();
            }

            return Ok(book);
        }
    }
}
