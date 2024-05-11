using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QwickFoodz
{
    public class CustomerDetails : PersonalDetails, IBalance
    {
        /*
        Field: _balance
        Properties: CustomerID, WalletBalance
        Methods: WalletRecharge, DeductBalance
        */

        //Field
        private double _balance;
        private static int s_customerID = 1000;

        //Property
        public string CustomerID { get; }//ReadOnly Property
        public double WalletBalance { get { return _balance; } }

        //Constructors
        public CustomerDetails(double WalletBalance, string name, string fatherName, Gender gender, string mobile, DateTime dob, string mailID, string location) : base(name, fatherName, gender, mobile, dob, mailID, location)
        {
            s_customerID++;
            CustomerID = "CID" + s_customerID;
            _balance = WalletBalance;
        }

        //Methods
        public void WalletRecharge(double amount)
        {
            _balance = _balance + amount;
        }

        public void DeductBalance(double amount)
        {
            _balance = _balance - amount;
        }

    }
}