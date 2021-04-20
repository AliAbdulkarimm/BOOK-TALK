using BookTalk.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookTalk.Pages
{
    public class IndexModel : PageModel
    {
        private readonly Context _context;
        private CustomerCartService _cartService;

        [BindProperty]
        public List<Book> bookList { get; set; }

        public IndexModel(Context context, CustomerCartService cartService)
        {
            _context = context;
            _cartService = cartService;
            bookList = _context.Books.Where(x => x.IsFeatured.Equals(true) || x.Sale > 0).ToList();
        }

        public void OnGet()
        {

            _context.Books.ToList().ForEach(x => {

                _cartService.AddToCart(x.Id);

            });

        }


    }
}
