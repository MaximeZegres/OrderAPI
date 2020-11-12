using Microsoft.EntityFrameworkCore;
using OrderAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderAPI.Data
{
    public class OrderApiContext : DbContext
    {
        public OrderApiContext(DbContextOptions<OrderApiContext> options)
            : base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        // Create mapping in OnModelCreating (DbModelBuilder) between Orders and Customers (and Orders and OrderDetails)
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //}
    }
}
