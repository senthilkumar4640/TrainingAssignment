using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculatorApp
{
    public class CircleArea : Math
    {
        protected double radius;
        public double Radius {get{return radius;} set{radius=value;}}
        internal double Area {get{return PI*radius*radius;}}
        public double CalculateCircleArea(double radius)
        {
            this.radius = radius;
            return Area;
        }
        
    }
}