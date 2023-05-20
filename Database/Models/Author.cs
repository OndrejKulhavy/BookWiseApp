using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookWiseApp.Database.Models
{
    internal class Author
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Biography { get; set; }

        public Author(int id, string firstName, string lastName, string biography)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Biography = biography;
        }
    }
}
