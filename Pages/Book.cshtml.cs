using System;
using System.Collections.Generic;
using BookTalk.Data;
using BookTalk.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookTalk.Pages
{
    public class BookModel : PageModel
    {
        private Context _context;

        public BookPageModel contentModel;
        public BookModel(Context context)
        {
            _context = context;
            contentModel = new BookPageModel();
        }

        public void OnGet(string bookId)
        {
            Book book = _context.Books.Find(bookId);

            contentModel.Title = book.Title;
            contentModel.Description = book.Description;
            contentModel.ImageUrl = book.CoverUrl;
            contentModel.Price = book.Price;
        }
    }


}
