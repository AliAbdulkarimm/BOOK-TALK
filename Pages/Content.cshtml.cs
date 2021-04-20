using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookTalk.Data;
using BookTalk.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookTalk.Pages
{
    public class ContentModel : Microsoft.AspNetCore.Mvc.RazorPages.PageModel
    {
        private Context _context;
        private EmailService _email;

        public ContentPageModel contentModel;

        [BindProperty]
        public SendEmailModel emailModel { get; set; }

        public bool showContactForm = false;
        public bool showEmailSentSuccess = false;
        public ContentModel(Context context, EmailService emailService)
        {
            _context = context;
            _email = emailService;
            contentModel = new ContentPageModel();
        }

        public void OnGet(string pageName)
        {

            if (pageName.ToLower().Equals("Contact".ToLower()))
            {
                showContactForm = true;
            }
            else
            {
                showContactForm = false;
            }

            if (pageName is not null)
            {
                // Get the current content named in "page string" from database using the title as a find atribute.
                Data.Content content = _context.Content.Where(page => page.Title.Equals(pageName)).FirstOrDefault();
                
                if (content is not null) 
                {
                    if (content.IsPublished)
                    {
                        contentModel.Title = content.Title;
                        contentModel.Body = content.Body;
                        contentModel.ImageUrl = content.ImageUrl;
                    }
                    else
                    {
                        contentModel.Title = "Sorry, this page has not been published";
                    }
                }
                else
                {
                    contentModel.Title = "Sorry, this page does not exist (404)";
                }

            }
            else
            {
                contentModel.Title = "Sorry, you have no query";
            }

        }


        public void OnPostSendEmail(IFormFile file)
        {
            bool didSend =_email.SendContactEmail(emailModel);

            if (didSend)
            {
                showEmailSentSuccess = true;
            }
        }
    }
}
