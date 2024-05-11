using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculatorApp
{
    public class CylinderVolume : CircleArea
    {
        private double height;
        public double Height {get{return height;} set{height = value;}}
        internal double Volume{get{return Area*height;}}
        public double calculateVolume(double radius, double height)
        {
            this.radius = radius;
            this.height = height;
            return Volume;
        }
    }
}