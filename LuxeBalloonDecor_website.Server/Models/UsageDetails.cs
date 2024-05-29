using System.ComponentModel.DataAnnotations;

namespace LuxeBalloonDecor_website.Server.Models
{
    public class UsageDetails
    {
        [Key]
        public int usageID { get; set; }
        public int itemID { get; set; }
        public DateTime usageDate { get; set; }
        public int quantityUsed { get; set; }
        public string purpose { get; set; }
    }
}
