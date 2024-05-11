using System;
using System.IO;
namespace CollegeStudentAdmission
{
    public static class FileHandling
    {
        //Method for Create..
        public static void Create()
        {
            //Creating a folder
            if(!Directory.Exists("CollegeAdmission"))
            {
                Directory.CreateDirectory("CollegeAdmission");
                Console.WriteLine("The folder has been created...");
            }

            //Creating a File for Admission Class..
            if(!File.Exists("CollegeAdmission/AdmissionDetails.csv"))
            {
                File.Create("CollegeAdmission/AdmissionDetails.csv").Close();
                Console.WriteLine("The file has been created...");
            }

            //Creating a File for Department Class..
            if(!File.Exists("CollegeAdmission/DepartmentDetails.csv"))
            {
                File.Create("CollegeAdmission/DepartmentDetails.csv").Close();
                Console.WriteLine("The file has been created...");

            }

            //Creating a File for Student Class..
            if(!File.Exists("CollegeAdmission/StudentDetails.csv"))
            {
                File.Create("CollegeAdmission/StudentDetails.csv").Close();
                Console.WriteLine("The file has been created...");

            }
        }
    
        //Method for Write..
        public static void WriteToCSV()
        {
            //Admission Class
            string[] admission = new string[Operations.admissionList.Count];
            for(int i=0;i<Operations.admissionList.Count;i++)
            {
                admission[i] = Operations.admissionList[i].AdmissionID+","+Operations.admissionList[i].StudentID+","+Operations.admissionList[i].DepartmentID+","+Operations.admissionList[i].AdmissionDate.ToString("dd/MM/yyyy")+","+Operations.admissionList[i].AdmissionStatus;
            }
            File.WriteAllLines("CollegeAdmission/AdmissionDetails.csv",admission);


            //Department Class
            string [] department = new string[Operations.departmentList.Count];
            for(int i=0;i<Operations.departmentList.Count;i++)
            {
                department[i] = Operations.departmentList[i].DepartmentID+","+Operations.departmentList[i].DepartmentName+","+Operations.departmentList[i].NumberOfSeats;
            }
            File.WriteAllLines("CollegeAdmission/DepartmentDetails.csv",department);


            //Student Class
            string[] students = new string[Operations.studentList.Count];
            for(int i=0; i<Operations.studentList.Count;i++)
            {
                students[i] = Operations.studentList[i].StudentID+","+Operations.studentList[i].StudentName+","+Operations.studentList[i].FatherName+","+Operations.studentList[i].DOB.ToString("dd/MM/yyyy")+","+Operations.studentList[i].Gender+","+Operations.studentList[i].PhysicsMark+","+Operations.studentList[i].ChemistryMark+","+Operations.studentList[i].MathsMark;
            }
            File.WriteAllLines("CollegeAdmission/StudentDetails.csv",students);

        }
    
        //Method for Read..
        public static void ReadFromCSV()
        {
            //Admission Class..
            string[] admissions = File.ReadAllLines("CollegeAdmission/AdmissionDetails.csv");
            foreach(string admission in admissions)
            {
                //Creating object
                AdmissionDetails admission1 = new AdmissionDetails(admission);
                Operations.admissionList.Add(admission1);
            }

            //Department Class..
            string[] departments = File.ReadAllLines("CollegeAdmission/DepartmentDetails.csv");
            foreach(string department in departments)
            {
                //Creating object
                DepartmentDetails department1 = new DepartmentDetails(department);
                Operations.departmentList.Add(department1);

            }

            //Student Class..
            string[] students = File.ReadAllLines("CollegeAdmission/StudentDetails.csv");
            foreach (string student in students)
            {
                //creating object
                StudentDetails student1 = new StudentDetails(student);
                Operations.studentList.Add(student1);
            }
        }
    }
}