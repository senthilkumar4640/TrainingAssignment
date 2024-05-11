using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace MovieTicketBooking
{
    public static class FileHandling
    {
        public static void create()
        {
            if(!Directory.Exists("MovieTicketBooking"))
            {
                Directory.CreateDirectory("MovieTicketBooking");
                Console.WriteLine("Folder Created Successfully..");
            }
            if(!File.Exists("MovieTicketBooking/UserDetails.csv"))
            {
                File.Create("MovieTicketBooking/UserDetails.csv").Close();
                Console.WriteLine("UserDetails File Created Successfully..");
            }
             if(!File.Exists("MovieTicketBooking/BookingDetails.csv"))
            {
                File.Create("MovieTicketBooking/BookingDetails.csv").Close();
                Console.WriteLine("BookingDetails File Created Successfully..");
            }
             if(!File.Exists("MovieTicketBooking/MovieDetails.csv"))
            {
                File.Create("MovieTicketBooking/MovieDetails.csv").Close();
                Console.WriteLine("MovieDetails File Created Successfully..");
            }
             if(!File.Exists("MovieTicketBooking/ScreeningDetails.csv"))
            {
                File.Create("MovieTicketBooking/ScreeningDetails.csv").Close();
                Console.WriteLine("ScreeningDetails File Created Successfully..");
            }
             if(!File.Exists("MovieTicketBooking/TheatreDetails.csv"))
            {
                File.Create("MovieTicketBooking/TheatreDetails.csv").Close();
                Console.WriteLine("TheatreDetails File Created Successfully..");
            }
        }
    
        public static void WriteToCSV()
        {
            //User Detail Class
            string[] user = new string[Program.userDetailsList.Count];
            for(int i=0;i<Program.userDetailsList.Count;i++)
            {
                user[i] = Program.userDetailsList[i].UserID+","+Program.userDetailsList[i].Name+","+Program.userDetailsList[i].Age+","+Program.userDetailsList[i].PhoneNumber+","+Program.userDetailsList[i].WalletBalance;
            }
            File.WriteAllLines("MovieTicketBooking/UserDetails.csv",user);

            //Booking Details
            string[] booking = new string[Program.bookingDetailsList.Count];
            for(int i=0;i<Program.bookingDetailsList.Count;i++)
            {
                booking[i] = Program.bookingDetailsList[i].BookingID+","+ Program.bookingDetailsList[i].UserID+","+Program.bookingDetailsList[i].MovieID+","+Program.bookingDetailsList[i].TheatreID+","+Program.bookingDetailsList[i].SeatCount+","+Program.bookingDetailsList[i].TotalAmount+","+Program.bookingDetailsList[i].BookingStatus;
            }
            File.WriteAllLines("MovieTicketBooking/BookingDetails.csv",booking);

            //Movie details
            string[] movie = new string[Program.movieDetailsList.Count];
            for(int i=0;i<Program.movieDetailsList.Count;i++)
            {
                movie[i] = Program.movieDetailsList[i].MovieID+","+ Program.movieDetailsList[i].MovieName+","+ Program.movieDetailsList[i].Language;
            }
            File.WriteAllLines("MovieTicketBooking/MovieDetails.csv",movie);

            //Screen Details
            string[] screen = new string[Program.screeningDetailsList.Count];
            for(int i=0;i<Program.screeningDetailsList.Count;i++)
            {
                screen[i] = Program.screeningDetailsList[i].MovieID+","+ Program.screeningDetailsList[i].TheatreID+","+ Program.screeningDetailsList[i].NoOfSeats+","+ Program.screeningDetailsList[i].TicketPrice;
            }
            File.WriteAllLines("MovieTicketBooking/ScreeningDetails.csv",screen);

            //theatre details
            string[] theatre = new string[Program.theatreDetailsList.Count];
            for(int i=0;i<Program.theatreDetailsList.Count;i++)
            {
                theatre[i] = Program.theatreDetailsList[i].TheatreID+","+ Program.theatreDetailsList[i].TheatreName+","+ Program.theatreDetailsList[i].TheatreLocation;
            }
            File.WriteAllLines("MovieTicketBooking/TheatreDetails.csv",theatre);

        }

        public static void ReadFromCSV()
        {
            //user detail class
            string[] user = File.ReadAllLines("MovieTicketBooking/UserDetails.csv");
            foreach(string users in user)
            {
                //Creating object
                UserDetails user1 = new UserDetails(users);
                Program.userDetailsList.Add(user1);
            }

            //Booking details
            string[] booking = File.ReadAllLines("MovieTicketBooking/BookingDetails.csv");
            foreach(string bookings in booking)
            {
                //Creating object
                UserDetails booking1 = new UserDetails(bookings);
                Program.userDetailsList.Add(booking1);
            }

            //Movie Details
            string[] movie = File.ReadAllLines("MovieTicketBooking/MovieDetails.csv");
            foreach(string movies in movie)
            {
                //Creating object
                UserDetails movie1 = new UserDetails(movies);
                Program.userDetailsList.Add(movie1);
            }

            //Screening Details
            string[] screen = File.ReadAllLines("MovieTicketBooking/ScreeningDetails.csv");
            foreach(string screens in screen)
            {
                //Creating object
                UserDetails screen1 = new UserDetails(screens);
                Program.userDetailsList.Add(screen1);
            }

            //Theatre Details
            string[] theatre = File.ReadAllLines("MovieTicketBooking/TheatreDetails.csv");
            foreach(string theatres in theatre)
            {
                //Creating object
                UserDetails theatre1 = new UserDetails(theatres);
                Program.userDetailsList.Add(theatre1);
            }

        }
    }
}