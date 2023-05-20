using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BookWiseApp.Database.Models;
using System.Threading.Tasks;

namespace BookWiseApp.Database.Data_Access_Objects
{
    public class LoanDAO : IDAO<Loan>
    {
        public void Delete(Loan element)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Loan> GetAll()
        {
            throw new NotImplementedException();
        }

        public Loan? GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void Save(Loan element)
        {
            throw new NotImplementedException();
        }
    }
}
