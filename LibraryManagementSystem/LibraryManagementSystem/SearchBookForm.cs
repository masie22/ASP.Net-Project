using LibraryManagementSystem.Database;
using LibraryManagementSystem.Classes;
using LibraryManagementSystem.Service;
using System;
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
    public partial class SearchBookForm : Form
    {
        public SearchBookForm()
        {
            InitializeComponent();
        }

        private void UserLogIn_Load(object sender, EventArgs e)
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
            SearchBook();
        }

        private void SearchBook()
        {
            BookIntermediaryClass bookIntermediaryClass = new BookIntermediaryClass();

            DataTable booksTable = new DataTable();
            booksTable = bookIntermediaryClass.GetSelectedBooks(searchGenreDropdown.SelectedValue.ToString(), bookNameTextbox.Text);
            searchedBookGridView.DataSource = booksTable;
            searchedBookGridView.ReadOnly = true;
        }

        private void findBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogInForm logInForm = new LogInForm();
            logInForm.Show();
            this.Close();
        }
    }
}
