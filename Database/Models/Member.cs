using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookWiseApp.Database.Models
{
    internal class Member
    {
        public int Id { get; set;}
        public string FirstName { get; set;}
        public string LastName { get; set;}
        public string Address { get; set;}
        public string Email { get; set;}
        public string Phone { get; set;}

        public Member(int id, string firstName, string lastName, string address, string email, string phone)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            Email = email;
            Phone = phone;
        }
    }
}
