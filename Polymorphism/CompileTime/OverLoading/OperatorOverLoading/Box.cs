using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OperatorOverLoading
{
    public class Box
    {
        //Field
        private double _length;
        private double _breadth;
        private double _height;

        //Constructors
        public Box(double length, double breadth, double height)
        {
            _length = length;
            _breadth = breadth;
            _height = height;
        }

        //Method
        public double CalculateVolume()
        {
            return _length*_breadth*_height;
        }

        public static Box Add(Box box1, Box box2)
        {
            Box box = new Box(0,0,0);
            box._length = box1._length + box2._length;
            box._breadth = box1._breadth + box2._breadth;
            box._height = box1._height + box2._height;

            return box;
        }

        public static Box operator+(Box box1, Box box2)
        {
            Box box = new Box(0,0,0);
            box._length = box1._length + box2._length;
            box._breadth = box1._breadth + box2._breadth;
            box._height = box1._height + box2._height;

            return box;
        }
    }
}