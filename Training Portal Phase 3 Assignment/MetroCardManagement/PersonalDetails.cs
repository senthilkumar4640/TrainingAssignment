using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetroCardManagement
{
    public class PersonalDetails
    {
        /*
        Properties:
        •	UserName
        •	Phone Number
        */

        //Properties
        public string UserName { get; set; }
        public long PhoneNumber { get; set; }

        //Constructors
        public PersonalDetails(string userName, long phoneNumber)
        {
            UserName = userName;
            PhoneNumber = phoneNumber;
        }//Constructors ends
        
        
        public PersonalDetails()
        {

        }
}
}