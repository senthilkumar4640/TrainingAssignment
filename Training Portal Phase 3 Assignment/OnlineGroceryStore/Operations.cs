using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace OnlineGroceryStore
{
    public static class Operations
    {
        static List<CustomerRegistration> customerList = new List<CustomerRegistration>();
        static List<ProductDetails> productList = new List<ProductDetails>();
        static List<BookingDetails> bookingList = new List<BookingDetails>();
        static List<OrderDetails> orderList = new List<OrderDetails>();

        static CustomerRegistration currentUserLoggedIn;

        public static void MainMenu()
        {
            Console.WriteLine("Welcome to Online Grocery Store..");
            string mainOption = "yes";
            do
            {
                Console.WriteLine("Menu\n1.Customer Registration\n2.Customer Login\n3.Exit");
                int option = int.Parse(Console.ReadLine());
                switch(option)
                {
                    case 1:
                    {
                        Console.WriteLine("Customer Registration");
                        CustomerRegistration();
                        break;
                    }
                    case 2:
                    {
                        Console.WriteLine("Customer Login");
                        CustomerLogin();
                        break;
                    }
                    case 3:
                    {
                        Console.WriteLine("Application Exited Sucessfully");
                        mainOption = "no";
                        break;
                    }
                }

            }while(mainOption == "yes");

        }

        public static void CustomerRegistration()
        {
            //walletBalance, Name, FatherName, Gender, Mobile, DOB, MailID
            Console.Write("Enter the Wallet Balance: ");
            double walletBalance = double.Parse(Console.ReadLine());
            Console.Write("Enter the name: ");
            string name = Console.ReadLine();
            Console.Write("Enter the FatherName: ");
            string fatherName = Console.ReadLine();
            Console.Write("Enter the Gender {Male, Female}: ");
            Gender gender = Enum.Parse<Gender>(Console.ReadLine(),true);
            Console.Write("Enter the Mobile Number: ");
            string mobile = Console.ReadLine();
            Console.Write("Enter the Date Of Birth(dd/mm/yyyy): ");
            DateTime dob = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
            Console.Write("Enter the MailID: ");
            string mailID = Console.ReadLine();

            //Creating Object
            CustomerRegistration customer = new CustomerRegistration(walletBalance,name,fatherName,gender,mobile,dob,mailID);
            //Adding list
            customerList.Add(customer);
            //Showing the customer ID
            Console.WriteLine("Registered Successfully, Your Customer ID is "+customer.CustomerID);
        }

        public static void CustomerLogin()
        {
            Console.Write("Enter your Customer ID: ");
            string loginID = Console.ReadLine().ToUpper();
            bool isFlag = true;
            foreach(CustomerRegistration customer in customerList)
            {
                if(loginID.Equals(customer.CustomerID))
                {
                    isFlag=false;
                    currentUserLoggedIn=customer;
                    Console.WriteLine("Logged in successfully..");
                    SubMenu();
                    break;
                }
            }
            if(isFlag)
            {
                Console.WriteLine("Your Customer ID is Invalid");
            }
        }

        public static void SubMenu()
        {
            string subOption = "yes";
            do
            {
                /*
                a)	Show Customer Details
                b)	Show Product Details
                c)	Wallet Recharge
                d)	Take Order
                e)	Modify Order Quantity
                f)	Cancel Order
                g)	Show Balance
                h)	Exit
                */
                Console.WriteLine("Sub menu\n1.Show Customer Details\n2.Show Product Details\n3.Wallet Recharge\n4.Take Order\n5.Modify order quantity\n6.Cancel order\n7.Show Balance\n8.Exit");
                int option = int.Parse(Console.ReadLine());
                switch(option)
                {
                    case 1:
                    {
                        Console.WriteLine("Customer Details");
                        CustomerDetails();
                        break;
                    }
                    case 2:
                    {
                        Console.WriteLine("Product Details");
                        ProductDetails();
                        break;
                    }
                     case 3:
                    {
                        Console.WriteLine("Wallet Recharge");
                        WalletsRecharge();
                        break;
                    }
                    case 4:
                    {
                        Console.WriteLine("Take Order");
                        break;
                    }
                     case 5:
                    {
                        Console.WriteLine("Modify Order Quantity");
                        break;
                    }
                     case 6:
                    {
                        Console.WriteLine("Cancel Order");
                        break;
                    }
                     case 7:
                    {
                        Console.WriteLine("Balance");
                        Balance();
                        break;
                    }
                     case 8:
                    {
                        Console.WriteLine("Running back to main menu");
                        subOption="no";
                        break;
                    }
                }

            }while(subOption=="yes");
        }

        public static void CustomerDetails()
                {
                    Console.WriteLine("|CustomerID|WalletBalance|Name|Fathername|Gender|Mobile|DOB|MailID|");
                    foreach(CustomerRegistration customer in customerList)
                    {
                       Console.WriteLine($"|{currentUserLoggedIn.CustomerID}|{currentUserLoggedIn.WalletBalance}|{currentUserLoggedIn.Name}|{currentUserLoggedIn.FatherName}|{currentUserLoggedIn.Gender}|{currentUserLoggedIn.Mobile}|{currentUserLoggedIn.DOB.ToString("dd/MM/yyyy")}|{currentUserLoggedIn.MailID}"); 
                       break;
                    }
                }

        public static void ProductDetails()
        {
             Console.WriteLine("|ProductID|ProductName|QuantityAvaliable|PricePerQuantity|");
                    foreach(ProductDetails product in productList)
                    {
                       Console.WriteLine($"|{product.ProductID}|{product.ProductName}|{product.QuantityAvailable}|{product.PricePerQuantity}|"); 
                    }
        }

        public static void WalletsRecharge()
        {
            Console.Write("Enter the amount to recharge: ");
            double amount = double.Parse(Console.ReadLine());
            if(amount > 0)
            {
                currentUserLoggedIn.WalletRecharge(amount);
                Console.WriteLine("Recharged Succesfully..");
            }
            else
            {
                Console.WriteLine("Enter the valid amount..");
            }
        }

        public static void Balance()
        {
            Console.WriteLine($"Your balance is {currentUserLoggedIn.WalletBalance}");
        }


                
        public static void AddDefault()
        {
            //Customer List
            CustomerRegistration customer1 = new CustomerRegistration(10000,"Ravi","Ettapparajan",Gender.Male,"974774646", new DateTime(1999,11,11),"ravi@gmail.com"); 
            CustomerRegistration customer2 = new CustomerRegistration(15000, "Baskaran","Sethurajan",Gender.Male,"847575775",new DateTime(1999,11,11),"baskaran@gmail.com");
            customerList.AddRange(new List<CustomerRegistration>(){customer1,customer2});

            //Product List
            ProductDetails product1 = new ProductDetails("Sugar",20,40);
            ProductDetails product2 = new ProductDetails("Rice",100,50);
            ProductDetails product3 = new ProductDetails("Milk",10,40);
            ProductDetails product4 = new ProductDetails("Coffee",10,10);
            ProductDetails product5 = new ProductDetails("Tea",10,10);
            ProductDetails product6 = new ProductDetails("Masala Powder",10,20);
            ProductDetails product7 = new ProductDetails("Salt",10,10);
            ProductDetails product8 = new ProductDetails("Turmeric Powder",10,25);
            ProductDetails product9 = new ProductDetails("Chilli Powder",10,20);
            ProductDetails product10 = new ProductDetails("Groundnut Oil",10,140);
            productList.AddRange(new List<ProductDetails>(){product1,product2,product3,product4,product5,product6,product7,product8,product9,product10});

            //Booking List
            BookingDetails booking1 = new BookingDetails("CID1001",220,new DateTime(2022,07,26), BookingStatus.Booked);
            BookingDetails booking2 = new BookingDetails("CID1002",400,new DateTime(2022,07,26), BookingStatus.Booked);
            BookingDetails booking3 = new BookingDetails("CID1001",280,new DateTime(2022,07,26), BookingStatus.Cancelled);
            BookingDetails booking4 = new BookingDetails("CID1002",0,new DateTime(2022,07,26), BookingStatus.Initiated);
            bookingList.AddRange(new List<BookingDetails>(){booking1,booking2,booking3,booking4});

            //Order List
            OrderDetails order1 = new OrderDetails("BID3001","PID2001",	2,80);
            OrderDetails order2 = new OrderDetails("BID3001","PID2002",	2,100);
            OrderDetails order3 = new OrderDetails("BID3001","PID2003",	1,40);
            OrderDetails order4 = new OrderDetails("BID3002","PID2001",	1,40);
            OrderDetails order5 = new OrderDetails("BID3002","PID2002",	4,200);
            OrderDetails order6 = new OrderDetails("BID3002","PID2010",	1,140);
            OrderDetails order7 = new OrderDetails("BID3002","PID2009",	1,20);
            OrderDetails order8 = new OrderDetails("BID3003","PID2002",	2,100);
            OrderDetails order9 = new OrderDetails("BID3003","PID2008",	4,100);
            OrderDetails order10 = new OrderDetails("BID3003","PID2001", 2,80);
            orderList.AddRange(new List<OrderDetails>(){order1,order2,order3,order4,order5,order6,order7,order8,order9,order10});
        }
    }
}