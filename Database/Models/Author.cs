using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookWiseApp.Database.Models
{
    public class Author : IBaseClass
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

        public Author(string firstName, string lastName, string biography)
        {
            Id = 0;
            FirstName = firstName;
            LastName = lastName;
            Biography = biography;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
