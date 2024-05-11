using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MultilevelInheritance;

namespace MultilevelInheritance
{
    public class EmployeeDetails : StudentDetails
    {
        //Field
        //Static Field
        private static int s_empID = 5000;

        //Properties
        public string  EmployeeID { get; }//ReadOnly Property

        public string Designation { get; set; }

        //Constructors
        public EmployeeDetails(string studentID, string userID, string userName, string fatherName, Gender gender, long phoneNumber,string standard, string yoj, string designation) : base(studentID,userID, userName, fatherName, gender, phoneNumber,standard,yoj)
        {
            s_empID++;
            EmployeeID = "EMP" + s_empID;
            Designation = designation;
        }//Constructors Ends
    }
}