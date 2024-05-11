using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMedicalStore
{
    //Enum Declaration
    public enum OrderStatus{Select, Purchased, Cancelled}
    public class OrderDetail
    {
        /*
        Properties:
        a.	OrderID (Auto increment - OID2001)
        b.	UserID
        c.	MedicineID
        d.	MedicineCount
        e.	TotalPrice
        f.	OrderDate
        g.	OrderStatus {Enum – Purchased, Cancelled}
        */

        //Field 
        private static int s_orderID = 2000;

        //Property
        public string OrderID { get; }//ReadOnly Property
        public string UserID { get; set; }
        public string MedicineID { get; set; }
        public int MedicineCount { get; set; }
        public double TotalPrice { get; set; }
        public DateTime OrderDate { get; set; }
        public OrderStatus OrderStatus { get; set; }

        //Constructors
        public OrderDetail(string userId, string medicineID, int medicineCount, double totalPrice, DateTime orderDate, OrderStatus orderStatus)
        {
            s_orderID++;
            OrderID = "OID"+s_orderID;
            UserID = userId;
            MedicineID = medicineID;
            MedicineCount = medicineCount;
            TotalPrice = totalPrice;
            OrderDate = orderDate;
            OrderStatus = orderStatus;
        }
    }
}