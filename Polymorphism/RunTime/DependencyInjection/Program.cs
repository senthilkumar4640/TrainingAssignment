using System;
using System.Collections.Generic;
namespace DependencyInjection;
class Program
{
    public static void Main(string[] args)
    {
        CCAccount ccAccount =  new CCAccount();
        ccAccount.AccountNumber = 123;
        ccAccount.Name = "Senthil";
        ccAccount.Balance = 100000000;

        SBAccount sBAccount = new SBAccount();
        sBAccount.AccountNumber = 123;
        sBAccount.Name = "Kumar";
        sBAccount.Balance = 100000000;

        // List<CCAccount> ccList = new List<CCAccount>();
        // ccList.Add(ccAccount);
        // List<SBAccount> sbList = new List<SBAccount>();
        // sbList.Add(sBAccount);

        //storing two class value in one class
        List<IAccount> accountList = new List<IAccount>();
        accountList.Add(sBAccount);
        accountList.Add(ccAccount);
    }
}