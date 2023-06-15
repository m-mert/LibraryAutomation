using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAutomation.Models
{
    public class Loan 
    {
        public Loan(Book book,Customer customer)
        {
            Book = book;
            Customer = customer;
            BorrowDate = DateTime.Now;
        }
      
        public DateTime BorrowDate { get; private set; }
        public DateTime ReturnDate { get; set; }
        public Book Book { get; set; }
        public Customer Customer { get; set; }

       
      
    }
   
}

