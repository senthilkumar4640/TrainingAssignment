using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeStudentAdmission
{
    public class DepartmentDetails
    {
        /*
        a.	DepartmentID – (AutoIncrement - DID101)
        b.	DepartmentName
        c.	NumberOfSeats
        */

        //Field
        //Static Field
        private static int s_departmentID = 100;
        public string DepartmentID { get; }//Read Only Property
        public string DepartmentName{ get; set; }
        public int NumberOfSeats { get; set; }

        //Constructor
        public DepartmentDetails(string departmentName, int numberOfSeats)
        {
            //Auto Incrementation
            s_departmentID++;

            //Assigning
            DepartmentID = "DID" + s_departmentID;
            DepartmentName = departmentName;
            NumberOfSeats = numberOfSeats;
        }

        //FileHandling Constructor
        public DepartmentDetails(string department)
        {
            string[] values = department.Split(",");
            DepartmentID = values[0];
            s_departmentID = int.Parse(values[0].Remove(0,3));
            DepartmentName = values[1];
            NumberOfSeats = int.Parse(values[2]);
        }
    }
}