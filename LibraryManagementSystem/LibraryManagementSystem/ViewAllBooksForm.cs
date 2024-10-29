using LibraryManagementSystem.Classes;
using LibraryManagementSystem.Database;
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
    public partial class ViewAllBooksForm : Form
    {
        private BookIntermediaryClass intermediaryBookClass = new BookIntermediaryClass();
        
        public ViewAllBooksForm()
        {
            InitializeComponent();
        }

        private void ViewAllBooks_Load(object sender, EventArgs e)
        {

                DataTable booksTable = new DataTable();
                booksTable = intermediaryBookClass.GetBooks();
                allBooksGridView.DataSource = booksTable;
                allBooksGridView.ReadOnly = true;

        }


        private void ViewAllBooksForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            

        }
    }
}
