using OrderAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderAPI.Dtos
{
    public class OrderCreateDto
    {
        public Customer Customer { get; set; }

        public decimal TotalAmount { get; set; }

        public DateTime OrderDate { get; set; }

        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
