using System.Collections.Generic;
using BookTalk.Data;

namespace BookTalk.Data
{
    public class Book : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string CoverUrl { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        public bool IsVisible { get; set; }

        public bool IsFeatured { get; set; }
        public int Sale { get; set; }

        public virtual List<Author> Author { get; set;}

        public Book()
        {
            Title = string.Empty;
            Price = 0.0;
            Description = string.Empty;
            CoverUrl = string.Empty;
            Stock = 0;
            IsVisible = false;
            Author = new List<Author>();
        }

        public Book(string title, string description, string coverUrl, double price, int stock, int sale = 0, bool isFeatured = false, bool isVisible = false)
        {
            Title = title;
            Price = price;
            Description = description;
            CoverUrl = coverUrl;
            Stock = stock;
            IsVisible = isVisible;
            Sale = sale;
            IsFeatured = isFeatured;
            Author = new List<Author>();
        }
    }
}