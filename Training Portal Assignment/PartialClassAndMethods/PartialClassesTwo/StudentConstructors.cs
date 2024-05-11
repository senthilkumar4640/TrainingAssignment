using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartialClassesTwo
{
    public partial class StudentInfo
    {
        //Constructors
        public StudentInfo(string studentID, string name, string gender, string dob, long mobile, int physics, int chemistry, int maths)
        {
            StudentID = studentID;
            Name = name;
            Gender = gender;
            DOB = dob;
            Mobile = mobile;
            Physics = physics;
            Chemistry = chemistry;
            Maths = maths;
        }
    }
}