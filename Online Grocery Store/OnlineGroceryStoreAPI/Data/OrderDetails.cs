using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineGroceryStoreAPI.Data
{
     [Table("orderDetails", Schema = "public")]
    public class OrderDetails
    {
        [Key]
        public int OrderID { get; set; }
        public int BookingID { get; set; }
        public string ProductName { get; set; }
        public int PurchaseCount { get; set; }
        public double ProductTotalPrice { get; set; }
    }
}