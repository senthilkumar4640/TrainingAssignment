using System;
namespace BubbleSort;
class Program 
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the number as comma seperated: ");
        string input = Console.ReadLine();
        string[] inputArray = input.Split(',');
        int[] array = new int[inputArray.Length];
        for(int i=0;i<inputArray.Length;i++)
        {
            array[i] = int.Parse(inputArray[i]);
        }
        //Bubble Sort
        for(int i=0;i<array.Length-1;i++)
        {
            for(int j=0;j<array.Length-(i+1);j++)
            {
                if(array[j]>array[j+1])
                {
                    int temp = array[j];
                    array[j] = array[j+1];
                    array[j+1] = temp;

                }
            }
        }
        

        foreach(int i in array)
        {
            Console.Write(i + " ");
        }
    }
}