using LibraryManagementSystem.Classes;
using LibraryManagementSystem.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Service
{
    class BookIntermediaryClass
    {
        public string LastError { get; set; }

        public DataTable GetBooks()
        {
            BookAccessClass bookAccessClass = new BookAccessClass();
            string sqlQuery = "SELECT * FROM Books";

            try
            {
                return bookAccessClass.GetAllBooks(sqlQuery, CommandType.Text);
            }
            catch (Exception ex)
            {
               
                LastError = ex.Message;
                return null;
            }
        }//end GetBooks()

        public int AddBook(int bookId, string bookName, string authorName, string publisher, string genre, int numberOfCopies)
        {
            BookAccessClass bookAccessClass = new BookAccessClass();

            try
            {
                string query = "INSERT INTO Books (BookId,BookName,AuthorName,PublisherName,Genre,NoOfCopies) Values (@BookId, @BookName, @AuthorName, @PublisherName, @Genre, @NoOfCopies)";

                SqlParameter bookIdParameter = new SqlParameter("@BookId", SqlDbType.Int);
                bookIdParameter.Value = bookId;

                SqlParameter bookNameParameter = new SqlParameter("@BookName", SqlDbType.Text);
                bookNameParameter.Value = bookName;

                SqlParameter authorNameParameter = new SqlParameter("@AuthorName", SqlDbType.Text);
                authorNameParameter.Value = authorName;

                SqlParameter publisherParameter = new SqlParameter("@PublisherName", SqlDbType.Text);
                publisherParameter.Value = publisher;

                SqlParameter genreParameter = new SqlParameter("@Genre", SqlDbType.Text);
                genreParameter.Value = genre;

                SqlParameter numberOfCopiesParameter = new SqlParameter("@NoOfCopies", SqlDbType.Int);
                numberOfCopiesParameter.Value = numberOfCopies;

                return bookAccessClass.ExecNonQuery(query, CommandType.Text, bookIdParameter, bookNameParameter, authorNameParameter, publisherParameter, genreParameter, numberOfCopiesParameter);
            }
            catch (Exception ex)
            {
                LastError = ex.Message;
                return -1;
            }
        }//end AddBook()

        public int DeleteBook(int bookId)
        {
            BookAccessClass bookAccessClass = new BookAccessClass();

                string query = "DELETE FROM Books WHERE BookId = '" + bookId + "';";

                return bookAccessClass.ExecNonQuery(query, CommandType.Text);
            
        }

        public bool CheckIfIdExists(int bookId)
        {
            BookAccessClass bookAccessClass = new BookAccessClass();

            string query = "SELECT * FROM Books WHERE BookId = '" + bookId + "';";
                SqlDataReader reader = bookAccessClass.CheckBookDataById(query);
          
            if (reader.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }                    
        }

        public bool CheckIfUserIdExists(int userId)
        {
            BookAccessClass bookAccessClass = new BookAccessClass();

            string query = "SELECT * FROM UserTable WHERE UserID = '" + userId + "';";
            SqlDataReader reader = bookAccessClass.CheckBookDataById(query);

            if (reader.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void GetBookDataFromID(int bookId, string bookName, string authorName, string publisher, string genre, string numberOfCopies)
        {
            BookAccessClass bookAccessClass = new BookAccessClass();
            string query = "SELECT * FROM Books WHERE BookId = '" + bookId + "';";
            SqlDataReader reader = bookAccessClass.CheckBookDataById(query);

            if (reader.Read())
            {               
                bookName = reader[1].ToString();
                authorName = reader[2].ToString();
                publisher = reader[3].ToString();
                genre = reader[4].ToString();
                numberOfCopies = reader[5].ToString();

            }
            
        }

        public int UpdateBook(int bookId, string bookName, string authorName, string publisher, string genre, int numberOfCopies)
        {
            BookAccessClass bookAccessClass = new BookAccessClass();

            try
            {
                string query = "UPDATE Books " +
                    "SET " +
                    "BookId=@BookId," +
                    "BookName=@BookName," +
                    "AuthorName=@AuthorName," +
                    "PublisherName=@PublisherName," +
                    "Genre=@Genre," +
                    "NoOfCopies=@NoOfCopies" +
                    " WHERE BookId = '" + bookId + "';";

                SqlParameter bookIdParameter = new SqlParameter("@BookId", SqlDbType.Int);
                bookIdParameter.Value = bookId;

                SqlParameter bookNameParameter = new SqlParameter("@BookName", SqlDbType.Text);
                bookNameParameter.Value = bookName;

                SqlParameter authorNameParameter = new SqlParameter("@AuthorName", SqlDbType.Text);
                authorNameParameter.Value = authorName;

                SqlParameter publisherParameter = new SqlParameter("@PublisherName", SqlDbType.Text);
                publisherParameter.Value = publisher;

                SqlParameter genreParameter = new SqlParameter("@Genre", SqlDbType.Text);
                genreParameter.Value = genre;

                SqlParameter numberOfCopiesParameter = new SqlParameter("@NoOfCopies", SqlDbType.Int);
                numberOfCopiesParameter.Value = numberOfCopies;

                return bookAccessClass.ExecNonQuery(query, CommandType.Text, bookIdParameter, bookNameParameter, authorNameParameter, publisherParameter, genreParameter, numberOfCopiesParameter);
            }
            catch (Exception ex)
            {
                LastError = ex.Message;
                return -1;
            }
        }//end UpdateBook()

        public DataTable FillGenre()
        {
            BookAccessClass bookAccessClass = new BookAccessClass();
            string query = "SELECT Distinct Genre FROM Books;";
            try
            {
                return bookAccessClass.GetGenre(query, CommandType.Text);
            }
            catch (Exception ex)
            {
                LastError = ex.Message;
                return null;
            }
        }

        public DataTable GetSelectedBooks(string selectedGenre, string bookName)
        {
            BookAccessClass bookAccessClass = new BookAccessClass();
      string sqlQuery = "SELECT * from Books WHERE BookName='" + bookName + "' OR Genre='"+ selectedGenre + "';";        
            try
            {
                return bookAccessClass.GetAllBooks(sqlQuery, CommandType.Text);
            }
            catch (Exception ex)
            {
                LastError = ex.Message;
                return null;
            }
        }//end GetBooks()

        public DataTable FetchData(int bookId)
        {
            //get all data from a table through select query and return it back
            //instantiate the AccessClass
            BookAccessClass bookAccessClass = new BookAccessClass();
            try
            {
                //forming the sql query
                string query = "SELECT * FROM Books WHERE BookId = '" + bookId + "';";
                //call the getData method and store it inside the data set;
                DataSet customersData = bookAccessClass.GetNwData(query);
                //pass the data back to the form
                return customersData.Tables[0];

            }
            catch (Exception ex)
            {
                //DBError = bookAccessClass.ErrorReturned + ex.Message;
                return null;
            }
        }

        public DataTable GetLoanedBooks(string userId)
        {
            BookAccessClass bookAccessClass = new BookAccessClass();
            string sqlQuery = "SELECT BookID, DueDate, ReturnDate, Fine, Status from IssueBooks WHERE UserID='" + userId + "';";
            try
            {
                return bookAccessClass.GetAllBooks(sqlQuery, CommandType.Text);
            }
            catch (Exception ex)
            {
                LastError = ex.Message;
                return null;
            }
        }//end GetBooks()

    }
}
