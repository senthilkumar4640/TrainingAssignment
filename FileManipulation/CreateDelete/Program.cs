using System;
using System.IO;
namespace CreateDelete;
class Program
{
    public static void Main(string[] args)
    {
        string path = @"D:\Assignments\Practice\Advanced OOP\FileManipulation\CreateDeleteEx";
        string folderPath = path + "/Senthil";
        if(Directory.Exists(folderPath))
        {
            Console.WriteLine("Folder already exists..");
        }
        else
        {
            Directory.CreateDirectory(folderPath);
            Console.WriteLine("The folder has been created..");
        }

        string filePath = path + "/MyFile.txt";
        if(File.Exists(filePath))
        {
            Console.WriteLine("File already exists..");
        }
        else
        {
            File.Create(filePath);
            Console.WriteLine("The file has been created..");
        }

        Console.WriteLine("------------------");
        Console.WriteLine("File Manipulation");
        Console.WriteLine("------------------");
        Console.WriteLine("1.Create Folder\n2.Create File\n3.Delete Folder\n4.Delete File");
        Console.Write("Enter the option: ");
        int option = int.Parse(Console.ReadLine());
        switch(option)
        {
            case 1://Creating a folder
            {
                Console.Write("Enter the folder name: ");
                string folder = Console.ReadLine();
                string newPath = path + "/" + folder;
                if(Directory.Exists(newPath))
                {
                    Console.WriteLine("Folder already exists..");
                }
                else
                {
                    Directory.CreateDirectory(newPath);
                    Console.WriteLine("The folder has been created..");
                }
                break;
            }

            case 2://Creating a file
            {
                Console.Write("Enter the file name: ");
                string file = Console.ReadLine();
                Console.Write("Enter the file extension: ");
                string extension = Console.ReadLine();
                string newFilePath =path+"/"+file+"."+extension;
                if(File.Exists(newFilePath))
                {
                    Console.WriteLine("File already exists..");
                }
                else
                {
                    File.Create(newFilePath);
                    Console.WriteLine("The file has been created..");
                }
                break;
            }

            case 3://Deleting a folder
            {
                Console.WriteLine("These are the existing folders..");
                foreach(string pathOne in Directory.GetDirectories(path))
                {
                    Console.WriteLine(pathOne);
                }
                Console.Write("Enter the folder name: ");
                string delFolder = Console.ReadLine();
                foreach(string pathOne in Directory.GetDirectories(path))
                {
                    if(pathOne.Contains(delFolder))
                    {
                        Directory.Delete(pathOne);
                        Console.WriteLine("The folder has been deleted..");
                    }
                }
                break;
            }

            case 4://Deleting a file
            {
                Console.WriteLine("These are the existing files..");
                foreach(string fileOne in Directory.GetFiles(path))
                {
                    Console.WriteLine(fileOne);
                }
                Console.Write("Enter the file name and it's extension to delete: ");
                string delFile = Console.ReadLine();
                foreach(string fileOne in Directory.GetFiles(path))
                {
                    if(fileOne.Contains(delFile))
                    {
                        File.Delete(fileOne);
                        Console.WriteLine("The file has been deleted");
                    }
                }
                break;
            }
        }
    }
}