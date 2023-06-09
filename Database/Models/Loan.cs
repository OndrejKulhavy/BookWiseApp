using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookWiseApp.Database.Models
{
    public class Loan : IBaseClass
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public int MemberId { get; set; }
        public DateTime LoanDate { get; set; }
        public DateTime ReturnDate { get; set; }

        public Loan(int id, int bookId, int memberId, DateTime loanDate, DateTime returnDate)
        {
            Id = id;
            BookId = bookId;
            MemberId = memberId;
            LoanDate = loanDate;
            ReturnDate = returnDate;
        }

        public Loan(int bookId, int memberId, DateTime loanDate, DateTime returnDate)
        {
            Id = 0;
            BookId = bookId;
            MemberId = memberId;
            LoanDate = loanDate;
            ReturnDate = returnDate;
        }

        public override string ToString()
        {
            return $"{Id} {BookId} {MemberId} {LoanDate} {ReturnDate}";
        }
    }
}
