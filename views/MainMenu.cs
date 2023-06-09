using BookWiseApp.Database.DAO;
using BookWiseApp.Database.Models;
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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            loadLoans();
            loadBooks();
            loadMembers();
            loadAuthors();
           // loadScans();
        }

        private void dataGridLoans_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try {
                Loan selectedLoan = dataGridLoans.SelectedRows[0].DataBoundItem as Loan;
                new LoanView(selectedLoan).Show();
            }
            catch
            {
                MessageBox.Show("Please select a loan");
            }
        }
        private void loadLoans()
        {
            LoanDAO loanDAO = new LoanDAO();
            IEnumerable<Loan> loans = loanDAO.GetAll();
            dataGridLoans.DataSource = loans.ToList();
        }

        private void loadBooks()
        {
            BookDAO bookDAO = new BookDAO();
            IEnumerable<Book> books = bookDAO.GetAll();
            dataGridBooks.DataSource = books.ToList();
        }

        private void loadMembers()
        {
            MemberDAO memberDAO = new MemberDAO();
            IEnumerable<Member> members = memberDAO.GetAll();
            dataGridMembers.DataSource = members.ToList();
        }
        
        private void loadAuthors()
        {
            AuthorDAO authorDAO = new AuthorDAO();
            IEnumerable<Author> authors = authorDAO.GetAll();
            dataGridAuthors.DataSource = authors.ToList();
        }
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void memberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new MemberView().Show();
        }

        private void bookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new BookView().Show();
        }

        private void loanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new LoanView().Show();
        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CategoryView().Show();
        }

        private void authorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AuthorView().Show();
        }
    }
}
