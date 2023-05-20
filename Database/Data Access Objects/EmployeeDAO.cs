using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookWiseApp.Database.Models;

namespace BookWiseApp.Database.Data_Access_Objects
{
    public class EmployeeDAO : IDAO<Employee>
    {
        public void Delete(Employee element)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employee> GetAll()
        {
            throw new NotImplementedException();
        }

        public Employee? GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void Save(Employee element)
        {
            throw new NotImplementedException();
        }
    }
}
