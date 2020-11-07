using OrderAPI.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace OrderAPI.Tests
{
    public class BookTests : IDisposable
    {
        Book testBook;

        public BookTests()
        {
            var testBook = new Book
            {
                Title = "Le Crépuscule et l'Aube",
                Author = "Ken Follett",
                ISBN = "978-2221157701",
                Price = 24.50M
            };
        }


        public void Dispose()
        {
            testBook = null;
        }

        [Fact]
        public void CanChangeTitle()
        {
            
            // Act
            testBook.Title = "Execute Unit Test";

            // Assert
            Assert.Equal("Execute Unit Test", testBook.Title);
        }

        [Fact]
        public void CanChangeAuthor()
        {

            // Act
            testBook.Author = "Melpomene";

            // Assert
            Assert.Equal("Melpomene", testBook.Author);
        }

        [Fact]
        public void CanChangeISBN()
        {

            // Act
            testBook.ISBN = "123-4567891011";

            // Assert
            Assert.Equal("123-4567891011", testBook.ISBN);
        }
        
        [Fact]
        public void CanChangePrice()
        {

            // Act
            testBook.Price = 99.90M;

            // Assert
            Assert.Equal(99.90M, testBook.Price);
        }
    }
}
