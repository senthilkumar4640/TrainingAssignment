using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultilevelInheritanceOne
{
    //Enum Declaration
    public enum Gender {Select, Male, Female}
    public class PersonalInfo
    {
        /*
        Class PersonalInfo:
        Properties: Name, FatherName,Phone,Mail, dob,Gender
        Constructor to assign values
        */

        //Property
        public string Name { get; set; }
        public string FatherName { get; set; }
        public long Phone { get; set; }
        public string MailId { get; set; }
        public string DOB {get; set; }
        public Gender Gender { get; set; }
        
        //Constructor
        public PersonalInfo(string name, string fatherName, long phone, string mailID, string dob, Gender gender)
        {
            Name = name;
            FatherName = fatherName;
            Phone = phone;
            MailId = mailID;
            DOB = dob;
            Gender = gender;
        }
    }
}