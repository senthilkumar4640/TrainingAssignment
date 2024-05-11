using System;
namespace Inside;
class Program 
{
    public static void Main(string[] args)
    {
        First first = new First();
        Console.WriteLine(first.PrivateOut);
        Console.WriteLine(first.PublicNumber);

        Second second = new Second();
        Console.WriteLine(second.PrivateOut);
        Console.WriteLine(second.ProtectedNumberOut);
        Console.WriteLine(second.InternalProtected);
        Console.WriteLine(first.ProtectedInternalOut);
    }
}