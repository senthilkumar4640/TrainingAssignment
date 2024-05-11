using System;
namespace QwickFoodz;
class Program
{
    public static void Main(string[] args)
    {

        //Create
        //FileHandling.Create();

        //Adding default data
        Operations.AddDefault();

        //Mainmenu Calling
        Operations.MainMenu();
    }
}