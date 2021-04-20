using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookTalk.Data
{
    public class Content : BaseEntity
    {
        public string Title { get; set; }
        public string Body { get; set; }
        public string ImageUrl { get; set; }
        public bool IsInMenu { get; set; }
        public bool IsPublished { get; set; }

        public int MenuOrder { get; set; }

        public Content(string title, string body, bool isInMenu = false, bool isPublished = false, string imgUrl = "")
        {

            Title = title;
            Body = body;
            IsInMenu = isInMenu;
            IsPublished = isPublished;
            ImageUrl = imgUrl;
            MenuOrder = 100;

            // (Condition) if true -> do this : else do this 
            //            (        condition         )   (   true   ) : ( false )  
            // ImageUrl = string.IsNullOrEmpty(imgUrl) ? string.Empty : imgUrl;

            // These two codes to the exakt same thing. 

            //if (string.IsNullOrEmpty(imgUrl))
            //{
            //    imgUrl = string.Empty;
            //}
            //else
            //{
            //    imgUrl = imgUrl;
            //}

        }

        public Content(string title, string body, bool isInMenu, bool isPublished, string imgUrl, int menuorder)
        {

            Title = title;
            Body = body;
            IsInMenu = isInMenu;
            IsPublished = isPublished;
            ImageUrl = imgUrl;
            MenuOrder = menuorder;

        }

        public Content()
        {
            
        }
    }
}
