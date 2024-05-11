using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MetroCardManagementAPI.Data
{
    [Table("ticketFairDetails", Schema = "public")]
    public class TicketFairDetails
    {
        [Key]
        public int TicketID { get; set; }
        public string FromLocation { get; set; }
        public string ToLocation { get; set; }
        public double TicketFair { get; set; }
    }
}