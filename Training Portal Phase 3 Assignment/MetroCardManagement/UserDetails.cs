using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetroCardManagement
{
    public class UserDetails : PersonalDetails, IBalance
    {
        /*
        Properties:
        •	CardNumber(Auto generation- CMRL1001)
        •	Balance
        Methods:
        •	WalletRecharge
        •	DeductBalance
        */

        //Field
        private static int s_cardNumber = 1000;
        private double _balance;


        //Property
        public string CardNumber { get; }//ReadOnly Property
        public double Balance { get{return _balance;} set{}}

        //Constructors
        public UserDetails(string userName, long phoneNumber, double Balance) : base ( userName, phoneNumber)
        {
            s_cardNumber++;
            CardNumber = "CMRL" + s_cardNumber;
            _balance = Balance;
        }

        public UserDetails(string user)
        {
            string[] values = user.Split(",");
            CardNumber = values[0];
            s_cardNumber = int.Parse(values[0].Remove(0,4));
            UserName = values[1];
            PhoneNumber = long.Parse(values[2]);
            Balance = double.Parse(values[3]);

        }

        //Methods
        public double  WalletRecharge(double amount)
        {
            if(amount>0)
            {
                _balance = _balance+amount;
                return Balance;
            }
            else
            {
                Console.WriteLine("Enter the valid amount..");
                return 0;
            }
        }

        public double DeductBalance(double amount)
        {
            if(amount<=_balance)
            {
                _balance = _balance-amount;
                return Math.Abs(Balance);
            }
            return 0;

        }



    }
}