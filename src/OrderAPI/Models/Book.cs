using System;
using System.ComponentModel.DataAnnotations;

namespace OrderAPI.Models
{
    public class Book
    {
        [Key]
        [Required]
        public int Id {get;set;}
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public decimal UnitPrice {get;set;}
    }
}