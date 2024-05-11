using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VirtualFunctionsOne
{
    public class VolumeCalculator : AreaCalculator
    {
        //Property
        public double Height { get; set; }
        //Constructors
        public VolumeCalculator(double radius,double height) : base(radius)
        {
            Height = height;
        }
        //Virtual Method
         double result;
        public override void Calculate(double height)
        {
             result = Math.PI * Radius * Radius *height;
        }

          public override void Display()
        {
            Console.WriteLine($"Volume = {result}");
        }
    }
}