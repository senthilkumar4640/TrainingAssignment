using System;
namespace MetroCardManagement;
class Program 
{
    public static void Main(string[] args)
    {

        //Creating Folder and Files
        FileHandling.create();

        //Calling Default Value
        Operations.AddDefault();

        //Calling Main Menu
        Operations.MainMenu();

        //Writing to CSV
        FileHandling.WriteToCSV();

    }
}