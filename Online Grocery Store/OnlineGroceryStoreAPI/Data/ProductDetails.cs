using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineGroceryStoreAPI.Data
{
    [Table("productDetails", Schema = "public")]
    public class ProductDetails
    {
        [Key]
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int ProductQuantity { get; set; }
        public double ProductPrice { get; set; }
        public DateTime ProductPurchaseDate { get; set; }
        public DateTime ProductExpiryDate { get; set; }
        public string[] ProductImage { get; set; }
    }
}