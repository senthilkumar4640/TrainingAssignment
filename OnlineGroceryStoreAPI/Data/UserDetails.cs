using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineGroceryStoreAPI.Data
{
    [Table("userDetails", Schema ="public")]
    public class UserDetails
    {
        [Key]
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public string UserPassword { get; set; }
        public string UserPhone { get; set; }
        public string[] UserImage { get; set; }
        public string UserAddress { get; set; }
        public double UserBalance { get; set; }
    }
}