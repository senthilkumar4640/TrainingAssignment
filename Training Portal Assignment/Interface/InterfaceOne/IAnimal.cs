using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceOne
{
    public interface IAnimal
    {
        //Property
        string Name {get; set;}
        string Habitat {get; set;}
        string EatingHabit {get; set;}
        //method
        void DisplayName();
    }
}