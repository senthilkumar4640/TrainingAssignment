using System;
using System.IO;
using System.Runtime.CompilerServices;
namespace Array;
class Program
{
    public static void Main(string[] args)
    {
        //creating and initializing an array
        string[] arrayOne = new string[5];
        arrayOne[0]="Mani";
        arrayOne[1]="Ganesh";
        arrayOne[2]="Venkat";
        arrayOne[3]="Suresh";
        arrayOne[4]="Venkat";

        //printing the array using for loop
        for(int i=0; i<arrayOne.Length; i++)
        {
            Console.WriteLine(arrayOne[i]);
        }

        //checking the name in array using for loop
        bool isValue = true;
        Console.Write("Type the name to search in an Array : ");
        string arrayName1 = Console.ReadLine();
        for(int i=0; i<arrayOne.Length; i++)
        {
            if(arrayName1 == arrayOne[i])
            {
                isValue=false;
                Console.WriteLine("The name is present in array");
                Console.WriteLine($"The index of an name is {i}");

            }
        }
        if (isValue)
            {
                Console.WriteLine("The name is not present in array");
            }

        //checking the name in array using foreach loop]
        bool isTrue = true;
        Console.Write("Type the name to search in an Array : ");
        string arrayName2 = Console.ReadLine();
        foreach(string i in arrayOne)
        {
             if(arrayName2 == i)
            {
                isTrue=false;
                Console.WriteLine("The name is present in array");
            }

        }
        if(isTrue)
        {
            Console.WriteLine("The name is not present in array");
        }

    }
}