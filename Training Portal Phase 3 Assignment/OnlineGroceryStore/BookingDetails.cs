using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineGroceryStore
{
    public enum BookingStatus{Default,Initiated,Booked,Cancelled}
    
    public class BookingDetails
    {
        /*
        Properties: BookingID {Auto Increment – BID3000}, CustomerID, TotalPrice, 
        DateOfBooking, Booking Status – Default, Initiated, Booked, Cancelled.
        Method: ShowBookingDetails
        */

        //Field
        private static int s_bookingID = 3000;

        //Properties
        public string BookingID { get; }//ReadOnly
        public string CustomerID { get; }//ReadOnly
        public int TotalPrice { get; set; }
        public DateTime DateOfBooking { get; set; }
        public BookingStatus BookingStatus  { get; set; }

        //Constructors
        public BookingDetails(string customerID, int totalPrice, DateTime dateOfBooking, BookingStatus bookingStatus)
        {
            s_bookingID++;
            BookingID = "BID"+s_bookingID;
            CustomerID = customerID;
            TotalPrice = totalPrice;
            DateOfBooking =  dateOfBooking;
            BookingStatus = bookingStatus;
        }


        //Method
        public void ShowBookingDetails()
        {
            Console.WriteLine("|BookingID|CustomerID|TotalPrice|DateOfBooking|BookingStatus|");
        }

    }
}