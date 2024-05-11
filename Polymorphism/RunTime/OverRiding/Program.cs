using System;
namespace OverRiding;
public class Animal
{
    public virtual void Eat()
    {
        Console.WriteLine("Animal eats food");
    }
}

public class Dog : Animal
{
    public override void Eat()
    {
        Console.WriteLine("Dog eats food");
        //base.Eat()
        //this.Eat()
    }
}

public class Pomerian : Dog
{
    public override void Eat()
    {
        Console.WriteLine("Pomerian eats food");
    }
}
class Program
{
    public static void Main(string[] args)
    {
        Animal animal = new Animal();
        animal.Eat();
        Dog dog = new Dog();
        dog.Eat();
        Pomerian pomerian = new Pomerian();
        pomerian.Eat();

    }
}