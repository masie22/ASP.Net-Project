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
    public partial class UserLoanHistory : Form
    {
        public UserLoanHistory()
        {
            InitializeComponent();
        }

        private void userIdTextbox_Leave(object sender, EventArgs e)
        {
            BookIntermediaryClass bookIntermediaryClass = new BookIntermediaryClass();

            DataTable booksTable = new DataTable();
            if(userIdTextbox.Text != "")
            {
                booksTable = bookIntermediaryClass.GetLoanedBooks(userIdTextbox.Text);
                userHistorydataGridView.DataSource = booksTable;
                userHistorydataGridView.ReadOnly = true;
            }
            else
            {
                MessageBox.Show("User ID is not Found.");
            }
            
        }
    }
}
