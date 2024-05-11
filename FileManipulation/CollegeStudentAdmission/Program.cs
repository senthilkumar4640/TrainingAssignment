using System;
using System.IO;
namespace CollegeStudentAdmission;
class Program 
{
    public static void Main(string[] args)
    {
        //Creating Files
        FileHandling.Create();

        //Default Data Calling
        //Operations.AddDefaultData();

        //Reading Files
        FileHandling.ReadFromCSV();

        //Calling Main Menu
        Operations.MainMenu();

        //Writing Files
        FileHandling.WriteToCSV();


    }
}