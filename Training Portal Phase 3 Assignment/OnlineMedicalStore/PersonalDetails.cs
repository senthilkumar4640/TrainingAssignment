using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMedicalStore
{
    public class PersonalDetails
    {
        /*
        Properties:
        •	Name
        •	Age
        •	City
        •	PhoneNumber
        */

        //Property
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
        public string PhoneNumber { get; set; }

        //Constructor
        public PersonalDetails(string name, int age, string city, string phoneNumber)
        {
            Name = name;
            Age = age;
            City = city;
            PhoneNumber = phoneNumber;
        }
    }
}