using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartialClassesOne
{
    public partial class EmployeeInfo
    {
        //Property
        // properties -  EmployeeID,Name,Gender,DOB, Mobile
        public string EmployeeID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string DOB { get; set; }
        public long Mobile { get; set; }
    }
}