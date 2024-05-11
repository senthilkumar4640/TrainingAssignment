using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultilevelInheritance;

    public class StudentDetails : PersonalDetails
    {
        //Field
        //Static Field
        private static int s_studentID = 3000;

        //Property
        public string StudentId { get; }//ReadOnly Property
        public string Standard { get; set; }
        public string YOJ {get; set;}

        //Constructors
        public StudentDetails(string userID, string userName, string fatherName, Gender gender, long phoneNumber,string standard, string yoj) : base(userID, userName, fatherName, gender, phoneNumber)
        {
                s_studentID++;
                StudentId = "SID" + s_studentID;
                Standard = standard;
                YOJ = yoj;
        } //Constructors Ends

        public StudentDetails(string studentID, string userID, string userName, string fatherName, Gender gender, long phoneNumber,string standard, string yoj) : base(userID, userName, fatherName, gender, phoneNumber)
        {
            
                StudentId = studentID;
                Standard = standard;
                YOJ = yoj;
        } //Constructors Ends
    }
