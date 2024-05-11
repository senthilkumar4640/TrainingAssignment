using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultilevelInheritanceTwo
{
    public class BookInfo : RackInfo
    {
        /*
        Class BookInfo: Inherit RackInfo
        Properties: BookID, BookName, AuthorName, Price
        Method: Display info
        */

        public string BookID { get; set; }
        public string BookName { get; set; }
        public string AuthorName { get; set; }
        public double Price { get; set; }

        public BookInfo(string departmentName, string degree, int rackNumber, int columnNumber, string bookID, string bookName, string authorName, double price) : base(departmentName, degree, rackNumber, columnNumber)
        {
            BookID = bookID;
            BookName = bookName;
            AuthorName = authorName;
            Price = price;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("|Degree|DepartmentName|RackNumber|ColumnNumber|BookID|BookName|AuthourName|Price|");
            Console.WriteLine($"|{Degree}|{DepartmentName}|{RackNumber}|{ColumnNumber}|{BookID}|{BookName}|{AuthorName}|{Price}|");
        }
    }
}