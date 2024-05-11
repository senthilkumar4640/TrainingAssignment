using System;
using System.Runtime.CompilerServices;
namespace HierarchicalInheritanceOne;

public class Program 
{
    public static void Main(string[] args)
    {
        //Creating object for PersonalInfo class
        PersonalInfo person1 = new PersonalInfo("Senthil", "Ranga", "08/03/2002", 8825816924, Gender.Male,"Senthil@gmail.com");

        //Creating object for Teacher class
        Teacher teacher1 = new Teacher(person1.Name, person1.FatherName,person1.DOB,person1.Phone,person1.Gender,person1.MailID,"CSE","Artificial Intelligence","BE",5,"30/05/2008");

        //Creating object for StudentInfo class
        StudentInfo student1 = new StudentInfo(person1.Name, person1.FatherName,person1.DOB,person1.Phone,person1.Gender,person1.MailID,"BE","EEE",6);

        //Creating object for PrincipalInfo class
        PrincipalInfo principal1 = new PrincipalInfo(person1.Name, person1.FatherName,person1.DOB,person1.Phone,person1.Gender,person1.MailID,"ME",10,"08/06/2006");


        teacher1.ShowDetails();
        student1.ShowDetails();
        principal1.ShowDetails();
    }
}