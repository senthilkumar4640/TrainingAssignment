using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SingleInheritanceTwo
{
    public enum Gender {Select, Male, Female}
    public class PersonalInfo
    {
        /*
        Class PersonalInfo:
        Properties: Name, FatherName, Phone, MailID, DOB, Gender
        */

        //Property
        public string Name { get; set; }
        public string FatherName { get; set; }
        public long Phone { get; set; }
        public string MailID { get; set; }
        public string DOB { get; set; }
        public Gender Gender { get; set; }

        public PersonalInfo(string name, string fatherName, long phone, string mailID, string dob, Gender gender)
        {
            Name = name;
            FatherName = fatherName;
            Phone = phone;
            MailID = mailID;
            DOB = dob;
            Gender = gender;
        }
    }
}