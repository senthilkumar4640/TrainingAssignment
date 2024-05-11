using System;
using System.Diagnostics;
namespace BinarySearch;
class Program
{
    public static void Main(string[] args)
    {

        //Integer
        int[]intValues = {45,33,12,55,77,22,33,14,67,78,22,11,44,66,88,12,35,84,93,77};
        int intElement = 66;
        Array.Sort(intValues);
        Stopwatch intStopwatch = Stopwatch.StartNew();
        int intPosition = BinarySearch(intValues,intElement);
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
        int intPosition1 = BinarySearch(intValues1,intElement1);
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
        string[] strValues = {"SF3023", "SF3021", "SF3067", "SF3043", "SF3053", "SF3032", "SF3063", "SF3089", "SF3062", "SF3092"};
        string strElement = "SF3067";
        Array.Sort(strValues);
        Stopwatch strStopwatch = Stopwatch.StartNew();
        int strPosition = BinarySearch(strValues,strElement);
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
        int strPosition1 = BinarySearch(strValues1,strElement1);
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
    static int BinarySearch(int[] values, int element)
    {
        int left =0;
        int right = values.Length-1;
        while(left<=right)
        {
            int middle = left + ((right-left)/2);

            if(values[middle] == element)
            {
                return middle;
            }
            else if(values[middle]<element)
            {
                left = middle + 1;
            }
            else
            {
                right = middle - 1;
            }
        }
        return -1;
    }


    //double
     static int BinarySearch(double[] values, double element)
    {
        int left =0;
        int right = values.Length-1;
        while(left<=right)
        {
            int middle = left + ((right-left)/2);

            if(values[middle] == element)
            {
                return middle;
            }
            else if(values[middle]<element)
            {
                left = middle + 1;
            }
            else
            {
                right = middle - 1;
            }
        }
        return -1;
    }

    //string
    static int BinarySearch(string[] values, string element)
    {
        int left =0;
        int right = values.Length-1;
        while(left<=right)
        {
            int middle = left + ((right-left)/2);
            int compare = string.Compare(values[middle],element);

            if(compare==0)
            {
                return middle;
            }
            else if(compare<0)
            {
                left = middle + 1;
            }
            else
            {
                right = middle - 1;
            }
        }
        return -1;
    }

    //char
    static int BinarySearch(char[] values, char element)
    {
        int left =0;
        int right = values.Length-1;
        while(left<=right)
        {
            int middle = left + ((right-left)/2);

            if(values[middle] == element)
            {
                return middle;
            }
            else if(values[middle]<element)
            {
                left = middle + 1;
            }
            else
            {
                right = middle - 1;
            }
        }
        return -1;
    }
}