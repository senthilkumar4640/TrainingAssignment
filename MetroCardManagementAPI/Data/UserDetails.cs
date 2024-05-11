using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MetroCardManagementAPI.Data
{
    [Table("userDetails", Schema = "public")]
    public class UserDetails
    {
        [Key]
        public int CardID { get; set; }
        public string UserName { get; set; }
        public string UserPhoneNumber { get; set; }
        public string UserPassword { get; set; }
        public double Balance { get; set; }
    }
}