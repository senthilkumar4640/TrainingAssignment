using System;
namespace StringManipulation;
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the Main String : ");
        string mainString = Console.ReadLine();
        Console.Write("Enter the Sub String : ");
        string subString = Console.ReadLine();
        string[] res= mainString.Split(subString);
        int count = res.Length-1;
        Console.WriteLine(count);
    }
}
