using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HybridInheritanceOne
{
    public class TheroyExamMarks : PersonalInfo
    {
        //Property
        public int[] Sem1 { get; set; }
        public int[] Sem2 { get; set; }
        public int[] Sem3 { get; set; }
        public int[] Sem4 { get; set; }

        //Constructors
        public TheroyExamMarks(string name, string fatherName, string phone, DateTime dob, string mailID, int[] sem1, int[]sem2, int[]sem3, int[]sem4):base(name, fatherName, phone, dob, mailID)
        {
            Sem1 = sem1;
            Sem2 = sem2;
            Sem3 = sem3;
            Sem4 = sem4;
        }
    }
}