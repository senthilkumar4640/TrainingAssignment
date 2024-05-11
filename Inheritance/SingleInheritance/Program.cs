using System;
namespace SingleInheritance;
class Program 
{
    public static void Main(string[] args)
    {
        //Creating class for PersonalDetails Class
        PersonalDetails person1 = new PersonalDetails("Senthil", "Ranga", Gender.Male, 8825816924);
        Console.WriteLine($"|Person ID: {person1.UserID}|Person Name: {person1.UserName}|Father Name: {person1.FatherName}|Gender: {person1.Gender}|Phone Number: {person1.PhoneNumber}|");

        //Creating class for StudentDetails Class
        StudentDetails student1 = new StudentDetails(person1.UserID,person1.UserName, person1.FatherName, person1.Gender, person1.PhoneNumber,"6th","2023");


    }
}