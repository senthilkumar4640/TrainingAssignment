using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HierarchicalInheritance
{
    public class CustomerDetails : PersonalDetails
    {
        //Field
        //Static Field
        private static int s_custID = 200;

        //Property
        public string CustomerID { get; }//ReadOnly Property
        public int Balance { get; set; }

        //Constructor
        public CustomerDetails(string userID, string userName, string fatherName, Gender gender, long phoneNumber,int balance):base(userID,  userName,  fatherName,  gender,  phoneNumber)
        {
            s_custID++;
            CustomerID = "CID" + s_custID;
            Balance = balance;
        } //Constructor Ends
    }
}