using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookTalk.Data;
using BookTalk.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookTalk.Pages.Checkout
{
    public class IndexModel : PageModel
    {

        private readonly Context _context;
        private CustomerCartService _cartService;

        [BindProperty]
        public List<Book> BooksInCart { get; set; } = new List<Book>();


        public IndexModel(Context context, CustomerCartService cartService)
        {
            _context = context;
            _cartService = cartService;

            _cartService.GetCheckoutSum().ForEach(delegate(CheckoutSummary model) 
            {
                Book book = _context.Books.Where(x => x.Id == model.Book.Id).FirstOrDefault();

                if (book is not null)
                {
                    BooksInCart.Add(book);
                }

            });

        }

        public void OnGet()
        {
        }


        public void OnPostRemoveFromCart(string bookid)
        {
            _cartService.RemoveFromCart(bookid);


        }


        public void OnPostDecrementItem(string bookid)
        {
            _cartService.DecrementItem(bookid);

        }

        public void OnPostAddToCart(string bookid)
        {
            _cartService.AddToCart(bookid);

        }

    }
}
