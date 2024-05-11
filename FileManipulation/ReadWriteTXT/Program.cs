using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
namespace ReadWriteTXT;
class Program 
{
    public static void Main(string[] args)
    {
        if(!Directory.Exists("TestFolder"))
        {
            Directory.CreateDirectory("TestFolder");
            Console.WriteLine("The folder has been created..");
        }
        else
        {
            Console.WriteLine("Folder already exists..");
        }

        if(!File.Exists("TestFolder/MyFile.txt"))
        {
            File.Create("TestFolder/MyFile.txt").Close();
            Console.WriteLine("The file has been created..");
        }
        else
        {
            Console.WriteLine("File already exists..");
        }

        Console.WriteLine("1.Read from file\n2.Write to file");
        int option = int.Parse(Console.ReadLine());
        switch(option)
        {
            case 1:
            {
                StreamReader sr = new StreamReader("TestFolder/MyFile.txt");
                string data = sr.ReadLine();
                while(data != null)
                {
                    Console.WriteLine(data);
                    data = sr.ReadLine();
                }
                sr.Close();
                break;
            }

            case 2:
            {
                string[] contents = File.ReadAllLines("TestFolder/MyFile.txt");
                StreamWriter sw = new StreamWriter("TestFolder/MyFile.txt");
                Console.WriteLine("Enter the details to add: ");
                string data = Console.ReadLine();
                string old="";
                foreach(string line in contents)
                {
                    old = old + line +"\n";
                }
                old = old + data +"\n";
                sw.WriteLine(old);
                sw.Close();
                Console.WriteLine("Line added sucessfully..");
                break;
            }
        }
    }
}