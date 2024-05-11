using System;
using System.Security.Cryptography.X509Certificates;
namespace PolymorphismOne;
class Program 
{
    public static void Main(string[] args)
    {
       Console.WriteLine(MultiplyMethod(5));
       Console.WriteLine(MultiplyMethod(5,8));
       Console.WriteLine(MultiplyMethod(5,8,9));
       Console.WriteLine(MultiplyMethod(5.1,8));
       Console.WriteLine(MultiplyMethod(5.1,8.1,9));
        
    }
     //Method 1
    public static int MultiplyMethod(int n)
    {
            return n*n;
    }

     //Method 2
     public static int MultiplyMethod(int a, int b)
     {
        return a*b;
     }

      //Method 3
     public static int MultiplyMethod(int a, int b, int c)
     {
        return a*b*c;
     }

      //Method 4
     public static double MultiplyMethod(double a, int b)
     {
        return a*b;
     }

      //Method 5
     public static double MultiplyMethod(double a, double b,int c)
     {
        return a*b;
     }

    
}