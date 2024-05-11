using System;
using System.Xml.XPath;
namespace Dowhile;
class Program
{
    public static void Main(string[] args)
    {
        string result;
        do
        {

        Console.Write("Enter the number : ");
        int num = int.Parse(Console.ReadLine());

        if(num % 2 == 0)
        {
            Console.WriteLine("Even");
        }
        else
        {
            Console.WriteLine("Odd");
        }
            
        Console.Write("You need to check another number? - yes/no : ");
        result = Console.ReadLine();

        while(result != "yes" && result !="no"){
   
            Console.Write("Your input is wrong and type a valid input. - yes/no : ");
            result = Console.ReadLine();

        }

        }while(result=="yes");
    }
}