using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace DoctorPatientAppointmentSystem;

    public class Operations
    {
        public static List<PatientDetails> patientList = new List<PatientDetails>();
        public static List<DoctorDetails> doctorList = new List<DoctorDetails>();
        public static List<AppointmentDetails> appointmentList = new List<AppointmentDetails>();
        public static PatientDetails currentPatientLogin;

        public static void AddingDefaultData()
        {
            PatientDetails patient1 = new PatientDetails("welcome", "Robert", 40, Gender.Male);
            patientList.Add(patient1);
            PatientDetails patient2 = new PatientDetails("welcome", "Laura", 36, Gender.Female);
            patientList.Add(patient2);
            PatientDetails patient3 = new PatientDetails("welcome", "Anne", 42, Gender.Male);
            patientList.Add(patient3);

            DoctorDetails doctor1 = new DoctorDetails("Nancy", DepartmentType.Anaesthesiology);
            doctorList.Add(doctor1);
            DoctorDetails doctor2 = new DoctorDetails("Andrew", DepartmentType.Cardiology);
            doctorList.Add(doctor2);
            DoctorDetails doctor3 = new DoctorDetails("Janet", DepartmentType.Diabetology);
            doctorList.Add(doctor3);
            DoctorDetails doctor4 = new DoctorDetails("Margaret", DepartmentType.Neonatology);
            doctorList.Add(doctor4);
            DoctorDetails doctor5 = new DoctorDetails("Steven", DepartmentType.Nephrology);
            doctorList.Add(doctor5);

            AppointmentDetails appointment1 = new AppointmentDetails("1", "2", new DateTime(2012, 8, 3), "Heart problem");
            appointmentList.Add(appointment1);
            AppointmentDetails appointment2 = new AppointmentDetails("1", "5", new DateTime(2024, 5, 9), "Spinal cord injury");
            appointmentList.Add(appointment2);
            AppointmentDetails appointment3 = new AppointmentDetails("2", "2", new DateTime(2024, 6, 15), "Heart attack");
            appointmentList.Add(appointment3);

            Console.WriteLine("Patient Details:");
            foreach (PatientDetails patient in patientList)
            {
                Console.WriteLine($"{patient.PatientID,-3} | {patient.Password,-8} | {patient.Name,-10} | {patient.Age,-5} | {patient.Gender,-8}");
            }
            Console.WriteLine("Doctor Details");
            foreach (DoctorDetails doctor in doctorList)
            {
                Console.WriteLine($"{doctor.DoctorID,-3} | {doctor.Name,-10} | {doctor.Department,-20}");
            }
            Console.WriteLine("Appointment details");
            foreach (AppointmentDetails appointment in appointmentList)
            {
                Console.WriteLine($"{appointment.AppointmentID,-3} | {appointment.PatientID,-3} | {appointment.DoctorID,-3} | {appointment.Date.ToString("MM/dd/yyyy"),-10} | {appointment.Problem}");
            }
        }
        public static void MainMenu()
        {
            bool flag = true;
            do
            {
                Console.Write("Choose:  1.Login  2.Register : ");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {
                            Login();
                            break;
                        }
                    case 2:
                        {
                            Register();
                            break;
                        }
                    default:
                        {
                            flag = false;
                            break;
                        }
                }
            } while (flag);
        }
        public static void Login()
        {
            bool flag = true;
            Console.Write("Enter your Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your Password: ");
            string password = Console.ReadLine();
            foreach (PatientDetails patient in patientList)
            {
                if (patient.Name == name && patient.Password == password)
                {
                    flag = false;
                    currentPatientLogin = patient;
                    Console.WriteLine("Patient logged in successfully");
                    SubMenu();
                }
            }
            if (flag)
            {
                Console.WriteLine("Sorry, your record is invalid. Please register your profile and log in again");
            }
        }
        public static void Register()
        {
            Console.WriteLine("REGISTRATION FORM: ");
            Console.Write("Enter your Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter a Password: ");
            string password = Console.ReadLine();
            Console.Write("Enter your Age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Choose you Gender: 1.Male  2.Female : ");
            Gender gender = Enum.Parse<Gender>(Console.ReadLine());

            PatientDetails patient = new PatientDetails(password, name, age, gender);
            patientList.Add(patient);
            Console.WriteLine($"Successfully registered. Your ID is {patient.PatientID}");
        }
        public static void SubMenu()
        {
            bool flag = true;
            do
            {
                Console.Write("Choose:  1.Book Appointment  2.View Appointment Details  3.Edit My profile  4.Exit : ");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        {
                            BookAppointment();
                            break;
                        }
                    case 2:
                        {
                            ViewAppointmentDetails();
                            break;
                        }
                    case 3:
                        {
                            EditMyProfile();
                            break;
                        }
                    case 4:
                        {
                            flag = false;
                            Console.WriteLine("Exitting the application");
                            break;
                        }
                    default:
                        {
                            flag = false;
                            break;
                        }
                }

            } while (flag);
        }
        public static void BookAppointment()
        {
            Console.WriteLine("Doctor adn Department Details");
            foreach (DoctorDetails doctor in doctorList)
            {
                Console.WriteLine($"{doctor.DoctorID,-3} | {doctor.Name,-10} | {doctor.Department,-20}");
            }
            Console.Write("Enter the DoctorID for the department to visit: ");
            string doctorID = Console.ReadLine();
            int count = 0;
            DateTime tempDate = DateTime.Now;
            DateTime AppDate = DateTime.Today;
            foreach (DoctorDetails doctor1 in doctorList)
            {
                if (doctorID == doctor1.DoctorID)
                {
                    foreach (AppointmentDetails appointment in appointmentList)
                    {
                        if (appointment.DoctorID == doctorID)
                        {
                            count++;
                            tempDate = appointment.Date;
                        }
                    }
                }
            }
            if (tempDate < DateTime.Today)
            {
                Console.WriteLine("Appointment is confirmed for the date - " + DateTime.Today.ToString("dd/MM/yyyy"));
                AppDate = DateTime.Today;
            }
            else if (tempDate >= DateTime.Today)
            {
                if (count == 0)
                {
                    Console.WriteLine("Appointment is confirmed for the date - " + DateTime.Today.ToString("dd/MM/yyyy"));
                    AppDate = DateTime.Today;

                }
                else if (count == 1 || count == 2)
                {
                    Console.WriteLine("Appointment is confirmed for the date - " + tempDate.AddDays(1).ToString("dd/MM/yyyy"));
                    AppDate = tempDate.AddDays(1);
                }

            }
            Console.Write("Do you want to book an appointment: yes/no : ");
            string option = Console.ReadLine().ToLower();
            if (option == "yes")
            {
                Console.Write("Enter the problem you have: ");
                string problem = Console.ReadLine();
                AppointmentDetails appointment = new AppointmentDetails(currentPatientLogin.PatientID, doctorID, AppDate, problem);
                appointmentList.Add(appointment);
                Console.WriteLine("Booked an appointment");
            }
            else
            {
                SubMenu();
            }
        }
        public static void ViewAppointmentDetails()
        {
            bool flag = true;
            foreach (AppointmentDetails appointment in appointmentList)
            {
                if (currentPatientLogin.PatientID == appointment.PatientID)
                {
                    flag = false;
                    Console.WriteLine($"{appointment.AppointmentID,-3} | {appointment.PatientID,-3} | {appointment.DoctorID,-3} | {appointment.Date.ToString("MM/dd/yyyy"),-10} | {appointment.Problem}");
                }
            }
            if (flag)
            {
                Console.WriteLine("No Appointment History");
            }

        }
        public static void EditMyProfile()
        {
            bool flag = true;
            do
            {
                Console.Write("Choose the one you want to edit:  1.Name  2.Password  3.Age  4.Gender  5.Exit: ");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        {
                            Console.Write("Enter your new name: ");
                            string newName = Console.ReadLine();
                            currentPatientLogin.Name = newName;
                            ViewMyProfile();
                            break;
                        }
                    case 2:
                        {
                            Console.Write("Enter your new password: ");
                            string newPassword = Console.ReadLine();
                            currentPatientLogin.Password = newPassword;
                            ViewMyProfile();
                            break;
                        }
                    case 3:
                        {
                            Console.Write("Enter your new age: ");
                            int newAge = int.Parse(Console.ReadLine());
                            currentPatientLogin.Age = newAge;
                            ViewMyProfile();
                            break;
                        }
                    case 4:
                        {
                            Console.Write("Choose the gender: 1. Male  2.Female");
                            Gender newGender = Enum.Parse<Gender>(Console.ReadLine());
                            currentPatientLogin.Gender = newGender;
                            ViewMyProfile();
                            break;
                        }
                    case 5:
                        {
                            ViewMyProfile();
                            Console.WriteLine("Exiyting the edit option");
                            flag = false;
                            break;
                        }
                    default:
                        {
                            flag = false;
                            break;
                        }
                }
            } while (flag);
        }
        public static void ViewMyProfile()
        {
            foreach (PatientDetails patient in patientList)
            {
                if (currentPatientLogin.PatientID == patient.PatientID)
                {
                    Console.WriteLine($"{patient.PatientID,-3} | {patient.Password,-8} | {patient.Name,-10} | {patient.Age,-5} | {patient.Gender,-8}");
                }
            }
        }
    }
