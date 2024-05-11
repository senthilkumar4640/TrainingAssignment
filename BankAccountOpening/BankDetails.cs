using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace BankAccountOpening
{
    /// <summary>
    /// DataType Gender used to select a instance of <see cref="BankDetails"/> Gender Information 
    /// </summary>
    public enum Gender { Select, Male, Female, Transgender }

    /// <summary>
    /// Class BankDetails used to create instance for bank <see cref="BankDetails"/>
    /// Refer documentation on <see href="www.syncfusion.com"/>
    /// </summary>
    public class BankDetails
    {
        /// <summary>
        /// Static Field s_customerID used to autoincrement CustomerID of the instance of <see cref="BankDetails"/>
        /// </summary>
        private static int s_customerID = 1000;

        /// <summary>
        ///  CustomerName property used to hold a Customer's Name of instance of <see cref="BankDetails"/>
        /// </summary>
        public string CustomerName { get; set; }
        /// <summary>
        /// CustomerID property used to hold a Customer's ID of instance of <see cref="BankDetails"/>
        /// </summary> 

        public string CustomerID { get; }//ReadOnly Property

        public int Balance { get; set; }

        public Gender Gender { get; set; }

        public long Phone { get; set; }

        public string MailID { get; set; }

        public DateTime DOB { get; set; }
        /// <summary>
        /// Constructor BankDetails used to initialize default values to it's property
        /// </summary> 
        public BankDetails()
        {

        }
        /// <summary>
        /// Constructor BankDetails used to initialize parameter values to it's property
        /// </summary>
        /// <param name="customerName">customerName parameter used to assign its value to associated property</param>
        /// <param name="balance">balance parameter used to assign its value to associated property</param>
        /// <param name="gender">gender parameter used to assign its value to associated property</param>
        /// <param name="phone">phone parameter used to assign its value to associated property</param>
        /// <param name="mailID">mailID parameter used to assign its value to associated property</param>
        /// <param name="dob">dob parameter used to assign its value to associated property</param>
        public BankDetails(string customerName, int balance, Gender gender, long phone, string mailID, DateTime dob)
        {
            s_customerID++;

            CustomerID = "HDFC" + s_customerID;
            CustomerName = customerName;
            Balance = balance;
            Gender = gender;
            Phone = phone;
            MailID = mailID;
            DOB = dob;

        }

    }

      ///<summary>
    /// Method is used to add the amount to the bank account <see cref="BankDetails"/>
    ///</summary>
    /// <param name="balAmount">It is the bank balance</param>
    /// <param name="depAmount">It is the deposited amount</param>
    /// <returns>It returns the deposited amount</returns>
    /// 
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