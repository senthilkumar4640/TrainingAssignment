using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MetroCardManagement
{
    public static class Operations
    {
        //CustomList
        public static CustomList<UserDetails> userCustomList = new CustomList<UserDetails>();
        public static CustomList<TravelDetail> travelCustomList = new CustomList<TravelDetail>();
        public static CustomList<TicketFairDetails>ticketCustomList = new CustomList<TicketFairDetails>();

        //Global object
        static UserDetails currentUserLoggedIn;

        //AddDefault Method
        public static void AddDefault()
        {
            //UserDetails class
            UserDetails user1 = new UserDetails ("Ravi",9848812345,1000);
            UserDetails user2 = new UserDetails ("Baskaran",9948854321,1000);
            userCustomList.AddRange(new CustomList<UserDetails>(){user1,user2});

            //Travel Detail class
            TravelDetail travel1 = new TravelDetail("CMRL1001","Airport","Egmore",new DateTime(2023,10,10),55);
            TravelDetail travel2 = new TravelDetail("CMRL1001","Egmore","Koyembedu",new DateTime(2023,10,10),32);
            TravelDetail travel3 = new TravelDetail("CMRL1002","Alandur","Koyembedu",new DateTime(2023,11,10),25);
            TravelDetail travel4 = new TravelDetail("CMRL1002","Egmore","Thirumangalam",new DateTime(2023,11,10),25);
            travelCustomList.AddRange(new CustomList<TravelDetail>(){travel1,travel2,travel3,travel4});

            //Ticket Fair class
            TicketFairDetails ticket1 = new TicketFairDetails("Airport","Egmore",55);
            TicketFairDetails ticket2 = new TicketFairDetails("Airport","Koyambedu",25);
            TicketFairDetails ticket3 = new TicketFairDetails("Alandur","Koyambedu",25);
            TicketFairDetails ticket4 = new TicketFairDetails("Koyambedu","Egmore",32);
            TicketFairDetails ticket5 = new TicketFairDetails("Vadapalani","Egmore",45);
            TicketFairDetails ticket6 = new TicketFairDetails("Arumbakkam","Egmore",25);
            TicketFairDetails ticket7 = new TicketFairDetails("Vadapalani","Koyambedu",25);
            TicketFairDetails ticket8 = new TicketFairDetails("Arumbakkam","Koyambedu",16);
            ticketCustomList.AddRange(new CustomList<TicketFairDetails>(){ticket1,ticket2,ticket3,ticket4,ticket5,ticket6,ticket7,ticket8});
        }
    
        //MainMenu
        public static void MainMenu()
        {
            Console.WriteLine("-----Welcome to Syncfusion Metro-----");
            string mainOption = "yes";
            do
            {
                Console.WriteLine("Main Menu\n1. New User Registration\n2. Login User\n3. Exit");
                int option = int.Parse(Console.ReadLine());
                switch(option)
                {
                    case 1:
                    {
                        Console.WriteLine("-----New User Registration-----");
                        NewUserRegistration();
                        break;
                    }
                    case 2:
                    {
                        Console.WriteLine("-----Login User-----");
                        LoginUser();
                        break;
                    }
                    case 3:
                    {
                        Console.WriteLine("Application Exited Successfully..");
                        mainOption="no";
                        break;
                    }
                }

            }while(mainOption=="yes");
        }

        //New user registration method
        public static void NewUserRegistration()
        {
            /*
            •	UserName
            •	Phone Number
            •	Balance
            */

            Console.Write("Enter the user name: ");
            string userName = Console.ReadLine();
            Console.Write("Enter your Phone Number: ");
            long phoneNumber = long.Parse(Console.ReadLine());
            Console.Write("Enter the Amount for the Balance: ");
            double Balance = double.Parse(Console.ReadLine());
            //Creating a object
            UserDetails user  = new UserDetails(userName,phoneNumber,Balance);
            //Adding a CustomList
            userCustomList.Add(user);
            //Displaying Card Number
            Console.WriteLine("Registered Successfully..\nYour Card Number is "+user.CardNumber);

        }
    
        //Login User
        public static void LoginUser()
        {
            Console.Write("Enter your : ");
            string loginID = Console.ReadLine().ToUpper();
            bool isFlag = true;
            foreach(UserDetails user in userCustomList)
            {
                if(loginID.Equals(user.CardNumber))
                {
                    isFlag = false;
                    currentUserLoggedIn = user;
                    SubMenu();
                    break;
                }
            }
            if(isFlag)
            {
                Console.WriteLine("The card number you entered is not a valid one..");
            }
        }
    
        //Sub Menu
        public static void SubMenu()
        {
            /*
            a.	Balance Check
            b.	Rechange
            c.	View Travel History	
            d.	Travel
            e.	Exit 
            */

            string subOption = "yes";
            do
            {
                Console.WriteLine("Sub Menu\n1. Balance Check\n2.Recharge\n3.View Travel History\n4.Travel\n5.Exit");
                int option = int.Parse(Console.ReadLine());
                switch(option)
                {
                    case 1:
                    {
                        Console.WriteLine("-----Balance Check-----");
                        BalanceCheck();
                        break;
                    }
                    case 2:
                    {
                        Console.WriteLine("-----Recharge-----");
                        Recharge();
                        break;
                    }
                    case 3:
                    {
                        Console.WriteLine("-----View Travel History-----");
                        TravelHistory();
                        break;
                    }
                    case 4:
                    {
                        Console.WriteLine("-----Travel-----");
                        Travel();
                        break;
                    }
                    case 5:
                    {
                        Console.WriteLine("Running back to Main Menu..");
                        subOption = "no";
                        break;
                    }
                }
            }while(subOption=="yes");
        }

        //Balance Check Method
        public static void BalanceCheck()
        {
            Console.WriteLine($"Your Balance is {currentUserLoggedIn.Balance}");
        }

        //Recharge 
        public static void Recharge()
        {
            Console.Write("Enter the amount to recharge: ");
            double amount = double.Parse(Console.ReadLine());
            Console.WriteLine($"Your Recharged Balance is {currentUserLoggedIn.WalletRecharge(amount)}");
        }

        //Travel History
        public static void TravelHistory()
        {
            bool isFlag = true;
            Console.WriteLine("|TravelID|CardNumber|FromLocation|ToLocation|Date|TravelCost|");
            foreach(TravelDetail travel in travelCustomList)
            {
                if(currentUserLoggedIn.CardNumber == travel.CardNumber)
                {
                    isFlag = false;
                     Console.WriteLine($"|{travel.TravelId}|{travel.CardNumber}|{travel.FromLocation}|{travel.ToLocation}|{travel.Date.ToString("dd/MM/yyyy")}|{travel.TravelCost}|");
                }
            }
            if(isFlag)
            {
                Console.WriteLine("There is no travel history for you..");
            }
        }

        //Travel
        public static void Travel()
        {
            
            //Show the Ticket fair details where the user wishes to travel by getting TicketID.
            Console.WriteLine("|TicketId|FromLocation|ToLocation|Fair|");
            foreach(TicketFairDetails ticket in ticketCustomList)
            {
                Console.WriteLine($"|{ticket.TicketID}|{ticket.FromLocation}|{ticket.ToLocation}|{ticket.TicketPrice}");
            }
            //Check the ticketID is valid. Else show “Invalid user id”.
            Console.Write("Enter the Ticket ID to travel: ");
            string travellingID = Console.ReadLine().ToUpper();
            bool isFlag = true;
            foreach(TicketFairDetails ticket in ticketCustomList)
            {
                if(travellingID.Equals(ticket.TicketID))
                {
                    isFlag=false;
                    //IF ticket is valid then, 
                    //Check the balance from the user object 
                    //whether it has sufficient balance to travel.

                    if(currentUserLoggedIn.Balance>ticket.TicketPrice)
                    {
                    //If “Yes” deduct the respective amount from the balance and add the travel details like 
                    //Card number, From and ToLocation, Travel Date, Travel cost, Travel ID (auto generation) 
                    //in his travel history.
                    
                    currentUserLoggedIn.DeductBalance(ticket.TicketPrice);
                    TravelDetail travel = new TravelDetail(currentUserLoggedIn.CardNumber, ticket.FromLocation, ticket.ToLocation, DateTime.Now, ticket.TicketPrice);
                    travelCustomList.Add(travel);
                    Console.WriteLine("Have a nice journey..");
                    }
                    else
                    {
                        //If “No” ask him to recharge and go to the “Existing User Service” menu
                        Console.WriteLine("Insufficient Balance to Travel.. ");
                        SubMenu();
                    }
                }
                
            }
            if(isFlag)
            {
                Console.WriteLine("Invalid Ticket ID");
            }
        

        }
    }
}