using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Classes
{
    public class Book
    {
        private int Id { get; set; }

        private string BookName { get; set; }
        private string AuthorName { get; set; }

        private string PublisherName { get; set;}

        private string Genre { get; set; }

        private int NumberOfCopies { get; set; }


        public int BookID
        {
            get { return Id; }
            set { Id = value; }
        }


        public Book ()
        {

        }


        public Book(int bookNo, string bookTitle, string author, string publisher, string genre, int copies)
        {
            bookNo = Id;
            bookTitle = BookName;
            author = AuthorName;
            publisher = PublisherName;
            genre = Genre;
            copies = NumberOfCopies;
        }


        /*        public int AddBook(int bookId, string title, string author, string publisher, string booktype, int copies)
                {

                }*/

        public string GenreLocation(int whichGenre)
        {
            string location;

            switch (whichGenre)
            {
                case 1:
                    location = "Place it on the 3rd Floor";
                    break;

                case 2:
                    location = "Place it on the 3rd Floor";
                    break;

                case 3:
                    location = "Place it on the 3rd Floor";
                    break;

                case 4:
                    location = "Place it on the 2nd Floor";
                    break;

                default:
                    location = "Place it on the 1st Floor";
                    break;
            }

            return location;
        }
        public void IssueBook()
        {

        }

        public void ReturnBook()
        {

        }


    }
}
