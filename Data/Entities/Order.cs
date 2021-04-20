using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BookTalk.Data
{
    public class Order : BaseEntity
    {

        public string Status { get; set; } // Order recived, order is being proccesed, order has been shipped... etc.
        public bool Finnished { get; set; }
        public string PaymentMethod { get; set; } // Paypal, credit card, klarna etc...
        public double TotalPrice { get; set; }

        public string Name { get; set; }
        public string Address { get; set; }
        public string SecondAddress { get; set; }
        public string Provenance { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }


        [ForeignKey("Id")]
        public string UserId { get; set; }
        public User User { get; set; }

        
        public List<UserOrder> UserOrder { get; set; }

        public Order()
        {
            Status = string.Empty;
            Finnished = false;
            PaymentMethod = string.Empty;
            TotalPrice = 0;

            Address = string.Empty;
            Provenance = string.Empty;
            City = string.Empty;
            ZipCode = string.Empty;

            User = new User();
            UserId = string.Empty;

            UserOrder = new List<UserOrder>();

        }

    }
}
