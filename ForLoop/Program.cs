using System;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;
namespace ForLoop;
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the start number : ");
        int startNum = int.Parse(Console.ReadLine());
        Console.Write("Enter the end number : ");
        int endNum = int.Parse(Console.ReadLine());
             int result=0;

        for(int i=startNum; i<=endNum; i++)
        {
           // int result;
            result = result +(i*i);
        }
        Console.WriteLine(result);
    }

}