using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderAPI.Dtos
{
    public class CustomerReadDto
    {
        public int CustomerId { get; set; }
        public string FullName { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
        public decimal Price { get; set; }
    }
}
