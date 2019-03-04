using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookService.API.Data;
using BookService.API.Entities;

namespace BookService.API.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly BookContext _context;
        public BookRepository(BookContext context)
        {
            _context = context;
        }
        public IEnumerable<Book> GetAllBooks()
        {
            return _context.books.Data;
        }

        public Book GetBook(string Id)
        {
            return _context.books.Data.Find(b => b.Id.ToLower().Equals(Id.ToLower()));
        }
    }
}
