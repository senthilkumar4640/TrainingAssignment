using System;
namespace ReadAndWrite;
class Program
{
    public static void Main(string[] args)
    {
        //Getting the inputs

        Console.Write("Enter your name : ");
        string name = Console.ReadLine();
        Console.Write("Enter your father name : ");
        string fatherName = Console.ReadLine();

        //Printing the results

        //Concatenation
        Console.WriteLine(name +" "+fatherName);

        //Placeholder
        Console.WriteLine("{0} {1}", name,fatherName);

        //Interpolation - Less runtime
        Console.WriteLine($"{name} {fatherName}");

        //Read - to store the ascii valiue of any character or number
        int name1 = Console.Read();

        //Readkey - wait in console , press any input to close
        Console.ReadKey();
    }
}