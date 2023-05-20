using BookWiseApp.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookWiseApp.Database
{
    public interface IDAO<T> where T : IBaseClass
    {
        T? GetByID(int id);
        IEnumerable<T> GetAll();
        void Save(T element);
        void Delete(T element);
    }
}