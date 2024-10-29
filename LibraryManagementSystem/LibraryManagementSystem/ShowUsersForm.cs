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
    public partial class ShowUsersForm : Form
    {
        public ShowUsersForm()
        {
            InitializeComponent();
        }

   
        private void usertypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddUserInter showuser = new AddUserInter();
            dataGridView1.DataSource = showuser.getAllUserData(usertypeComboBox.SelectedItem.ToString());
        }

        private void ShowUsers_FormClosed(object sender, FormClosedEventArgs e)
        {
            AdminLogIn adminLogIn = new AdminLogIn();
            adminLogIn.Show();
            this.Hide();
        }
    }
}
