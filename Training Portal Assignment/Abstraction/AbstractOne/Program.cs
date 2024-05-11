using System;
namespace AbstractOne;
class Program 
{
    public static void Main(string[] args)
    {
        Cylinders cylinder = new Cylinders(7,39);
        Console.WriteLine($"Area of calculator {cylinder.CalculateArea()}");
        Console.WriteLine($"Volume of calculator {cylinder.CalculateVolume()}");

        Cubes cube = new Cubes(10);
        Console.WriteLine($"Area of cube {cube.CalculateArea()}");
        Console.WriteLine($"Volume of cube {cube.CalculateVolume()}");

    }
}