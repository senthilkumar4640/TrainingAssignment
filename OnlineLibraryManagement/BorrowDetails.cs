using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace OnlineLibraryManagement
{
    public enum Status {Select, Default, Borrowed, Returned}
    public class BorrowDetails
    {
        /*
        •	BorrowID (Auto Increment – LB2000)
        •	BookID 
        •	UserID
        •	BorrowedDate – ( Current Date and Time )
        •	BorrowBookCount 
        •	Status –  ( Enum - Default, Borrowed, Returned )
        •	PaidFineAmount
        */

        //Field
        //Static Field
        private static int s_borrowID = 2000;

        //Properties
        public string BorrowID { get; }//Read Only Property

        public string BookID { get; set; }

        public string UserID { get; set; }

        public DateTime BorrowedDate {get; set;}

        public int BorrowBookCount { get; set; }

        public Status Status {get; set;}

        public int PaidFineAmount { get; set; }


        //Constructors
        public BorrowDetails(string bookID, string userID, DateTime borrowedDate, int borrowBookCount, Status status, int paidFineAmount)
        {
            //Auto Incrementation
            s_borrowID++;

            //Assigning
            BorrowID = "LB" + s_borrowID;
            BookID = bookID;
            UserID = userID;
            BorrowedDate = borrowedDate;
            BorrowBookCount = borrowBookCount;
            Status = status;
            PaidFineAmount = paidFineAmount;
        }//Constructors Ends
    }
}