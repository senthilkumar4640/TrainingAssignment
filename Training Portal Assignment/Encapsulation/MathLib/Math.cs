using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MathLib
{
    public class Math
    {
        protected internal double PI = 3.14;
        internal double m = 9.8;
        public double CalculateWeight(double mass)
        {
            return mass*m;
        }
        
    }
}