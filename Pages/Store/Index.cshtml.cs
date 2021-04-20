using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookTalk.Data;
using BookTalk.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookTalk.Pages.Store
{
    public class IndexModel : PageModel
    {
        public string Name { get; private set; }

        public List<Book> Books { get; private set; }

        private Context _context;
        private CustomerCartService _cartService;

        public IndexModel(Context context, CustomerCartService cartService)
        {
            _context = context;
            _cartService = cartService;
            Books = _context.Books.ToList();
        }

        public void OnGet()
        {

        }

        public IActionResult OnPostAddToCart(string bookId)
        {
            _cartService.AddToCart(bookId);

            return LocalRedirect("/store");
        }

    }
}
