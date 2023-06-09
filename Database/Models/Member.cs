using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookWiseApp.Database.Models
{
    public class Member : IBaseClass
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public Member(
            int id,
            string firstName,
            string lastName,
            string address,
            string email,
            string phone
        )
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            Email = email;
            PhoneNumber = phone;
        }

        public Member(string firstName, string lastName, string address, string email, string phone)
        {
            Id = 0;
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            Email = email;
            PhoneNumber = phone;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
