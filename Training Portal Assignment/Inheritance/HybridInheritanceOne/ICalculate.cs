using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HybridInheritanceOne
{
    public interface ICalculate
    {
        //Property
        int ProjectMark {get; set;}

        //Method
        void CalculateUGTotal();
        void CalculateUGPercentage();
    }
}