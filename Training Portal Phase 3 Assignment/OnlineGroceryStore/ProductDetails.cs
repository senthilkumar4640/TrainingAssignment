using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineGroceryStore
{
    public class ProductDetails
    {
        /*
        Properties: ProductID {Auto Increment – PID2000}, ProductName, 
        QuantityAvailable, PricePerQuantity

        Method: ShowProductDetails
        */

        //Field
        private static int s_productID = 2000;

        //Property
        public string ProductID { get; }//ReadOnly Property
        public string ProductName { get; set; }
        public int  QuantityAvailable { get; set; }
        public int PricePerQuantity { get; set; }

        //Constructors
        public ProductDetails(string productName, int quantityAvailable, int pricePerQuantity)
        {
            s_productID++;
            ProductID = "PID"+s_productID;
            ProductName = productName;
            QuantityAvailable = quantityAvailable;
            PricePerQuantity = pricePerQuantity;
        }

        //Methods
                public static void ShowProductDetails()
                {
                    Operations.ProductDetails();
                }
    }
}