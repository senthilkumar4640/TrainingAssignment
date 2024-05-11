using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SealedClassOne
{
    public enum Gender{Select, Male, Female}
    public class PersonalInfo
    {
        public string Name { get; set; }
        public string FatherName { get; set; }
        public string Mobile { get; set; }
        public string MailID { get; set; }
        public Gender Gender { get; set; }

        public PersonalInfo(string name, string fathername, string mobile, string mailID, Gender gender)
        {
            Name = name;
            FatherName = fathername;
            Mobile = mobile;
            MailID = mailID;
            Gender = gender;
        }

        public void UpdateInfo()
        {
            
        }
    }
}