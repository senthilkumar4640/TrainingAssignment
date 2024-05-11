using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VirtualFunctionsOne
{
    public class AreaCalculator
    {
        //Property
        public double Radius { get; set; }
        //Constrcutor
        public AreaCalculator(double radius)
        {
            Radius = radius;
        }
        //Virtual Method
        double result;
        public virtual void Calculate(double radius)
        {
            result = Math.PI * radius * radius;
        }

        public virtual void Display()
        {
            Console.WriteLine($"Area = {result}");
        }
    }
}