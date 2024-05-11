using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultilevelInheritanceTwo
{
    public class DepartmentDetails
    {
        /*
        Class DepartmentDetails:
        Properties: DepartmentName, Degree
        */

        //Property
        public string DepartmentName { get; set; }
        public string Degree { get; set; }

        public DepartmentDetails(string departmentName, string degree)
        {
            DepartmentName = departmentName;
            Degree = degree;

        }
    }
}