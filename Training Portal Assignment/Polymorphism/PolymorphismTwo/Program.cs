using System;
namespace PolymorphismTwo;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(MultiplyMethod(5));
        Console.WriteLine(MultiplyMethod(5.444444887778888));
        Console.WriteLine(MultiplyMethod(5.9));
        Console.WriteLine(MultiplyMethod(589876543456));

    }
    //Method 1
    public static int MultiplyMethod(int n)
    {
        return n * n;
    }

    //Method 2
    public static double MultiplyMethod(double n)
    {
        return n * n;
    }

    //Method 3
    public static float MultiplyMethod(float n)
    {
        return n * n;
    }

    //Method 1
    public static long MultiplyMethod(long n)
    {
        return n * n;
    }
}
