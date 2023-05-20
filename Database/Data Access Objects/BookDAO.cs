using System;
using System.Collections.Generic;
using BookWiseApp.Database.Models;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookWiseApp.Database.Data_Access_Objects
{
    public class BookDAO : IDAO<Book>
    {
        public void Delete(Book element)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Book> GetAll()
        {
            throw new NotImplementedException();
        }

        public Book? GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void Save(Book element)
        {
            throw new NotImplementedException();
        }
    
    }
}
