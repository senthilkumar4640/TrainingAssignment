using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interface
{
    public interface ICalculate
    {
        //Fully abstraction - no definition
        //No fields and constructor

        //Property
        int number {get; set;}//declaration only, no specifier
        //method
        int Calculate();//Method - Declaration only, no definition


    }
}