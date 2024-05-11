using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeStudentAdmission
{
    //Enum Declaration
    public enum Gender {Select, Male, Female, Transgender}
    public class StudentDetails
    {
        /*
        a.	StudentID – (AutoGeneration ID – SF3000)
        b.	StudentName
        c.	FatherName
        d.	DOB
        e.	Gender – Enum (Male, Female, Transgender)
        f.	Physics
        g.	Chemistry
        h.	Maths
        */

        //Field
        //Static Field
        private static int s_studentID = 3000;

        //Properties
        public string StudentID { get; } //Read Only Property
        public string StudentName { get; set; }
        public string FatherName { get; set; }
        public DateTime DOB { get; set; }
        public Gender Gender { get; set; }
        public int PhysicsMark { get; set; }
        public int ChemistryMark { get; set; }
        public int MathsMark { get; set; }

        //Constructor
        public StudentDetails(string studentName, string fatherName, DateTime dob, 
        Gender gender, int physicsMark, int chemistryMark, int mathsMark )
        {
            //Auto Incrementation
            s_studentID++;

            //Assigning
            StudentID = "SF" + s_studentID;
            StudentName = studentName;
            FatherName = fatherName;
            DOB = dob;
            Gender = gender;
            PhysicsMark = physicsMark;
            ChemistryMark = chemistryMark;
            MathsMark = mathsMark;

        }

        //Methods
        /*
        Check Eligibility (Method with argument, with return types) – cutOff -75.0
        Calculate average of 3 marks, if average >= 75.0 return true, else false
        */
        public double Average()
        {
            int total = PhysicsMark + ChemistryMark + MathsMark;
            double average = (double)total / 3;
            return average;
        }

        public bool CheckEligibility(double cutOff)
        {
            if(Average()>=cutOff)
            {
                return true;
            }
            return false;
        }
    }
}