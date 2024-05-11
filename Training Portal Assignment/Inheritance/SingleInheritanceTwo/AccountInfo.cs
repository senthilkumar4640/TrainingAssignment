using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SingleInheritanceTwo
{
    public class AccountInfo : PersonalInfo
    {
        /*
        Class AccountInfo : Inherit PersonalInfo
        Properties: AccountNumber, BranchName, IFSCCode, Balance
        Methods: ShowAccountInfo, Deposit , Withdraw, ShowBalance.
        */

        //Property
        public int AccountNumber { get; set; }
        public string BranchName { get; set; }
        public string IFSCCode { get; set; }
        public double Balance { get; set; }

        public AccountInfo(string name, string fatherName, long phone, string mailID, string dob, Gender gender, int accountNumber, string branchName, string  iFSCCode, double balance) : base (name, fatherName, phone, mailID, dob, gender)
        {
            AccountNumber = accountNumber;
            BranchName = branchName;
            IFSCCode = iFSCCode;
            Balance = balance;
        }

        public void ShowAccountInfo()
        {
            Console.WriteLine("| Name | FatherName | Phone | MailID | DOB | Gender | AccountNumber | BranchName | IFSCCode | Balance |");
            Console.WriteLine($"| {Name} | {FatherName} | {Phone} | {MailID} | {DOB} | {Gender} | {AccountNumber} | {BranchName} | {IFSCCode} | {Balance} |");
        }

        public void Deposit(double Amount)
        {
            Balance = Balance + Amount;
            Console.WriteLine($"Deposited Amount : {Amount}");
            Console.WriteLine($"Your Balance is : {Balance}");
        }

        public void Withdraw(double Amount)
        {
            if(Balance >= Amount)
            {
                Balance = Math.Abs(Amount-Balance);
                Console.WriteLine($"Withdrawl Amount : {Amount}");
                Console.WriteLine($"Your Balance is : {Balance}");
            }
            else
            {
                Console.WriteLine("Insufficient Balance");
            }
        }

        public void ShowBalance()
        {
            Console.WriteLine($"Your Balance is : {Math.Abs(Balance)}");
        }
    }

}
