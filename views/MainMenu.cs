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

        private void dataGridLoans_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void dataGridLoans_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Loan? selectedLoan = dataGridLoans.SelectedRows[0].DataBoundItem as Loan;
                new LoanView(selectedLoan).Show();
            }
            catch
            {
                MessageBox.Show("Please select a loan");
            }
        }

        private void dataGridBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Book? selectedBook = dataGridBooks.SelectedRows[0].DataBoundItem as Book;
                new BookView(selectedBook).Show();
            }
            catch
            {
                MessageBox.Show("Please select a book");
            }
        }

        private void dataGridAuthors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Author? selectedAuthor = dataGridAuthors.SelectedRows[0].DataBoundItem as Author;
                new AuthorView(selectedAuthor).Show();
            }
            catch
            {
                MessageBox.Show("Please select an author");
            }
        }

        private void dataGridMembers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /*
            try
            {
                Member? selectedMember = dataGridMembers.SelectedRows[0].DataBoundItem as Member;
                new MemberView(selectedMember).Show();
            }
            catch
            {
                MessageBox.Show("Please select a member");
            }*/
        }

        private void dataGridScans_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // try
            // {
            //     Scan? selectedScan = dataGridScans.SelectedRows[0].DataBoundItem as Scan;
            //     new ScanView(selectedScan).Show();
            // }
            // catch
            // {
            //     MessageBox.Show("Please select a scan");
            // }
        }



        private void loadLoans()
        {
            LoanDAO loanDAO = new LoanDAO();
            IEnumerable<Loan> loans = loanDAO.GetAll();
            dataGridLoans.DataSource = loans.ToList();

            dataGridLoans.Columns["Id"].Visible = false;
        }

        private void loadBooks()
        {
            BookDAO bookDAO = new BookDAO();
            IEnumerable<Book> books = bookDAO.GetAll();
            dataGridBooks.DataSource = books.ToList();

            dataGridBooks.Columns["Id"].Visible = false;
        }

        private void loadMembers()
        {
            MemberDAO memberDAO = new MemberDAO();
            IEnumerable<Member> members = memberDAO.GetAll();
            dataGridMembers.DataSource = members.ToList();

            dataGridMembers.Columns["Id"].Visible = false;
        }

        private void loadAuthors()
        {
            AuthorDAO authorDAO = new AuthorDAO();
            IEnumerable<Author> authors = authorDAO.GetAll();
            dataGridAuthors.DataSource = authors.ToList();

            dataGridAuthors.Columns["Id"].Visible = false;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e) { }

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

        private void authorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AuthorView().Show();
        }

        private void dataGridMembers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadLoans();
            loadBooks();
            loadMembers();
            loadAuthors();
        }

        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
