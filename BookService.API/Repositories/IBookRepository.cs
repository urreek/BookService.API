using BookService.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookService.API.Repositories
{
    public interface IBookRepository
    {
        IEnumerable<Book> GetAllBooks();

        Book GetBook(string Id);
    }
}
