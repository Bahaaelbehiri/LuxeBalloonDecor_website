using System.ComponentModel.DataAnnotations;

namespace LuxeBalloonDecor_website.Server.Models
{
    public class InventoryRequest
    {
        [Key]
        public int requestID { get; set; }
        public int itemID { get; set; }
        public int requestedQuantity { get; set; }
        public DateTime requestDate { get; set; }
        public int reqestStatus { get; set; } // Request/Booking Status Enum
    }
}
