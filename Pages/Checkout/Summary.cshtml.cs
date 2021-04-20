using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookTalk.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookTalk.Pages.Checkout
{
    [Authorize( Roles = "Customer,Admin")]
    public class SummaryModel : PageModel
    {
        private Context _context;
        private CustomerCartService _cartService;


        public SummaryModel(Context context, CustomerCartService cartService)
        {
            _context = context;
            _cartService = cartService;
        }


        public void OnGet()
        {
        }


        public IActionResult OnPostConfirmSummary(string name, string address, string secondaddress, string provenance, string zipcode, string city)
        {

            User user = _context.Users.Where(x => x.UserName.Equals(User.Identity.Name)).FirstOrDefault();

            if (user is not null)
            {
                Order order = new Order();
                List<UserOrder> userOrders = new List<UserOrder>();

                _cartService.GetCheckoutSum().ForEach(item =>
                {

                    UserOrder userOrder = new UserOrder(order, item.Book);

                    userOrders.Add(userOrder);

                });

                order.Status = "Order summarized";
                order.Finnished = false;
                order.PaymentMethod = "Not Selected";
                order.TotalPrice = _cartService.GetCheckoutSum().Sum(x => x.Book.Price * x.Quantity);

                order.Name = name;
                order.Address = address;
                order.SecondAddress = secondaddress;
                order.Provenance = provenance;
                order.ZipCode = zipcode;
                order.City = city;


                order.User = user;
                order.UserId = user.Id;
                order.UserOrder = userOrders;


                _context.Orders.Add(order);
                _context.SaveChanges();


                return LocalRedirect($"checkout/payment/{order.Id}");
            }
            else
            {
                return Page();
            }
            
        
        }
    }
}
