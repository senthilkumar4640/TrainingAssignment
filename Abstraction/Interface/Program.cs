using System;
namespace Interface;
class Program 
{
    public static void Main(string[] args)
    {
        Square number1 = new Square(); //class variable as object
        number1.number=20;
        Console.WriteLine(number1.Calculate());

        Circle number2 = new Circle();
        number2.number=20;
        Console.WriteLine(number2.Calculate());
    }
}