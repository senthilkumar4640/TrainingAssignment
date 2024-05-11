using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultilevelInheritanceOne
{
    public class StudentInfo : PersonalInfo
    {
        /*
        Class StudentInfo: inherits PersonalInfo
        Propeties: RegisterNumber, Standard, Branch, AcadamicYear
        Method: GetStudentInfo, ShowInfo
        */

        public int RegisterNumber { get; set; }
        public string Standard { get; set; }
        public string Branch { get; set; }
        public string AcadamicYear { get; set; }

        public StudentInfo(string name, string fatherName, long phone, string mailID, string dob, Gender gender, int registerNumber, string standard, string branch, string acadamicYear) : base(name, fatherName, phone, mailID, dob, gender)
        {
            RegisterNumber = registerNumber;
            Standard = standard;
            Branch = branch;
            AcadamicYear = acadamicYear;
        }
    }
}