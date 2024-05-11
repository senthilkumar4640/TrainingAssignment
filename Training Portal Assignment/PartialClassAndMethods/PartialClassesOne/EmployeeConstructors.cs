using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartialClassesOne
{
    //Constructor
    public partial class EmployeeInfo
    {
        public EmployeeInfo(string employeeID, string name, string gender, string dob, long mobile)
        {
            EmployeeID = employeeID;
            Name = name;
            Gender = gender;
            DOB = dob;
            Mobile = mobile;
        }
    }
}