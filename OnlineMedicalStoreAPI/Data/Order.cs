using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
 
namespace OnlineMedicalStoreAPI.Data
{
    [Table("Order", Schema = "public")]
    public class Order
    {
        [Key]
        public int OrderID { get; set; }
        public int MedicineID { get; set; }
        public int UserID { get; set; }
        public string MedicineName { get; set; }
        public int MedicineCount { get; set; }
        public string OrderStatus { get; set; }

    }
}