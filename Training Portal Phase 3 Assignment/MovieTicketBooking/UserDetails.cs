using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Threading.Tasks;

/// <summary>
/// Namespace which contains Movie Ticket Booking Application
/// </summary>
namespace MovieTicketBooking
{
    /// <summary>
    /// Class <see cref="UserDetails"/> contains details of user which inherits <see cref="PersonalDetails"/> class and <see cref="IWallet"/> interface
    /// </summary>
    public class UserDetails : PersonalDetails,IWallet
    {
        /// <summary>
        /// Private static int field which is auto incremented
        /// <see cref="UserDetails"/> class's object
        /// For further information refer <see href="www.syncfusion.com"> Syncfusion </see>
        /// </summary>
        private static int s_userID = 1001;

        /// <summary>
        /// private string field used to store user ID
        /// </summary>
        private string _userID;
        public string UserID { get{return _userID;} }

        /// <summary>
        /// private double field used to store wallet balance
        /// </summary>
        private double _walletBalance;
        public double WalletBalance { get{return _walletBalance;} }

        /// <summary>
        /// Constructor of the Class <see cref="UserDetails"/> used to assign value to properties
        /// </summary>
        /// <param name="walletBalance">Parameter walletBalance used to assign value to its property</param>
        /// <param name="name">Parameter name used to assign value to its property</param>
        /// <param name="age">Parameter age used to assign value to its property</param>
        /// <param name="phoneNumber">Parameter phoneNumber used to assign value to its property</param>
        public UserDetails(double walletBalance,string name,int age,long phoneNumber)
        :base(name,age,phoneNumber)
        {
            _userID = "UID"+s_userID++;
            _walletBalance = walletBalance;
        }

        public UserDetails(string user)
        {
            string[] values = user.Split(",");
            _userID = values[0];
            s_userID = int.Parse(values[0].Remove(0,3));
            Name = values[1];
            Age = int.Parse(values[2]);
            PhoneNumber = long.Parse(values[3]);
            _walletBalance = double.Parse(values[4]);
        }

    

        /// <summary>
        /// Method WalletRecharge used to recharge the wallet of the user
        /// </summary>
        /// <param name="amount">It requires double value as parameter</param>
        public void WalletRecharge(double amount)
        {
            _walletBalance+=amount;
        }
        
        /// <summary>
        /// Method DeductBalance used to deduct balance from the wallet of the user
        /// </summary>
        /// <param name="amount">It requires double value as parameter</param>
        public void DeductBalance(double amount)
        {
            _walletBalance-=amount;
        }
    }
}