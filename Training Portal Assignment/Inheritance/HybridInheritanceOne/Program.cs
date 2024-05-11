using System;
namespace HybridInheritanceOne;
class Program 
{
    public static void Main(string[] args)
    {
        int[] sem1 = {90,65,48,78,94,67};
        int[] sem2 = {90,95,98,78,94,67};
        int[] sem3 = {95,65,58,78,84,67};
        int[] sem4 = {90,85,98,68,94,87};
         Marksheet marksheet = new Marksheet("Senthil","Ranga","8825816924",new DateTime(2002,03,08),"Senthil@gmail.com",sem1,sem2,sem3,sem4,3001,new DateTime(2024,05,04) );
        marksheet.CalculateUGTotal();
        marksheet.CalculateUGTotal();
        marksheet.ShowUGMarkSheet();
    }
}