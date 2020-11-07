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
            throw new System.NotImplementedException();
        }

        public Customer GetCustomerById(int id)
        {
            throw new System.NotImplementedException();
        }

        public void CreateCustomer(Customer customer)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateCustomer(Customer customer)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteCustomer(Customer customer)
        {
            throw new System.NotImplementedException();
        }



        // Orders
        public IEnumerable<Order> GetAllOrders()
        {
            throw new System.NotImplementedException();
        }

        public Order GetOrderById(int id)
        {
            throw new System.NotImplementedException();
        }

        public void CreateOrder(Order order)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateOrder(Order order)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteOrder(Order order)
        {
            throw new System.NotImplementedException();
        }



        // Save change
        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

    }
}