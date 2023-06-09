using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookWiseApp.Database.Models
{
    public class Book : IBaseClass
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public int CategoryId { get; set; }
        public string ISBN { get; set; }
        public DateTime PublicationDate { get; set; }
        
        public Book(int id, string title, int authorId, int categoryId, string isbn, DateTime publicationDate)
        {
            Id = id;
            Title = title;
            AuthorId = authorId;
            CategoryId = categoryId;
            ISBN = isbn;
            PublicationDate = publicationDate;
        }

        public Book(string title, int authorId, int categoryId, string isbn, DateTime publicationDate)
        {
            Id = 0;
            Title = title;
            AuthorId = authorId;
            CategoryId = categoryId;
            ISBN = isbn;
            PublicationDate = publicationDate;
        }

        public override string ToString()
        {
            return $"{Title}";
        }
    }



}
