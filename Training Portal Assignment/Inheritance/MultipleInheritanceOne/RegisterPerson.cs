using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultipleInheritanceOne
{
    public class RegisterPerson : PersonalInfo,IFamilyInfo,IShowData
    {
        private static int s_registerNum = 1000;

        public string RegisterNumber { get; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string HouseAddress { get; set; }
        public int NoOfSiblings { get; set; }
        public DateTime DateOfRegistration { get; set; }

        public RegisterPerson(string name, string gender, DateTime dob, string phone, MaritalDetails maritalDetails, string fatherName, string motherName, string houseAddress,int noOfSiblings, DateTime dateOfRegistration):base( name,  gender,  dob,  phone,  maritalDetails)
        {
            s_registerNum++;
            RegisterNumber = "RID"+s_registerNum;
            FatherName = fatherName;
            MotherName = motherName;
            HouseAddress = houseAddress;
            NoOfSiblings = noOfSiblings;
            DateOfRegistration = dateOfRegistration;
        }

        public void ShowInfo()
        {
            Console.WriteLine("RegisterNumber|Name|FatherName|MotherName|DOB|Phone|MaritalDetails|HouseAddress|NoOfSiblings|DateOfRegistration|");
            Console.WriteLine($"{RegisterNumber}|{Name}|{FatherName}|{MotherName}|{DOB}|{Phone}|{MaritalDetails}|{HouseAddress}|{NoOfSiblings}|{DateOfRegistration}|");

        }
    }
}