using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartialClassesOne
{
    //Methods
    public partial class EmployeeInfo
    {
        public void Update(string name, string gender, string dob, long mobile)
        {
            Name= name;
            Gender = gender;
            DOB = dob;
            Mobile = mobile;
        }

        public void Display()
        {
            Console.WriteLine("|EmployeeID|Name|Gender|DOB|Mobile|");
            Console.WriteLine($"|{EmployeeID}|{Name}|{Gender}|{DOB}|{Mobile}|");
        }
    }
}