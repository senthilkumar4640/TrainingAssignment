using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeStudentAdmission
{
    //Enum Declaration
    public enum AdmissionStatus {Select, Admitted, Cancelled}
    public class AdmissionDetails
    {
        /*
        a.	AdmissionID – (Auto Increment ID - AID1001)
        b.	StudentID
        c.	DepartmentID
        d.	AdmissionDate
        e.	AdmissionStatus – Enum- (Select, Admitted, Cancelled)
        */

        //Field
        private static int s_admissionID = 1000;

        //Property
        public string AdmissionID { get; }//Read Only Property
        public string StudentID {get; set;}
        public string DepartmentID { get; set;}
        public DateTime AdmissionDate { get; set; }
        public AdmissionStatus AdmissionStatus { get; set; }
        

        //Constructor
        public AdmissionDetails(string studentID, string departmentID, 
        DateTime admissionDate, AdmissionStatus  admissionStatus)
        {
            //Auto Incrementation
            s_admissionID++;

            //Assigning
            AdmissionID = "AID" + s_admissionID;
            StudentID = studentID;
            DepartmentID = departmentID;
            AdmissionDate = admissionDate;
            AdmissionStatus = admissionStatus;
        }

        //File Handling Constructor
        public AdmissionDetails(string admission)
        {
            string[] values = admission.Split(",");
            AdmissionID = values[0];
            s_admissionID = int.Parse(values[0].Remove(0,3));
            StudentID = values[1];
            DepartmentID = values[2];
            AdmissionDate = DateTime.ParseExact(values[3],"dd/MM/yyyy",null);
            AdmissionStatus = Enum.Parse<AdmissionStatus>(values[4]);
        }

    }
}