using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractClassesAndMethods
{
    public abstract class Employee //abstract classes
    {
        //Abstract class - partial abstration.
        //It has fields, property, method, constructor, destructors, indexers, events.
        //can have both abstract declaration and normal definitions
        //can only use with an inherited class
        //Not support muliple inheritance
        //it cannot be static class

        //Normal Field
        protected string _name; //protected achieved by inheritance

        //Abstract Property
        public abstract string Name { get; set; }

        //Normal Property
        public double Amount { get; set; }

        //Normal Method
        public string Display()
        {
            return _name;
        }

        //Abstract Method
        public abstract double Salary(int dates); //Only Declaration
    }
}