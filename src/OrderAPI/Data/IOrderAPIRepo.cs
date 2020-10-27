using System;
using System.Collections.Generic;
using OrderAPI.Models;

namespace OrderAPI.Data
{
    public interface IOrderAPIRepo
    {
        bool saveChanges();


        // Book methods
        IEnumerable<Book> GetAllBooks(); 
        Book GetBookById(int id);
        void CreateBook(Book book);
        void UpdateBook(Book book);
        void DeleteBook(Book book);

        // Customer methods
        IEnumerable<Customer> GetAllCustomers();
        Customer GetCustomerById(int id);
        void CreateCustomer(Customer customer);
        void UpdateCustomer(Customer customer);
        void DeleteCustomer(Customer customer);

        // Order methods
        IEnumerable<Order> GetAllOrders();
        Order GetOrderById(int id);
        void CreateOrder(Order order);
        void UpdateOrder(Order order);
        void DeleteOrder(Order order);

    }
}