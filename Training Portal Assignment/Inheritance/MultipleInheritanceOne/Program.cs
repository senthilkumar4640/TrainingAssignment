using System;
namespace MultipleInheritanceOne;
class Program 
{
    public static void Main(string[] args)
    {
        RegisterPerson person1 = new RegisterPerson("Senthil","male",new DateTime(2002,03,08),"8825816924",MaritalDetails.Married,"Ranganathan","Meena","14,vellara street",0,new DateTime(2024,05,05));
        person1.ShowInfo();
        RegisterPerson person2 = new RegisterPerson("Bhuvi","female",new DateTime(2002,07,16),"8825816494",MaritalDetails.Married,"Krishna","Parimala","14,KKnagar street",1,new DateTime(2024,12,05));
        person2.ShowInfo();
    }
}
