using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HierarchicalInheritanceTwo
{
    public class TemporaryEmployee : SalaryInfo
    {
        /*
        Class TemporaryEmployee: inherit SalaryInfo
        Properties: EmployeeID, Employee Type, DA=0.15% of basic,
        HRA= 0.13% of basic, Total Salary
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
        
        public TemporaryEmployee(double basicSalary, int month, string employeeType) : base(basicSalary,month)
        {
            s_employeeID++;
            EmployeeID = "TID" + s_employeeID;
            EmployeeType = employeeType;
        }

        public void ShowSalary2()
        {
            //DA=0.15% of basic, HRA= 0.13% of basic
       

            DA = BasicSalary * 0.0015;
            HRA = BasicSalary * 0.0013;
            PF = BasicSalary * 0.001;

            TotalSalary = BasicSalary + DA + HRA - PF;
            // double salary = Math.Round(TotalSalary, 3);

            Console.WriteLine($"Your Salary is : {TotalSalary} - Temporary.");
        
        }
    }
}