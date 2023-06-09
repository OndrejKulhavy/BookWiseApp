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
    public partial class BookView : Form
    {
        private Book? book;

        public BookView()
        {
            InitializeComponent();

            setAuthorsCombo();

            setGenresCombo();
        }

        public BookView(Book book)
        {
            InitializeComponent();
            setAuthorsCombo();
            setGenresCombo();
            this.book = book;
            input_book_title.Text = book.Title;
            input_book_isbn.Text = book.ISBN;
            datePicker_book_published.Value = book.PublicationDate;

            var selectedAuthor = combo_book_author.Items
                .Cast<Author>()
                .Where(a => a.Id == book.AuthorId)
                .FirstOrDefault();

            if (selectedAuthor != null)
            {
                combo_book_author.SelectedItem = selectedAuthor;
            }

            var selectedGenre = combo_book_category.Items
                .Cast<Category>()
                .Where(c => c.Id == book.CategoryId)
                .FirstOrDefault();

            if (selectedGenre != null)
            {
                combo_book_category.SelectedItem = selectedGenre;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) { }

        private void setAuthorsCombo()
        {
            IEnumerable<Author> authors = new AuthorDAO().GetAll();
            foreach (Author author in authors)
            {
                combo_book_author.Items.Add(author);
            }
        }

        private void setGenresCombo()
        {
            IEnumerable<Category> genres = new CategoryDAO().GetAll();
            foreach (Category genre in genres)
            {
                combo_book_category.Items.Add(genre);
            }
        }

        private void button_book_save_Click(object sender, EventArgs e)
        {
            if (book == null)
            {
                book = new Book(
                    input_book_title.Text,
                    ((Author)combo_book_author.SelectedItem).Id,
                    ((Category)combo_book_category.SelectedItem).Id,
                    input_book_isbn.Text,
                    datePicker_book_published.Value
                );
            }
            else
            {
                book.Title = input_book_title.Text;
                book.AuthorId = ((Author)combo_book_author.SelectedItem).Id;
                book.CategoryId = ((Category)combo_book_category.SelectedItem).Id;
                book.ISBN = input_book_isbn.Text;
                book.PublicationDate = datePicker_book_published.Value;
            }

            new BookDAO().Save(book);
            this.Hide();
        }
    }
}
