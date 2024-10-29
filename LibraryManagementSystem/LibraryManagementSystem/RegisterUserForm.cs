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
    public partial class RegisterUserForm : Form
    {
        public RegisterUserForm()
        {
            InitializeComponent();
        }

        private void deleteUserButton_Click(object sender, EventArgs e)
        {
         }

        private void addUserButton_Click(object sender, EventArgs e)
        {

        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegisterUserForm_Load(object sender, EventArgs e)
        {

        }


       
        private void submitButton_Click_1(object sender, EventArgs e)
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

            if(user.UserId != "")
            {
                string message = addUserInter.registerUser(user);

                MessageBox.Show(message);
            }
            else
            {
                MessageBox.Show("User ID cannot be empty");
            }
            
        }

        private void cancelButton_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            LogInForm logIn = new LogInForm();
            logIn.Show();


        }
    }
}
