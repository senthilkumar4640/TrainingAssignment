using System;
namespace MultilevelInheritanceTwo;
class Program 
{
    public static void Main(string[] args)
    {
        BookInfo book1 = new BookInfo("CSE","BE",25,5,"SF1001","HarryPotter","Harrel",200);
        BookInfo book2 = new BookInfo("ECE","BE",35,9,"SF1002","Marvel","Jonaha",500);

        book1.DisplayInfo();
        book2.DisplayInfo();
    }
}
