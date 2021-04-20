using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BookTalk.Data;
using Microsoft.AspNetCore.Authorization;

namespace BookTalk.Pages.Admin.Content
{

    [Authorize( Roles = "Admin")]
    public class IndexModel : PageModel
    {
        private readonly Context _context;


        [BindProperty]
        public List<ContentListModel> contentList { get; set; }

        private static List<ContentListModel> _cl = new List<ContentListModel>();


        public IndexModel(Context context)
        {
            _context = context;

            contentList = new List<ContentListModel>();

            

        }


        public void OnGet()
        {

            if (contentList is null)
            {
                contentList = _cl;
            }

            RefreshContent();

            

        }


        private void RefreshContent()
        {

            foreach (var content in _context.Content.ToList())
            {

                ContentListModel model = new ContentListModel
                {
                    Id = content.Id,
                    Title = content.Title,
                    Body = content.Body,
                    ImageUrl = content.ImageUrl,
                    IsInMenu = content.IsInMenu,
                    IsPublished = content.IsPublished,
                    MenuOrder = content.MenuOrder

                };

                contentList.Add(model);

                contentList = contentList.OrderBy(x => x.MenuOrder).ToList();

                _cl = contentList;

            }
        }

        public IActionResult OnPostDeleteContent(string contentid)
        {
            Data.Content content = _context.Content.Where(x => x.Id == contentid).FirstOrDefault();

            if (content is not null)
            {

                _context.Content.Remove(content);
                _context.SaveChanges();
            
            }

            RefreshContent();

            return Page();
   
        }



    }
}
