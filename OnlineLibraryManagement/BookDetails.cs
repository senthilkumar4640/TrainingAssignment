using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineLibraryManagement
{
    public class BookDetails
    {
        /*
        1.	BookID (Auto Increment - BID1000)
        2.	BookName
        3.	AuthorName
        4.	BookCount
        */

        //Field
        //Static Field
        private static int s_bookID = 1000;

        //Property
        public string BookID { get;}//Read Only Property

        public string BookName { get; set; }

        public string AuthorName { get; set; }

        public int BookCount { get; set; }

        //Constructors
        public BookDetails(string bookName, string authorName, int bookCount)
        {

            //AutoIncrementation
            s_bookID++;

            //Assigning
            BookID = "BID" + s_bookID;
            BookName = bookName;
            AuthorName = authorName;
            BookCount = bookCount;
        }//Constructor Ends
    }
}