using System;
namespace ArrayList;
class Program 
{
    public static void Main(string[] args)
    {
        //Creating list for CustomList
         CustomList<int> numberList = new CustomList<int>();
         numberList.Add(10);
         numberList.Add(20);
         numberList.Add(30);
         numberList.Add(40);
         numberList.Add(50);

        //Creating a another list
         CustomList<int> numbers = new CustomList<int>();
         numbers.Add(60);
         numbers.Add(70);

         //Adding list to the another list
         numberList.AddRange(numbers);

         //displaying a list using for loop
         for(int i=0; i<numberList.Count;i++)
         {
            Console.WriteLine(numberList[i]);
         }

         Console.WriteLine("-------");

         //Contains method checking
         bool result = numberList.Contains(20);
         Console.WriteLine(result);

         Console.WriteLine("-------");

         //IndexOf method checking
         int position = numberList.IndexOf(30);
         Console.WriteLine(position);

         Console.WriteLine("-------");

         //Insert method calling
         numberList.Insert(1,100);
         for(int i=0; i<numberList.Count;i++)
         {
            Console.WriteLine(numberList[i]);
         }

         Console.WriteLine("-------");

         //RemoveAt method calling
         numberList.RemoveAt(1);
         for(int i=0; i<numberList.Count;i++)
         {
            Console.WriteLine(numberList[i]);
         }

         Console.WriteLine("--------");

         //Remove Method calling
         bool temp = numberList.Remove(50);
         Console.WriteLine(temp);
      

         Console.WriteLine("--------");

         

    }
}