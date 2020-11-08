using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OrderAPI.Models
{
    public class Order
    {
        [Key]
        [Required]
        public int OrderId { get; set; }

        public int FK_CustomerId { get; set; }

        public Customer Customer { get; set; }

        public decimal TotalAmount { get; set; }

        public DateTime OrderDate { get; set; }

        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}