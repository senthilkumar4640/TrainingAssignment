using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HybridInheritanceOne
{
    public class Marksheet : TheroyExamMarks,ICalculate
    {
        //Property
        public int MarksheetNumber { get; set; }
        public DateTime DateOfIssue { get; set; }
        public int Total { get; set; }
        public double Percentage { get; set; }
        public int ProjectMark{get; set;}

        //Constructor
        public Marksheet(string name, string fatherName, string phone, DateTime dob, string mailID, int[] sem1, int[]sem2, int[]sem3, int[]sem4, int marksheetNumber,DateTime dateOfIssue ):base( name,  fatherName,  phone,  dob,  mailID,  sem1, sem2, sem3, sem4)
        {
            MarksheetNumber = marksheetNumber;
            DateOfIssue= dateOfIssue;
            
        }

       
        //Method

        public void CalculateUGTotal()
        {
            Total = Sem1.Sum()+Sem2.Sum()+Sem3.Sum()+Sem4.Sum();
        }

        public void CalculateUGPercentage()
        {
            Percentage = ProjectMark+Total/28;
        }
        public void ShowUGMarkSheet()
        {
            Console.WriteLine("MarksheetNumber|DateOfIssue|Name|FatherName|DOB|Total|Percentage");
            Console.WriteLine($"{MarksheetNumber}|{DateOfIssue}|{Name}|{FatherName}|{DOB}|{Total}|{Percentage}");
        }
    }
}