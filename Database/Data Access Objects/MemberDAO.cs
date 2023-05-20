using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookWiseApp.Database.Models;


namespace BookWiseApp.Database.Data_Access_Objects
{
    public class MemberDAO : IDAO<Member>
    {
        public void Delete(Member element)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Member> GetAll()
        {
            throw new NotImplementedException();
        }

        public Member? GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void Save(Member element)
        {
            throw new NotImplementedException();
        }

    }
}
