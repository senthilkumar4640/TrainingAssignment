using System;
using System.IO;
using System.Collections.Generic;
using System.Text.Json;
using System.Reflection.Metadata;
using Microsoft.Win32.SafeHandles;
namespace ReadWrite;
class Program 
{
    public static void Main(string[] args)
    {
        //Creating Folder..
        if(Directory.Exists("TestFolder"))
        {
            Console.WriteLine("Folder already exists..");
        }
        else
        {
            Directory.CreateDirectory("TestFolder");
            Console.WriteLine("The folder has been created..");
        }

        //Creating CSV File..
        if(File.Exists("TestFolder/Data1.csv"))//Comma Seperated Values
        {
            Console.WriteLine("CSV File already exists..");
        }
        else
        {
            File.Create("TestFolder/Data1.csv").Close();
            Console.WriteLine("The CSV file has been created..");
        }

        //Creating JSON File..
         if(File.Exists("TestFolder/Data2.json"))//javascript Object Notation
        {
            Console.WriteLine("JSON File already exists..");
        }
        else
        {
            File.Create("TestFolder/Data2.json").Close();
            Console.WriteLine("The JSON file has been created..");
        }

        //List Creating
        List<Student> studentList = new List <Student>();
        studentList.Add(new Student() {Name = "Senthil", FatherName="Ranganathan", DOB = new DateTime(2002,03,08), StudentGender = Gender.Male, TotalMark=450});
        studentList.Add(new Student() {Name = "Bhuvana", FatherName="Krishna", DOB = new DateTime(2002,07,16), StudentGender = Gender.Female, TotalMark=500});
        studentList.Add(new Student() {Name = "Meena", FatherName="Ranganathan", DOB = new DateTime(1976,12,05), StudentGender = Gender.Female, TotalMark=460});

        //Calling Write method for CSV
        WriteToCSV(studentList);

        //Calling Read method for CSV
        ReadCSV();

        //Calling Write method for JSON
        WriteToJSON(studentList);

        //Calling Read method for JSON
        ReadJSON();
    }


    //Method to write in CSV file..
    static void WriteToCSV(List<Student> studentList)
    {
        StreamWriter sw = new StreamWriter("TestFolder/Data1.csv");
        foreach(Student student in studentList)
        {
            string line = $"{student.Name},{student.FatherName},{student.StudentGender},{student.DOB.ToString("dd/MM/yyyy")},{student.TotalMark}";
            sw.WriteLine(line);
        }
        sw.Close();
    }

    //Method to read in CSV file..
    static void ReadCSV()
    {
        List<Student> newList = new List<Student>();
        StreamReader sr = new StreamReader("TestFolder/Data1.csv");
        string line = sr.ReadLine();
        while(line!=null)
        {
            string[] values = line.Split(",");
            if(values[0]!=null)
            {
                Student student = new Student
                {
                    Name = values[0],
                    FatherName = values[1],
                    StudentGender = Enum.Parse<Gender>(values[2]),
                    DOB = DateTime.ParseExact(values[3],"dd/MM/yyyy",null),
                    TotalMark = int.Parse(values[4])
                };
                newList.Add(student);
            }
            line = sr.ReadLine();
        }
        sr.Close();
        foreach(Student student in newList)
        {
            Console.WriteLine($"Name: {student.Name}\nFatherName: {student.FatherName}\nGender: {student.StudentGender}\nDOB: {student.DOB.ToString("dd/MM/yyyy")}\nTotalmark: {student.TotalMark}");
            Console.WriteLine();
        }

    }


    //Method to write in JSON file..
    static void WriteToJSON(List<Student> studentList)
    {
        StreamWriter sw = new StreamWriter("TestFolder/Data2.json");
        var option = new JsonSerializerOptions
        {
            WriteIndented = true
        };
        string jsonData = JsonSerializer.Serialize(studentList,option);
        sw.WriteLine(jsonData);
        sw.Close();
    }


    //Method to Read in JSON file..
    static void ReadJSON()
    {
        List<Student> newList = JsonSerializer.Deserialize<List<Student>>(File.ReadAllText("TestFolder/Data2.json"));
        foreach(Student student in newList)
        {
            Console.WriteLine($"Name: {student.Name}\nFatherName: {student.FatherName}\nGender: {student.StudentGender}\nDOB: {student.DOB.ToString("dd/MM/yyyy")}\nTotalmark: {student.TotalMark}");
            Console.WriteLine();
        }
    }
}