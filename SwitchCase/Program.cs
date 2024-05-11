using System;
namespace SwitchCase;
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the num 1 : ");
        double num1 = double.Parse(Console.ReadLine());
        Console.Write("Enter the operand to perform (+,-,*,/,%)");
        string operand = Console.ReadLine();
        Console.WriteLine("Enter the num 2 : ");
        double num2 = double.Parse(Console.ReadLine());

        switch(operand)
        {
            case "+":
            {
                Console.WriteLine($"{num1} + {num2} = {num1+num2}");
                break;
            }
            case "-":
            {
                Console.WriteLine($"{num1} - {num2} = {num1-num2}");
                break;
            }
            case "*":
            {
                Console.WriteLine($"{num1} * {num2} = {num1*num2}");
                break;
            }
            case "/":
            {
                Console.WriteLine($"{num1} / {num2} = {num1/num2}");
                break;
            }
            case "%":
            {
                Console.WriteLine($"{num1} % {num2} = {num1%num2}");
                break;
            }
            default:
            {
                Console.WriteLine("Invalid Input");
                break;
            }

         
            }

        }

        
    }
