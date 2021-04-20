using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookTalk.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookTalk.Pages.Admin.Store
{
    [Authorize( Roles = "Admin")]
    public class IndexModel : PageModel
    {
        private readonly Context _context;

        public List<Book> books { get; set; } = new List<Book>();

        public IndexModel(Context context)
        {
            _context = context;
            books = _context.Books.ToList();
        }
        public void OnGet(string value)
        {
            if (!string.IsNullOrWhiteSpace(value))
            {

                ViewData["message"] = $"Book added: {_context.Books.Where(x => x.Id == value).FirstOrDefault().Title}";

            }
            else
            {

                ViewData["message"] = string.Empty;
            }
        }
    }
}
