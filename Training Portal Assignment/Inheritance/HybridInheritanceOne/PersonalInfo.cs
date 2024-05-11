using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HybridInheritanceOne
{
    public class PersonalInfo
    {
        //Field
        private static int s_registerNumber = 1000;

        //Property
        public string RegisterNumber { get; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public string Phone { get; set; }
        public DateTime DOB { get; set; }
        public string MailID { get; set; }

        //Constructor
        public PersonalInfo(string name, string fatherName, string phone, DateTime dob, string mailID)
        {
            RegisterNumber = "RID"+s_registerNumber;
            Name = name;
            FatherName = fatherName;
            Phone = phone;
            DOB = dob;
            MailID = mailID;
        }
    }
}