using System;
namespace TypeConversion;
class Program
{
    public static void Main(string[] args)

    {
        //Type Conversion String to Int(Parse Method)

        // Console.Write("Enter the number 1 : ");
        // int num1 = int.Parse(Console.ReadLine());
        // Console.Write("Enter the number 2 : ");
        // int num2 = int.Parse(Console.ReadLine());
        // Console.WriteLine($"{num1} + {num2} = {num1 + num2}");

        

        //Type Conversion String to Double.

        // Console.Write("Enter a double number : ");
        // double num3 = double.Parse(Console.ReadLine());
        // Console.WriteLine($"The double value is {num3}");


        //Convert Method
        Console.Write("Enter the number : ");
        int num4 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"The number is {num4}");










    }
}
