using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MetroCardManagement
{
    public class TicketFairDetails
    {
        /*
        Properties:
        •	TicketID (Auto Generated – MR3001)
        •	FromLocation
        •	ToLocation
        •	TicketPrice
        */

        //Field
        private static int s_ticketID = 3000;

        //Property
        public string TicketID { get; }//Readonly Property
        public string FromLocation { get; set; }
        public string ToLocation { get; set; }
        public int TicketPrice { get; set; }

        //constructors
        public TicketFairDetails(string fromLocation, string toLocation, int ticketPrice)
        {
            s_ticketID++;
            TicketID = "MR"+s_ticketID;
            FromLocation = fromLocation;
            ToLocation = toLocation;
            TicketPrice = ticketPrice;
        }

        public TicketFairDetails(string ticket)
        {
            string[] values = ticket.Split(",");
            TicketID = values[0];
            s_ticketID = int.Parse(values[0].Remove(0,2));
            FromLocation = values[1];
            ToLocation = values[2];
            TicketPrice = int.Parse(values[3]);
        }
    }
}