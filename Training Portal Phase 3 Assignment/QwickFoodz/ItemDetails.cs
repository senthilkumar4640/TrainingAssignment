using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QwickFoodz
{
    public class ItemDetails
    {
        //Properties: ItemID – (ITID100), OrderID, FoodID, PurchaseCount, PriceOfOrder

        //Field
        private static int s_itemID = 4000;

        //Property
        public string ItemID { get; }//ReadOnly Property
        public string OrderID { get; }
        public string FoodID { get; }
        public int PurchaseCount { get; set; }
        public double PriceOfOrder { get; set; }

        //Constructors
        public ItemDetails(string orderID, string foodID, int purchaseCount, double priceOfOrder)
        {
            s_itemID++;
            ItemID = "ITID" + s_itemID;
            OrderID = orderID;
            FoodID = foodID;
            PurchaseCount = purchaseCount;
            PriceOfOrder = priceOfOrder;
        }

    }
}