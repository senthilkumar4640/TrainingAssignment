using System;
namespace ByType;
class Program 
{
    public static void Main(string[] args)
    {
        Console.WriteLine(Add(1,2));
        Console.WriteLine(Add(5.7,2));
        Console.WriteLine(Add("1","2"));



    }

    public static int Add(int a, int b)
    {
        return a+b;
    }

    public static string Add(string a, string b)
    {
        return a+b;
    }

    public static double Add(double a, double b)
    {
        return a+b;
    }
}