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
    public partial class StudentFacultyLogInForm : Form
    {
        public StudentFacultyLogInForm()
        {
            InitializeComponent();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogInForm logInForm = new LogInForm();
            logInForm.Show();
            this.Close();
        }

        private void findBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchBookForm searchBook = new SearchBookForm();
            searchBook.Show();
        }

        private void userDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserLoanHistory loanHistory = new UserLoanHistory();
            loanHistory.Show();
        }
    }
}
