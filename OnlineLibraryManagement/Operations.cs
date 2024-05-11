using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineLibraryManagement
{
    public static class Operations
    {
        //global variablr
        static UserDetails currentUserLoggedIn;

        //list
        static List<UserDetails> userList = new List<UserDetails>();
        static List<BookDetails> bookList = new List<BookDetails>();
        static List<BorrowDetails> borrowList = new List<BorrowDetails>();


        //MainMenu
        public static void MainMenu()
        {
            //Entry Message
            Console.WriteLine("**************** WELCOME TO SYNCFUSION COLLEGE LIBRARY ****************");
            string option = "yes";
            do
            {
                //Need to show main menu
                Console.WriteLine("Main Menu\n1.User Registration\n2.User Login\n3.Exit");
                //Need to get input
                Console.Write("Select the option:");
                int mainChoice = int.Parse(Console.ReadLine());
                //Switch case
                switch (mainChoice)
                {
                    case 1:
                        {
                            Console.WriteLine("---------- USER REGISTRATION ----------");
                            UserRegistration();
                            break;
                        }

                    case 2:
                        {
                            Console.WriteLine("---------- USER LOGIN ----------");
                            UserLogin();
                            break;
                        }

                    case 3:
                        {
                            Console.WriteLine("Application Ended Successfully");
                            option = "no";
                            break;
                        }
                }
                //Iterate it till exit
            } while (option == "yes");

        }//MainMenu Ends

        //User Registration
        public static void UserRegistration()
        {
            //Need to get details
            /*
            a.	Username
            b.	Gender (Enum – Select, Male, Female, Transgender)
            c.	Department  
            d.	MobileNumber
            e.	MailID
            f.	WalletBalance
            */
            Console.Write("Enter your name: ");
            string userName = Console.ReadLine();
            Console.Write("Enter your gender: ");
            Gender gender = Enum.Parse<Gender>(Console.ReadLine(), true);
            Console.Write("Enter your department as specified - ECE, EEE, CSE: ");
            Department department = Enum.Parse<Department>(Console.ReadLine(), true);
            Console.Write("Enter your mobile number: ");
            long mobileNumber = long.Parse(Console.ReadLine());
            Console.Write("Enter your mail ID: ");
            string mailID = Console.ReadLine();
            Console.Write("Enter your wallet balance: ");
            int balance = int.Parse(Console.ReadLine());
            //Need to create a object
            UserDetails user = new UserDetails(userName, gender, department, mobileNumber, mailID, balance);
            //Need to add the list
            userList.Add(user);
            //Need to show the ID
            Console.WriteLine($"Registration successful. Your User ID : {user.UserID}");
        }//User Registration Ends


        //User Login
        public static void UserLogin()
        {
            //Need to get ID input
            Console.Write("Enter your user ID: ");
            string loginID = Console.ReadLine().ToUpper();
            //Validating the id in list
            bool isFlag = true;
            foreach (UserDetails user in userList)
            {
                if (loginID.Equals(user.UserID))
                {
                    isFlag = false;
                    //global varible
                    currentUserLoggedIn = user;
                    Console.WriteLine("Logged In Successfully");
                    //calling submenu
                    SubMenu();
                    break;

                }
            }
            if (isFlag)
            {
                Console.WriteLine("Invalid ID or Please Enter a valid one");
            }
            //Invalid or valid

        }//User Login Ends

        //Sub menu
        public static void SubMenu()
        {
            string option = "yes";
            do
            {
                //Need to show sub menu
                Console.WriteLine("Sub Menu\n1.Borrow Book\n2.Show Borrowed History\n3.Return Books\n4.WalletRecharge\n5.Exit");
                //Need to get input
                Console.Write("Select the option:");
                int subChoice = int.Parse(Console.ReadLine());
                //switch
                switch (subChoice)
                {
                    case 1:
                        {
                            Console.WriteLine("---------- BORROW BOOK ----------");
                            BorrowBook();
                            break;
                        }

                    case 2:
                        {
                            bool isFlag = true;
                            foreach (BorrowDetails borrow in borrowList)
                            {
                                if (borrow.UserID != currentUserLoggedIn.UserID)
                                {
                                    isFlag = false;
                                }
                            }
                            if (isFlag == false)
                            {
                                Console.WriteLine("You have not borrowed any books!");
                            }
                            else
                            {
                                Console.WriteLine("---------- BORROW HISTORY ----------");
                                ShowBorrowHistory();
                                break;
                            }
                            break;
                        }

                    case 3:
                        {
                            Console.WriteLine("---------- RETURN BOOKS ----------");
                            ReturnBooks();
                            break;
                        }

                    case 4:
                        {
                            Console.WriteLine("---------- WALLET RECHARGE ----------");
                            WalletRecharge();
                            break;
                        }

                    case 5:
                        {
                            Console.WriteLine("Taking Back to main menu");
                            option = "no";
                            break;
                        }
                }

            } while (option == "yes");
        }//sub menu ends


        //Borrow books
        public static void BorrowBook()
        {
            //need to show the list of books
            Console.WriteLine($"|BookID|BookName|AuthorName|BookCount");
            //showing the details
            foreach(BookDetails book in bookList)
            {
                Console.WriteLine($"|{book.BookID}|{book.BookName}|{book.AuthorName}|{book.BookCount}");
            }
            //need to ask the user that book id to borrow
            Console.Write("Enter the Book ID to borrow: ");
            string userBookID = Console.ReadLine().ToUpper();
            //need to check book id available
            foreach(BookDetails book in bookList)
            {
                if(userBookID.Equals(book.BookID))
                {
                    //need to enter the count
                    Console.Write("Enter the count of the book: ");
                    int bookCount = int.Parse(Console.ReadLine());
                     //need to check the book availability
                    if(bookCount <= book.BookCount)
                    {
                          //need to check the book availability
                    // foreach (BorrowDetails borrow in borrowList)
                    // {
                    //     if (bookCount <= book.BookCount)
                    //     {
                    //         BorrowDetails borrows = new BorrowDetails(borrow.BookID, currentUserLoggedIn.UserID, DateTime.Now, borrow.BorrowBookCount, Status.Borrowed, borrow.PaidFineAmount);
                    //         //reduce book count
                    //         borrow.BorrowBookCount--;
                    //         //adding in list
                    //         borrowList.Add(borrows);
                    //     }
                    // }
                    //need to check history of user
                    //reaches 3 means tell them reached limit
                    //after need to give book and tells the date and fin amount 0
                    //create object to borrow details

                    //Borrow book ends
                        break;
                        //need to check history of user
                        //reaches 3 means tell them reached limit
                        //after need to give book and tells the date and fin amount 0
                        //create object to borrow details
                       
                        //Borrow book ends
                    }
                    //not avaliable means tell the date of availability
                    else
                    {
                        Console.WriteLine("Books are not avalaible for the selected count");
                        break;
                    }
                   
                }
                else
                {
                    Console.WriteLine("Invalid Book ID, Please enter a valid one.");
                    break;
                }
            }
        }
            


        //Show Borrow History
        public static void ShowBorrowHistory()
        {
            //need to show the current user details
            Console.WriteLine("|BorrowID|BookID|UserID|BorrowedDate|BorrowBookCount|Status|PaidFineAmount|");
            //showing the current user details
            foreach (BorrowDetails borrow in borrowList)
            {
                if (currentUserLoggedIn.UserID.Equals(borrow.UserID))
                {
                    Console.WriteLine($"|{borrow.BorrowID}|{borrow.BookID}|{borrow.UserID}|{borrow.BorrowedDate.ToString("dd/MM/yyyy")}|{borrow.BorrowBookCount}|{borrow.Status}|{borrow.PaidFineAmount}|");
                }

            }
        }//Show Borrow History ends


        //Return books
        public static void ReturnBooks()
        {


        }//Return books ends


        //wallet recharge
        public static void WalletRecharge()
        {
            string option = "true";
            do
            {   //need to ask the user
                Console.Write("Do you want to recharge the wallet? - yes or no : ");
                //condition yes or no
                string conditionalOption = Console.ReadLine();
                if (conditionalOption == "yes")
                {
                    Console.Write("Enter the amount: ");
                    double rechargeAmount = double.Parse(Console.ReadLine());
                    if (rechargeAmount > 0)
                    {
                        double balance = currentUserLoggedIn.WalletRecharges(rechargeAmount);
                        Console.WriteLine($"Your wallet balance is {balance}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please enter the valid amount");
                    }
                }
                else
                {
                    option = "false";
                    SubMenu();
                    break;
                }


            } while (option == "true");
        }//Wallet recharge ends


        //Default Value method
        public static void AddDefault()
        {
            //UserDetails Class
            UserDetails user1 = new UserDetails("Ravichandran", Gender.Male, Department.EEE, 9938388333, "ravi@gmail.com", 100);
            UserDetails user2 = new UserDetails("Priyadharshini", Gender.Female, Department.CSE, 9944444455, "priya@gmail.com", 150);
            userList.AddRange(new List<UserDetails>() { user1, user2 });

            //BookDetails Class
            BookDetails book1 = new BookDetails("C#", "Author1", 3);
            BookDetails book2 = new BookDetails("HTML", "Author2", 5);
            BookDetails book3 = new BookDetails("CSS", "Author1", 3);
            BookDetails book4 = new BookDetails("JS", "Author1", 3);
            BookDetails book5 = new BookDetails("TS", "Author2", 2);
            bookList.AddRange(new List<BookDetails>() { book1, book2, book3, book4, book5 });

            //BorrowDetails Class
            BorrowDetails borrower1 = new BorrowDetails("BID1001", "SF3001", new DateTime(2023, 09, 10), 2, Status.Borrowed, 0);
            BorrowDetails borrower2 = new BorrowDetails("BID1003", "SF3001", new DateTime(2023, 09, 12), 1, Status.Borrowed, 0);
            BorrowDetails borrower3 = new BorrowDetails("BID1004", "SF3001", new DateTime(2023, 09, 14), 1, Status.Returned, 16);
            BorrowDetails borrower4 = new BorrowDetails("BID1002", "SF3002", new DateTime(2023, 09, 11), 2, Status.Borrowed, 0);
            BorrowDetails borrower5 = new BorrowDetails("BID1005", "SF3002", new DateTime(2023, 09, 09), 1, Status.Returned, 20);
            borrowList.AddRange(new List<BorrowDetails>() { borrower1, borrower2, borrower3, borrower4, borrower5 });
        }
    }
}