using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractOne
{
    public class Cubes : Shape
    {
        public override double Area{get; set;}
        public override double Volume{get; set;}
        public Cubes(double width):base(width)
        {

        }
        public override double CalculateArea()
        {
            Area = 6* Width * Width;
            return Area;
        }

        public override double CalculateVolume()
        {
            Volume = Width* Width * Width;
            return Volume;
        }


    }
}