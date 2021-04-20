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
    [Authorize(Roles = "Admin")]
    public class AddModel : PageModel
    {

        private Context _context;

        public AddModel(Context context)
        {
            _context = context;
        }

        public void OnGet()
        {
        }


        public IActionResult OnPostAddNewBook(string title, string description, string coverurl, double price, int stock, int sale )
        {

            try 
            {
                Book book = new Book(title, description, coverurl, price, stock, sale, false, true);

                _context.Books.Add(book);

                _context.SaveChanges();

                ViewData["message"] = "Book has been saved!";

                return LocalRedirect($"/admin/store/{book.Id}");
            }
            catch(Exception ex)
            {
                ViewData["message"] = $"Something went wrong! {ex}";

                return Page();

            }


        }


    }
}
