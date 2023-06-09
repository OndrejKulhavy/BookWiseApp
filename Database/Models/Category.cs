using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookWiseApp.Database.Models
{
    public class Category : IBaseClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Category(int id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }

        public Category(string name, string description)
        {
            Id = 0;
            Name = name;
            Description = description;
        }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
