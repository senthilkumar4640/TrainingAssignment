using System;
namespace SingleInheritanceOne;
class Program 
{
    public static void Main(string[] args)
    {
        //Creating object for PersonalInfo
        PersonalInfo personal = new PersonalInfo("Senthil", "Ranga", 8825816924, "senthil@gmail.com", "08/03/2002", Gender.Male);

        //Creating object for StudentInfo
        StudentInfo student = new StudentInfo(personal.Name, personal.FatherName, personal.Phone,personal.MailID,personal.DOB, personal.Gender, 4640, "12th", "Biology", "2023");
       
        //Method calling
        student.ShowStudentInfo();
    }
}