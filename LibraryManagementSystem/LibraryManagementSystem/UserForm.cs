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
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            AddUserInter addUserInter = new AddUserInter();
            User user = new User();
            user.UserId = userIdTextBox.Text;
            user.Username = usernameTextBox.Text;
            user.Password = passwordTextBox.Text;
            user.Name = nameTextBox.Text;
            user.Contact = contactTextBox.Text;
            user.Level = levelComboBox.Text;
            user.Program = programTextBox.Text;
            user.UserType = roleComboBox.Text;

            string message = addUserInter.insertUserDetail(user);


            MessageBox.Show(message);

            if (message.Equals("User added Successfully"))
            {
                ClearData();
            }

        }

      

        private void useridTextBox_Leave(object sender, EventArgs e)
        {
            String userid = userIdTextBox.Text;

            AddUserInter inter = new AddUserInter();

            User user = inter.getUserDatafromID(userid);

            if(user != null)
            {
                nameTextBox.Text = user.Name;
                contactTextBox.Text = user.Contact;
                programTextBox.Text = user.Program;
                levelComboBox.SelectedItem = user.Level;
                roleComboBox.SelectedItem = user.UserType;
                usernameTextBox.Text = user.Username;
                passwordTextBox.Text = user.Password;
            }
        }

        private void UserForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            AdminLogIn obj = new AdminLogIn();
            obj.Show();
        }

        private void updateUserButton_Click(object sender, EventArgs e)
        {
            AddUserInter userInter = new AddUserInter();
            User user = new User();
            user.UserId = userIdTextBox.Text;
            user.Username = usernameTextBox.Text;
            user.Password = passwordTextBox.Text;
            user.Name = nameTextBox.Text;
            user.Contact = contactTextBox.Text;
            user.Level = levelComboBox.Text;
            user.Program = programTextBox.Text;
            user.UserType = roleComboBox.Text;

            string message = userInter.updateUser(user);

            MessageBox.Show(message);

            if (message.Equals("User updated"))
            {
                dataGridView1.DataSource = userInter.getAllUserData();

                ClearData();
            }
           
        }

        private void deleteUserButton_Click(object sender, EventArgs e)
        {
            AddUserInter userInter = new AddUserInter();
            User user = new User();
            user.UserId = userIdTextBox.Text;
            user.Username = usernameTextBox.Text;
            user.Password = passwordTextBox.Text;
            user.Name = nameTextBox.Text;
            user.Contact = contactTextBox.Text;
            user.Level = levelComboBox.Text;
            user.Program = programTextBox.Text;
            user.UserType = roleComboBox.Text;

            string message = userInter.DeleteUser(user);
            MessageBox.Show(message);

            if (message.Equals("User Deleted"))
            {
                dataGridView1.DataSource = userInter.getAllUserData();

                ClearData();
            }

        }


        private void ClearData()
        {
            userIdTextBox.Clear();
            usernameTextBox.Clear();
            passwordTextBox.Clear();
            nameTextBox.Clear();
            contactTextBox.Clear();
            levelComboBox.SelectedIndex=0;
            roleComboBox.SelectedIndex = 0;
            programTextBox.Clear();

        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
