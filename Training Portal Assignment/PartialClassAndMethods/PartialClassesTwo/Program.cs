using System;
namespace PartialClassesTwo;
class Program 
{
    public static void Main(string[] args)
    {
        //Object Creating
        StudentInfo student1 = new StudentInfo("Sf1001","Senthil","Male","08/03/2002",8825816924,95,98,94);

        //Method Calling
        student1.Calculate();

    }
}