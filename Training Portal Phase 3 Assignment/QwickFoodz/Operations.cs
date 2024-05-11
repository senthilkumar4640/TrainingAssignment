using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace QwickFoodz
{
    public static class Operations
    {
        //List
        public static CustomList<CustomerDetails> customerList = new CustomList<CustomerDetails>();
        public static CustomList<FoodDetails> foodList = new CustomList<FoodDetails>();
        public static CustomList<OrderDetails> orderList = new CustomList<OrderDetails>();
        public static CustomList<ItemDetails> itemList = new CustomList<ItemDetails>();

        //Global variable
        static CustomerDetails currentCustomerLoggedIn;

        public static void AddDefault()
        {

            //Customer Details
            CustomerDetails customer1 = new CustomerDetails(10000, "Ravi", "Ettapparajan", Gender.Male, "974774646", new DateTime(1999, 11, 11), "ravi@gmail.com", "Chennai");
            CustomerDetails customer2 = new CustomerDetails(15000, "Baskaran", "Sethurajan", Gender.Male, "847575775", new DateTime(1999, 11, 11), "baskaran@gmail.com", "Chennai");
            customerList.Add(customer1);
            customerList.Add(customer2);

            //Food Details
            FoodDetails food1 = new FoodDetails("Chicken Briyani 1Kg", 100, 12);
            FoodDetails food2 = new FoodDetails("Mutton Briyani 1Kg", 150, 10);
            FoodDetails food3 = new FoodDetails("Veg Full Meals", 150, 10);
            FoodDetails food4 = new FoodDetails("Noodles", 150, 10);
            FoodDetails food5 = new FoodDetails("Dosa", 150, 10);
            FoodDetails food6 = new FoodDetails("Idly (2 pieces)", 150, 10);
            FoodDetails food7 = new FoodDetails("Pongal", 150, 10);
            FoodDetails food8 = new FoodDetails("Vegetable Briyani", 150, 10);
            FoodDetails food9 = new FoodDetails("Lemon Rice", 150, 10);
            FoodDetails food10 = new FoodDetails("Veg Pulav", 150, 10);
            FoodDetails food11 = new FoodDetails("Chicken 65 (200 Grams)", 150, 10);
            foodList.Add(food1);
            foodList.Add(food2);
            foodList.Add(food3);
            foodList.Add(food4);
            foodList.Add(food5);
            foodList.Add(food6);
            foodList.Add(food7);
            foodList.Add(food8);
            foodList.Add(food9);
            foodList.Add(food10);
            foodList.Add(food11);

            //Order Details
            OrderDetails order1 = new OrderDetails("CID1001", 580, new DateTime(2022, 11, 26), OrderStatus.Ordered);
            OrderDetails order2 = new OrderDetails("CID1002", 870, new DateTime(2022, 11, 26), OrderStatus.Ordered);
            OrderDetails order3 = new OrderDetails("CID1001", 820, new DateTime(2022, 11, 26), OrderStatus.Cancelled);
            orderList.Add(order1);
            orderList.Add(order2);
            orderList.Add(order3);

            //Item Details
            ItemDetails item1 = new ItemDetails("OID3001", "FID2001", 2, 200);
            ItemDetails item2 = new ItemDetails("OID3001", "FID2002", 2, 300);
            ItemDetails item3 = new ItemDetails("OID3001", "FID2003", 1, 80);
            ItemDetails item4 = new ItemDetails("OID3002", "FID2001", 1, 100);
            ItemDetails item5 = new ItemDetails("OID3002", "FID2002", 4, 600);
            ItemDetails item6 = new ItemDetails("OID3002", "FID2000", 1, 120);
            ItemDetails item7 = new ItemDetails("OID3002", "FID2009", 1, 50);
            ItemDetails item8 = new ItemDetails("OID3003", "FID2002", 2, 300);
            ItemDetails item9 = new ItemDetails("OID3003", "FID2008", 4, 320);
            ItemDetails item10 = new ItemDetails("OID3003", "FID2001", 2, 200);
            itemList.Add(item1);
            itemList.Add(item2);
            itemList.Add(item3);
            itemList.Add(item4);
            itemList.Add(item5);
            itemList.Add(item6);
            itemList.Add(item7);
            itemList.Add(item8);
            itemList.Add(item9);
            itemList.Add(item10);
        }

        public static void MainMenu()
        {
            Console.WriteLine("Welcome to Qwick Foodz");
            string option = "yes";
            do
            {
                Console.WriteLine("Main Menu\n1. Customer Registration\n2. Customer Login\n3. Exit");
                int mainOption = int.Parse(Console.ReadLine());
                switch (mainOption)
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
                            option = "no";
                            Console.WriteLine("Application exited successfully..");
                            break;

                        }
                }

            } while (option == "yes");
        }

        public static void CustomerRegistration()
        {
            /*
            i.	Name,
            ii.	FatherName, 
            iii.	Gender- {Select, Male, Female, Transgender}, 
            iv.	Mobile, 
            v.	DOB, 
            vi.	MailID, 
            b.	Location 
            */

            //Asking value from user
            Console.Write("Enter your Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your Father Name: ");
            string fatherName = Console.ReadLine();
            Console.Write("Enter your Gender {Male, Female, Transgender}: ");
            Gender gender = Enum.Parse<Gender>(Console.ReadLine(), true);
            Console.Write("Enter your Mobile Number: ");
            string mobile = Console.ReadLine();
            Console.Write("Enter your DOB as specified DD/MM/YYYY: ");
            DateTime dob = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
            Console.Write("Enter your MailID: ");
            string mailID = Console.ReadLine();
            Console.Write("Enter your Location: ");
            string location = Console.ReadLine();

            //creating object
            CustomerDetails customer = new CustomerDetails(0, name, fatherName, gender, mobile, dob, mailID, location);
            customerList.Add(customer);

            //Showing customer ID
            Console.WriteLine("Customer Registration Successful.. Your Customer ID is :" + customer.CustomerID);
        }

        public static void CustomerLogin()
        {
            Console.Write("Enter the Customer ID: ");
            string loginID = Console.ReadLine().ToUpper();
            bool isFlag = true;
            foreach (CustomerDetails customer in customerList)
            {
                if (loginID.Equals(customer.CustomerID))
                {
                    isFlag = false;
                    currentCustomerLoggedIn = customer;
                    SubMenu();
                    break;
                }
            }
            if (isFlag)
            {
                Console.WriteLine("Invalid Customer ID");
            }
        }

        public static void SubMenu()
        {
            Console.WriteLine("Welcome " + currentCustomerLoggedIn.Name);
            string subOption = "yes";
            do
            {
                Console.WriteLine("Sub Menu\n1. Show Profile\n2. Order Food\n3. Cancel Order\n4. Modify Order\n5. Order History\n6. Recharge Wallet\n7. Show Wallet Balance\n8. Exit");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        {
                            Console.WriteLine("Show Profile");
                            ShowProfile();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Order Food");
                            OrderFood();
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Cancel Order");
                            CancelOrder();
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Modify Order");
                            ModifyOrder();
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("Order History");
                            OrderHistory();
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine("Recharge Wallet");
                            RechargeWallet();
                            break;
                        }
                    case 7:
                        {
                            Console.WriteLine("Show Wallet Balance");
                            ShowWalletBalance();
                            break;
                        }
                    case 8:
                        {
                            subOption = "no";
                            Console.WriteLine("Running Back to Main Menu");
                            break;
                        }
                }

            } while (subOption == "yes");
        }

        public static void ShowProfile()
        {
            Console.WriteLine("|CustomerID|WalletBalance|Name|FatherName|Gender|Mobile|DOB|MailID|Location|");
            foreach (CustomerDetails customer in customerList)
            {
                Console.WriteLine($"|{currentCustomerLoggedIn.CustomerID}|{currentCustomerLoggedIn.WalletBalance}|{currentCustomerLoggedIn.Name}|{currentCustomerLoggedIn.FatherName}|{currentCustomerLoggedIn.Gender}|{currentCustomerLoggedIn.Mobile}|{currentCustomerLoggedIn.DOB.ToString("dd/MM/yyyy")}|{currentCustomerLoggedIn.MailID}|{currentCustomerLoggedIn.Location}|");
                break;
            }
        }

        public static void OrderHistory()
        {
            bool isFlag = true;
            Console.WriteLine("|OrderID|CustomerID|TotalPrice|DateOfOrder|OrderStatus|");
            foreach (OrderDetails order in orderList)
            {
                if (orderList != null && currentCustomerLoggedIn.CustomerID.Equals(order.CustomerID))
                {
                    isFlag = false;
                    Console.WriteLine($"|{order.OrderID}|{order.CustomerID}|{order.TotalPrice}|{order.DateOfOrder.ToString("dd/MM/yyyy")}|{order.OrderStatus}|");
                }
            }
            if (isFlag)
            {
                Console.WriteLine("You dosen't have any order history");
            }

        }

        public static void RechargeWallet()
        {
            Console.Write("Enter the amount to be recharged: ");
            double amount = double.Parse(Console.ReadLine());
            if (amount > 0)
            {
                currentCustomerLoggedIn.WalletRecharge(amount);
                Console.WriteLine("Amount Recharged Successfully");
            }
            else
            {
                Console.WriteLine("Enter the valid amount");
            }

        }

        public static void ShowWalletBalance()
        {
            Console.WriteLine($"Your Total Balance is: {currentCustomerLoggedIn.WalletBalance}");
        }

        public static void OrderFood()
        {

            // a.	Create OrderDetails object with CustomerID, TotalPrice = 0, DateOfOrder as today and OrderStatus = Initiated.
            OrderDetails order = new OrderDetails(currentCustomerLoggedIn.CustomerID, 0, DateTime.Now, OrderStatus.Initiated);
            // b.	Create localItemList for adding your wishlist.
            CustomList<ItemDetails> localItemList = new CustomList<ItemDetails>();

            string option = "";
            bool isFlag = true;

            // c.	Show all the list of food items available in store for processing the order.
            Console.WriteLine("|FoodID|FoodName|PricePerQuantity|QuantityAvailable|");
            foreach (FoodDetails food in foodList)
            {
                Console.WriteLine($"|{food.FoodID}|{food.FoodName}|{food.PricePerQuantity}|{food.QuantityAvailable}|");
            }
            // d.	Ask the FoodID, order quantity from user and check whether it is available. If not show FoodID Invalid or FoodQuantity 
            //unavailable based on the scenario. 
            Console.Write("Enter the FoodID: ");
            string foodOrderID = Console.ReadLine().ToUpper();
            Console.Write("Enter the count: ");
            int foodOrderCount = int.Parse(Console.ReadLine());

            isFlag = false;
            foreach (FoodDetails food in foodList)
            {
                double priceOrder = foodOrderCount * food.PricePerQuantity;
                if (foodOrderID.Equals(food.FoodID) && foodOrderCount <= food.QuantityAvailable)
                {
                    ItemDetails item = new ItemDetails(order.OrderID, food.FoodID, foodOrderCount, priceOrder);
                    food.QuantityAvailable = food.QuantityAvailable - foodOrderCount;
                    double totalPrice = foodOrderCount * food.PricePerQuantity;
                    localItemList.Add(item);

                    Console.Write("Whether you need to order more? (yes or no): ");
                    option = Console.ReadLine();

                    if (currentCustomerLoggedIn.WalletBalance > 0 && currentCustomerLoggedIn.WalletBalance >= totalPrice)
                    {
                        order.TotalPrice = totalPrice;
                        order.OrderStatus = OrderStatus.Ordered;
                        currentCustomerLoggedIn.DeductBalance(totalPrice);
                        itemList.AddRange(localItemList);
                    }
                    else
                    {
                        Console.WriteLine("Insufficient Balance");
                        Console.WriteLine("Do you want to recharge? (yes / no)");
                        string rechargeOption = Console.ReadLine();
                        if (rechargeOption == "no")
                        {
                            food.QuantityAvailable = food.QuantityAvailable + foodOrderCount;
                        }
                        else
                        {
                            RechargeWallet();
                            ShowWalletBalance();
                        }
                    }
                }
            }
            if (isFlag)
            {
                Console.WriteLine("Food ID invalid or Food Quantity not available");
            }
        }

        public static void CancelOrder()
        {
            Console.WriteLine("|OrderID|CustomerID|TotalPrice|DateOfOrder|OrderStatus|");
            foreach (OrderDetails order in orderList)
            {
                if (currentCustomerLoggedIn.CustomerID.Equals(order.CustomerID) && order.OrderStatus.Equals(OrderStatus.Ordered))
                {
                    Console.WriteLine($"|{order.OrderID}|{order.CustomerID}|{order.TotalPrice}|{order.DateOfOrder.ToString("dd/MM/yyyy")}|{order.OrderStatus}|");
                    Console.Write("Enter the Order ID: ");
                    string cancelID = Console.ReadLine().ToUpper();


                    if (cancelID.Equals(order.OrderID))
                    {

                        foreach (FoodDetails food in foodList)
                        {
                            foreach (ItemDetails item in itemList)
                            {
                                food.QuantityAvailable = food.QuantityAvailable + item.PurchaseCount;
                            }

                        }
                        currentCustomerLoggedIn.WalletRecharge(order.TotalPrice);
                        order.OrderStatus = OrderStatus.Cancelled;

                        Console.WriteLine($"{order.OrderID} was cancelled successfully");
                    }
                }
            }
        }

        public static void ModifyOrder()
        {
            bool isFlag = true;
            Console.WriteLine("|OrderID|CustomerID|TotalPrice|DateOfOrder|OrderStatus|");
            foreach (OrderDetails order in orderList)
            {
                if (currentCustomerLoggedIn.CustomerID.Equals(order.CustomerID) && order.OrderStatus.Equals(OrderStatus.Ordered))
                {
                    isFlag = false;
                    Console.WriteLine($"|{order.OrderID}|{order.CustomerID}|{order.TotalPrice}|{order.DateOfOrder.ToString("dd/MM/yyyy")}|{order.OrderStatus}|");
                    Console.Write("Enter the Order ID: ");
                    string modifyID = Console.ReadLine().ToUpper();
                    if (modifyID.Equals(order.OrderID))
                    {

                    }
                }
            }
            if (isFlag)
            {
                Console.WriteLine("You dosen't have any order history");
            }


        }
    }
}
