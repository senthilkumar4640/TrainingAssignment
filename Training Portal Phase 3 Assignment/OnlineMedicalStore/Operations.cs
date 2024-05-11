using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Transactions;
using System.Xml.Serialization;

namespace OnlineMedicalStore
{
    public static class Operations
    {
        static List<UserDetail> userList = new List<UserDetail>();
        static List<MedicineDetail> medicineList = new List<MedicineDetail>();
        static List<OrderDetail> orderList = new List<OrderDetail>();

        static UserDetail currentUserLoggedIn;
        public static void AddDefault()
        {
            //Userdetails
            UserDetail user1 = new UserDetail("Ravi", 33, "Theni", "9877774440", 400);
            UserDetail user2 = new UserDetail("Baskaran", 33, "Theni", "9877774440", 500);
            userList.Add(user1);
            userList.Add(user2);

            //Medicine Details
            MedicineDetail medicine1 = new MedicineDetail("Paracitamol", 40, 5, new DateTime(2024, 04, 15));
            MedicineDetail medicine2 = new MedicineDetail("Calpol", 10, 5, new DateTime(2030, 06, 10));
            MedicineDetail medicine3 = new MedicineDetail("Gelucil", 3, 40, new DateTime(2029, 08, 30));
            medicineList.Add(medicine1);
            medicineList.Add(medicine2);
            medicineList.Add(medicine3);

            //Order Details
            OrderDetail order1 = new OrderDetail("UID1001", "MD101", 3, 15, new DateTime(2022, 11, 15), OrderStatus.Purchased);
            OrderDetail order2 = new OrderDetail("UID1001", "MD102", 2, 10, new DateTime(2022, 11, 17), OrderStatus.Cancelled);
            OrderDetail order3 = new OrderDetail("UID1001", "MD104", 3, 100, new DateTime(2023, 04, 15), OrderStatus.Purchased);
            orderList.Add(order1);
            orderList.Add(order2);
            orderList.Add(order3);
        }

        public static void MainMenu()
        {
            Console.WriteLine("-----Welcome to Online Medical Store-----");
            string mainOption = "yes";
            do
            {
                Console.WriteLine("Main Menu\n1. User Registration\n2. Login User\n3. Exit");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        {
                            Console.WriteLine("-----User Registration-----");
                            UserRegistration();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("-----Login User-----");
                            UserLogin();
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Application Exited Successfully..");
                            mainOption = "no";
                            break;
                        }
                }

            } while (mainOption == "yes");
        }

        public static void UserRegistration()
        {
            /*
            a.	Username
            b.	Age
            c.	City
            d.	Phone Number
            e.	Balance
            */
            Console.Write("Enter the Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter the Age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Enter the City: ");
            string city = Console.ReadLine();
            Console.Write("Enter the Phone Number: ");
            string phoneNumber = Console.ReadLine();
            Console.Write("Enter the Balance: ");
            double walletBalance = double.Parse(Console.ReadLine());
            //Create object
            UserDetail user = new UserDetail(name, age, city, phoneNumber, walletBalance);
            userList.Add(user);
            //Showing User ID
            Console.WriteLine("Registered Succesfully.. ");
            Console.WriteLine("Your UserID is " + user.UserID);
        }

        public static void UserLogin()
        {
            Console.Write("Enter the UserID: ");
            string loginID = Console.ReadLine().ToUpper();
            bool isFlag = true;
            foreach (UserDetail user in userList)
            {
                if (loginID.Equals(user.UserID))
                {
                    isFlag = false;
                    currentUserLoggedIn = user;
                    SubMenu();
                    break;
                }
            }
            if (isFlag)
            {
                Console.WriteLine("Invalid UserID.Please enter a valid one");
            }
        }

