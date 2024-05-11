using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMedicalStore
{
    public interface IWallet
    {
        /*
        Properties:
        a)	WalletBalance

        Methods:
        a)	Wallet Recharge
        b)	Deduct Balance
        */

        //Property
        double WalletBalance{get;}

        //Method
        void WalletRecharge(double amount);
        void DeductBalance(double amount);

    }
}