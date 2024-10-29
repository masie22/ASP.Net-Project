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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //instantiating about box 
            AboutBox aboutBox = new AboutBox();
            //make mainform parent of aboutbox
            aboutBox.MdiParent = this;
            //display about box
            aboutBox.Show();
        }

        private void logInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //instansiate Login form
            LogInForm logInForm = new LogInForm();
            logInForm.MdiParent = this;
            logInForm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisterUserForm register = new RegisterUserForm();
            register.MdiParent = this;
                register.Show();
            
        }
    }
}
