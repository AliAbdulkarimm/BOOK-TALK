using BookTalk.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookTalk.Models
{
    public class CheckoutModel
    {
        public int Quantity { get; set; }
        public string BookId { get; set; }
        public Book Book { get; set; }
        public DateTime Added { get; set; }

        public CheckoutModel()
        {
            Quantity = 0;
            BookId = string.Empty;
        }

        public CheckoutModel(Book book)
        {
            Quantity = 0;
            BookId = book.Id;
            Book = book;
            Added = DateTime.Now;
        }
    }
}
