using System;
namespace InterfaceOne;
class Program 
{
    public static void Main(string[] args)
    {
        Dog dog1 = new Dog("Bubly", "House","Omnivore");
        Dog dog2 = new Dog("Bubly", "Garden","Carnivore");
        Duck duck1 = new Duck("Donald","Pond","Herbivore");
        Duck duck2 = new Duck("Donald","Pond","Herbivore");
        dog1.DisplayName();
        dog1.DisplayInfo();
        dog2.DisplayName();
        dog2.DisplayInfo();
        duck1.DisplayName();
        duck1.DisplayInfo();
        duck2.DisplayName();
        duck2.DisplayInfo();
      
    }
}