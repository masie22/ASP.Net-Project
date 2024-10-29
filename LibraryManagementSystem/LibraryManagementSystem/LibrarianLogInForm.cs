using System;
using LibraryManagementSystem.Service;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class LibrarianLogInForm : Form
    {
        public LibrarianLogInForm()
        {
            InitializeComponent();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void issueBookToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            IssueReturnForm issueReturnBooks = new IssueReturnForm();
            issueReturnBooks.Show();
        }

        private void LibrarianLogInForm_Load(object sender, EventArgs e)
        {
            BookIntermediaryClass bookIntermediaryClass = new BookIntermediaryClass();

            DataTable booksTable = new DataTable();
            booksTable = bookIntermediaryClass.FillGenre();
            searchGenreDropdown.DataSource = booksTable;
            searchGenreDropdown.ValueMember = "Genre";
            searchGenreDropdown.DisplayMember = "Genre";
        }

        private void searchBookButton_Click(object sender, EventArgs e)
        {
            BookIntermediaryClass bookIntermediaryClass = new BookIntermediaryClass();

            DataTable booksTable = new DataTable();
            booksTable = bookIntermediaryClass.GetSelectedBooks(searchGenreDropdown.SelectedValue.ToString(), bookNameTextbox.Text);
            searchedBookGridView.DataSource = booksTable;
            searchedBookGridView.ReadOnly = true;
        }

        private void showAllBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewAllBooksForm viewAllBooksForm = new ViewAllBooksForm();
            viewAllBooksForm.Show();
        }
    }
}
