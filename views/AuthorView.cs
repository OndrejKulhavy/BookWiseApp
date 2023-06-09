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
    public partial class AuthorView : Form
    {
        private int? authorId;

        public AuthorView()
        {
            InitializeComponent();
        }

        public AuthorView(Author author)
        {
            InitializeComponent();
            this.authorId = author.Id;
            input_author_first_name.Text = author.FirstName;
            input_author_last_name.Text = author.LastName;
            input_author_biography.Text = author.Biography;
        }

        private void label3_Click(object sender, EventArgs e) { }

        private void button_save_author_Click(object sender, EventArgs e)
        {
            if (authorId != null)
            {
                Author author = new Author(
                    (int)authorId,
                    input_author_first_name.Text,
                    input_author_last_name.Text,
                    input_author_biography.Text
                );
                new AuthorDAO().Save(author);
            }
            else
            {
                Author author = new Author(
                    input_author_first_name.Text,
                    input_author_last_name.Text,
                    input_author_biography.Text
                );
                new AuthorDAO().Save(author);
                Hide();
            }
        }
    }
}
