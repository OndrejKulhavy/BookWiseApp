using BookWiseApp.Database.DAO;
using BookWiseApp.Database.Models;
using BookWiseApp.email;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookWiseApp.views
{
    public partial class LoanView : Form
    {
        private int? loanId;

        public LoanView(Loan loan)
        {
            InitializeComponent();
            date_loan_start.Value = loan.LoanDate;
            date_loan_end.Value = loan.ReturnDate;
            loanId = loan.Id;
            setBooksCombo();
            setMemberCombo();

            var selectedBook = combo_loan_book.Items
                .Cast<Book>()
                .Where(b => b.Id == loan.BookId)
                .FirstOrDefault();

            if (selectedBook != null)
            {
                combo_loan_book.SelectedItem = selectedBook;
            }

            var selectedMember = combo_loan_member.Items
                .Cast<Member>()
                .Where(m => m.Id == loan.MemberId)
                .FirstOrDefault();

            if (selectedMember != null)
            {
                combo_loan_member.SelectedItem = selectedMember;
            }
        }

        public LoanView()
        {
            InitializeComponent();
            setBooksCombo();
            setMemberCombo();
        }

        private void label1_Click(object sender, EventArgs e) { }

        private void setBooksCombo()
        {
            IEnumerable<Book> books = new BookDAO().GetAll();
            foreach (Book book in books)
            {
                combo_loan_book.Items.Add(book);
            }
        }

        private void setMemberCombo()
        {
            IEnumerable<Member> members = new MemberDAO().GetAll();
            foreach (Member member in members)
            {
                combo_loan_member.Items.Add(member);
            }
        }

        private void button_loan_save_Click(object sender, EventArgs e)
        {
            Book book = (Book)combo_loan_book.SelectedItem;
            Member member = (Member)combo_loan_member.SelectedItem;
            DateTime loanDate = date_loan_start.Value;
            DateTime returnDate = date_loan_end.Value;

            Loan loan;
            if (loanId == null)
                loan = new Loan(book.Id, member.Id, loanDate, returnDate);
            else
                loan = new Loan((int)loanId, book.Id, member.Id, loanDate, returnDate);

            new LoanDAO().Save(loan);

            ReceiptSender.SendReceipt(loan);

            this.Hide();
        }
    }
}
