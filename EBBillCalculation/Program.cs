using System;
using System.Collections.Generic;
namespace EBBillCalculation;
class Program 
{
    public static void Main(string[] args)
    {
        List<EBDetail> ebList = new List<EBDetail>();
        int n;
        do
        {
            Console.WriteLine("##### PRESS #####\n1.Registration\n2.Login\n3.Exit");
            n = int.Parse(Console.ReadLine());
            
            switch(n)
            {
                case 1:
                {
                    Console.WriteLine("Registration Form");
                    Console.Write("Enter Your User Name : ");
                    string userName = Console.ReadLine();
                    Console.Write("Enter Your Phone Number : ");
                    long phone = long.Parse(Console.ReadLine());
                    Console.Write("Enter your Mail ID : ");
                    string mailID = Console.ReadLine();
                    Console.Write("Enter the Units : ");
                    int units = int.Parse(Console.ReadLine());

                    EBDetail ebInfo = new EBDetail(userName, phone, mailID, units);
                    Console.WriteLine("You have registered succesfully");
                    Console.WriteLine("Your Meter ID : " + ebInfo.EbId);
                    ebList.Add(ebInfo);

                    break;
                }

                 case 2:
                 {
                    Console.WriteLine("##### LOGIN #####");
                    Console.Write("Enter Your Meter ID : ");
                    string userID = Console.ReadLine();
                    bool flag = true;

                    foreach(EBDetail i in ebList)
                    {
                        if(i.EbId == userID)
                        {
                            Console.WriteLine($"WELCOME {i.UserName}!!");
                            Console.WriteLine("##### PRESS #####\n1.Calculate Amount\n2.User Details\n3.Exit");
                            int input = int.Parse(Console.ReadLine());
                            switch(input)
                            {
                                case 1:
                                {
                                    Console.WriteLine("##### EB AMOUNT #####");
                                    Console.WriteLine($"Meter ID : {i.EbId}");
                                    Console.WriteLine($"User Name : {i.UserName}");
                                    Console.WriteLine($"Unit : {i.Units}");
                                    Console.WriteLine($"Amount : {EbBill(i.Units)}");
                                    break;
                                }

                                case 2:
                                {
                                    Console.WriteLine("##### USER DETAIL #####");
                                    Console.WriteLine($"Meter ID : {i.EbId}");
                                    Console.WriteLine($"User Name : {i.UserName}");
                                    Console.WriteLine($"Phone Number : {i.Phone}");
                                    Console.WriteLine($"Mail ID : {i.MailId}");
                                    break;
                                }

                                case 3:
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

                    if(flag)
                    {
                        Console.WriteLine("Invalid Meter ID");
                        break;
                    }
                    break;
                 }

                 case 3:
                 {
                    break;
                 }


            }
            
        } while (n!=3);
    }

    public static int EbBill(int a)
    {
        return a*5;
    }
}