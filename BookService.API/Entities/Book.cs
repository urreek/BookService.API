using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BookService.API.Entities
{
    [XmlType("book")]
    public class Book
    {
        [Key]
        [XmlAttribute("id")]
        public string Id { get; set; }
        [Required]
        [XmlElement("author")]
        public string Author { get; set; }
        [Required]
        [MaxLength(100)]
        [XmlElement("title")]
        public string Title { get; set; }
        [XmlElement("genre")]
        public string Genre { get; set; }
        [XmlElement("price")]
        public decimal Price { get; set; }
        [XmlElement("publish_date")]
        public DateTime PublishDate { get; set; }
        [XmlElement("description")]
        public string Description { get; set; }
    }
}
