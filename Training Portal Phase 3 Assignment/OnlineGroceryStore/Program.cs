using System;
namespace OnlineGroceryStore;
class Program 
{
    public static void Main(string[] args)
    {
        //Adding default value
        Operations.AddDefault();

        //Calling Main menu
        Operations.MainMenu();
    }
}