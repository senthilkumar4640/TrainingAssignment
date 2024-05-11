using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interface
{
    public interface IBalance
    {
        //property
        double WalletBalance{get; set;}

        //method
        double WalletRecharge();
    }
}