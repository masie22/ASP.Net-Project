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
    public partial class AdminLogIn : Form
    {
        public AdminLogIn()
        {
            InitializeComponent();
        }

        private void showBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewAllBooksForm allBooksForm = new ViewAllBooksForm();
            allBooksForm.Show();
        }

        private void showUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowUsersForm users = new ShowUsersForm();   
            users.Show();
            this.Hide();
            
        }

        private void addUpdateDeleteBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AUDBooksForm bookForm = new AUDBooksForm();
            bookForm.Show();
        }

        private void addUpdateDeleteUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserForm form = new UserForm();
            form.Show();
            this.Close();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogInForm logInForm = new LogInForm();
            logInForm.Show();
            this.Close();
         
        }
    }
}
