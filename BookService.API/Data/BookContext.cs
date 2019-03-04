using BookService.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookService.API.Data
{
    public class BookContext
    {
        public XMLDataSet<Book> books { get; set; } = new XMLDataSet<Book>("Data/books.xml", "catalog");
    }
}
