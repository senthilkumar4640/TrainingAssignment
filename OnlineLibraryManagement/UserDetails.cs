using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineLibraryManagement
{
    public enum Gender {Select, Male, Female, Transgender}

    public enum Department {Select, ECE, EEE, CSE}

    public class UserDetails
    {
        /*
        a.	UserID (Auto Increment – SF3000)
        b.	UserName
        c.	Gender
        d.	Department – (Enum – ECE, EEE, CSE)
        e.	MobileNumber
        f.	MailID
        g.	WalletBalance

        */

        //Field
        //Static Field
        private static int s_userID = 3000;

        //Properties
        public string UserID { get; }//Read Only Property

        public string UserName { get; set; }

        public Gender Gender { get; set; }

        public Department Department { get; set; }

        public long MobileNumber { get; set; }

        public string MailID { get; set; }

        public double WalletBalance { get; set; }

        //Constructors
        public UserDetails(string userName, Gender gender, Department department, long mobileNumber, string mailID, double walletBalance)
        {
            //AutoIncrementation
            s_userID++;

            //Assigning
            UserID = "SF" + s_userID;
            UserName = userName;
            Gender = gender;
            Department = department;
            MobileNumber = mobileNumber;
            MailID = mailID;
            WalletBalance = walletBalance;

        }//Constructor Ends

        
        //Wallet Recharge Method
        public double WalletRecharges(double amount)
        {
            
            double total  = WalletBalance + amount;
            return total;
       
        }//Wallet Recharge Method Ends


        //Deduct Balance Method
        public double deductBalance(double amount)
        {
            double total  = WalletBalance - amount;
            return total;
        }//Deduct Balance Method Ends

    }
}