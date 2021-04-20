using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookTalk.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookTalk.Pages.Store
{

    public class DetailModel : PageModel
    {
        private Context _context;

        public Book book { get; set; }
        public DetailModel(Context context)
        {
            _context = context;
            book = new Book();

        }


       
        public void OnGet(string bookId)
        {

           book = _context.Books.Find(bookId);

            if (book is null)
            {
                book.Title = "Book was not found";
            }


        }
    }
}
