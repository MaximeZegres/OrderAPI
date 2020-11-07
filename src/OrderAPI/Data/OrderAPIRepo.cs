using System;
using System.Collections.Generic;
using System.Linq;
using OrderAPI.Models;

namespace OrderAPI.Data
{
    public class OrderAPIRepo : IOrderAPIRepo
    {
        private readonly OrderApiContext _context;

        public OrderAPIRepo(OrderApiContext context)
        {
            _context = context;
        }


        // Books
        public IEnumerable<Book> GetAllBooks()
        {
            return _context.Books.ToList();
        }

        public Book GetBookById(int id)
        {
            return _context.Books.FirstOrDefault(p => p.Id == id);
        }

        public void CreateBook(Book book)
        {
            if(book == null)
            {
                throw new ArgumentNullException(nameof(book));
            }

            _context.Books.Add(book);
        }

        public void UpdateBook(Book book)
        {
            // Do nothing in repository
        }

        public void DeleteBook(Book book)
        {
            if(book == null)
            {
                throw new ArgumentNullException(nameof(book));
            }

            _context.Books.Remove(book);
        }




        // Customers
        public IEnumerable<Customer> GetAllCustomers()
        {
            return _context.Customers.ToList();
        }

        public Customer GetCustomerById(int id)
        {
            return _context.Customers.FirstOrDefault(p => p.CustomerId == id);
        }

        public void CreateCustomer(Customer customer)
        {
            if (customer == null)
            {
                throw new ArgumentNullException(nameof(customer));
            }

            _context.Customers.Add(customer);
        }

        public void UpdateCustomer(Customer customer)
        {
            // Do nothing in repository
        }

        public void DeleteCustomer(Customer customer)
        {
            if (customer == null)
            {
                throw new ArgumentNullException(nameof(customer));
            }

            _context.Customers.Remove(customer);
        }



        // Orders
        public IEnumerable<Order> GetAllOrders()
        {
            return _context.Orders.ToList();
        }

        public Order GetOrderById(int id)
        {
            return _context.Orders.FirstOrDefault(p => p.OrderId == id);
        }

        public void CreateOrder(Order order)
        {
            if (order == null)
            {
                throw new ArgumentNullException(nameof(order));
            }

            _context.Orders.Add(order);
        }

        public void UpdateOrder(Order order)
        {
            // Do nothing in repository
        }

        public void DeleteOrder(Order order)
        {
            if (order == null)
            {
                throw new ArgumentNullException(nameof(order));
            }

            _context.Orders.Remove(order);
        }



        // Save change
        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

    }
}