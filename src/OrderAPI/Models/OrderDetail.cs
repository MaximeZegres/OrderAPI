using System;
using System.ComponentModel.DataAnnotations;

namespace OrderAPI.Models
{
    public class OrderDetail
    {
        [Key]
        [Required]
        public int OrderDetailId { get; set; }

        public int FK_OrderId { get; set; }

        public int FK_BookId { get; set; }

        public decimal DetailPrice { get; set; }

        public int Quantity { get; set; }
    }
}