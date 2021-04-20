using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookTalk.Data
{
    public class ContentListModel : BaseEntity
    {
        public string Title { get; set; }
        public string Body { get; set; }
        public string ImageUrl { get; set; }
        public bool IsInMenu { get; set; }
        public bool IsPublished { get; set; }
        public int MenuOrder { get; set; }

    }
}
