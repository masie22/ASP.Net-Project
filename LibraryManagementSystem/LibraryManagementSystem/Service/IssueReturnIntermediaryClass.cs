using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem.Service
{
    class IssueReturnIntermediaryClass
    {
        public string LastError;
        public bool CheckIfIdExists(int bookId)
        {
            Database.IssueReturnClass issueReturnClass = new Database.IssueReturnClass();

            string query = "SELECT * FROM Books WHERE BookId = '" + bookId + "';";
            SqlDataReader reader = issueReturnClass.CheckBookDataById(query);

            if (reader.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public DataTable FetchBookName(int bookId)
        {
            //get all data from a table through select query and return it back
            //instantiate the AccessClass
            Database.IssueReturnClass issueReturnClass = new Database.IssueReturnClass();
            try
            {
                //forming the sql query
                string query = "SELECT BookName FROM Books WHERE BookId = '" + bookId + "';";
                //call the getData method and store it inside the data set;
                DataSet bookData = issueReturnClass.GetData(query);
                //pass the data back to the form
                return bookData.Tables[0];

            }
            catch (Exception ex)
            {
                LastError = ex.Message;
                return null;
            }
        }


        public DataTable GetIssueBooks(int userId)
        {
            //instantiate Model class
            Database.IssueReturnClass issueReturnClass = new Database.IssueReturnClass();
            string sqlQuery = "SELECT * FROM IssueBooks WHERE UserID = '" + userId + "';";

            try
            {
                //return all the books data into the table
                return issueReturnClass.GetAllBooks(sqlQuery, CommandType.Text);
            }
            catch (Exception ex)
            {
                LastError = ex.Message;
                return null;
            }
        }//end GetBooks()

        public DataTable FetchUserName(int userId)
        {
            //get all data from a table through select query and return it back
            //instantiate the AccessClass
            Database.IssueReturnClass issueReturnClass = new Database.IssueReturnClass();
            try
            {
                //forming the sql query
                string query = "SELECT Name FROM UserTable WHERE UserID = '" + userId + "';";
                //call the getData method and store it inside the data set;
                DataSet bookData = issueReturnClass.GetData(query);
                //pass the data back to the form
                return bookData.Tables[0];

            }
            catch (Exception ex)
            {
                //DBError = bookAccessClass.ErrorReturned + ex.Message;
                return null;
            }
        }

        public DateTime GetDueDate(int userId, int bookId)
        {
            //Instantiate DataClass
            string queryString = "SELECT DueDate FROM IssueBooks WHERE BookID = '" + bookId + "' and UserID = '" + userId + "';";
            try
            {
                //instantiate Model class
                Database.IssueReturnClass bookAccessClass = new Database.IssueReturnClass();
                return (DateTime)bookAccessClass.GetScalar(queryString, CommandType.Text);
            }
            catch (Exception ex)
            {
                LastError = ex.Message;
                return DateTime.Parse(LastError);
            }
        }//Get Count

        public int IssueBook(int userId, int bookId, System.DateTime dueDate)
        {
            //instantiate Model class
            Database.IssueReturnClass bookAccessClass = new Database.IssueReturnClass();

            try
            {
                string query = "INSERT INTO IssueBooks (UserID, BookID, DueDate, Status) Values (@userID, @bookID, @dueDate, @status)";

                SqlParameter userIdParameter = new SqlParameter("@userID", SqlDbType.Int);
                userIdParameter.Value = userId;

                SqlParameter bookIdParameter = new SqlParameter("@bookID", SqlDbType.Int);
                bookIdParameter.Value = bookId;

                SqlParameter dueDateParameter = new SqlParameter("@dueDate", SqlDbType.DateTime);
                dueDateParameter.Value = dueDate;

                string statusIssued = "Issued";
                SqlParameter statusParameter = new SqlParameter("@status", SqlDbType.Text);
                statusParameter.Value = statusIssued;

                //call model method
                return bookAccessClass.ExecNonQuery(query, CommandType.Text, userIdParameter, bookIdParameter, dueDateParameter, statusParameter);
            }
            catch (Exception ex)
            {
                LastError = ex.Message;
                return -1;
            }
        }//end AddBook()


        public bool CheckIfIdExists(int userId, int bookId)
        {
            Database.IssueReturnClass issueReturnClass = new Database.IssueReturnClass();

            string query = "SELECT * FROM IssueBooks WHERE BookID = '" + bookId + "' and UserID = '" + userId + "';";
            SqlDataReader reader = issueReturnClass.CheckBookDataById(query);

            if (reader.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int ReturnBook(int userId, int bookId, System.DateTime returnDate, double fine)
        {
            Database.IssueReturnClass issueReturnClass = new Database.IssueReturnClass();

            try
            {
                string query = "UPDATE IssueBooks SET ReturnDate=@returnDate, Status=@status, Fine=@fine WHERE BookID = '" + bookId + "' and UserID = '" + userId + "';";

                SqlParameter returnDateParameter = new SqlParameter("@returnDate", SqlDbType.DateTime);
                returnDateParameter.Value = returnDate;

                string statusReturned = "Returned";
                SqlParameter statusParameter = new SqlParameter("@status", SqlDbType.Text);
                statusParameter.Value = statusReturned;

                SqlParameter fineParameter = new SqlParameter("@fine", SqlDbType.Decimal);
                fineParameter.Value = fine;

                return issueReturnClass.ExecNonQuery(query, CommandType.Text, returnDateParameter, statusParameter, fineParameter);
            }
            catch (Exception ex)
            {
                LastError = ex.Message;
                return -1;
            }
        }
    }
}
