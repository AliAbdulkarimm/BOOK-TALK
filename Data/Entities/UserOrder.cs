using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BookTalk.Data
{
    public class UserOrder : BaseEntity
    {

        [ForeignKey("Id")]
        public string OrderId { get; set; }
        public Order Order { get; set; }

        [NotMapped]
        [ForeignKey("Id")]
        public string BookId { get; set; }
        public Book Book { get; set; }

        public int Quantity { get; set; }

        public UserOrder() { }

        public UserOrder(Order order, Book book)
        {
            OrderId = order.Id;
            Order = order;

            BookId = book.Id;
            Book = book;

        }


    }
}
