using System;
namespace ValueAndReferenceType;
class Program
{
    public static void Main(string[] args)
    {
        int number1 = 10;
        Console.WriteLine(number1);

        int number2 = number1;
        Console.WriteLine(number2);

        number1 = 20;

        Console.WriteLine(number2);

        StudentDetails sample = new StudentDetails();
        sample.name = "Senthil";
        Console.WriteLine(sample.name);

        StudentDetails sample1 = sample;
        sample1.name = "Kumar";
        Console.WriteLine(sample.name);
        Console.WriteLine(sample1.name);
    }
}