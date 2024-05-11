using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineGroceryStore
{
    public interface IBalance
    {
        // Properties: WalletBalance
        double WalletBalance {get;}

        // Method: WalletRecharge
        double WalletRecharge(double amount);

    }
}