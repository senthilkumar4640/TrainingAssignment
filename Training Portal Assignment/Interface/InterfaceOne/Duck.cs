using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceOne
{
    public class Duck
    {
        
        //Property
        public string Name { get; set; }
        public string Habitat { get; set; }
        public string EatingHabit { get; set; }

        //Constructor
        public Duck(string name, string habitat, string eatingHabit)
        {
            Name = name;
            Habitat = habitat;
            EatingHabit = eatingHabit;
        }

        //method
        public void DisplayName()
        {
            Console.WriteLine($"Duck name: {Name}");
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Duck Info..\nDuck name: {Name}\nHabitat: {Habitat}\nEating Habit: {EatingHabit}");
        }
    }
}