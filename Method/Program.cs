using System;

public class Program
        {
            public static void Main(string[] args)
            {
                string res;
                do{
                    
                Console.Write("Enter the num 1 :");
                double num1 = int.Parse(Console.ReadLine());
                Console.Write("Enter the num 2 :");
                double num2 = int.Parse(Console.ReadLine());
                Console.Write("Enter the operand: +,-,*,/ : ");
                string operand = Console.ReadLine();

                switch(operand)
                {
                    case "+":
                    {
                        Console.WriteLine(Addition(num1,num2));
                        break;
                    }
                    case "-":
                    {
                        Console.WriteLine(Subtraction(num1,num2));
                        break;
                    }
                    case "*":
                    {
                        Console.WriteLine(Multiplication(num1,num2));
                        break;
                    }
                    case "/":
                    {
                        Console.WriteLine(Division(num1,num2));
                        break;
                    }
                    
                }
                Console.Write("Do you want to continue : yes / no : ");
                res = Console.ReadLine();
                }
                while(res == "yes");


            }

            public static double Addition(double a, double b)
            {
                return a+b;
            }

             public static double Subtraction(double a, double b)
            {
                return a-b;
            }

             public static double Multiplication(double a, double b)
            {
                return a*b;
            }

             public static double Division(double a, double b)
            {
                return a/b;
            }

        }
            