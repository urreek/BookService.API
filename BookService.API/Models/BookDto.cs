using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookService.API.Models
{
    public class BookDto
    {
        public string Id { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        [MaxLength(100)]
        public string Title { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
        public string PublishDate { get; set; }
        public string Description { get; set; }
    }
}
