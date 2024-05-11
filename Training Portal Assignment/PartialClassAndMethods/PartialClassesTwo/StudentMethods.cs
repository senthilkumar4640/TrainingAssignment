using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartialClassesTwo
{
    public partial class StudentInfo
    {
        //Methods
        public void Calculate()
        {
            int Total = Physics+Chemistry+Maths;
            double Percentage = Total/3;
            Console.WriteLine($"Your Total Mark is : {Total}");
            Console.WriteLine($"Your Percentaga is : {Percentage}");
        }
    }
}