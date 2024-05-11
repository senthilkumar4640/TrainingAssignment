using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SingleInheritance
{
    //Enum Declaration
    public enum Gender{Select, Male, Female, Transgender}
    public class PersonalDetails
    {
        //Field
        //Static Field
        private static int s_userID = 1000;

        //Property
        public string UserID {get;}//ReadOnly Property
        public string UserName { get; set; }
        public string FatherName { get; set; }
        public Gender Gender { get; set; }
        public long PhoneNumber { get; set; }

        //Constructor
        public PersonalDetails(string userName, string fatherName, Gender gender, long phoneNumber)
        {
            s_userID++;
            UserID = "SF" + s_userID;
            UserName = userName;
            FatherName = fatherName;
            Gender = gender;
            PhoneNumber = phoneNumber;
        } //Constructors Ends

           public PersonalDetails(string userID, string userName, string fatherName, Gender gender, long phoneNumber)
        {
            UserID = userID;
            UserName = userName;
            FatherName = fatherName;
            Gender = gender;
            PhoneNumber = phoneNumber;
        } //Constructors Ends
    }
}