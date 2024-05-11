using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QwickFoodz
{
    public enum OrderStatus { Select, Initiated, Ordered, Cancelled }
    public class OrderDetails
    {
        //Properties: OrderID, CustomerID, TotalPrice, DateOfOrder, OrderStatus – {Default, Initiated, Ordered, Cancelled}.

        //Field
        private static int s_orderID = 3000;

        //Property
        public string OrderID { get; }//ReadOnly Property
        public string CustomerID { get; }
        public double TotalPrice { get; set; }
        public DateTime DateOfOrder { get; set; }
        public OrderStatus OrderStatus { get; set; }

        //Constructors
        public OrderDetails(string customerID, double totalPrice, DateTime dateOfOrder, OrderStatus orderStatus)
        {
            s_orderID++;
            OrderID = "OID" + s_orderID;
            CustomerID = customerID;
            TotalPrice = totalPrice;
            DateOfOrder = dateOfOrder;
            OrderStatus = orderStatus;
        }
    }
}