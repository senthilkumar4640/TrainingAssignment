using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultilevelInheritanceOne
{
    public class HSCDetails  : StudentInfo
    {
        /*
        Class HSCDetails: Inherits StudentInfo
        Properties: HSCMarksheetNumber, Physics, Chemistry, Maths, Total, Percentage marks
        Methods: GetMarks, Calculate – Total and percentage, Show Marksheet.
        */

        //Property 
        public int  HSCMarksheetNumber{ get; set; }
        public int Physics { get; set; }
        public int Chemistry { get; set; }
        public int Maths { get; set; }
        public int Total { get; set; }
        public double PercentageMarks { get; set; }

        public HSCDetails(string name, string fatherName, long phone, string mailID, string dob, Gender gender, int registerNumber, string standard, string branch, string acadamicYear, int hSCMarkSheetNumber, int physics, int chemistry,int maths) : base(name, fatherName, phone, mailID, dob, gender,registerNumber,standard, branch, acadamicYear)
        {
            HSCMarksheetNumber = hSCMarkSheetNumber;
            Physics = physics;
            Chemistry = chemistry;
            Maths = maths;
        }

        public void GetMarks()
        {
            Console.WriteLine("|Physics|Chemistry|Maths");
            Console.WriteLine($"|{Physics}|{Chemistry}|{Maths}");
        }

        public void Calculate()
        {
            Total = Physics+Chemistry+Maths;
            Console.WriteLine($"Total : {Total}");
            PercentageMarks = Total/3;
            Console.WriteLine($"Percentage : {PercentageMarks}");
        }

        public void ShowMarkSheet()
        {
            Console.WriteLine("|HSC MarkSheet Number|Name|Register Number|Standard|Branch|Physics|Chemistry|Maths|Total|Percentage|Academic Year|");
            Console.WriteLine($"|{HSCMarksheetNumber}|{Name}|{RegisterNumber}|{Standard}|{Branch}|{Physics}|{Chemistry}|{Maths}|{Total}|{PercentageMarks}|{AcadamicYear}|");
        }       
    }
}