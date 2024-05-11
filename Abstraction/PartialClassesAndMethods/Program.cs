using System;
namespace PartialClassesAndMethods;
class Program 
{
    public static void Main(string[] args)
    {
        PersonalDetails person = new PersonalDetails();
        person.DOB = new DateTime(2002,03,08);
    }
}