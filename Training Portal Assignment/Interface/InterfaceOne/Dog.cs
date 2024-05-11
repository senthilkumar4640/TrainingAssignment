using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceOne
{
    public class Dog : IAnimal
    {
        //Property
        public string Name { get; set; }
        public string Habitat { get; set; }
        public string EatingHabit { get; set; }

        //Constructor
        public Dog(string name, string habitat, string eatingHabit)
        {
            Name = name;
            Habitat = habitat;
            EatingHabit = eatingHabit;
        }

        //method
        public void DisplayName()
        {
            Console.WriteLine($"Dog name: {Name}");
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Dog Info..\nDog name: {Name}\nHabitat: {Habitat}\nEating Habit: {EatingHabit}");
        }
    }
}