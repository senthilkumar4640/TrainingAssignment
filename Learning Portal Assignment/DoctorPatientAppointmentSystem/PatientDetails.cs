using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoctorPatientAppointmentSystem
{
    public enum Gender
    {
        Select, Male, Female, Enum
    }
    public class PatientDetails
    {
        private static int s_patientID = 0;
        public string PatientID { get; }
        public string Password { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }
        public PatientDetails(string password, string name, int age, Gender gender)
        {
            s_patientID++;
            PatientID = s_patientID.ToString();
            Password = password;
            Name = name;
            Age = age;
            Gender = gender;
        }
    }
}