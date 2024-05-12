using System;
namespace DoctorPatientAppointmentSystem;
class Program 
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Syncfusion Hospital");

        Operations.AddingDefaultData();
        Operations.MainMenu();
    }
}