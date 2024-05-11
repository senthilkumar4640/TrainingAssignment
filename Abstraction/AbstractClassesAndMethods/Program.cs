using System;
namespace AbstractClassesAndMethods;
class Program 
{
    public static void Main(string[] args)
    {
        //Employee job1 = new Syncfusion();//object creation for abstract class using inherited class
        Syncfusion job1 = new Syncfusion();
        job1.Name = "Senthil";
        Console.WriteLine(job1.Display());
        Console.WriteLine(job1.Salary(30));

        Employee job2 = new Zoho();
        job2.Name = "Kumar";
        Console.WriteLine(job2.Display());
        Console.WriteLine(job2.Salary(30));
    }
}
