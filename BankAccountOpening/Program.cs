using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
namespace BankAccountOpening;
class Program
{
    public static void Main(string[] args)
    {

        List<BankDetails> bankList = new List<BankDetails>();
        int n;
        do
        {

            Console.WriteLine("Hi User!! Here the menu,");
            Console.WriteLine(" ##### PRESS #####\n1.Registration\n2.Login\n3.Exit");
            n = int.Parse(Console.ReadLine());

            switch (n)
            {
                case 1:
                    {
                        Console.WriteLine("Bank Registration Form");
                        Console.Write("Customer Name : ");
                        string customerName = Console.ReadLine();
                        Console.Write("Balance : ");
                        int balance = int.Parse(Console.ReadLine());
                        Console.Write("Gender : ");
                        Gender gender = Enum.Parse<Gender>(Console.ReadLine(), true);
                        Console.Write("Phone : ");
                        long phone = long.Parse(Console.ReadLine());
                        Console.Write("Mail Id  : ");
                        string mailID = Console.ReadLine();
                        Console.Write("Date of Birth DD/MM/YYYY : ");
                        DateTime dob = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

                        BankDetails bankInfo = new BankDetails(customerName, balance, gender, phone, mailID, dob);
                        Console.WriteLine("You have registered succesfully");
                        Console.WriteLine("Your Cust ID : " + bankInfo.CustomerID);
                        bankList.Add(bankInfo);
                        break;
                    }

                case 2:
                    {
                        Console.Write("Enter the Cust ID : ");
                        string userID = Console.ReadLine();
                        bool flag = true;
                        foreach (BankDetails i in bankList)
                        {
                            if (i.CustomerID == userID)
                            {
                                Console.WriteLine($"Welcome {i.CustomerName}!!");
                                Console.WriteLine("1.Deposit\n2.Withdraw\n3.Balance Check\n4.Exit");
                                int option = int.Parse(Console.ReadLine());

                                switch (option)
                                {
                                    case 1:
                                        {
                                            Console.WriteLine("##### DEPOSIT #####");
                                            Console.Write("Enter the Amount : ");
                                            double dAmount = double.Parse(Console.ReadLine());
                                            double dBal = deposit(dAmount, i.Balance);
                                            Console.WriteLine($"Your current balance : {dBal}");
                                            break;
                                        }

                                    case 2:
                                        {
                                            Console.WriteLine("##### WITHDRAW #####");
                                            Console.Write("Enter the Amount : ");
                                            double wAmount = double.Parse(Console.ReadLine());
                                            double wBal = withdraw(wAmount, i.Balance);
                                            Console.WriteLine($"Your current balance : {wBal}");
                                            break;
                                        }

                                    case 3:
                                        {
                                            Console.WriteLine("##### BALANCE #####");
                                            Console.WriteLine($"Your current balance : {i.Balance}");
                                            break;
                                        }

                                    case 4:
                                        {
                                            break;
                                        }

                                    default:
                                        {
                                            Console.WriteLine("Invalid Option");
                                            break;
                                        }
                                }

                                flag = false;
                            }
                        }

                        if (flag)
                        {
                            Console.WriteLine("Invalid User ID");
                            break;
                        }
                        break;
                    }

                case 3:
                    {
                        break;
                    }

            }

        } while (n != 3);

    }
    /// <summary>
    /// Method is used to add the amount to the bank account <see cref="BankDetails"/>
    /// </summary>
    /// <param name="balAmount">It is the bank balance</param>
    /// <param name="depAmount">It is the deposited amount</param>
    /// <returns>It returns the deposited amount</returns>
    public static double deposit(double balAmount, double depAmount)
    {
        double bDeposit = balAmount + depAmount;

        return bDeposit;

    }

    public static double withdraw(double balAmount, double witAmount)
    {
        double bWithdraw = Math.Abs(balAmount - witAmount);
        return bWithdraw;
    }

}