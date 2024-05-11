using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineGroceryStore
{
    public class CustomerRegistration : PersonalDetails,IBalance
    {
        /*
        Properties: CustomerID {Auto Increment – CID1000}, WalletBalance
        Methods: WalletRecharge
        */
        //Field
        private static int s_customerID = 1000;
        private double _balance;

        //Property
        public string CustomerID { get; }//ReadOnly Property
        public double WalletBalance{get{return _balance;}}
        

        //Constructors
        public CustomerRegistration(double walletBalance, string name, string fatherName, Gender gender, string mobile, DateTime dob, string mailID):base( name, fatherName, gender, mobile, dob, mailID)
        {
            s_customerID++;
            CustomerID = "SF"+s_customerID;
            _balance = walletBalance;
        }

        //Method
        public double WalletRecharge(double amount)
        {
            _balance = _balance+amount;
            return _balance;
        }

    }
}