using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineGroceryStore
{
    public class OrderDetails
    {
        //Properties: OrderID {Auto Increment – OID4000}, BookingID, ProductID,
        // PurchaseCount, PriceOfOrder

        //Field
        private static int s_orderID = 4000;

        //Property
        public string OrderID { get;  }//ReadOnly
        public string BookingID { get;  }//ReadOnly
        public string ProductID { get;  }//ReadOnly
        public int PurchaseCount { get; set; }
        public int PriceOfOrder { get; set; }

        //Constructors
        public OrderDetails(string bookingID, string productID, int purchaseCount, int priceOfOrder)
        {
            s_orderID++;
            OrderID = "OID"+s_orderID;
            BookingID = bookingID;
            ProductID = productID;
            PurchaseCount = purchaseCount;
            PriceOfOrder = priceOfOrder;
        }
    }
}