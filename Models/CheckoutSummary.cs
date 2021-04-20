using BookTalk.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookTalk.Models
{
    public class CheckoutSummary
    {
        public Book Book { get; set; }
        public int Quantity { get; set; }

        public CheckoutSummary(Book book, int quantity)
        {
            Book = book;
            Quantity = quantity;
        }
    }
}
