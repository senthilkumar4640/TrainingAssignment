using System;
namespace PartialClassesOne;
class Program
{
    public static void Main(string[] args)
    {
        //Creating Object for EmployeeInfo
        EmployeeInfo employee1 = new EmployeeInfo("SF1001", "Senthil", "Male","08/03/2002",8825816924);

        //Displaying
        employee1.Display();

        //Updateing Details
        employee1.Update("Bhuvana","Female","16/07/2002",8903089312);

        //Displaying
        employee1.Display();
    }
}