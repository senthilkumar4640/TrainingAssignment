using System;
namespace HierarchicalInheritanceTwo;
class Program 
{
    public static void Main(string[] args)
    {
        //Creating Object for SalaryInfo
        SalaryInfo salary = new SalaryInfo(21500,15);

        //Creating Object for Permanent employee
        PermanentEmployee perEmployee1 = new PermanentEmployee(salary.BasicSalary,salary.Month,"Permanent");

        //Creating Object for Temporary employee
        TemporaryEmployee temEmployee1 = new TemporaryEmployee(salary.BasicSalary,salary.Month,"Temporary");

        //Calling Methods
        perEmployee1.ShowSalary1();
        temEmployee1.ShowSalary2();
    }
}