using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartialClassesTwo
{
    public partial class StudentInfo
    {
        //Property
        //StudentID,Name,Gender,DOB, Mobile, Physics, Chemistry, Maths

        public string StudentID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string DOB { get; set; }
        public long Mobile { get; set; }
        public int Physics { get; set; }
        public int Chemistry { get; set; }
        public int Maths { get; set; }
    }
}