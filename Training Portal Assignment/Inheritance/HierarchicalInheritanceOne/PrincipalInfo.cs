using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HierarchicalInheritanceOne
{
    public class PrincipalInfo : PersonalInfo
    {
        /*
        Class PrincipalInfo inherit PersonalInfo
        Properties: PrincipalID, Qualification, YearOfExperience, DateOfJoining
        Methods: ShowDetails
        */

        //Field
        private static int s_principalID = 2000;

        //Properties
        public string PrincipalID { get; }
        public string Qualification { get; set; }
        public int YearOfExperience { get; set; }
        public string DateOfJoining { get; set; }

        //Constructor
        public PrincipalInfo(string name, string fatherName, string dob, long phone, Gender gender, string mailID, string qualification, int yearOfExperience, string dateOfJoining) : base(name, fatherName, dob, phone, gender, mailID)
        {
            s_principalID++;
            PrincipalID = "PID" + s_principalID;
            Qualification = qualification;
            YearOfExperience = yearOfExperience;
            DateOfJoining = dateOfJoining;
        }

        //Method
        public void ShowDetails()
        {
            Console.WriteLine("|Name|FatherName|DOB|Phone|Gender|MailID|PrincipalID|Qualification|YearOfExperience|DateOfJoining|");
            Console.WriteLine($"|{Name}|{FatherName}|{DOB}|{Phone}|{Gender}|{MailID}|{PrincipalID}|{Qualification}|{YearOfExperience}|{DateOfJoining}|");
        }
    }
}