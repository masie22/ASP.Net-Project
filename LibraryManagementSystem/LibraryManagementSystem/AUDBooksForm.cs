using LibraryManagementSystem.Classes;
using LibraryManagementSystem.Database;
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
    //enums

    public enum Genres
    {
        Dissertation = 0,
        Reviews = 1,
        CourseBook = 2,
        Journals = 3,
        Articles = 4,
        ReferenceEntries = 5
    }

    public partial class AUDBooksForm : Form
    {
        int chooseGenre;
        string radioSelectedText;
        public AUDBooksForm()
        {
            InitializeComponent();
        }
    
        private void dissertationsRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton selectedRadio = (RadioButton)sender;

            switch (selectedRadio.Name)
            {

                case "dissertationsRadioBtn":
                    chooseGenre = (int)Genres.Dissertation;
                    radioSelectedText = selectedRadio.Text;
                    Book disserBook = new Book();
                    bookLocationLabel.Text = disserBook.GenreLocation(chooseGenre);

                    break;

                case "reviewsRadioBtn":
                    chooseGenre = (int)Genres.Reviews;
                    radioSelectedText = selectedRadio.Text;
                    Book reviewbook = new Book();
                    bookLocationLabel.Text = reviewbook.GenreLocation(chooseGenre);
                    break;

                case "courseRadioButton":
                    chooseGenre = (int)Genres.CourseBook;
                    radioSelectedText = selectedRadio.Text;
                    Book courseBk = new Book();
                    bookLocationLabel.Text = courseBk.GenreLocation(chooseGenre);
                    break;

                case "articlesRadioBtn":
                    chooseGenre = (int)Genres.Articles;
                    radioSelectedText = selectedRadio.Text;
                    Book article = new Book();
                    bookLocationLabel.Text = article.GenreLocation(chooseGenre);
                    break;

                case "referenceRadioBtn":
                    chooseGenre = (int)Genres.ReferenceEntries;
                    radioSelectedText = selectedRadio.Text;
                    Book refBook = new Book();
                    bookLocationLabel.Text = refBook.GenreLocation(chooseGenre);
                    break;

                case "journalRadioBtn":
                    chooseGenre = (int)Genres.ReferenceEntries;
                    radioSelectedText = selectedRadio.Text;
                    Book journal = new Book();
                    bookLocationLabel.Text = journal.GenreLocation(chooseGenre);
                    break;
            }
        }

        private void addBookButton_Click(object sender, EventArgs e)
        {

            BookIntermediaryClass intermediaryBookClass = new BookIntermediaryClass();

            int bookId;
            int bookCount;
            int resultCheck = 0;


            try
            {
                if (intermediaryBookClass.CheckIfIdExists(int.Parse(bookIdTextbox.Text)))
                {
                    resultLabel.Text = "Id already exists. Try another ID";
                }
                else
                {
                    if (!int.TryParse(bookIdTextbox.Text, out bookId))
                    {

                        resultLabel.Text = "Please Enter a Valid Book ID";
                        return;
                    }
                    if ((bookNameTextbox.Text == "") || (authorNameTextbox.Text == "") || !int.TryParse(numberOfCopiesTextbox.Text, out bookCount))
                    {
                        resultLabel.Text = "Book Name, Author Name and Number of Copies are required.";
                        return;
                    }

                    resultCheck = intermediaryBookClass.AddBook(bookId, bookNameTextbox.Text, authorNameTextbox.Text, publisherTextbox.Text, radioSelectedText.ToString(), bookCount);

                    if (resultCheck > 0)
                    {
                        MessageBox.Show("Successfully Added");
                        GridviewFill();
                    }
                    else
                    {
                        resultLabel.Text = $"Cannot insert {Environment.NewLine}{intermediaryBookClass.LastError}";
                    }
                }

            }
            catch (Exception ex)
            {
                resultLabel.Text = ex.Message;
            }
        }//end addBookBtn

        private void deleteBookButton_Click(object sender, EventArgs e)
        {
            BookIntermediaryClass intermediaryBookClass = new BookIntermediaryClass();

            int bookId;

            try
            {
                if (!int.TryParse(bookIdTextbox.Text, out bookId))
                {

                    MessageBox.Show("Please Enter a Valid Book ID");
                    return;
                }
                else
                {
                    if (intermediaryBookClass.CheckIfIdExists(bookId))
                    {
                        intermediaryBookClass.DeleteBook(bookId);
                        MessageBox.Show("Successfully Deleted");
                        GridviewFill();
                    }
                    else
                    {
                        resultLabel.Text = $"Respective data for given ID does not exists.{Environment.NewLine} Check the ID and try again.";
                    }
                }
            }
            catch (Exception ex)
            {
                resultLabel.Text = ex.Message;
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void searchButton_Click(object sender, EventArgs e)
        {

            //instantiate the intermediary class
            BookIntermediaryClass bookIntermediaryClass = new BookIntermediaryClass();

            //get the data to a table and binding source
            DataTable nwDataTable = bookIntermediaryClass.FetchData(int.Parse(bookIdTextbox.Text));

            //instantiate a binding source
            BindingSource bindingSource = new BindingSource();

            //assign teh data to binding source:
            bindingSource.DataSource = nwDataTable;

            //data binding the controls:

            bookNameTextbox.DataBindings.Add("text", bindingSource, "BookName", false);//CompanyName should be the same name as in the sql query, false becuase you dot want to change the formating

            authorNameTextbox.DataBindings.Add("text", bindingSource, "AuthorName", false);
            publisherTextbox.DataBindings.Add("text", bindingSource, "PublisherName", false);

            //string a = nwDataTable.Rows[0]["Genre"].ToString();
            if (nwDataTable.Rows[0]["Genre"].ToString() == dissertationsRadioBtn.Text)
            {
                dissertationsRadioBtn.Checked = true;
            }
            else if(nwDataTable.Rows[0]["Genre"].ToString() == reviewsRadioBtn.Text){
                reviewsRadioBtn.Checked = true;
            }
            else if (nwDataTable.Rows[0]["Genre"].ToString() == articlesRadioBtn.Text)
            {
                articlesRadioBtn.Checked = true;
            }
            else if (nwDataTable.Rows[0]["Genre"].ToString() == courseRadioButton.Text)
            {
                courseRadioButton.Checked = true;
            }
            else if (nwDataTable.Rows[0]["Genre"].ToString() == referenceRadioBtn.Text)
            {
                referenceRadioBtn.Checked = true;
            }
            else if (nwDataTable.Rows[0]["Genre"].ToString() == journalRadioBtn.Text)
            {
                journalRadioBtn.Checked = true;
            }
            else
            {
                resultLabel.Text = "Genre is empty";
            }
            
            numberOfCopiesTextbox.DataBindings.Add("text", bindingSource, "NoOfCopies", false);      
        }//end fill()

        private void updateBookButton_Click(object sender, EventArgs e)
        {
            BookIntermediaryClass intermediaryBookClass = new BookIntermediaryClass();

            int bookId;
            int resultCheck = 0;

            try
            {
                if (!int.TryParse(bookIdTextbox.Text, out bookId))
                {

                    resultLabel.Text = "Please Enter a Valid Book ID";
                    return;
                }

                if (intermediaryBookClass.CheckIfIdExists(bookId))
                {
                    resultCheck = intermediaryBookClass.UpdateBook(bookId, bookNameTextbox.Text, authorNameTextbox.Text, publisherTextbox.Text, radioSelectedText.ToString(), int.Parse(numberOfCopiesTextbox.Text));

                    if (resultCheck > 0)
                    {
                        MessageBox.Show("Successfully Updated");
                        GridviewFill();
                    }
                    else
                    {
                        resultLabel.Text = $"Cannot update {Environment.NewLine}{intermediaryBookClass.LastError}";
                    }
                }
                else
                {
                    resultLabel.Text = $"Cannot update. Book ID does not exist. ";
                }                              
            }
            catch (Exception ex)
            {
                resultLabel.Text = ex.Message;
            }
        }//end update button

        private void AUDBooks_Load(object sender, EventArgs e)
        {
            GridviewFill();
        }

        private void GridviewFill()
        {
            allBooksDataGridView.Refresh();
            BookIntermediaryClass intermediaryBookClass = new BookIntermediaryClass();
            DataTable booksTable = new DataTable();
            booksTable = intermediaryBookClass.GetBooks();
            allBooksDataGridView.DataSource = booksTable;
            allBooksDataGridView.ReadOnly = true;
        }
    }//end class
}//end namespace
