using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMedicalStore
{
    public class UserDetail : PersonalDetails,IWallet
    {
        /*
        1.	UserID (Auto Increment – UID1001)
        2.	WalletBalance
            Methods:
        1.	Wallet Recharge
        2.	Deduct Balance
        */

        //Field
        private static int s_userID = 1000;
        private double _balance;

        //Property
        public string UserID { get;  }//ReadOnly Property
        public double WalletBalance{get{return _balance;}}//ReadOnly Property

        //Constructors
        public UserDetail(string name, int age, string city, string phoneNumber,double walletBalance):base(name, age, city, phoneNumber)
        {
            s_userID++;
            UserID = "UID"+s_userID;
            _balance = walletBalance;
        }

        //Method
        public void WalletRecharge(double amount)
        {
            _balance =  _balance + amount;
        }

        public void DeductBalance(double amount)
        {
            _balance =  _balance - amount;
        }
    }
}