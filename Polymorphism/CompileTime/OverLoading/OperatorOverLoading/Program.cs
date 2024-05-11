using System;
using System.ComponentModel;
namespace OperatorOverLoading;
class Program
{
    public static void Main(string[] args)
    {
        Box box1 = new Box(1.2,2.3,3.4);
        Box box2 = new Box(12.3,23.4,34.5);

        Console.WriteLine(box1.CalculateVolume());
        Console.WriteLine(box1.CalculateVolume());

        Box box3 = Box.Add(box1,box2);

        Box box4 = box1 + box2;

        int c = 1+2;
    }
}