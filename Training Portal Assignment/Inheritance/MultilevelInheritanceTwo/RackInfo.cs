using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultilevelInheritanceTwo
{
    public class RackInfo : DepartmentDetails
    {
        /*
        Class RackInfo: DepartmentDetails
        Properties: RackNumber, ColumnNumber
        */

        //Property
        public int RackNumber { get; set; }
        public int ColumnNumber { get; set; }

        public RackInfo(string departmentName, string degree, int rackNumber, int columnNumber) : base(departmentName,degree)
        {
            RackNumber = rackNumber;
            ColumnNumber = columnNumber;
        }
    }
}