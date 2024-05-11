using System;
using System.ComponentModel.DataAnnotations;
namespace VirtualFunctionsOne;
class Program 
{
    public static void Main(string[] args)
    {
        //Creating Object for AreaCalculator
        AreaCalculator area = new AreaCalculator(20);
        
         //Creating Object for VolumeCalculator
         VolumeCalculator volume = new VolumeCalculator(area.Radius,50);

         //Method Calling
        area.Calculate(area.Radius);
        volume.Calculate(volume.Height);
        //Displaying
        area.Display();
        volume.Display();

    }
}