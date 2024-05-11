using System;
using System.ComponentModel.DataAnnotations;
namespace CalculatorApp;
class Program 
{
    public static void Main(string[] args)
    {
        CylinderVolume cylinder = new CylinderVolume();
        cylinder.Radius=7;
        cylinder.Height=20;
        double volume = cylinder.calculateVolume(cylinder.Radius,cylinder.Height);
        Console.WriteLine("Cylinder volume "+volume);
        CircleArea circle = new CircleArea();
        double mass = 5;
        Console.WriteLine("Weight "+cylinder.CalculateCircleArea(mass));
        double area = circle.CalculateCircleArea(cylinder.Radius);
        Console.WriteLine("Circle Area "+area);
        Console.WriteLine("Value of area volume "+cylinder.Area);
    }
}