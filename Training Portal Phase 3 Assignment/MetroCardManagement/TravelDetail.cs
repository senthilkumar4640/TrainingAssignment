using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace MetroCardManagement
{
    public class TravelDetail
    {
        /*
        Properties:
        a.	TravelId (Auto Generated -TID2001)
        b.	Card Number
        c.	FromLocation
        d.	ToLocation
        e.	Date
        f.	Travel Cost
        */

        //Field
        private static int s_travelID =2000;

        //Properties
        public string TravelId { get; }//ReadOnly Property
        public string CardNumber { get; set; }
        public string FromLocation { get; set; }
        public string ToLocation { get; set; }
        public DateTime Date { get; }
        public int TravelCost { get; set; }

        //Constructors
        public TravelDetail(string cardNumber, string fromLocation, string toLocation, DateTime date, int travelCost)
        {
            s_travelID++;
            TravelId = "TID"+s_travelID;
            CardNumber = cardNumber;
            FromLocation = fromLocation;
            ToLocation = toLocation;
            Date = date;
            TravelCost = travelCost;
        }

        public TravelDetail(string travel)
        {
            string[] values = travel.Split(",");
            TravelId = values[0];
            s_travelID = int.Parse(values[0].Remove(0,3));
            CardNumber = values[1];
            FromLocation = values[2];
            ToLocation = values[3];
            Date = DateTime.ParseExact(values[4],"dd/MM/yyyy",null);
            TravelCost = int.Parse(values[5]);
        }
    }
}