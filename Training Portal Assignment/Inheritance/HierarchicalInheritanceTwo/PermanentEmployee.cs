using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Threading.Tasks;

namespace HierarchicalInheritanceTwo
{
    public class PermanentEmployee : SalaryInfo
    {
        /*
        Class PermanentEmployee: inherit SalaryInfo
        Properties: EmployeeID, Employee Type, DA=0.2% of basic, HRA= 0.18% of basic, 
        PF – 0.1 % basic, Total Salary
        Method: Calculate TotalSalary – Basic +DA+HRA-PF, ShowSalary
        */

        //Field
        private static int s_employeeID = 1000;
        public string EmployeeID { get; }
        public string EmployeeType { get; set; }
        public double DA { get; set; }
        public double HRA { get; set; }
        public double PF { get; set; }
        public double TotalSalary { get; set; }
        
        public PermanentEmployee(double basicSalary, int month, string employeeType) : base(basicSalary,month)
        {
            s_employeeID++;
            EmployeeID = "EID" + s_employeeID;
            EmployeeType = employeeType;
        }

        public void ShowSalary1()
        {
            //DA=0.2% of basic, HRA= 0.18% of basic, PF – 0.1 % basic

            DA = BasicSalary * 0.002;
            HRA = BasicSalary * 0.0018;
            PF = BasicSalary * 0.001;

            TotalSalary = BasicSalary + DA + HRA - PF;
            // double salary = Math.Round(TotalSalary, 3);
            
            Console.WriteLine($"Your Salary is : {TotalSalary} - Permanent.");
        
        }
    }
}