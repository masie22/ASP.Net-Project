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
    public partial class ForgotPasswordForm : Form
    {
        public ForgotPasswordForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            // If any of the fields are empty, it is throwing some exception. So , I added just one line here.
                if (userIDTextBox.Text != "" && usernameTextBox.Text != "" && passwordTexBox.Text != "" && confirmPassTextBox.Text != "")
                {
                    if (passwordTexBox.Text.Equals(confirmPassTextBox.Text))
                    {
                        User user = new User();
                        user.UserId = userIDTextBox.Text;
                        user.Username = usernameTextBox.Text;
                        user.Password = passwordTexBox.Text;
                        Login_inter inter = new Login_inter();
                        string message = inter.ForgotPassword(user);
                        MessageBox.Show(message);
                        if (message.Equals("Password Updated Successfully"))
                        {
                            LogInForm form = new LogInForm();
                            form.Show();
                        this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Passwords Not Matched");
                    }
                }
                else
                {
                    MessageBox.Show("Please fill up all the fields");
                }
            }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            LogInForm form = new LogInForm();
            form.Show();
            this.Close();
        }
    }
}
