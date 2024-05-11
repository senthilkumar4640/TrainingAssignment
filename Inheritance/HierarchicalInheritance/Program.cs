using System;
namespace HierarchicalInheritance;
class Program 
{
    public static void Main(string[] args)
    {
        //Creating object for PersonalDetails Class
        PersonalDetails person1 = new PersonalDetails("Senthil", "Ranga", Gender.Male, 8825816924);
        Console.WriteLine($"|Person ID: {person1.UserID}|Person Name: {person1.UserName}|Father Name: {person1.FatherName}|Gender: {person1.Gender}|Phone Number: {person1.PhoneNumber}|");

        //Creating object for StudentDetails Class
        StudentDetails student1 = new StudentDetails(person1.UserID,person1.UserName, person1.FatherName, person1.Gender, person1.PhoneNumber,"6th","2023");

        //Creating object for CustomerDetails Class
        CustomerDetails customer1 = new CustomerDetails(person1.UserID, person1.UserID,person1.FatherName,person1.Gender,person1.PhoneNumber,1000);
    }
}