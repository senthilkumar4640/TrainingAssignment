using System;
using System.Diagnostics;
namespace LinearSearch;
class Program 
{
    public static void Main(string[] args)
    {

        //Integer
        int[]intValues = {45,33,12,55,77,22,33,14,67,78,22,11,44,66,88,12,35,84,93,77};
        int intElement = 66;
        Array.Sort(intValues);
        Stopwatch intStopwatch = Stopwatch.StartNew();
        int intPosition = LinearSearch(intValues,intElement);
        intStopwatch.Stop();
        if(intPosition>-1)
        {
            Console.WriteLine($"Index of the {intElement} is {intPosition}. Time taken - {intStopwatch.ElapsedMilliseconds}ms.");
        }
        else
        {
            Console.WriteLine("Element not found");
        }


        //double
        double[]intValues1 = {1.1,65.3,93.9,55.5,3.5,6.9};
        double intElement1 = 3.5;
        Array.Sort(intValues1);
        Stopwatch intStopwatch1 = Stopwatch.StartNew();
        int intPosition1 = LinearSearch(intValues1,intElement1);
        intStopwatch.Stop();
        if(intPosition>-1)
        {
            Console.WriteLine($"Index of the {intElement1} is {intPosition1}. Time taken - {intStopwatch1.ElapsedMilliseconds}ms.");
        }
        else
        {
            Console.WriteLine("Element not found");
        }


        //String
        string[] strValues = {"SF3023", "SF3021", "SF3043", "SF3053", "SF3032", "SF3063", "SF3089", "SF3062", "SF3092","SF3067"};
        string strElement = "SF3067";
        Array.Sort(strValues);
        Stopwatch strStopwatch = Stopwatch.StartNew();
        int strPosition = LinearSearch(strValues,strElement);
        strStopwatch.Stop();
        if(strPosition>-1)
        {
            Console.WriteLine($"Index of the {strElement} is {strPosition}. Time taken - {strStopwatch.ElapsedMilliseconds}ms.");
        }
        else
        {
            Console.WriteLine("Element not found");
        }


        //char
        char[] strValues1 = {'c','a','f','b','k','h','j','I','i','z','t','m','p','l','d'};
        char strElement1 = 'm';
        Array.Sort(strValues1);
        Stopwatch strStopwatch1 = Stopwatch.StartNew();
        int strPosition1 = LinearSearch(strValues1,strElement1);
        strStopwatch1.Stop();
        if(strPosition>-1)
        {
            Console.WriteLine($"Index of the {strElement1} is {strPosition1}. Time taken - {strStopwatch1.ElapsedMilliseconds}ms.");
        }
        else
        {
            Console.WriteLine("Element not found");
        }

    }



 //Int
    static int LinearSearch(int[] values, int element)
    {
        for(int i=0; i<values.Length;i++)
        {
            if(values[i] == element)
            {
                return i;
            }
        }
        return -1;
    }


    //double
     static int LinearSearch(double[] values, double element)
    {
        for(int i=0; i<values.Length;i++)
        {
            if(values[i] == element)
            {
                return i;
            }
        }
        return -1;
    }

    //string
    static int LinearSearch(string[] values, string element)
    {
        for(int i=0; i<values.Length;i++)
        {
            if(values[i] == element)
            {
                return i;
            }
        }
        return -1;
    }

    //char
    static int LinearSearch(char[] values, char element)
    {
        for(int i=0; i<values.Length;i++)
        {
            if(values[i] == element)
            {
                return i;
            }
        }
        return -1;
    }
    
}