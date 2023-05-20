using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookWiseApp.Database.Models
{
    public class Scan : IBaseClass
    {
        public int Id { get; set; }
        public string ISBN { get; set; }
        public DateTime ScanDate { get; set; }

        public Scan(int id, string isbn, DateTime scanDate)
        {
            Id = id;
            ISBN = isbn;
            ScanDate = scanDate;
        }

        public Scan(string isbn, DateTime scanDate)
        {
            Id = 0;
            ISBN = isbn;
            ScanDate = scanDate;
        }
    }
}
