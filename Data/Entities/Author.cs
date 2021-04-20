using System.ComponentModel.DataAnnotations.Schema;

namespace BookTalk.Data
{
    public class Author : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhotoUrl { get; set; }


        [ForeignKey("Id")]
        public string BookId { get; set; }
        public Book Book { get; set; }

        public Author()
        {
            FirstName = string.Empty;
            LastName = string.Empty;
            PhotoUrl = string.Empty;
        }

    }
}