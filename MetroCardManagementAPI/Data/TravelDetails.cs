using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MetroCardManagementAPI.Data
{
    [Table("travelDetails", Schema = "public")]
    public class TravelDetails
    {
        [Key]
        public int TravelID { get; set; }
        public int CardID { get; set; }
        public string FromLocation { get; set; }
        public string ToLocation { get; set; }
        public DateTime TravelDate { get; set; }
        public double TravelFair { get; set; }
    }
}