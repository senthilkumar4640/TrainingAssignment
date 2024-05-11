using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HierarchicalInheritanceTwo
{
    public class SalaryInfo
    {
        /*
        Class SalaryInfo
        Properties: BasicSalary, Month
        */

        public double BasicSalary { get; set; }
        public int Month { get; set; }

        public SalaryInfo(double basicSalary, int month)
        {
            BasicSalary = basicSalary;
            Month = month;
        }
    }
}