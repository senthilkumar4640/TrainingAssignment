using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QwickFoodz
{
    public interface IBalance
    {
        /*
        Properties: WalletBalance
        Method: WalletRecharge, DeductBalance
        */

        //Property
        double WalletBalance { get; }//ReadOnly Property

        //Method
        void WalletRecharge(double amount);
        void DeductBalance(double amount);
    }
}