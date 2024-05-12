using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoctorPatientAppointmentSystem
{
     public enum DepartmentType
    {
        Select, Anaesthesiology, Cardiology, Diabetology, Neonatology, Nephrology
    }
    public class DoctorDetails
    {
        private static int s_doctorID = 0;
        public string DoctorID { get; }
        public string Name { get; set; }
        public DepartmentType Department { get; set; }
        public DoctorDetails(string name, DepartmentType department)
        {
            s_doctorID++;
            DoctorID = s_doctorID.ToString();
            Name = name;
            Department = department;
        }
    }
}