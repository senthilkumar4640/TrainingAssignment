using System;
namespace  OnlineMedicalStore;
class Program 
{
    public static void Main(string[] args)
    {
        //Adding default data
        Operations.AddDefault();
        //Calling Mainmenu
        Operations.MainMenu();
    }
}