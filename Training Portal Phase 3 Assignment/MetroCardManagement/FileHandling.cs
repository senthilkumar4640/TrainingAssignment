using System;
using System.IO;

namespace MetroCardManagement
{
    public static class FileHandling
    {
        public static void create()
        {
            //Creating a folder..
             if(!Directory.Exists("MetroCardManagement"))
            {
                Directory.CreateDirectory("MetroCardManagement");
                Console.WriteLine("The folder has been created...");
            }

            //Creating a File for Userdetail Class..
            if(!File.Exists("MetroCardManagement/UserDetails.csv"))
            {
                File.Create("MetroCardManagement/UserDetails.csv").Close();
                Console.WriteLine("The file has been created...");
            }

            //Creating a File for TicketFair Class..
            if(!File.Exists("MetroCardManagement/TicketFairDetails.csv"))
            {
                File.Create("MetroCardManagement/TicketFairDetails.csv").Close();
                Console.WriteLine("The file has been created...");

            }

            //Creating a File for TravelDetail Class..
            if(!File.Exists("MetroCardManagement/TravelDetail.csv"))
            {
                File.Create("MetroCardManagement/TravelDetail.csv").Close();
                Console.WriteLine("The file has been created...");
            }

        }

        //Write
        public static void WriteToCSV()
        {
          
        }

        //Read
        public static void ReadFromCSV()
        {
            //User class
            string[] users = File.ReadAllLines("MetroCardManagement/UserDetails.csv");
            foreach(string user in users)
            {
                //Creating object
                UserDetails user1 = new UserDetails(user);
                Operations.userCustomList.Add(user1);
            }

            //travel class
            string[] travelers = File.ReadAllLines("MetroCardManagement/TravelDetail.csv");
            foreach(string travel in travelers)
            {
                //Creating object
                TravelDetail travel1 = new TravelDetail(travel);
                Operations.travelCustomList.Add(travel1);
            }

            //ticket fair class
            string[] tickets = File.ReadAllLines("MetroCardManagement/TicketFairDetails.csv");
            foreach(string ticket in tickets)
            {
                //Creating object
                TicketFairDetails ticket1 = new TicketFairDetails(ticket);
                Operations.ticketCustomList.Add(ticket1);
            }
        }
    }
}
