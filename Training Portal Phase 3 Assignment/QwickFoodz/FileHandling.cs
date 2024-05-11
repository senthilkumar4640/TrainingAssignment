using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace QwickFoodz
{
    public static class FileHandling
    {
        //create
        public static void Create()
        {
            if (!Directory.Exists("QwickFoodz"))
            {
                Directory.CreateDirectory("QwickFoodz");
                Console.WriteLine("Folder created succesfully");
            }
            if (!File.Exists("QwickFoodz/CustomerDetails.csv"))
            {
                File.Create("QwickFoodz/CustomerDetails.csv");
                Console.WriteLine("File created succesfully");
            }
            if (!File.Exists("QwickFoodz/FoodDetails.csv"))
            {
                File.Create("QwickFoodz/FoodDetails.csv");
                Console.WriteLine("File created succesfully");
            }
            if (!File.Exists("QwickFoodz/OrderDetails.csv"))
            {
                File.Create("QwickFoodz/OrderDetails.csv");
                Console.WriteLine("File created succesfully");
            }
            if (!File.Exists("QwickFoodz/ItemDetails.csv"))
            {
                File.Create("QwickFoodz/ItemDetails.csv");
                Console.WriteLine("File created succesfully");
            }
        }

        //Write
        public static void WriteToCSV()
        {
            
        }

        //Read
        public static void ReadFromCSV()
        {

        }

    }
}