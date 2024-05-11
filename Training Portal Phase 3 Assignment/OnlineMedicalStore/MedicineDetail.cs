using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMedicalStore
{
    public class MedicineDetail
    {
        /*
        Properties:
        a.	MedicineID (MD100)
        b.	MedicineName
        c.	AvailableCount
        d.	Price
        e.	DateOfExpiry
        */
        //Field
        private static int s_medicineID = 100;
        //Properties
        public string MedicineID { get; }//ReadOnly Property
        public string MedicineName { get; set; }
        public int AvailableCount { get; set; }
        public double Price { get; set; }
        public DateTime DateOfExpiry { get; set; }

        //Constructors
        public MedicineDetail(string medicineName, int availableCount, double price, DateTime dateOfExpiry )
        {
            s_medicineID++;
            MedicineID = "MD"+s_medicineID;
            MedicineName = medicineName;
            AvailableCount = availableCount;
            Price = price;
            DateOfExpiry = dateOfExpiry;
        }
    }
}