using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookService.API.Entities;
using BookService.API.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace BookService.API.Controllers
{
    [Route("api/books")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBookRepository _bookRepository;

        public BooksController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Book>> Get()
        {
            return Ok(_bookRepository.GetAllBooks());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Book> Get(string id)
        {
            return Ok(_bookRepository.GetBook(id));
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
