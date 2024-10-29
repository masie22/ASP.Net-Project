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
    public partial class IssueReturnForm : Form
    {
        public IssueReturnForm()
        {
            InitializeComponent();
        }

        public void ShowErrorMessage()
        {
            int userId, bookId;
            if (userIDTextBox.Text == "" || (!int.TryParse(userIDTextBox.Text, out userId)) || (int.Parse(userIDTextBox.Text) <= 0)
                || (bookIDTextBox.Text == "" || (!int.TryParse(bookIDTextBox.Text, out bookId)) || (int.Parse(bookIDTextBox.Text) <= 0)))
            {
                errorLabel.Text = "User ID and Book ID must have an int value(value>0).";
                return;
            }
            else
            {
                errorLabel.Text = "";
            }

        }

        public DataTable GetBooks()
        {
            Database.IssueReturnClass issueReturnClass = new Database.IssueReturnClass();
            string sqlQuery = "SELECT * FROM Books";

            try
            {
                return issueReturnClass.GetAllBooks(sqlQuery, CommandType.Text);
            }
            catch (Exception ex)
            {
                errorLabel.Text = ex.Message;
                return null;
            }
        }//end GetBooks()

        private void IssuedBooksGridviewFill()
        {
            int userId = int.Parse(userIDTextBox.Text);
            issueReturnGridView.Refresh();
            //Instantiate Controller class
            Service.IssueReturnIntermediaryClass issueReturnIntermediaryClass = new Service.IssueReturnIntermediaryClass();

            DataTable booksTable = new DataTable();
            booksTable = issueReturnIntermediaryClass.GetIssueBooks(userId);
            issueReturnGridView.DataSource = booksTable;
            issueReturnGridView.ReadOnly = true;
        }

        public void FetchBookNameToTextbox()
        {
            Service.IssueReturnIntermediaryClass issueReturnIntermediaryClass = new Service.IssueReturnIntermediaryClass();

            DataTable bookDataTable = issueReturnIntermediaryClass.FetchBookName(int.Parse(bookIDTextBox.Text));
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = bookDataTable;
            bookNameTextBox.DataBindings.Add("text", bindingSource, "BookName", false);

        }

        public void FetchUsernameToTextbox()
        {
            Service.IssueReturnIntermediaryClass issueReturnIntermediaryClass = new Service.IssueReturnIntermediaryClass();

            DataTable userDataTable = issueReturnIntermediaryClass.FetchUserName(int.Parse(userIDTextBox.Text));
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = userDataTable;
            userNameTextBox.DataBindings.Add("text", bindingSource, "Name", false);
        }

        private void userNameSearchBtn_Click_1(object sender, EventArgs e)
        {
            int userId;
            Service.BookIntermediaryClass bookIntermediaryClass = new Service.BookIntermediaryClass();
            if ((!int.TryParse(userIDTextBox.Text, out userId)))
            {
                errorLabel.Text = "User ID must be an int value";
            }
             if (bookIntermediaryClass.CheckIfUserIdExists(int.Parse(userIDTextBox.Text)))
            {
                
                FetchUsernameToTextbox();

            }
            else
            {
                errorLabel.Text = "User ID does not exist";
            }
        }

        private void bookNameSearchBtn_Click_1(object sender, EventArgs e)
        {
            int bookId;
            Service.BookIntermediaryClass bookIntermediaryClass = new Service.BookIntermediaryClass();
            if ((!int.TryParse(bookIDTextBox.Text, out bookId)))
            {
                errorLabel.Text = "Book ID must be an int value";
            }
            if (bookIntermediaryClass.CheckIfIdExists(int.Parse(bookIDTextBox.Text)))
            {
                
                FetchBookNameToTextbox();

            }
            else
            {
                errorLabel.Text = "Book ID does not exist";
            }

        }

        private void issueBookButton_Click_1(object sender, EventArgs e)
        {
            if (userNameTextBox.Text != "" && bookNameTextBox.Text != "")
            {

                int noOfRows = 0;
                int userId = int.Parse(userIDTextBox.Text);
                int bookId = int.Parse(bookIDTextBox.Text);
                //Instantiate Controller class
                Service.IssueReturnIntermediaryClass issueReturnIntermediaryClass = new Service.IssueReturnIntermediaryClass();

                try
                {
                    noOfRows = issueReturnIntermediaryClass.IssueBook(userId, bookId, dueDateTimePicker.Value);

                    if (noOfRows > 0)
                    {
                        MessageBox.Show("Book has been successfully issued.");
                        IssuedBooksGridviewFill();
                        ClearControls();
                        this.Refresh();
                    }
                    else
                    {
                        errorLabel.Text = $"Cannot insert {Environment.NewLine}{issueReturnIntermediaryClass.LastError}";
                    }
                }
                catch (Exception ex)
                {
                    errorLabel.Text = ex.Message;
                }
            }
            else
            {
                errorLabel.Text = "Enter valid userID and bookID";
            }
        }

        private void returnBookButton_Click_1(object sender, EventArgs e)
        {
            if (userNameTextBox.Text != "" && bookNameTextBox.Text != "")
            {
                
                int userId = int.Parse(userIDTextBox.Text);
                int bookId = int.Parse(bookIDTextBox.Text);                
                double fine = 0;

                //Instantiate Controller class
                Service.IssueReturnIntermediaryClass issueReturnIntermediaryClass = new Service.IssueReturnIntermediaryClass();
                if (issueReturnIntermediaryClass.CheckIfIdExists(userId, bookId))
                {
                    DateTime returnDate = System.DateTime.Now;
                    DateTime dueDateString = issueReturnIntermediaryClass.GetDueDate(userId, bookId);
                    //DateTime dueDate = DateTime.Parse(dueDateString);

                    if (dueDateString >= returnDate)
                    {
                        //ok return
                        //update issuebooks table with new return date and status is returened and fine is 0
                        issueReturnIntermediaryClass.ReturnBook(userId, bookId, returnDate, fine);
                        MessageBox.Show("Book has been successfully returned.");
                        IssuedBooksGridviewFill();
                        ClearControls();
                        this.Refresh();
                    }
                    else
                    {
                        //fine calculate
                        int daysdifference = (int)((returnDate - dueDateString).TotalDays);
                        fine = daysdifference * 5;
                        issueReturnIntermediaryClass.ReturnBook(userId, bookId, returnDate, fine);
                        MessageBox.Show("Book has been successfully returned with a fine.");
                        IssuedBooksGridviewFill();
                        ClearControls();
                    }

                }

            }
        }

        private void ClearControls()
        {
            userIDTextBox.Clear();
            bookIDTextBox.Clear();
            userNameTextBox.Clear();
            bookNameTextBox.Clear();
        }
    }
}

