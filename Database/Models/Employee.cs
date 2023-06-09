using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookWiseApp.Database.Models
{
    public class Employee : IBaseClass
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set;}
        public string PasswordHash { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    
        public Employee(int id, string firstName, string lastName, string passwordHash, string email, string phoneNumber)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            PasswordHash = passwordHash;
            Email = email;
            PhoneNumber = phoneNumber;
        }

        public Employee(string firstName, string lastName, string passwordHash, string email, string phoneNumber)
        {
            Id = 0;
            FirstName = firstName;
            LastName = lastName;
            PasswordHash = passwordHash;
            Email = email;
            PhoneNumber = phoneNumber;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