        public static void SubMenu()
        {
            string subOption = "yes";
            do
            {
                Console.WriteLine("Sub Menu\n1.Show medicine list\n2.Purchase medicine\n3.Modify purchase\n4.Cancel purchase\n5.Show purchase history\n6.Recharge Wallet\n7.Show Wallet Balance\n8.Exit");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        {
                            Console.WriteLine("-----Show medicine list-----");
                            ShowMedicineList();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("-----Purchase medicine-----");
                            PusrchaseMedicine();
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("-----Modify purchase-----");
                            ModifyPurchase();
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("-----Cancel purchase-----");
                            CancelPurchase();
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("-----Show purchase history.-----");
                            ShowPurchaseHistory();
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine("-----Recharge Wallet-----");
                            RechargeWallet();
                            break;
                        }
                    case 7:
                        {
                            Console.WriteLine("-----Show Wallet Balance-----");
                            ShowWalletBalance();
                            break;
                        }
                    case 8:
                        {
                            Console.WriteLine("Running back to Main Menu..");
                            subOption = "no";
                            break;
                        }
                }
            } while (subOption == "yes");
        }
        public static void ShowMedicineList()
        {
            Console.WriteLine("|MedicineID|MedicineName|AvailableCount|Price|DateOfExpiry|");
            foreach (MedicineDetail medicine in medicineList)
            {
                Console.WriteLine($"|{medicine.MedicineID}|{medicine.MedicineName}|{medicine.AvailableCount}|{medicine.Price}|{medicine.DateOfExpiry.ToString("dd/MM/yyyy")}|");
            }
        }

        public static void PusrchaseMedicine()
        {

            // 1.	Show the List of medicine details by traversing the medicine details list.
            ShowMedicineList();
            // 2.	Ask the user to select the medicine using MedicineID.
            Console.Write("Enter the Medicine ID: ");
            string medID = Console.ReadLine().ToUpper();
            // 3.	Ask the number of counts of that medicine he wants to buy.
            Console.Write("Enter the number of count: ");
            int MedicineCount = int.Parse(Console.ReadLine());
            // 4.	Check the Medicine list whether the MedicineID was available. If it is available, then 
            bool isFlag = true;
            foreach (MedicineDetail medicine in medicineList)
            {
                if (medID.Equals(medicine.MedicineID))
                {
                    isFlag = false;
                    // a.	check the asked count is available. If it is available, then
                    if (MedicineCount <= medicine.AvailableCount)
                    {
                        // b.	Check the medicine was not expired. If it is expired or not available, then show the user “Medicine is not available”.
                        if (medicine.DateOfExpiry > DateTime.Now)
                        {
                            // c.	If the medicine is not expired, then check User has enough balance to purchase that medicine. 
                            if (currentUserLoggedIn.WalletBalance >= medicine.Price)
                            {
                                // 5.	Reduce the number of AvailableCount of that medicine in MedicineDetails. 
                                medicine.AvailableCount = medicine.AvailableCount - MedicineCount;
                                // 6.	Deduct the total amount from user’s balance amount.
                                double TotalPrice = medicine.Price * MedicineCount;
                                currentUserLoggedIn.DeductBalance(TotalPrice);
                                // 7.	If all the conditions specified in step 4 are true then calculate the total amount of 
                                //purchased medicines, OrderDate is Now, Put OrderStatus as “Purchased” and create object for 
                                //OrderDetails class and add it to the list. 
                                OrderDetail order = new OrderDetail(currentUserLoggedIn.UserID, medicine.MedicineID, MedicineCount, TotalPrice, DateTime.Now, OrderStatus.Purchased);
                                orderList.Add(order);
                                // 8.	Finally show the message “Medicine was purchased successfully”.
                                Console.WriteLine("Medicine was purchased successfully");
                            }
                            else
                            {
                                Console.WriteLine("You have not enough balance..");
                                break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Medicine is Expired");
                            break;
                        }

                    }
                    else
                    {
                        Console.WriteLine("Medicine is not enough count");
                        break;
                    }

                }
            }
            if (isFlag)
            {
                Console.WriteLine("Medicine is not available");
            }




        }

        public static void ShowPurchaseHistory()
        {
            Console.WriteLine("|OrderID|UserID|MedicineID|MedicineCount|TotalPrice|OrderDate|OrderStatus|");
            foreach (OrderDetail order in orderList)
            {
                if (currentUserLoggedIn.UserID.Equals(order.UserID))
                {
                    Console.WriteLine($"|{order.OrderID}|{order.UserID}|{order.MedicineID}|{order.MedicineCount}|{order.TotalPrice}|{order.OrderDate.ToString("dd/MM/yyyy")}|{order.OrderStatus}|");
                }
            }
        }

        public static void ModifyPurchase()
        {
            bool isFlag = false;
            // 1.	Show the order details of current logged in user to pick a order detail by using OrderID
            // and whose status is “Purchased”. Check whether the purchase details is present. If yes then,
            Console.WriteLine("|OrderID|UserID|MedicineID|MedicineCount|TotalPrice|OrderDate|OrderStatus|");
            foreach (OrderDetail order in orderList)
            {
                if (currentUserLoggedIn.UserID.Equals(order.UserID) && order.OrderStatus.Equals(OrderStatus.Purchased))
                {
                    Console.WriteLine($"|{order.OrderID}|{order.UserID}|{order.MedicineID}|{order.MedicineCount}|{order.TotalPrice}|{order.OrderDate.ToString("dd/MM/yyyy")}|{order.OrderStatus}|");
                    Console.WriteLine();
                    if (currentUserLoggedIn.UserID.Equals(order.UserID) && order.OrderStatus.Equals(OrderStatus.Purchased))
                    {
                        // 2.Ensure the order ID is available and ask the user to enter the new quantity of the medicine. 
                        //Calculate the order price and update in the order price. 
                        Console.Write("Enter the Order ID: ");
                        string modifyID = Console.ReadLine().ToUpper();
                        if (modifyID.Equals(order.OrderID))
                        {
                            Console.Write("Enter the quantity: ");
                            int quantity = int.Parse(Console.ReadLine());
                            // 3.Calculate the total price of order and update in purchase details entry. 
                            foreach (MedicineDetail medicine in medicineList)
                            {
                                order.MedicineCount = order.MedicineCount + quantity;
                                order.TotalPrice = order.TotalPrice + (quantity * medicine.Price);
                                currentUserLoggedIn.DeductBalance(order.TotalPrice);
                                isFlag = true;
                                break;

                            }
                        }
                    }
                }
            }
            if (isFlag)
            {
                Console.WriteLine("order modified successfully");
            }




            // 4.	Show order modified successfully.

        }
        public static void CancelPurchase()
        {

            // 1.	Show the order details of the currently logged in user whose order status is “Purchased”
            Console.WriteLine("|OrderID|UserID|MedicineID|MedicineCount|TotalPrice|OrderDate|OrderStatus|");
            foreach (OrderDetail order in orderList)
            {
                if (currentUserLoggedIn.UserID.Equals(order.UserID) && order.OrderStatus.Equals(OrderStatus.Purchased))
                {
                    Console.WriteLine($"|{order.OrderID}|{order.UserID}|{order.MedicineID}|{order.MedicineCount}|{order.TotalPrice}|{order.OrderDate.ToString("dd/MM/yyyy")}|{order.OrderStatus}|");
                }
            }
                    Console.WriteLine("Enter the Order ID: ");
                    string cancelID = Console.ReadLine().ToUpper();
            foreach(OrderDetail order in orderList)
            {
                
                    //Get the OrderID information from the user and check the OrderID present in the list and 
                    //check its OrderStatus is Purchased.
                    if (cancelID.Equals(order.OrderID))
                    {

                        //If the OrderID matches increase the count of that Medicine in the medicine details, 
                        //Return the amount to the user.  Change the Status of the order to “Cancelled”.
                        foreach (MedicineDetail medicine in medicineList)
                        {
                            medicine.AvailableCount = medicine.AvailableCount + order.MedicineCount;
                        }
                        currentUserLoggedIn.WalletRecharge(order.TotalPrice);
                        order.OrderStatus = OrderStatus.Cancelled;
                        // 4.	Show the user that the “OrderID XXX was cancelled successfully”. 
                        Console.WriteLine($"{order.OrderID} was cancelled successfully");
                    }
                }
            }
            public static void RechargeWallet()
            {
                Console.Write("Enter the amount: ");
                double amount = double.Parse(Console.ReadLine());
                if (amount > 0)
                {
                    currentUserLoggedIn.WalletRecharge(amount);
                    Console.WriteLine("Recharged Succesfully..");
                }
                else
                {
                    Console.WriteLine("Enter the valid amount..");
                }
            }
            public static void ShowWalletBalance()
            {
                Console.WriteLine($"Your Balance is {currentUserLoggedIn.WalletBalance}");
            }
        }

    }
