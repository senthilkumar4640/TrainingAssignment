using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetroCardManagement
{
    public interface IBalance
    {
        /*
        Properties:
        •	Balance
        Methods:
        •	WalletRecharge
        •	DeductBalance
        */

        //Property
        double Balance { get; }//ReadOnly Property

        //Method
        double WalletRecharge(double amount);

        double DeductBalance(double amount);
    }
}