using BookWiseApp.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookWiseApp.Database.Data_Access_Objects
{
    public class AuthorDAO : IDAO <Author>
    {
        public void Delete(Author element)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Author> GetAll()
        {
            throw new NotImplementedException();
        }

        public Author? GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void Save(Author element)
        {
            throw new NotImplementedException();
        }
    }
}
