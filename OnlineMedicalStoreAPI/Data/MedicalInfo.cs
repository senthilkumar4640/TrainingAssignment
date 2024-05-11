using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
 
namespace OnlineMedicalStoreAPI.Data
{
    [Table("MedicalInfo", Schema = "public")]
    public class MedicalInfo
    {
        [Key]
        public int MedicineID { get; set; }
        public string MedicineName { get; set; }
        public int MedicineCount { get; set; }
        public int MedicinePrice { get; set; }
        public DateTime MedicineExpiryDate { get; set; }
    }
}