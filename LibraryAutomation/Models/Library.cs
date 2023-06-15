using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAutomation.Models
{
    public class Library
    {
        public List<Customer> Customers { get; set; }
        public List<Book> Books { get; set; }
        public List<Loan> Loans { get; set; }
        public Library()
        {
            Books = new List<Book>();
            Customers = new List<Customer>();
            Books = new List<Book>();

        }
        public void AddBook(Book book)
        {
            Books.Add(book);
        }
        public void AddCustomer(Customer customer)
        {
            Customers.Add(customer);
        }
        public void BorrowBook(Book book, Customer customer)
        {
            IsThereBook(book);
            IsThereCustomer(customer);

            Loan loan = new Loan(book, customer);
            Loans.Add(loan);
        }
        public void ReturnBook(Book book,Customer customer) 
        {
            var loan = GetLoan(book, customer);
            loan.ReturnDate = DateTime.Now;
            Loans.Remove(loan);
        }
        private Loan GetLoan (Book book,Customer customer)
        {
            foreach(var item in Loans) 
            {
            if(item.Book.ISBN == book.ISBN && item.Customer.CustomerEmail == customer.CustomerEmail)
                {
                    return item;
                }
            }
            throw new Exception("Loan not found");
        }
        private void IsThereBook(Book book)
        {
            bool result = false;
            foreach (var item in Books)
            {
                if (item.ISBN == book.ISBN)
                {
                    result = true;
                    break;
                }
            }
            if (!result)
            {
                throw new Exception("Book not found..");
            }
        }
        private void IsThereCustomer(Customer customer)
        {
            bool result = false;
            foreach (var item in Customers)
            {
                if (item.CustomerEmail == customer.CustomerEmail)
                {
                    result = true;
                    break;
                }
            }
            if (!result)
            {
                throw new Exception("Customer not found..");
            }

        }

    }
}
