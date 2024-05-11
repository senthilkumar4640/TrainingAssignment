using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace CollegeStudentAdmission
{
    //Static Class
    public static class Operations
    {
        //Local / Global Object Creation
        static StudentDetails currentLoggedInStudent;

        //Static List Creation
        public static List<StudentDetails> studentList = new List<StudentDetails>();
        public static List<DepartmentDetails> departmentList = new List<DepartmentDetails>();
        public static List<AdmissionDetails> admissionList = new List<AdmissionDetails>();

        //Main Menu
        public static void MainMenu() 
        {
            Console.WriteLine("********** Welcome to Syncfusion College **********");

            string mainChoice = "yes";
            do
            {
                //Need to show the main menu option
                Console.WriteLine("MainMenu\n1. Registration\n2. Login\n3. Departmentwise Seat Availability\n4. Exit");
                //Need to get an input user and validate
                Console.Write("Select an option: ");
                int mainOption = int.Parse(Console.ReadLine());
                //Need to create menu structure
                switch (mainOption)
                {
                    case 1:
                        {
                            Console.WriteLine("********** Student Registration **********");
                            StudentRegistration();
                            break;
                        }

                    case 2:
                        {
                            Console.WriteLine("********** Student Login **********");
                            StudentLogin();
                            break;
                        }

                    case 3:
                        {
                            Console.WriteLine("********** Departmentwise Seat Availability **********");
                            DepartmentWiseAvailbility();
                            break;
                        }

                    case 4:
                        {
                            Console.WriteLine("Application Exited Sucessfully");
                            mainChoice = "no";
                            break;
                        }
                }
                //Need to iterate until the option exit
            } while (mainChoice == "yes");
        }//Main Menu Ends


        //Student Registration
        public static void StudentRegistration()
        {
            //Need to get required details
            Console.Write("Enter your name: ");
            string studentName = Console.ReadLine();
            Console.Write("Enter your father name: ");
            string fatherName = Console.ReadLine();
            Console.Write("Enter your DOB as specified DD/MM/YYYY: ");
            DateTime dob = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
            Console.Write("Enter your gender (Male / Female): ");
            Gender gender = Enum.Parse<Gender>(Console.ReadLine(), true);
            Console.Write("Enter your Physics mark: ");
            int physicsMark = int.Parse(Console.ReadLine());
            Console.Write("Enter your Chemistry mark: ");
            int chemistryMark = int.Parse(Console.ReadLine());
            Console.Write("Enter your Maths mark: ");
            int mathsMark = int.Parse(Console.ReadLine());

            //Need to create an object
            StudentDetails student = new StudentDetails(studentName, fatherName, dob, gender, physicsMark, chemistryMark, mathsMark);
            //Need to add in the list
            studentList.Add(student);
            //Need to display confirmation message and ID
            Console.WriteLine($"Registration successful. Student ID : {student.StudentID}");
        }//Student Registrations Ends


        //Student Login
        public static void StudentLogin()
        {
            //Need to get ID input
            Console.Write("Enter your student ID: ");
            string loginID = Console.ReadLine().ToUpper();
            //Validate by its presence in the list
            bool isFlag = true;
            foreach (StudentDetails student in studentList)
            {
                if (loginID.Equals(student.StudentID))
                {
                    isFlag = false;
                    //Current user to global varible
                    currentLoggedInStudent = student;
                    Console.WriteLine("Logged In Successfully");
                    //Need to call submenu
                    SubMenu();
                    break;

                }
            }
            if (isFlag)
            {
                Console.WriteLine("Invalid ID or ID not present");
            }
            //If not - Invalid or valid
        }//Student Login Ends

        //Submenu
        public static void SubMenu()
        {
            string subChoice = "yes";
            do
            {
                Console.WriteLine("********** SubMenu **********");
                //Need to show submenu options
                Console.WriteLine("Select an option\n1. Check Eligibility\n2. Show Details\n3. Take Admission\n4. Cancel Admission\n5. Admission Details\n6. Exit");
                //getting user option
                Console.Write("Enter your option: ");
                int subOption = int.Parse(Console.ReadLine());
                //Need to create submenu structure
                switch (subOption)
                {
                    case 1:
                        {
                            Console.WriteLine("********** Check Eligibility **********");
                            CheckEligibility();
                            break;
                        }

                    case 2:
                        {
                            Console.WriteLine("********** Show Details **********");
                            ShowDetails();
                            break;
                        }

                    case 3:
                        {
                            Console.WriteLine("********** Take Admission **********");
                            TakeAdmission();
                            break;
                        }

                    case 4:
                        {
                            Console.WriteLine("********** Cancel Admission **********");
                            CancelAdmission();
                            break;
                        }

                    case 5:
                        {
                            Console.WriteLine("********** Admission Details **********");
                            AdmissionDetails();
                            break;
                        }

                    case 6:
                        {
                            Console.WriteLine("Taking back to Main Menu");
                            subChoice = "no";
                            break;
                        }
                }
                //iterate till option is exit
            } while (subChoice == "yes");

        }//Submenu Ends

        //Check Eligibility
        public static void CheckEligibility()
        {
            //Get cutoff value as input
            Console.Write("Enter the cutoff value: ");
            double cutoff = double.Parse(Console.ReadLine());
            //Check eligibility or not
            if (currentLoggedInStudent.CheckEligibility(cutoff))
            {
                Console.WriteLine("Student is Eligible");
            }
            else
            {
                Console.WriteLine("Student is not Eligible");
            }
        }//Check Elibility Ends


        //Show Details
        public static void ShowDetails()
        {
            //Need to show current student details
            Console.WriteLine("|StudentID|StudentName}|FatherName|DOB|Gender|PhysicsMark|ChemistryMark|MathsMark");
            Console.WriteLine($"|{currentLoggedInStudent.StudentID}|{currentLoggedInStudent.StudentName}|{currentLoggedInStudent.FatherName}|{currentLoggedInStudent.DOB}|{currentLoggedInStudent.Gender}|{currentLoggedInStudent.PhysicsMark}|{currentLoggedInStudent.ChemistryMark}|{currentLoggedInStudent.MathsMark}");
        }//Show Details Ends


        //Take Admission
        public static void TakeAdmission()
        {
            //Need to show available department details
            DepartmentWiseAvailbility();
            //Ask department ID from user
            Console.Write("Select a department ID: ");
            string departmentId = Console.ReadLine().ToUpper();
            //Check the ID is present or not
            bool isFlag = true;
            foreach (DepartmentDetails department in departmentList)
            {
                if (departmentId.Equals(department.DepartmentID))
                {
                    isFlag = false;
                    //Check the student is eligible or not
                    if (currentLoggedInStudent.CheckEligibility(75.0))
                    {
                        //Check the seat availability
                        if (department.NumberOfSeats > 0)
                        {
                            //Check student already taken any admission
                            int count = 0;
                            foreach (AdmissionDetails admission in admissionList)
                            {
                                if (currentLoggedInStudent.StudentID.Equals(admission.StudentID) && admission.AdmissionStatus.Equals(AdmissionStatus.Admitted))
                                {
                                    count++;
                                }
                            }
                            if (count == 0)
                            {
                                //Create admission object 
                                AdmissionDetails admissionTaken = new AdmissionDetails(currentLoggedInStudent.StudentID, department.DepartmentID, DateTime.Now, AdmissionStatus.Admitted); 
                                //Reduce seat count
                                department.NumberOfSeats--;
                                //Add to the admission list
                                admissionList.Add(admissionTaken);
                                //Display admission successful message
                                Console.WriteLine($"You have taken admission succesfully. Admission ID: {admissionTaken.AdmissionID}");
                            }
                            else
                            {
                                Console.WriteLine("You have already taken an admission");
                            }

                        }
                        else
                        {
                            Console.WriteLine("Seats are not available");
                        }

                    }
                    else
                    {
                        Console.WriteLine("You are not eligible due to low cutoff");
                    }
                    break;
                }
            }
            if (isFlag)
            {
                Console.WriteLine("Invalid ID or ID not present");
            }
        }//Take Admission Ends


        //Cancel Admission
        public static void CancelAdmission()
        {
            //Check student is taken any admission and display it
            bool isFlag = true;
            foreach(AdmissionDetails admission in admissionList)
            {
                if(currentLoggedInStudent.StudentID.Equals(admission.StudentID) && admission.AdmissionStatus.Equals(AdmissionStatus.Admitted))
                {
                    //Cancel the found admission
                    admission.AdmissionStatus=AdmissionStatus.Cancelled;
                    //return the seat to department
                    foreach(DepartmentDetails department in departmentList)
                    {
                        if(admission.DepartmentID.Equals(department.DepartmentID))
                        {
                            department.NumberOfSeats++;
                            isFlag = false;
                            break;
                        }
                    }
                break;
                }
            }
            if(isFlag)
            {
                Console.WriteLine("You have not admission to cancel");
            }
            
        }//Cancel Admission Ends


        //Admission Details
        public static void AdmissionDetails()
        {
            //Need to show current logged in student's admission details
            Console.WriteLine("|Admission ID|Student ID|Department ID|Admission Date|Admission Status");
            foreach (AdmissionDetails admission in admissionList)
            {
                if (currentLoggedInStudent.StudentID.Equals(admission.StudentID))
                {
                    Console.WriteLine($"|{admission.AdmissionID}|{admission.StudentID}|{admission.DepartmentID}|{admission.AdmissionDate}|{admission.AdmissionStatus}");
                }
            }

        }//Admission Details Ends


        //Departmentwise Seat Availbility
        public static void DepartmentWiseAvailbility()
        {
            //Need to show all department details
            Console.WriteLine("|DepartmentID|DepartmentName|NumberOfSeats|");
            foreach (DepartmentDetails department in departmentList)
            {
                Console.WriteLine($"|{department.DepartmentID}|{department.DepartmentName}|{department.NumberOfSeats}");
            }
            Console.WriteLine();

        }//Departmentwise Seat Availbility Ends


        //Adding Default Data
        public static void AddDefaultData()
        {
            StudentDetails student1 = new StudentDetails("Ravichandran", "Ettapparajan", new DateTime(1999, 11, 11), Gender.Male, 95, 95, 95);
            StudentDetails student2 = new StudentDetails("Baskaran", "Sethurajan", new DateTime(1999, 11, 11), Gender.Male, 95, 95, 95);
            studentList.AddRange(new List<StudentDetails>() { student1, student2 });

            DepartmentDetails department1 = new DepartmentDetails("EEE", 29);
            DepartmentDetails department2 = new DepartmentDetails("CSE", 29);
            DepartmentDetails department3 = new DepartmentDetails("MECH", 30);
            DepartmentDetails department4 = new DepartmentDetails("ECE", 30);
            departmentList.AddRange(new List<DepartmentDetails>() { department1, department2, department3, department4 });

            AdmissionDetails admission1 = new AdmissionDetails(student1.StudentID, department1.DepartmentID, new DateTime(2022, 05, 11), AdmissionStatus.Admitted);
            AdmissionDetails admission2 = new AdmissionDetails(student2.StudentID, department2.DepartmentID, new DateTime(2022, 05, 12), AdmissionStatus.Admitted);
            admissionList.AddRange(new List<AdmissionDetails>() { admission1, admission2 });
        }//Default Data End 

    }

}