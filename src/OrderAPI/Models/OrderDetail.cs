using System;
using System.ComponentModel.DataAnnotations;
using System.Net.Http.Headers;

namespace OrderAPI.Models
{
    public class OrderDetail
    {
        [Key]
        [Required]
        public int OrderDetailId { get; set; }

        public Book Book { get; set; }

        public int Quantity { get; set; }
    }
}