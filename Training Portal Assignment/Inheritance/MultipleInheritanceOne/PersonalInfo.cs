using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace MultipleInheritanceOne
{
    public enum MaritalDetails{Select, Married, Single}
    public class PersonalInfo : IShowData
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public DateTime DOB { get; set; }
        public string Phone { get; set; }
        public MaritalDetails MaritalDetails { get; set; }


        public PersonalInfo(string name, string gender, DateTime dob, string phone, MaritalDetails maritalDetails)
        {
            Name = name;
            Gender = gender;
            DOB = dob;
            Phone = phone;
            MaritalDetails = maritalDetails;

        }
        public void ShowInfo()
        {
            Console.WriteLine("|Name|Gender|DOB|Phone|MaritalDetails|");
            Console.WriteLine($"|{Name}|{Gender}|{DOB}|{Phone}|{MaritalDetails}|");
        }
    }
}