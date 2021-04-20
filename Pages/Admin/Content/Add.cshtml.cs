using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookTalk.Pages.Admin.Content
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


        public void OnPostAddContent(string title, string body, string imgurl, bool isinmenu, bool ispublished, int menuorder)
        {
            try
            {
                Data.Content content = new Data.Content(title, body = body, isinmenu, ispublished, imgurl, menuorder);

                _context.Content.Add(content);

                _context.SaveChanges();

                ViewData["message"] = "Your content has been added!";

            }
            catch (Exception ex)
            {
                ViewData["message"] = $"Something went wrong. Error: {ex}";
            }

        }

    }
}
