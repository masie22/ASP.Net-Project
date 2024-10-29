using LibraryManagementSystem.Classes;
using LibraryManagementSystem.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
            userTypeComboBox.SelectedIndex = 0;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            //Login Button clicked
            try
            {

                User user = new User();     //instantiate user class
                 

                user.UserType = userTypeComboBox.Text;   //properties accessed in this form class
                user.Username = usernameTextBox.Text;
                user.Password = passwordTextBox.Text;

                Login_inter inter = new Login_inter();    //instantiate the login intermediate class

                Boolean b = inter.Getdata(user);     //calling GetData method on  the login intermediate class

                if (b)
                {
                    MessageBox.Show("Login Successful");
                    if (userTypeComboBox.SelectedIndex == 1)
                    {
                        AdminLogIn obj = new AdminLogIn();
                        obj.Show();
                        this.Hide();
                    }
                    else
                    {
                        if (userTypeComboBox.SelectedIndex == 2)
                        {
                            LibrarianLogInForm obj1 = new LibrarianLogInForm();
                            obj1.Show();
                            this.Hide();
                        }

                        else
                        {
                            if (userTypeComboBox.SelectedIndex == 3)
                            {
                                StudentFacultyLogInForm obj2 = new StudentFacultyLogInForm();
                                obj2.Show();
                                this.Hide();
                            }
                            else
                            {
                                if (userTypeComboBox.SelectedIndex == 4)
                                {
                                    StudentFacultyLogInForm obj3 = new StudentFacultyLogInForm();
                                    obj3.Show();
                                    this.Hide();
                                }
                            }

                        }
                    }
                }
                else
                {
                    MessageBox.Show("Login Failure\nPlease try Again");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            

        }

        private void clearbutton_Click(object sender, EventArgs e)
        {
            usernameTextBox.Clear();
            passwordTextBox.Clear();
            userTypeComboBox.SelectedIndex = 0;
          
        }

        private void LogInForm_Load_1(object sender, EventArgs e) //doubt??
        {

        }

       


        private void userTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            {
                User user = new User();     //instantiate user class
                user.UserType = userTypeComboBox.Text;   //properties accessed in this form class
                user.Username = usernameTextBox.Text;
                user.Password = passwordTextBox.Text;
                Login_inter inter = new Login_inter();    //instantiate the login intermediate class
                Boolean b = inter.Getdata(user);     //calling GetData method on  the login intermediate class
                if (b)
                {
                    MessageBox.Show("User already exists");
                }
                else
                {
                    this.Hide();
                    RegisterUserForm userform = new RegisterUserForm();
                    userform.Show();
                }
            }

        }

        private void forgotPwdButton_Click(object sender, EventArgs e)
        {
            ForgotPasswordForm form = new ForgotPasswordForm();
            form.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
    }

