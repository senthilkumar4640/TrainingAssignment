using System;
namespace MultilevelInheritanceOne;
class Program
{
    public static void Main(string[] args)
    {
        //Creating object for HSCDetails
        HSCDetails student1 = new HSCDetails("Senthil","Ranga",8825816924,"Senthil@gmail.com","08/03/2002",Gender.Male,4640,"12th","Biology","2023",1465,95,92,98);
        HSCDetails student2 = new HSCDetails("Bhuvana","Parimala",8903089312,"Bhuvana@gmail.com","16/07/2002",Gender.Female,1468,"12th","Biology","2023",4685,98,97,94);

        student1.GetMarks();
        student1.Calculate();
        student1.ShowMarkSheet();

        student2.GetMarks();
        student2.Calculate();
        student2.ShowMarkSheet();
    }
}