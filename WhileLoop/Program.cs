using System;
namespace WhileLoop;
class Program
{
    public static void Main(string[] args)
    {
        //Exercise 1
        int i = 0;
        while(i<=50)
        {
            if(i%2==0 & i/5==0)
            {
                Console.WriteLine(i);

            }
            i++;

        }

        //Exercise 2 //bool temp1 = int.TryParse(Console.ReadLine(),out a)
        Console.WriteLine("Enter a valid number : ");
        bool isValid = int.TryParse(Console.ReadLine(), out int output);
        while(!isValid)
        {
            Console.WriteLine("Invalid number, enter again : ");
            isValid = int.TryParse(Console.ReadLine(), out output);
        }
    }
}