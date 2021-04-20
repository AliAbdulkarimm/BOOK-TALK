using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BookTalk.Pages.Admin.Content
{
    [Authorize(Roles = "Admin")]
    public class EditModel : PageModel
    {

        private Context _context;

        [BindProperty]
        public Data.Content _content { get; set; }
        public EditModel(Context context)
        {
            _context = context;
        }

        public void OnGet(string contentid)
        {
            _content = _context.Content.Where(x => x.Id == contentid).FirstOrDefault();

            _context.Entry(_content).State = EntityState.Detached;


            if (_content is null)
            {
                ViewData["message"] = "Content was not found!";
            }
        }


        public void OnPostSaveContent(string title, string body, string imgurl, bool isinmenu, bool ispublished, int menuorder, string contentid)
        {
            try
            {

                Data.Content dc = _context.Content.Where(x => x.Id == contentid).FirstOrDefault();

                _context.Entry(dc).State = EntityState.Modified;

                // force
                ispublished = true;
                isinmenu = true;

                dc.Title = title;
                dc.Body = body;
                dc.ImageUrl = imgurl;
                dc.IsInMenu = isinmenu;
                dc.IsPublished = ispublished;
                dc.MenuOrder = menuorder;
                
                _context.Content.Update(dc);

                _context.SaveChanges();

                ViewData["message"] = "Your content has been updated!";

            }
            catch (Exception ex)
            {
                ViewData["message"] = $"Something went wrong. Error: {ex}";
            }

        }

    }
}
